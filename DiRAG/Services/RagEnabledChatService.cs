using System.Text;
using DiRAG.Forms;
using DiRAG.Exceptions;

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

            if (checkedFolders.Count == 0)
            {
                // No folders selected for RAG, just pass through to inner service
                _lastCheckedFolders = new List<string>();
                return await _innerChatService.SendMessageAsync(userInput, systemMessage);
            }

            // Check if folder selection has changed
            bool foldersChanged = !checkedFolders.SequenceEqual(_lastCheckedFolders);

            // Only check for missing embeddings if folders have changed
            var foldersNeedingIndex = new List<string>();
            if (foldersChanged)
            {
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

                // Update last checked folders after indexing
                _lastCheckedFolders = new List<string>(checkedFolders);
            }

            // Get RAG settings
            var topK = Properties.Settings.Default.RAG_TopKChunks;
            var maxContextLength = Properties.Settings.Default.RAG_MaxContextLength;

            // Search for relevant chunks with error handling
            List<Models.SearchResult> relevantChunks = new List<Models.SearchResult>();
            try
            {
                relevantChunks = await _ragService.SearchRelevantChunksAsync(
                    userInput,
                    checkedFolders,
                    topK,
                    maxContextLength);
            }
            catch (VectorizationException vex)
            {
                // Return the formatted error message as an AI response
                return vex.GetFormattedErrorMessage();
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                return $"[Error]\n\nAn unexpected error occurred while processing your message with RAG.\n\n" +
                       $"Error: {ex.Message}\n\n" +
                       "Suggested actions:\n" +
                       "• Check your embedding service configuration in Settings\n" +
                       "• Try disabling RAG by unchecking folders in the Dir to RAG tab\n" +
                       "• Contact support if the issue persists";
            }

            // Build enhanced message with context
            string messageToSend;
            string? contextAsSystemMessage = null;

            if (_useContextInSystemMessage && relevantChunks.Count > 0)
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
                messageToSend = BuildEnhancedMessage(userInput, relevantChunks!);

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