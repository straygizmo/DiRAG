using System.Collections.Concurrent;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace DiRAG.Services.Mcp
{
    public class StdioMcpClient : IMcpClient
    {
        private readonly string _executablePath;
        private readonly string? _arguments;
        private readonly Dictionary<string, string>? _environmentVariables;
        private Process? _process;
        private StreamWriter? _stdin;
        private StreamReader? _stdout;
        private StreamReader? _stderr;
        private Task? _readOutputTask;
        private Task? _readErrorTask;
        private CancellationTokenSource? _cancellationTokenSource;
        private int _nextId = 1;
        private readonly ConcurrentDictionary<object, TaskCompletionSource<JsonRpcResponse>> _pendingRequests = new();
        private readonly JsonSerializerOptions _jsonOptions;
        private readonly StringBuilder _messageBuffer = new();
        private readonly SemaphoreSlim _sendSemaphore = new(1, 1);

        public bool IsConnected => _process != null && !_process.HasExited;
        public event EventHandler<string>? LogMessage;

        public StdioMcpClient(string executablePath, string? arguments = null, Dictionary<string, string>? environmentVariables = null)
        {
            _executablePath = executablePath;
            _arguments = arguments;
            _environmentVariables = environmentVariables;
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = false
            };
        }

        public async Task<bool> ConnectAsync()
        {
            try
            {
                LogMessage?.Invoke(this, $"Connecting to MCP server: {_executablePath} {_arguments}");

                var startInfo = new ProcessStartInfo
                {
                    FileName = _executablePath,
                    Arguments = _arguments ?? string.Empty,
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    StandardOutputEncoding = Encoding.UTF8,
                    StandardErrorEncoding = Encoding.UTF8,
                    StandardInputEncoding = Encoding.UTF8,
                    WorkingDirectory = _environmentVariables?.ContainsKey("WORKING_DIR") == true
                        ? _environmentVariables["WORKING_DIR"]
                        : Environment.CurrentDirectory
                };

                if (_environmentVariables != null)
                {
                    foreach (var kvp in _environmentVariables)
                    {
                        if (kvp.Key != "WORKING_DIR") // Skip special key
                        {
                            startInfo.Environment[kvp.Key] = kvp.Value;
                        }
                    }
                }

                _process = Process.Start(startInfo);
                if (_process == null)
                {
                    LogMessage?.Invoke(this, "Failed to start MCP server process");
                    return false;
                }

                _stdin = _process.StandardInput;
                _stdout = _process.StandardOutput;
                _stderr = _process.StandardError;

                _cancellationTokenSource = new CancellationTokenSource();

                // Start reading stderr first to capture startup messages
                _readErrorTask = Task.Run(() => ReadErrorAsync(_cancellationTokenSource.Token));

                // Small delay to let server initialize
                await Task.Delay(100);

                // Now start reading stdout for JSON-RPC messages
                _readOutputTask = Task.Run(() => ReadOutputAsync(_cancellationTokenSource.Token));

                // Wait a bit more to ensure the process has started
                await Task.Delay(400);

                if (_process.HasExited)
                {
                    LogMessage?.Invoke(this, $"MCP server process exited immediately with code: {_process.ExitCode}");
                    return false;
                }

                LogMessage?.Invoke(this, $"Connected to MCP server process");
                return true;
            }
            catch (Exception ex)
            {
                LogMessage?.Invoke(this, $"Failed to connect to MCP server: {ex.Message}");
                return false;
            }
        }

        public async Task DisconnectAsync()
        {
            try
            {
                _cancellationTokenSource?.Cancel();

                if (_readOutputTask != null)
                    await Task.WhenAny(_readOutputTask, Task.Delay(1000));
                if (_readErrorTask != null)
                    await Task.WhenAny(_readErrorTask, Task.Delay(1000));

                _stdin?.Close();
                _stdout?.Close();
                _stderr?.Close();

                if (_process != null && !_process.HasExited)
                {
                    _process.Kill();
                    await _process.WaitForExitAsync();
                }

                _process?.Dispose();
                _process = null;
                _stdin = null;
                _stdout = null;
                _stderr = null;
                _cancellationTokenSource?.Dispose();
                _cancellationTokenSource = null;

                LogMessage?.Invoke(this, "Disconnected from MCP server");
            }
            catch (Exception ex)
            {
                LogMessage?.Invoke(this, $"Error during disconnect: {ex.Message}");
            }
        }

        private async Task ReadOutputAsync(CancellationToken cancellationToken)
        {
            try
            {
                var currentMessage = new StringBuilder();

                while (!cancellationToken.IsCancellationRequested && _stdout != null)
                {
                    try
                    {
                        var line = await _stdout.ReadLineAsync();
                        if (line == null)
                            break;

                        line = line.Trim();
                        if (string.IsNullOrEmpty(line))
                            continue;

                        // Skip non-JSON lines (debug output from server)
                        if (!line.StartsWith("{"))
                        {
                            LogMessage?.Invoke(this, $"[STDOUT-SKIP] {line}");
                            continue;
                        }

                        LogMessage?.Invoke(this, $"[STDOUT] {line.Substring(0, Math.Min(200, line.Length))}...");

                        // Each line should be a complete JSON-RPC message
                        if (TryParseJsonRpcMessage(line, out var message))
                        {
                            HandleMessage(message);
                        }
                        else
                        {
                            LogMessage?.Invoke(this, $"Failed to parse JSON-RPC message: {line.Substring(0, Math.Min(100, line.Length))}");
                        }
                    }
                    catch (Exception lineEx) when (!cancellationToken.IsCancellationRequested)
                    {
                        LogMessage?.Invoke(this, $"Error processing line: {lineEx.Message}");
                    }
                }
            }
            catch (Exception ex) when (!cancellationToken.IsCancellationRequested)
            {
                LogMessage?.Invoke(this, $"Error reading output: {ex.Message}");
            }
        }


        private async Task ReadErrorAsync(CancellationToken cancellationToken)
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested && _stderr != null)
                {
                    try
                    {
                        var line = await _stderr.ReadLineAsync();
                        if (line == null)
                            break;

                        // Log stderr but don't treat as errors - many servers output info to stderr
                        LogMessage?.Invoke(this, $"[STDERR] {line}");
                    }
                    catch (Exception lineEx) when (!cancellationToken.IsCancellationRequested)
                    {
                        LogMessage?.Invoke(this, $"Error reading stderr line: {lineEx.Message}");
                    }
                }
            }
            catch (Exception ex) when (!cancellationToken.IsCancellationRequested)
            {
                LogMessage?.Invoke(this, $"Error reading stderr: {ex.Message}");
            }
        }

        private bool TryParseJsonRpcMessage(string text, out JsonRpcMessage? message)
        {
            message = null;
            try
            {
                using var doc = JsonDocument.Parse(text);
                if (doc.RootElement.TryGetProperty("method", out _))
                {
                    if (doc.RootElement.TryGetProperty("id", out _))
                    {
                        message = JsonSerializer.Deserialize<JsonRpcRequest>(text, _jsonOptions);
                    }
                    else
                    {
                        message = JsonSerializer.Deserialize<JsonRpcNotification>(text, _jsonOptions);
                    }
                }
                else
                {
                    message = JsonSerializer.Deserialize<JsonRpcResponse>(text, _jsonOptions);
                }
                return message != null;
            }
            catch
            {
                return false;
            }
        }

        private void HandleMessage(JsonRpcMessage message)
        {
            if (message is JsonRpcResponse response)
            {
                if (response.Id != null)
                {
                    // Try to match the response to a pending request
                    // The Id might be an integer or string, so we need to handle both
                    var idKey = response.Id;
                    if (_pendingRequests.TryRemove(idKey, out var tcs))
                    {
                        tcs.SetResult(response);
                        LogMessage?.Invoke(this, $"Matched response for request id: {response.Id}");
                    }
                    else
                    {
                        LogMessage?.Invoke(this, $"Received response for unknown request id: {response.Id}");
                    }
                }
            }
            else if (message is JsonRpcNotification notification)
            {
                LogMessage?.Invoke(this, $"Received notification: {notification.Method}");
            }
        }

        private async Task<T> SendRequestAsync<T>(string method, object? parameters)
        {
            if (!IsConnected)
                throw new InvalidOperationException("Not connected to MCP server");

            var id = _nextId++;
            var request = new JsonRpcRequest
            {
                Id = id,
                Method = method,
                Params = parameters
            };

            var tcs = new TaskCompletionSource<JsonRpcResponse>();
            _pendingRequests[id] = tcs;

            try
            {
                var json = JsonSerializer.Serialize(request, _jsonOptions);
                LogMessage?.Invoke(this, $"Sending: {json.Substring(0, Math.Min(200, json.Length))}...");

                await _sendSemaphore.WaitAsync();
                try
                {
                    await _stdin!.WriteLineAsync(json);
                    await _stdin.FlushAsync();
                    LogMessage?.Invoke(this, $"Message sent successfully (id: {id})");
                }
                finally
                {
                    _sendSemaphore.Release();
                }

                var timeoutTask = Task.Delay(30000); // 30 second timeout
                var responseTask = tcs.Task;

                if (await Task.WhenAny(responseTask, timeoutTask) == timeoutTask)
                {
                    _pendingRequests.TryRemove(id, out _);
                    LogMessage?.Invoke(this, $"Timeout waiting for response to {method} (id: {id})");
                    throw new TimeoutException($"Timeout waiting for response to {method}");
                }

                var response = await responseTask;
                if (response.Error != null)
                {
                    throw new Exception($"MCP error: {response.Error.Message} (code: {response.Error.Code})");
                }

                if (response.Result == null)
                {
                    throw new Exception($"No result in response for {method}");
                }

                var resultJson = JsonSerializer.Serialize(response.Result, _jsonOptions);
                var result = JsonSerializer.Deserialize<T>(resultJson, _jsonOptions);
                if (result == null)
                {
                    throw new Exception($"Failed to deserialize result for {method}");
                }

                return result;
            }
            finally
            {
                _pendingRequests.TryRemove(id, out _);
            }
        }

        public async Task<InitializeResponse> InitializeAsync(InitializeRequest request)
        {
            return await SendRequestAsync<InitializeResponse>(McpMethods.Initialize, request);
        }

        public async Task<List<Tool>> ListToolsAsync()
        {
            var response = await SendRequestAsync<ListToolsResponse>(McpMethods.ListTools, null);
            return response.Tools;
        }

        public async Task<CallToolResponse> CallToolAsync(string toolName, object? arguments)
        {
            var request = new CallToolRequest
            {
                Name = toolName,
                Arguments = arguments
            };
            return await SendRequestAsync<CallToolResponse>(McpMethods.CallTool, request);
        }

        public void Dispose()
        {
            try
            {
                DisconnectAsync().GetAwaiter().GetResult();
            }
            catch { }
            finally
            {
                _sendSemaphore?.Dispose();
            }
        }
    }
}