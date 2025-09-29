using DiRAG.Services.Mcp;
using System.Text;
using System.Text.Json;

namespace DiRAG.Services
{
    internal class McpEnabledChatService : IChatService
    {
        private readonly IChatService _innerChatService;
        private readonly IMcpService? _mcpService;

        public McpEnabledChatService(IChatService innerChatService, IMcpService? mcpService)
        {
            _innerChatService = innerChatService;
            _mcpService = mcpService;
        }

        public async Task<string> SendMessageAsync(string userInput, string? systemMessage = null)
        {
            // Check if MCP tools should be included
            if (_mcpService != null)
            {
                var tools = await _mcpService.GetAllToolsAsync();
                if (tools.Any())
                {
                    // Check if the user is asking to use a specific tool
                    var toolCalls = ParseToolCalls(userInput);
                    if (toolCalls.Any())
                    {
                        var results = new StringBuilder();
                        results.AppendLine("Tool execution results:");
                        results.AppendLine();

                        foreach (var toolCall in toolCalls)
                        {
                            try
                            {
                                var response = await _mcpService.CallToolAsync(toolCall.ToolName, toolCall.Arguments);
                                results.AppendLine($"**{toolCall.ToolName}:**");

                                foreach (var content in response.Content)
                                {
                                    if (content.Type == "text" && !string.IsNullOrEmpty(content.Text))
                                    {
                                        results.AppendLine(content.Text);
                                    }
                                    else if (content.Type == "image" && !string.IsNullOrEmpty(content.Data))
                                    {
                                        results.AppendLine($"[Image: {content.MimeType}]");
                                    }
                                }
                                results.AppendLine();
                            }
                            catch (Exception ex)
                            {
                                results.AppendLine($"Error calling tool {toolCall.ToolName}: {ex.Message}");
                                results.AppendLine();
                            }
                        }

                        // Add tool results to the user input
                        userInput = $"{userInput}\n\n{results}";
                    }
                    else
                    {
                        // Add available tools information to system message
                        var toolsInfo = new StringBuilder();
                        toolsInfo.AppendLine("Available MCP Tools:");
                        foreach (var tool in tools)
                        {
                            toolsInfo.AppendLine($"- {tool.Name}: {tool.Description}");
                        }

                        if (!string.IsNullOrEmpty(systemMessage))
                        {
                            systemMessage = $"{systemMessage}\n\n{toolsInfo}";
                        }
                        else
                        {
                            systemMessage = toolsInfo.ToString();
                        }
                    }
                }
            }

            // Pass through to the inner chat service
            return await _innerChatService.SendMessageAsync(userInput, systemMessage);
        }

        public void ClearHistory()
        {
            _innerChatService.ClearHistory();
        }

        private List<ToolCall> ParseToolCalls(string userInput)
        {
            var toolCalls = new List<ToolCall>();

            // Simple pattern matching for tool calls
            // Format: @toolname {json arguments} or @toolname(arg1, arg2)
            var lines = userInput.Split('\n');
            foreach (var line in lines)
            {
                if (line.StartsWith("@"))
                {
                    var spaceIndex = line.IndexOf(' ');
                    var parenIndex = line.IndexOf('(');

                    string toolName;
                    object? arguments = null;

                    if (spaceIndex > 0 && (parenIndex < 0 || spaceIndex < parenIndex))
                    {
                        // Format: @toolname {json} or @toolname text
                        toolName = line.Substring(1, spaceIndex - 1);
                        var argText = line.Substring(spaceIndex + 1).Trim();

                        if (argText.StartsWith("{") && argText.EndsWith("}"))
                        {
                            try
                            {
                                arguments = JsonSerializer.Deserialize<Dictionary<string, object>>(argText);
                            }
                            catch
                            {
                                arguments = new Dictionary<string, object> { ["text"] = argText };
                            }
                        }
                        else
                        {
                            arguments = new Dictionary<string, object> { ["text"] = argText };
                        }
                    }
                    else if (parenIndex > 0)
                    {
                        // Format: @toolname(args)
                        toolName = line.Substring(1, parenIndex - 1);
                        var closeParenIndex = line.IndexOf(')', parenIndex);
                        if (closeParenIndex > parenIndex)
                        {
                            var argText = line.Substring(parenIndex + 1, closeParenIndex - parenIndex - 1);
                            arguments = new Dictionary<string, object> { ["text"] = argText };
                        }
                    }
                    else
                    {
                        // Format: @toolname
                        toolName = line.Substring(1).Trim();
                    }

                    if (!string.IsNullOrEmpty(toolName))
                    {
                        toolCalls.Add(new ToolCall { ToolName = toolName, Arguments = arguments });
                    }
                }
            }

            return toolCalls;
        }

        private class ToolCall
        {
            public string ToolName { get; set; } = string.Empty;
            public object? Arguments { get; set; }
        }
    }
}