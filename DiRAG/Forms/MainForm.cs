using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using DiRAG.Pages;
using DiRAG.Services;
using DiRAG.Services.Mcp;
using DiRAG.Models;
using Krypton.Toolkit;
using System.Text.Json;

namespace DiRAG.Forms
{
    public partial class MainForm : KryptonForm
    {
        private IMcpService? _mcpService;
        private McpServerCollection _mcpServerCollection = new();

        // Event to notify Blazor about theme changes
        public event EventHandler<string>? ThemeChanged;

        public bool IsDarkTheme
        {
            get
            {
                var mode = GetThemeMode();
                return mode == "dark" || mode == "dark-indigo";
            }
        }

        public string GetThemeMode()
        {
            try
            {
                // Get the selected theme name from KryptonThemeListBox
                if (kryptonThemeListBox1.SelectedItem != null)
                {
                    var themeName = kryptonThemeListBox1.SelectedItem.ToString() ?? "";

                    // Check if theme name contains both "Blue" and "Dark" → Indigo dark mode
                    if (themeName.Contains("Blue", StringComparison.OrdinalIgnoreCase) &&
                        themeName.Contains("Dark", StringComparison.OrdinalIgnoreCase))
                    {
                        return "dark-indigo";
                    }

                    // Check if theme name contains "Black" or "Dark" → Regular dark mode
                    if (themeName.Contains("Black", StringComparison.OrdinalIgnoreCase) ||
                        themeName.Contains("Dark", StringComparison.OrdinalIgnoreCase))
                    {
                        return "dark";
                    }

                    // Otherwise → Light mode
                    return "light";
                }
                return "light";
            }
            catch
            {
                return "light";
            }
        }

