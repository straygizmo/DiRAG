namespace DiRAG.Services
{
    internal interface IChatService
    {
        Task<string> SendMessageAsync(string userInput, string? systemMessage = null);
        void ClearHistory();
    }
}
