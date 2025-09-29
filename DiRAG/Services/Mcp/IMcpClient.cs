namespace DiRAG.Services.Mcp
{
    public interface IMcpClient : IDisposable
    {
        Task<bool> ConnectAsync();
        Task DisconnectAsync();
        Task<InitializeResponse> InitializeAsync(InitializeRequest request);
        Task<List<Tool>> ListToolsAsync();
        Task<CallToolResponse> CallToolAsync(string toolName, object? arguments);
        bool IsConnected { get; }
        event EventHandler<string>? LogMessage;
    }
}