        public MainForm()
        {
            InitializeComponent();
            InitializeMcpComponents();
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            LoadSettings();
            LoadFolderTree();

            if (!IsConfigured())
            {
                ShowSettingsDialog();
                if (!IsConfigured())
                {
                    MessageBox.Show("API configuration is required to use this application.",
                        "Configuration Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }
            }

            InitializeBlazorWebView();
        }

        private void InitializeBlazorWebView()
        {
            var services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();

            // Add this form as a singleton so it can be injected
            services.AddSingleton(this);

            // Add localization service
            services.AddSingleton(Program.LocalizationService!);

            // Add RAG service
            services.AddScoped<IRagService>(serviceProvider =>
            {
                var embeddingUrl = Properties.Settings.Default.Embedding_Url;
                var apiKey = Properties.Settings.Default.OpenAI_ApiKey;
                var embeddingModel = Properties.Settings.Default.Embedding_Model;
                var useNativeEmbedding = Properties.Settings.Default.UseNativeEmbedding;
                var ggufModel = Properties.Settings.Default.EmbeddingGGUFModel;
                var contextLength = Properties.Settings.Default.RAG_ContextLength;
                var chunkSize = Properties.Settings.Default.RAG_ChunkSize;
                var chunkOverlap = Properties.Settings.Default.RAG_ChunkOverlap;

                return new RagService(embeddingUrl, apiKey, embeddingModel, useNativeEmbedding,
                    contextLength, chunkSize, chunkOverlap, ggufModel);
            });

            // Choose the chat service based on the selected API provider
            var apiProvider = Properties.Settings.Default.API_Provider;

            services.AddScoped<IChatService>(serviceProvider =>
            {
                IChatService innerService;

                if (apiProvider == "Claude Code")
                {
                    var cliPath = Properties.Settings.Default.ClaudeCode_CLIPath;
                    var model = Properties.Settings.Default.ClaudeCode_Model;
                    innerService = new ClaudeCodeChatService(cliPath, model);
                }
                else // OpenAI Compatible
                {
                    var baseUrl = Properties.Settings.Default.OpenAI_BaseUrl;
                    var apiKey = Properties.Settings.Default.OpenAI_ApiKey;
                    var model = Properties.Settings.Default.OpenAI_Model;
                    innerService = new OpenAIChatService(baseUrl, apiKey, model);
                }

                // Wrap the inner service with RAG capabilities
                var ragService = serviceProvider.GetRequiredService<IRagService>();
                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                var useContextInSystemMessage = Properties.Settings.Default.UseContextInSystemMessage;
                var ragEnabledService = new RagEnabledChatService(innerService, ragService, mainForm, useContextInSystemMessage);

                // Wrap with MCP capabilities
                var mcpService = mainForm.GetMcpService();
                return new McpEnabledChatService(ragEnabledService, mcpService);
            });

            blazorWebView1.HostPage = "wwwroot\\index.html";
            blazorWebView1.Services = services.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<Chat>("#app");
        }

        private bool IsConfigured()
        {
            var apiProvider = Properties.Settings.Default.API_Provider;

            if (apiProvider == "Claude Code")
            {
                var claudePath = Properties.Settings.Default.ClaudeCode_CLIPath;
                var claudeModel = Properties.Settings.Default.ClaudeCode_Model;
                return !string.IsNullOrEmpty(claudePath) && !string.IsNullOrEmpty(claudeModel);
            }
            else // OpenAI Compatible
            {
                var apiKey = Properties.Settings.Default.OpenAI_ApiKey;
                var model = Properties.Settings.Default.OpenAI_Model;
                return !string.IsNullOrEmpty(apiKey) && !string.IsNullOrEmpty(model);
            }
        }

        private void ShowSettingsDialog()
        {
            tabMain.SelectedIndex = 1;
        }


        private void LoadSettings()
        {
            // Load Language selection
            InitializeLanguageComboBox();
            UpdateUILabels(); // Apply current language labels

            // Load API Provider selection
            var apiProvider = Properties.Settings.Default.API_Provider;
            cmbAPIProvider.SelectedItem = apiProvider;

            // Load provider-specific settings
            openAISettingsControl.LoadSettings();
            claudeCodeSettingsControl.LoadSettings();

            // Load embedding settings
            txtEmbeddingUrl.Text = Properties.Settings.Default.Embedding_Url;
            txtEmbeddingModel.Text = Properties.Settings.Default.Embedding_Model;
            txtContextLength.Text = Properties.Settings.Default.RAG_ContextLength.ToString();
            txtChunkSize.Text = Properties.Settings.Default.RAG_ChunkSize.ToString();
            txtChunkOverlap.Text = Properties.Settings.Default.RAG_ChunkOverlap.ToString();
            txtTopKChunks.Text = Properties.Settings.Default.RAG_TopKChunks.ToString();
            txtMaxContextLength.Text = Properties.Settings.Default.RAG_MaxContextLength.ToString();

            // Load embedding method
            var embeddingMethod = Properties.Settings.Default.EmbeddingMethod;
            if (embeddingMethod == "GGUF")
            {
                rbEmbeddingGGUF.Checked = true;
            }
            else
            {
                rbEmbeddingAPI.Checked = true;
            }

            // Load GGUF models
            LoadGGUFModels();

            // Load selected GGUF model
            var ggufModel = Properties.Settings.Default.EmbeddingGGUFModel;
            if (!string.IsNullOrEmpty(ggufModel) && cmbGGUFModel.Items.Contains(ggufModel))
            {
                cmbGGUFModel.SelectedItem = ggufModel;
            }

            // Update UI visibility based on selected method
            UpdateEmbeddingMethodUI();

            var selectedIndex = Properties.Settings.Default.UI_Theme;
            if (selectedIndex >= 0)
            {
                kryptonThemeListBox1.SelectedIndex = selectedIndex;
            }

            // Update UI visibility based on selected provider
            UpdateProviderUI(apiProvider);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save API Provider selection
            Properties.Settings.Default.API_Provider = cmbAPIProvider.SelectedItem?.ToString() ?? "OpenAI Compatible";

            // Save provider-specific settings (always save, even if not currently selected)
            openAISettingsControl.SaveSettings();
            claudeCodeSettingsControl.SaveSettings();

            // Save embedding settings
            Properties.Settings.Default.Embedding_Url = txtEmbeddingUrl.Text;
            Properties.Settings.Default.Embedding_Model = txtEmbeddingModel.Text;

            if (int.TryParse(txtContextLength.Text, out var contextLength))
                Properties.Settings.Default.RAG_ContextLength = contextLength;
            if (int.TryParse(txtChunkSize.Text, out var chunkSize))
                Properties.Settings.Default.RAG_ChunkSize = chunkSize;
            if (int.TryParse(txtChunkOverlap.Text, out var chunkOverlap))
                Properties.Settings.Default.RAG_ChunkOverlap = chunkOverlap;
            if (int.TryParse(txtTopKChunks.Text, out var topKChunks))
                Properties.Settings.Default.RAG_TopKChunks = topKChunks;
            if (int.TryParse(txtMaxContextLength.Text, out var maxContextLength))
                Properties.Settings.Default.RAG_MaxContextLength = maxContextLength;

            // Save embedding method
            Properties.Settings.Default.EmbeddingMethod = rbEmbeddingGGUF.Checked ? "GGUF" : "API";
            Properties.Settings.Default.EmbeddingGGUFModel = cmbGGUFModel.SelectedItem?.ToString() ?? "";

            // For backward compatibility, set UseNativeEmbedding based on embedding method
            Properties.Settings.Default.UseNativeEmbedding = rbEmbeddingGGUF.Checked;

            Properties.Settings.Default.Save();

            MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnTestEmbedding_Click(object? sender, EventArgs e)
        {
            try
            {
                // Get current settings from UI
                var embeddingUrl = txtEmbeddingUrl.Text;
                var embeddingModel = txtEmbeddingModel.Text;
                var apiKey = Properties.Settings.Default.OpenAI_ApiKey;
                var useNativeEmbedding = rbEmbeddingGGUF.Checked;
                var ggufModel = cmbGGUFModel.SelectedItem?.ToString() ?? "";

                // Validate settings
                if (useNativeEmbedding)
                {
                    if (string.IsNullOrWhiteSpace(ggufModel))
                    {
                        MessageBox.Show("GGUF Model is required.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(embeddingUrl))
                    {
                        MessageBox.Show("Embedding URL is required.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(embeddingModel))
                    {
                        MessageBox.Show("Embedding Model is required.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Disable button during test
                if (sender is Krypton.Toolkit.KryptonButton btn)
                {
                    btn.Enabled = false;
                    btn.Values.Text = "Testing...";
                }

                string message;

                if (useNativeEmbedding)
                {
                    // Use native embeddinggemma_loader (Python GGUF implementation)
                    var ragService = new RagService(
                        embeddingUrl,
                        apiKey,
                        embeddingModel,
                        useNativeEmbedding,
                        contextLength: 2048,
                        chunkSize: 500,
                        chunkOverlap: 100,
                        ggufModel: ggufModel
                    );

                    const string testText = "This is a test to verify the embedding configuration.";
                    var embedding = await ragService.GenerateEmbeddingAsync(testText);

                    message = $"✓ Connection Successful!\n\n" +
                             $"Method: Native GGUF (embeddinggemma_loader)\n" +
                             $"Embedding Model: Local GGUF\n" +
                             $"Embedding Dimension: {embedding.Length}\n" +
                             $"Sample values: [{string.Join(", ", embedding.Take(5).Select(f => f.ToString("F4")))}...]";
                }
                else
                {
                    // Use Python implementation
                    var pythonExecutable = PythonPathHelper.PythonExecutable;
                    var testScript = PythonPathHelper.GetScriptPath("test_embedding.py");

                    // Create temporary config file
                    var tempConfigFile = Path.Combine(Path.GetTempPath(), $"test_embedding_config_{Guid.NewGuid()}.json");

                    try
                    {
                        var config = new
                        {
                            embedding_url = embeddingUrl,
                            embedding_model = embeddingModel,
                            api_key = apiKey
                        };

                        var configJson = System.Text.Json.JsonSerializer.Serialize(config, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
                        await File.WriteAllTextAsync(tempConfigFile, configJson);

                        // Run Python test script
                        var processStartInfo = new System.Diagnostics.ProcessStartInfo
                        {
                            FileName = pythonExecutable,
                            Arguments = $"\"{testScript}\" \"{tempConfigFile}\"",
                            RedirectStandardOutput = true,
                            RedirectStandardError = true,
                            UseShellExecute = false,
                            CreateNoWindow = true,
                            WorkingDirectory = PythonPathHelper.PythonToolsDirectory
                        };

                        using var process = new System.Diagnostics.Process { StartInfo = processStartInfo };
                        process.Start();

                        var output = await process.StandardOutput.ReadToEndAsync();
                        var error = await process.StandardError.ReadToEndAsync();

                        await process.WaitForExitAsync();

                        // Parse JSON result from Python script
                        var lastLine = output.Trim().Split('\n').LastOrDefault() ?? "";
                        var result = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, object>>(lastLine);

                        if (result != null && result.ContainsKey("success"))
                        {
                            var success = result["success"].ToString() == "True";

                            if (success)
                            {
                                var dimension = result.ContainsKey("dimension") ? result["dimension"].ToString() : "unknown";
                                var sampleValues = result.ContainsKey("sample_values")
                                    ? System.Text.Json.JsonSerializer.Deserialize<float[]>(result["sample_values"].ToString() ?? "[]")
                                    : Array.Empty<float>();

                                message = $"✓ Connection Successful!\n\n" +
                                         $"Method: Python\n" +
                                         $"Embedding Model: {embeddingModel}\n" +
                                         $"Embedding URL: {embeddingUrl}\n" +
                                         $"Embedding Dimension: {dimension}\n" +
                                         $"Sample values: [{string.Join(", ", sampleValues.Take(5).Select(f => f.ToString("F4")))}...]";
                            }
                            else
                            {
                                var errorMsg = result.ContainsKey("error") ? result["error"].ToString() : "Unknown error";
                                throw new Exception(errorMsg ?? "Unknown error");
                            }
                        }
                        else
                        {
                            throw new Exception($"Invalid Python script output:\n{output}\n\nError:\n{error}");
                        }
                    }
                    finally
                    {
                        // Clean up temp file
                        if (File.Exists(tempConfigFile))
                        {
                            try { File.Delete(tempConfigFile); } catch { }
                        }
                    }
                }

                MessageBox.Show(message, "Embedding Test Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Show error message
                var errorMessage = $"✗ Connection Failed!\n\n" +
                                  $"Error: {ex.Message}";

                if (ex.InnerException != null)
                {
                    errorMessage += $"\n\nDetails: {ex.InnerException.Message}";
                }

                MessageBox.Show(errorMessage, "Embedding Test Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Re-enable button
                if (sender is Krypton.Toolkit.KryptonButton btn)
                {
                    btn.Enabled = true;
                    btn.Values.Text = "Test Embedding";
                }
            }
        }

        private void InitializeLanguageComboBox()
        {
            // Clear existing items
            cmbLanguage.Items.Clear();

            // Add language options
            cmbLanguage.Items.Add("English (US)");
            cmbLanguage.Items.Add("日本語 (Japanese)");

            // Set the current language
            var currentLanguage = Properties.Settings.Default.PreferredLanguage;
            if (currentLanguage == "ja-JP")
            {
                cmbLanguage.SelectedIndex = 1;
            }
            else
            {
                cmbLanguage.SelectedIndex = 0;
            }
        }

        private void cmbLanguage_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (Program.LocalizationService == null) return;

            var selectedIndex = cmbLanguage.SelectedIndex;
            var cultureName = selectedIndex == 1 ? "ja-JP" : "en-US";

            // Change the culture
            Program.LocalizationService.ChangeCulture(cultureName);

            // Update UI labels
            UpdateUILabels();
        }

        private void UpdateUILabels()
        {
            var loc = Program.LocalizationService;
            if (loc == null) return;

            // Update tab names
            tabPageDir.Text = loc.GetString("TabDirToRag");
            tabPageSettings.Text = loc.GetString("TabSettings");
            tabPageChat.Text = loc.GetString("TabChat");
            tabPageRAG.Text = loc.GetString("TabRAG");
            tabPageTheme.Text = loc.GetString("TabTheme");
            tabPageMCP.Text = loc.GetString("TabMCP");

            // Update labels in Settings
            lblAPIProvider.Values.Text = loc.GetString("APIProvider") + ":";
            lblLanguage.Values.Text = loc.GetString("Language") + ":";

            // Update RAG Settings labels
            lblEmbeddingUrl.Values.Text = loc.GetString("EmbeddingURL") + ":";
            lblEmbeddingModel.Values.Text = loc.GetString("EmbeddingModel") + ":";
            lblContextLength.Values.Text = loc.GetString("ContextLength") + ":";
            lblChunkSize.Values.Text = loc.GetString("ChunkSize") + ":";
            lblChunkOverlap.Values.Text = loc.GetString("ChunkOverlap") + ":";
            lblMaxContextLength.Values.Text = loc.GetString("MaxContextLength") + ":";
            lblTopKChunks.Values.Text = loc.GetString("TopKChunks") + ":";

            // Update button texts
            btnSaveChatSettings.Values.Text = loc.GetString("Save");
            btnSaveRAGSettings.Values.Text = loc.GetString("Save");
            tspRefresh.Text = loc.GetString("Refresh");
            tsbIndexing.Text = loc.GetString("Indexing");

            // Update MCP buttons
            btnAddMcpServer.Values.Text = loc.GetString("Add");
            btnEditMcpServer.Values.Text = loc.GetString("Edit");
            btnRemoveMcpServer.Values.Text = loc.GetString("Remove");
            btnTestMcpServer.Values.Text = loc.GetString("Test");
            btnLoadMcpServers.Values.Text = loc.GetString("Load");
        }


        private void cmbAPIProvider_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var selectedProvider = cmbAPIProvider.SelectedItem?.ToString();
            UpdateProviderUI(selectedProvider);
        }

        private void UpdateProviderUI(string? provider)
        {
            if (provider == "Claude Code")
            {
                // Show Claude Code settings panel
                claudeCodeSettingsControl.Visible = true;

                // Hide OpenAI settings panel
                openAISettingsControl.Visible = false;
            }
            else // OpenAI Compatible
            {
                // Show OpenAI settings panel
                openAISettingsControl.Visible = true;

                // Hide Claude Code settings panel
                claudeCodeSettingsControl.Visible = false;
            }
        }

        private void LoadGGUFModels()
        {
            cmbGGUFModel.Items.Clear();

            try
            {
                var modelsPath = Path.Combine(PythonPathHelper.PythonToolsDirectory, "models");

                if (!Directory.Exists(modelsPath))
                {
                    return;
                }

                // Enumerate all folders and .gguf files
                foreach (var dir in Directory.GetDirectories(modelsPath))
                {
                    var dirName = Path.GetFileName(dir);
                    // Check if there are .gguf files in the folder
                    var ggufFiles = Directory.GetFiles(dir, "*.gguf");
                    foreach (var ggufFile in ggufFiles)
                    {
                        var fileName = Path.GetFileName(ggufFile);
                        var displayName = $"{dirName}/{fileName}";
                        cmbGGUFModel.Items.Add(displayName);
                    }
                }

                // Also check for .gguf files directly in models folder
                foreach (var ggufFile in Directory.GetFiles(modelsPath, "*.gguf"))
                {
                    var fileName = Path.GetFileName(ggufFile);
                    cmbGGUFModel.Items.Add(fileName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading GGUF models: {ex.Message}");
            }
        }

        private void UpdateEmbeddingMethodUI()
        {
            if (rbEmbeddingAPI.Checked)
            {
                // Show API controls
                txtEmbeddingUrl.Visible = true;
                lblEmbeddingUrl.Visible = true;
                txtEmbeddingModel.Visible = true;
                lblEmbeddingModel.Visible = true;

                // Hide GGUF controls
                cmbGGUFModel.Visible = false;
            }
            else if (rbEmbeddingGGUF.Checked)
            {
                // Hide API controls
                txtEmbeddingUrl.Visible = false;
                lblEmbeddingUrl.Visible = false;
                txtEmbeddingModel.Visible = false;
                lblEmbeddingModel.Visible = false;

                // Show GGUF controls
                cmbGGUFModel.Visible = true;
            }
        }

        private void rbEmbeddingAPI_CheckedChanged(object? sender, EventArgs e)
        {
            if (rbEmbeddingAPI.Checked)
            {
                UpdateEmbeddingMethodUI();
            }
        }

        private void rbEmbeddingGGUF_CheckedChanged(object? sender, EventArgs e)
        {
            if (rbEmbeddingGGUF.Checked)
            {
                UpdateEmbeddingMethodUI();
            }
        }

        private void KryptonThemeListBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Properties.Settings.Default.UI_Theme = kryptonThemeListBox1.SelectedIndex;
            Properties.Settings.Default.Save();

            // Notify Blazor about theme change with theme mode
            ThemeChanged?.Invoke(this, GetThemeMode());
        }

        private void LoadFolderTree()
        {
            ktvFolderTree.BeginUpdate();
            ktvFolderTree.Nodes.Clear();

            foreach (var drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    var driveNode = new TreeNode(drive.Name)
                    {
                        Tag = drive.RootDirectory.FullName
                    };
                    driveNode.Nodes.Add(new TreeNode());
                    ktvFolderTree.Nodes.Add(driveNode);
                }
            }

            ktvFolderTree.BeforeExpand += KtvFolderTree_BeforeExpand;
            ktvFolderTree.EndUpdate();

            RestoreTreeState();
        }

        private void KtvFolderTree_BeforeExpand(object? sender, TreeViewCancelEventArgs e)
        {
            if (e.Node == null || e.Node.Nodes.Count != 1 || e.Node.Nodes[0].Tag != null)
                return;

            e.Node.Nodes.Clear();

            var directoryPath = e.Node.Tag?.ToString();
            if (string.IsNullOrEmpty(directoryPath))
                return;

            try
            {
                var directoryInfo = new DirectoryInfo(directoryPath);
                foreach (var directory in directoryInfo.GetDirectories())
                {
                    try
                    {
                        var dirNode = new TreeNode(directory.Name)
                        {
                            Tag = directory.FullName
                        };
                        dirNode.Nodes.Add(new TreeNode());
                        e.Node.Nodes.Add(dirNode);
                    }
                    catch
                    {
                    }
                }
            }
            catch
            {
            }
        }

        public List<string> GetCheckedFolders()
        {
            var checkedFolders = new List<string>();
            GetCheckedFoldersRecursive(ktvFolderTree.Nodes, checkedFolders);
            return checkedFolders;
        }

        private void GetCheckedFoldersRecursive(TreeNodeCollection nodes, List<string> checkedFolders)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked && node.Tag != null)
                {
                    checkedFolders.Add(node.Tag.ToString()!);
                }
                if (node.Nodes.Count > 0)
                {
                    GetCheckedFoldersRecursive(node.Nodes, checkedFolders);
                }
            }
        }

        private async void tsbIndexing_Click(object sender, EventArgs e)
        {
            await Indexing();
        }

        public async Task Indexing()
        {
            SaveTreeState();

            var checkedFolders = GetCheckedFolders();

            if (checkedFolders.Count == 0)
            {
                MessageBox.Show("Please select at least one folder to process.", "No Folders Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tsbIndexing.Enabled = false;
            toolStripStatusLabel1.Text = "Processing...";

            try
            {
                var embeddingUrl = Properties.Settings.Default.Embedding_Url;
                var apiKey = Properties.Settings.Default.OpenAI_ApiKey;
                var embeddingModel = Properties.Settings.Default.Embedding_Model;
                var contextLength = Properties.Settings.Default.RAG_ContextLength;
                var chunkSize = Properties.Settings.Default.RAG_ChunkSize;
                var chunkOverlap = Properties.Settings.Default.RAG_ChunkOverlap;
                var useNativeEmbedding = Properties.Settings.Default.UseNativeEmbedding;
                var ggufModel = Properties.Settings.Default.EmbeddingGGUFModel;

                // Validation based on embedding method
                if (useNativeEmbedding)
                {
                    if (string.IsNullOrEmpty(ggufModel))
                    {
                        MessageBox.Show("Please select a GGUF model in the Settings tab.",
                            "Configuration Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(embeddingModel))
                    {
                        MessageBox.Show("Please configure Embedding settings in the Settings tab.",
                            "Configuration Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                var ragService = new Services.RagService(embeddingUrl, apiKey, embeddingModel, useNativeEmbedding, contextLength, chunkSize, chunkOverlap, ggufModel);
                var progress = new Progress<string>(status =>
                {
                    toolStripStatusLabel1.Text = status;
                    Application.DoEvents();
                });

                await ragService.ProcessFoldersAsync(checkedFolders, progress);

                toolStripStatusLabel1.Text = "Processing complete!";
                MessageBox.Show("RAG processing completed successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Error occurred";
                var detailedError = $"Error during RAG processing:\n\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}";
                if (ex.InnerException != null)
                {
                    detailedError += $"\n\nInner Exception:\n{ex.InnerException.Message}";
                }
                MessageBox.Show(detailedError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tsbIndexing.Enabled = true;
            }
        }

        private void tspRefresh_Click(object sender, EventArgs e)
        {
            LoadFolderTree();
        }

        private void SaveTreeState()
        {
            try
            {
                var treeState = new Dictionary<string, TreeNodeState>();
                SerializeTreeState(ktvFolderTree.Nodes, treeState);
                var json = JsonSerializer.Serialize(treeState);
                Properties.Settings.Default.FolderTree_State = json;
                Properties.Settings.Default.Save();
            }
            catch
            {
            }
        }

        private void SerializeTreeState(TreeNodeCollection nodes, Dictionary<string, TreeNodeState> treeState)
        {
            foreach (TreeNode node in nodes)
            {
                var path = node.Tag?.ToString();
                if (!string.IsNullOrEmpty(path))
                {
                    treeState[path] = new TreeNodeState
                    {
                        IsChecked = node.Checked,
                        IsExpanded = node.IsExpanded
                    };

                    if (node.Nodes.Count > 0)
                    {
                        SerializeTreeState(node.Nodes, treeState);
                    }
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTreeState();
        }

        private void RestoreTreeState()
        {
            try
            {
                var json = Properties.Settings.Default.FolderTree_State;
                if (string.IsNullOrEmpty(json))
                    return;

                var treeState = JsonSerializer.Deserialize<Dictionary<string, TreeNodeState>>(json);
                if (treeState == null)
                    return;

                DeserializeTreeState(ktvFolderTree.Nodes, treeState);
            }
            catch
            {
            }
        }

        private void DeserializeTreeState(TreeNodeCollection nodes, Dictionary<string, TreeNodeState> treeState)
        {
            foreach (TreeNode node in nodes)
            {
                var path = node.Tag?.ToString();
                if (!string.IsNullOrEmpty(path) && treeState.TryGetValue(path, out var state))
                {
                    node.Checked = state.IsChecked;

                    if (state.IsExpanded && node.Nodes.Count > 0)
                    {
                        node.Expand();

                        if (node.Nodes.Count > 0 && node.Nodes[0].Tag != null)
                        {
                            DeserializeTreeState(node.Nodes, treeState);
                        }
                    }
                }
            }
        }

        #region MCP Server Management

        private void InitializeMcpComponents()
        {
            // Initialize MCP service
            _mcpService = new McpService();
            _mcpService.LogMessage += (sender, message) =>
            {
                AppendMcpLog(message);
            };
            _mcpService.ServerStatusChanged += (sender, args) =>
            {
                UpdateServerStatus(args);
            };

            // Setup DataGridView
            dgvMcpServers.AllowUserToAddRows = false;
            dgvMcpServers.AllowUserToDeleteRows = false;
            dgvMcpServers.ReadOnly = true;
            dgvMcpServers.Columns.Clear();
            dgvMcpServers.Columns.Add("Name", "Name");
            dgvMcpServers.Columns.Add("Status", "Status");
            dgvMcpServers.Columns.Add("Type", "Type");
            dgvMcpServers.Columns.Add("Enabled", "Enabled");
            dgvMcpServers.Columns[0].Width = 100;
            dgvMcpServers.Columns[1].Width = 70;
            dgvMcpServers.Columns[2].Width = 50;
            dgvMcpServers.Columns[3].Width = 60;

            // Wire up event handlers
            btnAddMcpServer.Click += BtnAddMcpServer_Click;
            btnEditMcpServer.Click += BtnEditMcpServer_Click;
            btnRemoveMcpServer.Click += BtnRemoveMcpServer_Click;
            btnTestMcpServer.Click += BtnTestMcpServer_Click;
            btnLoadMcpServers.Click += BtnLoadMcpServers_Click;

            // Load MCP servers from settings
            LoadMcpServers();
        }

        private void LoadMcpServers()
        {
            try
            {
                var mcpServersJson = Properties.Settings.Default.MCP_Servers;
                if (!string.IsNullOrEmpty(mcpServersJson))
                {
                    _mcpServerCollection = JsonSerializer.Deserialize<McpServerCollection>(mcpServersJson) ?? new McpServerCollection();
                }
                else
                {
                    _mcpServerCollection = new McpServerCollection();
                }

                RefreshMcpServerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading MCP servers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveMcpServers()
        {
            try
            {
                var json = JsonSerializer.Serialize(_mcpServerCollection, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                Properties.Settings.Default.MCP_Servers = json;
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving MCP servers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshMcpServerList()
        {
            dgvMcpServers.Rows.Clear();
            foreach (var server in _mcpServerCollection.Servers)
            {
                var status = _mcpService?.IsServerLoaded(server.Id) ?? false ? "Connected" : "Disconnected";
                dgvMcpServers.Rows.Add(server.Name, status, server.TransportType.ToString(), server.IsEnabled);
                var row = dgvMcpServers.Rows[dgvMcpServers.Rows.Count - 1];
                row.Tag = server;
            }
        }

        private void BtnAddMcpServer_Click(object? sender, EventArgs e)
        {
            using var dialog = new McpServerDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _mcpServerCollection.Servers.Add(dialog.ServerConfig);
                SaveMcpServers();
                RefreshMcpServerList();
                AppendMcpLog($"Added server: {dialog.ServerConfig.Name}");
            }
        }

        private void BtnEditMcpServer_Click(object? sender, EventArgs e)
        {
            if (dgvMcpServers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a server to edit.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var server = dgvMcpServers.SelectedRows[0].Tag as McpServerConfig;
            if (server == null) return;

            using var dialog = new McpServerDialog(server);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SaveMcpServers();
                RefreshMcpServerList();
                AppendMcpLog($"Updated server: {server.Name}");
            }
        }

        private void BtnRemoveMcpServer_Click(object? sender, EventArgs e)
        {
            if (dgvMcpServers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a server to remove.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var server = dgvMcpServers.SelectedRows[0].Tag as McpServerConfig;
            if (server == null) return;

            var result = MessageBox.Show($"Are you sure you want to remove '{server.Name}'?",
                "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Unload server if connected
                if (_mcpService?.IsServerLoaded(server.Id) ?? false)
                {
                    _mcpService.UnloadServerAsync(server.Id).GetAwaiter().GetResult();
                }

                _mcpServerCollection.Servers.Remove(server);
                SaveMcpServers();
                RefreshMcpServerList();
                AppendMcpLog($"Removed server: {server.Name}");
            }
        }

        private async void BtnTestMcpServer_Click(object? sender, EventArgs e)
        {
            if (dgvMcpServers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a server to test.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var server = dgvMcpServers.SelectedRows[0].Tag as McpServerConfig;
            if (server == null || _mcpService == null) return;

            // Run test in background to prevent UI freeze
            btnTestMcpServer.Enabled = false;
            AppendMcpLog($"Testing server: {server.Name}");

            await Task.Run(async () =>
            {
                try
                {
                    var success = await _mcpService.LoadServerAsync(server);

                    Invoke(() => {
                        if (success)
                        {
                            AppendMcpLog($"Connection successful! Getting tools...");
                        }
                        else
                        {
                            AppendMcpLog($"Failed to connect to server: {server.Name}");
                        }
                    });

                    if (success)
                    {
                        var tools = await _mcpService.GetServerToolsAsync(server.Id);
                        Invoke(() => {
                            AppendMcpLog($"Test successful! Server provides {tools.Count} tools.");
                            if (tools.Count > 0)
                            {
                                AppendMcpLog("Available tools:");
                                foreach (var tool in tools.Take(5)) // Show first 5 tools
                                {
                                    AppendMcpLog($"  - {tool.Name}: {tool.Description}");
                                }
                                if (tools.Count > 5)
                                {
                                    AppendMcpLog($"  ... and {tools.Count - 5} more tools");
                                }
                            }
                        });

                        // Unload after test
                        await _mcpService.UnloadServerAsync(server.Id);
                    }
                }
                catch (Exception ex)
                {
                    Invoke(() => {
                        AppendMcpLog($"Test error: {ex.Message}");
                        if (ex.InnerException != null)
                        {
                            AppendMcpLog($"Inner error: {ex.InnerException.Message}");
                        }
                        MessageBox.Show($"Test failed: {ex.Message}", "Test Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }
                finally
                {
                    Invoke(() => {
                        RefreshMcpServerList();
                        btnTestMcpServer.Enabled = true;
                    });
                }
            });
        }

        private async void BtnLoadMcpServers_Click(object? sender, EventArgs e)
        {
            if (_mcpService == null) return;

            try
            {
                btnLoadMcpServers.Enabled = false;

                // Unload all servers first
                await _mcpService.UnloadAllServersAsync();

                // Load enabled servers
                int loadedCount = 0;
                foreach (var server in _mcpServerCollection.Servers)
                {
                    if (server.IsEnabled)
                    {
                        AppendMcpLog($"Loading server: {server.Name}");
                        var success = await _mcpService.LoadServerAsync(server);
                        if (success)
                        {
                            loadedCount++;
                            AppendMcpLog($"Successfully loaded: {server.Name}");
                        }
                        else
                        {
                            AppendMcpLog($"Failed to load: {server.Name}");
                        }
                    }
                }

                AppendMcpLog($"Loaded {loadedCount} servers.");
                RefreshMcpServerList();
            }
            catch (Exception ex)
            {
                AppendMcpLog($"Load error: {ex.Message}");
                MessageBox.Show($"Error loading servers: {ex.Message}", "Load Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLoadMcpServers.Enabled = true;
            }
        }

        private void AppendMcpLog(string message)
        {
            if (rtbMcpLog.InvokeRequired)
            {
                rtbMcpLog.Invoke(() => AppendMcpLog(message));
                return;
            }

            var timestamp = DateTime.Now.ToString("HH:mm:ss");
            rtbMcpLog.AppendText($"[{timestamp}] {message}\n");
            rtbMcpLog.ScrollToCaret();

            // Limit log size
            if (rtbMcpLog.Lines.Length > 1000)
            {
                var lines = rtbMcpLog.Lines.Skip(500).ToArray();
                rtbMcpLog.Lines = lines;
            }
        }

        private void UpdateServerStatus(McpServerEventArgs args)
        {
            if (dgvMcpServers.InvokeRequired)
            {
                dgvMcpServers.Invoke(() => UpdateServerStatus(args));
                return;
            }

            foreach (DataGridViewRow row in dgvMcpServers.Rows)
            {
                var server = row.Tag as McpServerConfig;
                if (server != null && server.Id == args.ServerId)
                {
                    row.Cells[1].Value = args.Status.ToString();
                    break;
                }
            }
        }

        public IMcpService? GetMcpService()
        {
            return _mcpService;
        }

        #endregion

        private class TreeNodeState
        {
            public bool IsChecked { get; set; }
            public bool IsExpanded { get; set; }
        }
    }
}
