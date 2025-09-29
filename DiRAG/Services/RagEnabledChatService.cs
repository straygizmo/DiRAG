using System.Text;
using DiRAG.Forms;

namespace DiRAG.Services
{
    internal class RagEnabledChatService : IChatService
    {
        private readonly IChatService _innerChatService;
        private readonly IRagService _ragService;
        private readonly MainForm _mainForm;
        private readonly List<string> _conversationHistory;
        private readonly bool _useContextInSystemMessage;
        private static string _lastContext = string.Empty;
        private static List<string> _lastCheckedFolders = new List<string>();

        public static string LastContext => _lastContext;
        public static List<string> LastCheckedFolders => _lastCheckedFolders;

        public RagEnabledChatService(IChatService innerChatService, IRagService ragService, MainForm mainForm, bool useContextInSystemMessage)
        {
            _innerChatService = innerChatService;
            _ragService = ragService;
            _mainForm = mainForm;
            _useContextInSystemMessage = useContextInSystemMessage;
            _conversationHistory = new List<string>();
        }

        public async Task<string> SendMessageAsync(string userInput, string? systemMessage = null)
        {
            if (string.IsNullOrEmpty(userInput))
                throw new ArgumentNullException(nameof(userInput), "Message is empty.");

            // Get checked folders from MainForm
            var checkedFolders = _mainForm.GetCheckedFolders();
            _lastCheckedFolders = new List<string>(checkedFolders);

            if (checkedFolders.Count == 0)
            {
                // No folders selected for RAG, just pass through to inner service
                return await _innerChatService.SendMessageAsync(userInput, systemMessage);
            }

            // Check if embeddings exist for all checked folders
            var foldersNeedingIndex = new List<string>();
            foreach (var folder in checkedFolders)
            {
                var embeddingsFile = Path.Combine(folder, "embeddings.jsonl");
                if (!File.Exists(embeddingsFile))
                {
                    foldersNeedingIndex.Add(folder);
                }
            }

            // Index folders if needed
            if (foldersNeedingIndex.Count > 0)
            {
                var progress = new Progress<string>(status =>
                {
                    Console.WriteLine($"Indexing: {status}");
                });

                await _mainForm.Indexing();
            }

            // Get RAG settings
            var topK = Properties.Settings.Default.RAG_TopKChunks;
            var maxContextLength = Properties.Settings.Default.RAG_MaxContextLength;

            // Search for relevant chunks
            var relevantChunks = await _ragService.SearchRelevantChunksAsync(
                userInput,
                checkedFolders,
                topK,
                maxContextLength);

            // Build enhanced message with context
            string messageToSend;
            string? contextAsSystemMessage = null;

            if (_useContextInSystemMessage && relevantChunks != null && relevantChunks.Count > 0)
            {
                // Build system message with context
                contextAsSystemMessage = BuildSystemMessageWithContext(relevantChunks);
                messageToSend = userInput;

                // Store the context for display
                _lastContext = contextAsSystemMessage;
            }
            else
            {
                // Build enhanced message with context included in user message
                messageToSend = BuildEnhancedMessage(userInput, relevantChunks);

                // Store the context for display
                _lastContext = ExtractContextFromEnhancedMessage(messageToSend, userInput);
            }

            // Send message to inner chat service with optional system message
            var response = await _innerChatService.SendMessageAsync(messageToSend, contextAsSystemMessage ?? systemMessage);

            // Add to conversation history
            _conversationHistory.Add($"User: {userInput}");
            _conversationHistory.Add($"Assistant: {response}");

            return response;
        }

        private string BuildEnhancedMessage(string userInput, List<Models.SearchResult> relevantChunks)
        {
            if (relevantChunks == null || relevantChunks.Count == 0)
            {
                return userInput;
            }

            var messageBuilder = new StringBuilder();

            // Add user message
            messageBuilder.AppendLine("[User Message]");
            messageBuilder.AppendLine(userInput);

            // Add context header
            messageBuilder.AppendLine();
            messageBuilder.AppendLine("---");
            messageBuilder.AppendLine("Please use the following context to answer the user's message:");

            // Add relevant chunks
            foreach (var chunk in relevantChunks)
            {
                var folderName = Path.GetFileName(chunk.FolderPath);
                messageBuilder.AppendLine($"[Context Source: {folderName}/{chunk.FilePath}]");
                messageBuilder.AppendLine(chunk.Text);
                messageBuilder.AppendLine();
                messageBuilder.AppendLine("---");
                messageBuilder.AppendLine();
            }

            return messageBuilder.ToString();
        }

        public void ClearHistory()
        {
            _conversationHistory.Clear();
            _innerChatService.ClearHistory();
        }

        private string BuildSystemMessageWithContext(List<Models.SearchResult> relevantChunks)
        {
            var messageBuilder = new StringBuilder();
            messageBuilder.AppendLine("Please use the following context to answer the user's message:");
            messageBuilder.AppendLine();

            // Add relevant chunks
            foreach (var chunk in relevantChunks)
            {
                var folderName = Path.GetFileName(chunk.FolderPath);
                messageBuilder.AppendLine($"[Context Source: {folderName}/{chunk.FilePath}]");
                messageBuilder.AppendLine(chunk.Text);
                messageBuilder.AppendLine();
                messageBuilder.AppendLine("---");
                messageBuilder.AppendLine();
            }

            return messageBuilder.ToString().Trim();
        }

        private string ExtractContextFromEnhancedMessage(string enhancedMessage, string userInput)
        {
            // If no context was added, return empty
            if (enhancedMessage == userInput)
            {
                return string.Empty;
            }

            // Extract the context portion (everything before "[User Message]")
            var userMessageIndex = enhancedMessage.IndexOf("[User Message]");
            if (userMessageIndex > 0)
            {
                return enhancedMessage.Substring(0, userMessageIndex).Trim();
            }

            return string.Empty;
        }
    }
}