namespace DiRAG.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            blazorWebView1 = new Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView();
            tabMain = new TabControl();
            tabPageDir = new TabPage();
            ktvFolderTree = new Krypton.Toolkit.KryptonTreeView();
            kToolStripDirTree = new Krypton.Toolkit.KryptonToolStrip();
            tsbIndexing = new ToolStripButton();
            tspRefresh = new ToolStripButton();
            lblRagStatus = new Krypton.Toolkit.KryptonLabel();
            tabPageSettings = new TabPage();
            tabSettings = new TabControl();
            tabPageChat = new TabPage();
            kPanelAPIProviderSettings = new Krypton.Toolkit.KryptonPanel();
            kPanelChatSettingTop = new Krypton.Toolkit.KryptonPanel();
            cmbAPIProvider = new Krypton.Toolkit.KryptonComboBox();
            lblAPIProvider = new Krypton.Toolkit.KryptonLabel();
            rbChatAPI = new Krypton.Toolkit.KryptonRadioButton();
            rbChatGGUF = new Krypton.Toolkit.KryptonRadioButton();
            lblChatMethod = new Krypton.Toolkit.KryptonLabel();
            cmbChatGGUFModel = new Krypton.Toolkit.KryptonComboBox();
            btnSaveChatSettings = new Krypton.Toolkit.KryptonButton();
            tabPageRAG = new TabPage();
            kPanelRAGTop = new Krypton.Toolkit.KryptonPanel();
            nudMaxContextLength = new Krypton.Toolkit.KryptonNumericUpDown();
            lblTotalMaxContextLength = new Krypton.Toolkit.KryptonLabel();
            nudTopKChunks = new Krypton.Toolkit.KryptonNumericUpDown();
            lblTopKChunks = new Krypton.Toolkit.KryptonLabel();
            nudChunkOverlap = new Krypton.Toolkit.KryptonNumericUpDown();
            nudChunkSize = new Krypton.Toolkit.KryptonNumericUpDown();
            nudModelContextLength = new Krypton.Toolkit.KryptonNumericUpDown();
            txtEmbeddingModel = new Krypton.Toolkit.KryptonTextBox();
            txtEmbeddingUrl = new Krypton.Toolkit.KryptonTextBox();
            lblEmbeddingUrl = new Krypton.Toolkit.KryptonLabel();
            lblEmbeddingModel = new Krypton.Toolkit.KryptonLabel();
            lblModelContextLength = new Krypton.Toolkit.KryptonLabel();
            lblChunkSize = new Krypton.Toolkit.KryptonLabel();
            lblChunkOverlap = new Krypton.Toolkit.KryptonLabel();
            rbEmbeddingAPI = new Krypton.Toolkit.KryptonRadioButton();
            rbEmbeddingGGUF = new Krypton.Toolkit.KryptonRadioButton();
            cmbGGUFModel = new Krypton.Toolkit.KryptonComboBox();
            lblEmbeddingMethod = new Krypton.Toolkit.KryptonLabel();
            btnTestEmbedding = new Krypton.Toolkit.KryptonButton();
            btnSaveRAGSettings = new Krypton.Toolkit.KryptonButton();
            tabPageTheme = new TabPage();
            kryptonThemeListBox1 = new Krypton.Toolkit.KryptonThemeListBox();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            lblLanguage = new Krypton.Toolkit.KryptonLabel();
            cmbLanguage = new Krypton.Toolkit.KryptonComboBox();
            tabPageMCP = new TabPage();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            rtbMcpLog = new Krypton.Toolkit.KryptonRichTextBox();
            dgvMcpServers = new Krypton.Toolkit.KryptonDataGridView();
            btnAddMcpServer = new Krypton.Toolkit.KryptonButton();
            btnEditMcpServer = new Krypton.Toolkit.KryptonButton();
            btnRemoveMcpServer = new Krypton.Toolkit.KryptonButton();
            btnTestMcpServer = new Krypton.Toolkit.KryptonButton();
            btnLoadMcpServers = new Krypton.Toolkit.KryptonButton();
            claudeCodeSettingsControl = new DiRAG.Forms.ProviderSettings.ClaudeCodeProviderSettingsControl();
            openAISettingsControl = new DiRAG.Forms.ProviderSettings.OpenAIProviderSettingsControl();
            kryptonManager1 = new Krypton.Toolkit.KryptonManager(components);
            toolTip1 = new ToolTip(components);
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            splitContainerMain = new SplitContainer();
            kPanelGGUFProviderSettings = new Krypton.Toolkit.KryptonPanel();
            tabMain.SuspendLayout();
            tabPageDir.SuspendLayout();
            kToolStripDirTree.SuspendLayout();
            tabPageSettings.SuspendLayout();
            tabSettings.SuspendLayout();
            tabPageChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kPanelAPIProviderSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kPanelChatSettingTop).BeginInit();
            kPanelChatSettingTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbAPIProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbChatGGUFModel).BeginInit();
            tabPageRAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kPanelRAGTop).BeginInit();
            kPanelRAGTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbGGUFModel).BeginInit();
            tabPageTheme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbLanguage).BeginInit();
            tabPageMCP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMcpServers).BeginInit();
            kryptonStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kPanelGGUFProviderSettings).BeginInit();
            SuspendLayout();
            // 
            // blazorWebView1
            // 
            blazorWebView1.Dock = DockStyle.Fill;
            blazorWebView1.Location = new Point(0, 0);
            blazorWebView1.Name = "blazorWebView1";
            blazorWebView1.Size = new Size(905, 636);
            blazorWebView1.TabIndex = 0;
            blazorWebView1.Text = "blazorWebView1";
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabPageDir);
            tabMain.Controls.Add(tabPageSettings);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Margin = new Padding(3, 2, 3, 2);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(374, 636);
            tabMain.TabIndex = 2;
            // 
            // tabPageDir
            // 
            tabPageDir.Controls.Add(ktvFolderTree);
            tabPageDir.Controls.Add(kToolStripDirTree);
            tabPageDir.Controls.Add(lblRagStatus);
            tabPageDir.Location = new Point(4, 24);
            tabPageDir.Margin = new Padding(3, 2, 3, 2);
            tabPageDir.Name = "tabPageDir";
            tabPageDir.Padding = new Padding(3, 2, 3, 2);
            tabPageDir.Size = new Size(366, 608);
            tabPageDir.TabIndex = 0;
            tabPageDir.Text = "📁Dir to RAG";
            tabPageDir.UseVisualStyleBackColor = true;
            // 
            // ktvFolderTree
            // 
            ktvFolderTree.CheckBoxes = true;
            ktvFolderTree.Dock = DockStyle.Fill;
            ktvFolderTree.Location = new Point(3, 27);
            ktvFolderTree.Margin = new Padding(3, 2, 3, 2);
            ktvFolderTree.MultiSelect = true;
            ktvFolderTree.Name = "ktvFolderTree";
            ktvFolderTree.Size = new Size(360, 577);
            ktvFolderTree.TabIndex = 0;
            // 
            // kToolStripDirTree
            // 
            kToolStripDirTree.Font = new Font("Segoe UI", 9F);
            kToolStripDirTree.Items.AddRange(new ToolStripItem[] { tsbIndexing, tspRefresh });
            kToolStripDirTree.Location = new Point(3, 2);
            kToolStripDirTree.Name = "kToolStripDirTree";
            kToolStripDirTree.Size = new Size(360, 25);
            kToolStripDirTree.TabIndex = 3;
            kToolStripDirTree.Text = "Refresh the tree";
            // 
            // tsbIndexing
            // 
            tsbIndexing.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbIndexing.Image = Properties.Resources.Indexing;
            tsbIndexing.ImageTransparentColor = Color.Magenta;
            tsbIndexing.Name = "tsbIndexing";
            tsbIndexing.Size = new Size(23, 22);
            tsbIndexing.Text = "Index the selected directory";
            tsbIndexing.Click += tsbIndexing_Click;
            // 
            // tspRefresh
            // 
            tspRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tspRefresh.Image = Properties.Resources.Refresh;
            tspRefresh.ImageTransparentColor = Color.Magenta;
            tspRefresh.Name = "tspRefresh";
            tspRefresh.Size = new Size(23, 22);
            tspRefresh.Text = "toolStripButton2";
            tspRefresh.Click += tspRefresh_Click;
            // 
            // lblRagStatus
            // 
            lblRagStatus.Dock = DockStyle.Bottom;
            lblRagStatus.Location = new Point(3, 604);
            lblRagStatus.Margin = new Padding(3, 2, 3, 2);
            lblRagStatus.Name = "lblRagStatus";
            lblRagStatus.Size = new Size(360, 2);
            lblRagStatus.TabIndex = 2;
            lblRagStatus.Values.Text = "";
            // 
            // tabPageSettings
            // 
            tabPageSettings.AutoScroll = true;
            tabPageSettings.Controls.Add(tabSettings);
            tabPageSettings.Location = new Point(4, 24);
            tabPageSettings.Margin = new Padding(3, 2, 3, 2);
            tabPageSettings.Name = "tabPageSettings";
            tabPageSettings.Padding = new Padding(9, 8, 9, 8);
            tabPageSettings.Size = new Size(366, 608);
            tabPageSettings.TabIndex = 2;
            tabPageSettings.Text = "⚙️Settings";
            tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            tabSettings.Controls.Add(tabPageChat);
            tabSettings.Controls.Add(tabPageRAG);
            tabSettings.Controls.Add(tabPageTheme);
            tabSettings.Controls.Add(tabPageMCP);
            tabSettings.Dock = DockStyle.Fill;
            tabSettings.Location = new Point(9, 8);
            tabSettings.Margin = new Padding(3, 2, 3, 2);
            tabSettings.Name = "tabSettings";
            tabSettings.SelectedIndex = 0;
            tabSettings.Size = new Size(348, 592);
            tabSettings.TabIndex = 15;
            // 
            // tabPageChat
            // 
            tabPageChat.Controls.Add(kPanelGGUFProviderSettings);
            tabPageChat.Controls.Add(kPanelAPIProviderSettings);
            tabPageChat.Controls.Add(kPanelChatSettingTop);
            tabPageChat.Controls.Add(btnSaveChatSettings);
            tabPageChat.Location = new Point(4, 24);
            tabPageChat.Margin = new Padding(3, 2, 3, 2);
            tabPageChat.Name = "tabPageChat";
            tabPageChat.Padding = new Padding(3, 2, 3, 2);
            tabPageChat.Size = new Size(340, 564);
            tabPageChat.TabIndex = 0;
            tabPageChat.Text = "Chat Settings";
            tabPageChat.UseVisualStyleBackColor = true;
            // 
            // kPanelAPIProviderSettings
            // 
            kPanelAPIProviderSettings.Location = new Point(61, 135);
            kPanelAPIProviderSettings.Name = "kPanelAPIProviderSettings";
            kPanelAPIProviderSettings.Size = new Size(176, 140);
            kPanelAPIProviderSettings.TabIndex = 3;
            // 
            // kPanelChatSettingTop
            // 
            kPanelChatSettingTop.Controls.Add(cmbAPIProvider);
            kPanelChatSettingTop.Controls.Add(lblAPIProvider);
            kPanelChatSettingTop.Controls.Add(rbChatAPI);
            kPanelChatSettingTop.Controls.Add(rbChatGGUF);
            kPanelChatSettingTop.Controls.Add(lblChatMethod);
            kPanelChatSettingTop.Controls.Add(cmbChatGGUFModel);
            kPanelChatSettingTop.Dock = DockStyle.Top;
            kPanelChatSettingTop.Location = new Point(3, 2);
            kPanelChatSettingTop.Margin = new Padding(3, 2, 3, 2);
            kPanelChatSettingTop.Name = "kPanelChatSettingTop";
            kPanelChatSettingTop.Size = new Size(334, 84);
            kPanelChatSettingTop.TabIndex = 0;
            // 
            // cmbAPIProvider
            // 
            cmbAPIProvider.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAPIProvider.DropDownWidth = 250;
            cmbAPIProvider.Items.AddRange(new object[] { "OpenAI Compatible", "Claude Code" });
            cmbAPIProvider.Location = new Point(8, 53);
            cmbAPIProvider.Name = "cmbAPIProvider";
            cmbAPIProvider.Size = new Size(304, 22);
            cmbAPIProvider.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbAPIProvider.TabIndex = 1;
            toolTip1.SetToolTip(cmbAPIProvider, "Select an API provider");
            cmbAPIProvider.SelectedIndexChanged += cmbAPIProvider_SelectedIndexChanged;
            // 
            // lblAPIProvider
            // 
            lblAPIProvider.Location = new Point(8, 34);
            lblAPIProvider.Margin = new Padding(3, 2, 3, 2);
            lblAPIProvider.Name = "lblAPIProvider";
            lblAPIProvider.Size = new Size(80, 20);
            lblAPIProvider.TabIndex = 14;
            lblAPIProvider.Values.Text = "API Provider:";
            // 
            // rbChatAPI
            // 
            rbChatAPI.Location = new Point(144, 10);
            rbChatAPI.Margin = new Padding(3, 2, 3, 2);
            rbChatAPI.Name = "rbChatAPI";
            rbChatAPI.Size = new Size(41, 20);
            rbChatAPI.TabIndex = 15;
            rbChatAPI.Values.Text = "API";
            rbChatAPI.CheckedChanged += rbChatAPI_CheckedChanged;
            // 
            // rbChatGGUF
            // 
            rbChatGGUF.Location = new Point(203, 10);
            rbChatGGUF.Margin = new Padding(3, 2, 3, 2);
            rbChatGGUF.Name = "rbChatGGUF";
            rbChatGGUF.Size = new Size(54, 20);
            rbChatGGUF.TabIndex = 16;
            rbChatGGUF.Values.Text = "GGUF";
            rbChatGGUF.CheckedChanged += rbChatGGUF_CheckedChanged;
            // 
            // lblChatMethod
            // 
            lblChatMethod.Location = new Point(3, 10);
            lblChatMethod.Margin = new Padding(3, 2, 3, 2);
            lblChatMethod.Name = "lblChatMethod";
            lblChatMethod.Size = new Size(85, 20);
            lblChatMethod.TabIndex = 17;
            lblChatMethod.Values.Text = "Chat Method:";
            // 
            // cmbChatGGUFModel
            // 
            cmbChatGGUFModel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbChatGGUFModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChatGGUFModel.DropDownWidth = 304;
            cmbChatGGUFModel.Location = new Point(8, 53);
            cmbChatGGUFModel.Margin = new Padding(3, 2, 3, 2);
            cmbChatGGUFModel.Name = "cmbChatGGUFModel";
            cmbChatGGUFModel.Size = new Size(312, 22);
            cmbChatGGUFModel.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbChatGGUFModel.TabIndex = 18;
            // 
            // btnSaveChatSettings
            // 
            btnSaveChatSettings.Dock = DockStyle.Bottom;
            btnSaveChatSettings.Location = new Point(3, 532);
            btnSaveChatSettings.Margin = new Padding(3, 2, 3, 2);
            btnSaveChatSettings.Name = "btnSaveChatSettings";
            btnSaveChatSettings.Size = new Size(334, 30);
            btnSaveChatSettings.TabIndex = 1;
            btnSaveChatSettings.Values.DropDownArrowColor = Color.Empty;
            btnSaveChatSettings.Values.Text = "Save";
            btnSaveChatSettings.Click += btnSave_Click;
            // 
            // tabPageRAG
            // 
            tabPageRAG.Controls.Add(kPanelRAGTop);
            tabPageRAG.Controls.Add(btnSaveRAGSettings);
            tabPageRAG.Location = new Point(4, 24);
            tabPageRAG.Margin = new Padding(3, 2, 3, 2);
            tabPageRAG.Name = "tabPageRAG";
            tabPageRAG.Padding = new Padding(3, 2, 3, 2);
            tabPageRAG.Size = new Size(339, 576);
            tabPageRAG.TabIndex = 1;
            tabPageRAG.Text = "RAG Settings";
            tabPageRAG.UseVisualStyleBackColor = true;
            // 
            // kPanelRAGTop
            // 
            kPanelRAGTop.Controls.Add(nudMaxContextLength);
            kPanelRAGTop.Controls.Add(lblTotalMaxContextLength);
            kPanelRAGTop.Controls.Add(nudTopKChunks);
            kPanelRAGTop.Controls.Add(lblTopKChunks);
            kPanelRAGTop.Controls.Add(nudChunkOverlap);
            kPanelRAGTop.Controls.Add(nudChunkSize);
            kPanelRAGTop.Controls.Add(nudModelContextLength);
            kPanelRAGTop.Controls.Add(txtEmbeddingModel);
            kPanelRAGTop.Controls.Add(txtEmbeddingUrl);
            kPanelRAGTop.Controls.Add(lblEmbeddingUrl);
            kPanelRAGTop.Controls.Add(lblEmbeddingModel);
            kPanelRAGTop.Controls.Add(lblModelContextLength);
            kPanelRAGTop.Controls.Add(lblChunkSize);
            kPanelRAGTop.Controls.Add(lblChunkOverlap);
            kPanelRAGTop.Controls.Add(rbEmbeddingAPI);
            kPanelRAGTop.Controls.Add(rbEmbeddingGGUF);
            kPanelRAGTop.Controls.Add(cmbGGUFModel);
            kPanelRAGTop.Controls.Add(lblEmbeddingMethod);
            kPanelRAGTop.Controls.Add(btnTestEmbedding);
            kPanelRAGTop.Dock = DockStyle.Fill;
            kPanelRAGTop.Location = new Point(3, 2);
            kPanelRAGTop.Margin = new Padding(3, 2, 3, 2);
            kPanelRAGTop.Name = "kPanelRAGTop";
            kPanelRAGTop.Size = new Size(333, 542);
            kPanelRAGTop.TabIndex = 0;
            // 
            // nudMaxContextLength
            // 
            nudMaxContextLength.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudMaxContextLength.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            nudMaxContextLength.Location = new Point(199, 275);
            nudMaxContextLength.Margin = new Padding(3, 2, 3, 2);
            nudMaxContextLength.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudMaxContextLength.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMaxContextLength.Name = "nudMaxContextLength";
            nudMaxContextLength.Size = new Size(113, 22);
            nudMaxContextLength.TabIndex = 21;
            nudMaxContextLength.Value = new decimal(new int[] { 8000, 0, 0, 0 });
            // 
            // lblTotalMaxContextLength
            // 
            lblTotalMaxContextLength.Location = new Point(5, 275);
            lblTotalMaxContextLength.Margin = new Padding(3, 2, 3, 2);
            lblTotalMaxContextLength.Name = "lblTotalMaxContextLength";
            lblTotalMaxContextLength.Size = new Size(193, 20);
            lblTotalMaxContextLength.TabIndex = 20;
            lblTotalMaxContextLength.Values.Text = "Total Max Context Length (chars):";
            // 
            // nudTopKChunks
            // 
            nudTopKChunks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudTopKChunks.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            nudTopKChunks.Location = new Point(200, 247);
            nudTopKChunks.Margin = new Padding(3, 2, 3, 2);
            nudTopKChunks.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudTopKChunks.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTopKChunks.Name = "nudTopKChunks";
            nudTopKChunks.Size = new Size(113, 22);
            nudTopKChunks.TabIndex = 19;
            nudTopKChunks.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblTopKChunks
            // 
            lblTopKChunks.Location = new Point(106, 247);
            lblTopKChunks.Margin = new Padding(3, 2, 3, 2);
            lblTopKChunks.Name = "lblTopKChunks";
            lblTopKChunks.Size = new Size(88, 20);
            lblTopKChunks.TabIndex = 18;
            lblTopKChunks.Values.Text = "Top K Chunks:";
            // 
            // nudChunkOverlap
            // 
            nudChunkOverlap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudChunkOverlap.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudChunkOverlap.Location = new Point(200, 196);
            nudChunkOverlap.Margin = new Padding(3, 2, 3, 2);
            nudChunkOverlap.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudChunkOverlap.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            nudChunkOverlap.Name = "nudChunkOverlap";
            nudChunkOverlap.Size = new Size(113, 22);
            nudChunkOverlap.TabIndex = 19;
            nudChunkOverlap.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // nudChunkSize
            // 
            nudChunkSize.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudChunkSize.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            nudChunkSize.Location = new Point(200, 170);
            nudChunkSize.Margin = new Padding(3, 2, 3, 2);
            nudChunkSize.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            nudChunkSize.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            nudChunkSize.Name = "nudChunkSize";
            nudChunkSize.Size = new Size(113, 22);
            nudChunkSize.TabIndex = 17;
            nudChunkSize.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // nudModelContextLength
            // 
            nudModelContextLength.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudModelContextLength.Increment = new decimal(new int[] { 256, 0, 0, 0 });
            nudModelContextLength.Location = new Point(200, 144);
            nudModelContextLength.Margin = new Padding(3, 2, 3, 2);
            nudModelContextLength.Maximum = new decimal(new int[] { 32768, 0, 0, 0 });
            nudModelContextLength.Minimum = new decimal(new int[] { 512, 0, 0, 0 });
            nudModelContextLength.Name = "nudModelContextLength";
            nudModelContextLength.Size = new Size(113, 22);
            nudModelContextLength.TabIndex = 15;
            nudModelContextLength.Value = new decimal(new int[] { 2048, 0, 0, 0 });
            // 
            // txtEmbeddingModel
            // 
            txtEmbeddingModel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmbeddingModel.Location = new Point(6, 106);
            txtEmbeddingModel.Margin = new Padding(3, 2, 3, 2);
            txtEmbeddingModel.Name = "txtEmbeddingModel";
            txtEmbeddingModel.Size = new Size(313, 23);
            txtEmbeddingModel.TabIndex = 13;
            txtEmbeddingModel.Text = "text-embedding-embeddinggemma-300m";
            // 
            // txtEmbeddingUrl
            // 
            txtEmbeddingUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmbeddingUrl.Location = new Point(6, 55);
            txtEmbeddingUrl.Margin = new Padding(3, 2, 3, 2);
            txtEmbeddingUrl.Name = "txtEmbeddingUrl";
            txtEmbeddingUrl.Size = new Size(313, 23);
            txtEmbeddingUrl.TabIndex = 11;
            txtEmbeddingUrl.Text = "http://localhost:/1234";
            // 
            // lblEmbeddingUrl
            // 
            lblEmbeddingUrl.Location = new Point(3, 34);
            lblEmbeddingUrl.Margin = new Padding(3, 2, 3, 2);
            lblEmbeddingUrl.Name = "lblEmbeddingUrl";
            lblEmbeddingUrl.Size = new Size(101, 20);
            lblEmbeddingUrl.TabIndex = 10;
            lblEmbeddingUrl.Values.Text = "Embedding URL:";
            // 
            // lblEmbeddingModel
            // 
            lblEmbeddingModel.Location = new Point(3, 85);
            lblEmbeddingModel.Margin = new Padding(3, 2, 3, 2);
            lblEmbeddingModel.Name = "lblEmbeddingModel";
            lblEmbeddingModel.Size = new Size(114, 20);
            lblEmbeddingModel.TabIndex = 12;
            lblEmbeddingModel.Values.Text = "Embedding Model:";
            // 
            // lblModelContextLength
            // 
            lblModelContextLength.Location = new Point(61, 146);
            lblModelContextLength.Margin = new Padding(3, 2, 3, 2);
            lblModelContextLength.Name = "lblModelContextLength";
            lblModelContextLength.Size = new Size(135, 20);
            lblModelContextLength.TabIndex = 14;
            lblModelContextLength.Values.Text = "Model Context Length:";
            // 
            // lblChunkSize
            // 
            lblChunkSize.Location = new Point(120, 171);
            lblChunkSize.Margin = new Padding(3, 2, 3, 2);
            lblChunkSize.Name = "lblChunkSize";
            lblChunkSize.Size = new Size(73, 20);
            lblChunkSize.TabIndex = 16;
            lblChunkSize.Values.Text = "Chunk Size:";
            // 
            // lblChunkOverlap
            // 
            lblChunkOverlap.Location = new Point(99, 196);
            lblChunkOverlap.Margin = new Padding(3, 2, 3, 2);
            lblChunkOverlap.Name = "lblChunkOverlap";
            lblChunkOverlap.Size = new Size(94, 20);
            lblChunkOverlap.TabIndex = 18;
            lblChunkOverlap.Values.Text = "Chunk Overlap:";
            // 
            // rbEmbeddingAPI
            // 
            rbEmbeddingAPI.Location = new Point(144, 10);
            rbEmbeddingAPI.Margin = new Padding(3, 2, 3, 2);
            rbEmbeddingAPI.Name = "rbEmbeddingAPI";
            rbEmbeddingAPI.Size = new Size(41, 20);
            rbEmbeddingAPI.TabIndex = 7;
            rbEmbeddingAPI.Values.Text = "API";
            rbEmbeddingAPI.CheckedChanged += rbEmbeddingAPI_CheckedChanged;
            // 
            // rbEmbeddingGGUF
            // 
            rbEmbeddingGGUF.Location = new Point(203, 10);
            rbEmbeddingGGUF.Margin = new Padding(3, 2, 3, 2);
            rbEmbeddingGGUF.Name = "rbEmbeddingGGUF";
            rbEmbeddingGGUF.Size = new Size(54, 20);
            rbEmbeddingGGUF.TabIndex = 8;
            rbEmbeddingGGUF.Values.Text = "GGUF";
            rbEmbeddingGGUF.CheckedChanged += rbEmbeddingGGUF_CheckedChanged;
            // 
            // cmbGGUFModel
            // 
            cmbGGUFModel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbGGUFModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGGUFModel.DropDownWidth = 295;
            cmbGGUFModel.Location = new Point(6, 55);
            cmbGGUFModel.Margin = new Padding(3, 2, 3, 2);
            cmbGGUFModel.Name = "cmbGGUFModel";
            cmbGGUFModel.Size = new Size(313, 22);
            cmbGGUFModel.TabIndex = 9;
            cmbGGUFModel.Visible = false;
            // 
            // lblEmbeddingMethod
            // 
            lblEmbeddingMethod.Location = new Point(3, 10);
            lblEmbeddingMethod.Margin = new Padding(3, 2, 3, 2);
            lblEmbeddingMethod.Name = "lblEmbeddingMethod";
            lblEmbeddingMethod.Size = new Size(122, 20);
            lblEmbeddingMethod.TabIndex = 6;
            lblEmbeddingMethod.Values.Text = "Embedding Method:";
            // 
            // btnTestEmbedding
            // 
            btnTestEmbedding.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnTestEmbedding.Location = new Point(40, 328);
            btnTestEmbedding.Margin = new Padding(3, 2, 3, 2);
            btnTestEmbedding.Name = "btnTestEmbedding";
            btnTestEmbedding.Size = new Size(236, 30);
            btnTestEmbedding.TabIndex = 22;
            btnTestEmbedding.Values.DropDownArrowColor = Color.Empty;
            btnTestEmbedding.Values.Text = "Test Embedding";
            btnTestEmbedding.Click += btnTestEmbedding_Click;
            // 
            // btnSaveRAGSettings
            // 
            btnSaveRAGSettings.Dock = DockStyle.Bottom;
            btnSaveRAGSettings.Location = new Point(3, 544);
            btnSaveRAGSettings.Margin = new Padding(3, 2, 3, 2);
            btnSaveRAGSettings.Name = "btnSaveRAGSettings";
            btnSaveRAGSettings.Size = new Size(333, 30);
            btnSaveRAGSettings.TabIndex = 2;
            btnSaveRAGSettings.Values.DropDownArrowColor = Color.Empty;
            btnSaveRAGSettings.Values.Text = "Save";
            btnSaveRAGSettings.Click += btnSave_Click;
            // 
            // tabPageTheme
            // 
            tabPageTheme.Controls.Add(kryptonThemeListBox1);
            tabPageTheme.Controls.Add(kryptonPanel4);
            tabPageTheme.Location = new Point(4, 24);
            tabPageTheme.Name = "tabPageTheme";
            tabPageTheme.Size = new Size(339, 576);
            tabPageTheme.TabIndex = 2;
            tabPageTheme.Text = "UI";
            tabPageTheme.UseVisualStyleBackColor = true;
            // 
            // kryptonThemeListBox1
            // 
            kryptonThemeListBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Microsoft365Blue;
            kryptonThemeListBox1.Dock = DockStyle.Fill;
            kryptonThemeListBox1.Location = new Point(0, 75);
            kryptonThemeListBox1.Name = "kryptonThemeListBox1";
            kryptonThemeListBox1.Size = new Size(339, 501);
            kryptonThemeListBox1.TabIndex = 0;
            kryptonThemeListBox1.SelectedIndexChanged += KryptonThemeListBox1_SelectedIndexChanged;
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Controls.Add(kryptonLabel1);
            kryptonPanel4.Controls.Add(lblLanguage);
            kryptonPanel4.Controls.Add(cmbLanguage);
            kryptonPanel4.Dock = DockStyle.Top;
            kryptonPanel4.Location = new Point(0, 0);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(339, 75);
            kryptonPanel4.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(2, 55);
            kryptonLabel1.Margin = new Padding(3, 2, 3, 2);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(50, 20);
            kryptonLabel1.TabIndex = 17;
            kryptonLabel1.Values.Text = "Theme:";
            // 
            // lblLanguage
            // 
            lblLanguage.Location = new Point(3, 8);
            lblLanguage.Margin = new Padding(3, 2, 3, 2);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(67, 20);
            lblLanguage.TabIndex = 15;
            lblLanguage.Values.Text = "Language:";
            // 
            // cmbLanguage
            // 
            cmbLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.DropDownWidth = 289;
            cmbLanguage.Location = new Point(4, 29);
            cmbLanguage.Margin = new Padding(3, 2, 3, 2);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(316, 22);
            cmbLanguage.TabIndex = 16;
            cmbLanguage.SelectedIndexChanged += cmbLanguage_SelectedIndexChanged;
            // 
            // tabPageMCP
            // 
            tabPageMCP.Controls.Add(kryptonPanel1);
            tabPageMCP.Location = new Point(4, 24);
            tabPageMCP.Name = "tabPageMCP";
            tabPageMCP.Size = new Size(339, 576);
            tabPageMCP.TabIndex = 3;
            tabPageMCP.Text = "MCP";
            tabPageMCP.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(rtbMcpLog);
            kryptonPanel1.Controls.Add(dgvMcpServers);
            kryptonPanel1.Controls.Add(btnAddMcpServer);
            kryptonPanel1.Controls.Add(btnEditMcpServer);
            kryptonPanel1.Controls.Add(btnRemoveMcpServer);
            kryptonPanel1.Controls.Add(btnTestMcpServer);
            kryptonPanel1.Controls.Add(btnLoadMcpServers);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(339, 576);
            kryptonPanel1.TabIndex = 0;
            kryptonPanel1.Visible = false;
            // 
            // rtbMcpLog
            // 
            rtbMcpLog.Location = new Point(10, 247);
            rtbMcpLog.Name = "rtbMcpLog";
            rtbMcpLog.ReadOnly = true;
            rtbMcpLog.Size = new Size(288, 254);
            rtbMcpLog.TabIndex = 6;
            rtbMcpLog.Text = "";
            // 
            // dgvMcpServers
            // 
            dgvMcpServers.BorderStyle = BorderStyle.None;
            dgvMcpServers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMcpServers.Location = new Point(10, 10);
            dgvMcpServers.Name = "dgvMcpServers";
            dgvMcpServers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMcpServers.Size = new Size(288, 200);
            dgvMcpServers.TabIndex = 0;
            // 
            // btnAddMcpServer
            // 
            btnAddMcpServer.Location = new Point(10, 216);
            btnAddMcpServer.Name = "btnAddMcpServer";
            btnAddMcpServer.Size = new Size(50, 25);
            btnAddMcpServer.TabIndex = 1;
            btnAddMcpServer.Values.DropDownArrowColor = Color.Empty;
            btnAddMcpServer.Values.Text = "Add";
            // 
            // btnEditMcpServer
            // 
            btnEditMcpServer.Location = new Point(66, 216);
            btnEditMcpServer.Name = "btnEditMcpServer";
            btnEditMcpServer.Size = new Size(50, 25);
            btnEditMcpServer.TabIndex = 2;
            btnEditMcpServer.Values.DropDownArrowColor = Color.Empty;
            btnEditMcpServer.Values.Text = "Edit";
            // 
            // btnRemoveMcpServer
            // 
            btnRemoveMcpServer.Location = new Point(122, 216);
            btnRemoveMcpServer.Name = "btnRemoveMcpServer";
            btnRemoveMcpServer.Size = new Size(60, 25);
            btnRemoveMcpServer.TabIndex = 3;
            btnRemoveMcpServer.Values.DropDownArrowColor = Color.Empty;
            btnRemoveMcpServer.Values.Text = "Remove";
            // 
            // btnTestMcpServer
            // 
            btnTestMcpServer.Location = new Point(188, 216);
            btnTestMcpServer.Name = "btnTestMcpServer";
            btnTestMcpServer.Size = new Size(50, 25);
            btnTestMcpServer.TabIndex = 4;
            btnTestMcpServer.Values.DropDownArrowColor = Color.Empty;
            btnTestMcpServer.Values.Text = "Test";
            // 
            // btnLoadMcpServers
            // 
            btnLoadMcpServers.Location = new Point(244, 216);
            btnLoadMcpServers.Name = "btnLoadMcpServers";
            btnLoadMcpServers.Size = new Size(54, 25);
            btnLoadMcpServers.TabIndex = 5;
            btnLoadMcpServers.Values.DropDownArrowColor = Color.Empty;
            btnLoadMcpServers.Values.Text = "Load";
            // 
            // claudeCodeSettingsControl
            // 
            claudeCodeSettingsControl.Location = new Point(0, 0);
            claudeCodeSettingsControl.Name = "claudeCodeSettingsControl";
            claudeCodeSettingsControl.Size = new Size(316, 120);
            claudeCodeSettingsControl.TabIndex = 2;
            // 
            // openAISettingsControl
            // 
            openAISettingsControl.Location = new Point(0, 0);
            openAISettingsControl.Name = "openAISettingsControl";
            openAISettingsControl.Size = new Size(315, 243);
            openAISettingsControl.TabIndex = 2;
            // 
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.ImageScalingSize = new Size(20, 20);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            kryptonStatusStrip1.Location = new Point(0, 636);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            kryptonStatusStrip1.Size = new Size(1283, 22);
            kryptonStatusStrip1.TabIndex = 4;
            kryptonStatusStrip1.Text = "kryptonStatusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(41, 17);
            toolStripStatusLabel1.Text = "status:";
            toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(0, 0);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(tabMain);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(blazorWebView1);
            splitContainerMain.Size = new Size(1283, 636);
            splitContainerMain.SplitterDistance = 374;
            splitContainerMain.TabIndex = 5;
            // 
            // kPanelGGUFProviderSettings
            // 
            kPanelGGUFProviderSettings.Location = new Point(61, 324);
            kPanelGGUFProviderSettings.Name = "kPanelGGUFProviderSettings";
            kPanelGGUFProviderSettings.Size = new Size(176, 138);
            kPanelGGUFProviderSettings.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 658);
            Controls.Add(splitContainerMain);
            Controls.Add(kryptonStatusStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiRAG";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            tabMain.ResumeLayout(false);
            tabPageDir.ResumeLayout(false);
            tabPageDir.PerformLayout();
            kToolStripDirTree.ResumeLayout(false);
            kToolStripDirTree.PerformLayout();
            tabPageSettings.ResumeLayout(false);
            tabSettings.ResumeLayout(false);
            tabPageChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kPanelAPIProviderSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)kPanelChatSettingTop).EndInit();
            kPanelChatSettingTop.ResumeLayout(false);
            kPanelChatSettingTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbAPIProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbChatGGUFModel).EndInit();
            tabPageRAG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kPanelRAGTop).EndInit();
            kPanelRAGTop.ResumeLayout(false);
            kPanelRAGTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbGGUFModel).EndInit();
            tabPageTheme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbLanguage).EndInit();
            tabPageMCP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMcpServers).EndInit();
            kryptonStatusStrip1.ResumeLayout(false);
            kryptonStatusStrip1.PerformLayout();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kPanelGGUFProviderSettings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView blazorWebView1;
        private TabControl tabMain;
        private TabPage tabPageDir;
        private Krypton.Toolkit.KryptonTreeView ktvFolderTree;
        private Krypton.Toolkit.KryptonLabel lblRagStatus;
        private TabPage tabPageSettings;
        private ProviderSettings.OpenAIProviderSettingsControl openAISettingsControl;
        private ProviderSettings.ClaudeCodeProviderSettingsControl claudeCodeSettingsControl;
        private Krypton.Toolkit.KryptonLabel lblEmbeddingUrl;
        private Krypton.Toolkit.KryptonTextBox txtEmbeddingUrl;
        private Krypton.Toolkit.KryptonLabel lblEmbeddingModel;
        private Krypton.Toolkit.KryptonTextBox txtEmbeddingModel;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private ToolTip toolTip1;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl tabSettings;
        private TabPage tabPageChat;
        private Krypton.Toolkit.KryptonPanel kPanelChatSettingTop;
        private TabPage tabPageRAG;
        private Krypton.Toolkit.KryptonPanel kPanelRAGTop;
        private Krypton.Toolkit.KryptonButton btnSaveChatSettings;
        private Krypton.Toolkit.KryptonButton btnSaveRAGSettings;
        private Krypton.Toolkit.KryptonButton btnTestEmbedding;
        private TabPage tabPageTheme;
        private Krypton.Toolkit.KryptonThemeListBox kryptonThemeListBox1;
        private Krypton.Toolkit.KryptonLabel lblModelContextLength;
        private Krypton.Toolkit.KryptonNumericUpDown nudModelContextLength;
        private Krypton.Toolkit.KryptonLabel lblChunkSize;
        private Krypton.Toolkit.KryptonNumericUpDown nudChunkSize;
        private Krypton.Toolkit.KryptonLabel lblChunkOverlap;
        private Krypton.Toolkit.KryptonNumericUpDown nudChunkOverlap;
        private Krypton.Toolkit.KryptonRadioButton rbEmbeddingAPI;
        private Krypton.Toolkit.KryptonRadioButton rbEmbeddingGGUF;
        private Krypton.Toolkit.KryptonComboBox cmbGGUFModel;
        private Krypton.Toolkit.KryptonLabel lblEmbeddingMethod;
        private Krypton.Toolkit.KryptonToolStrip kToolStripDirTree;
        private ToolStripButton tsbIndexing;
        private ToolStripButton tspRefresh;
        private SplitContainer splitContainerMain;
        private Krypton.Toolkit.KryptonComboBox cmbAPIProvider;
        private Krypton.Toolkit.KryptonLabel lblAPIProvider;
        private Krypton.Toolkit.KryptonRadioButton rbChatAPI;
        private Krypton.Toolkit.KryptonRadioButton rbChatGGUF;
        private Krypton.Toolkit.KryptonLabel lblChatMethod;
        private Krypton.Toolkit.KryptonComboBox cmbChatGGUFModel;
        private Krypton.Toolkit.KryptonLabel lblTopKChunks;
        private Krypton.Toolkit.KryptonNumericUpDown nudTopKChunks;
        private Krypton.Toolkit.KryptonLabel lblTotalMaxContextLength;
        private Krypton.Toolkit.KryptonNumericUpDown nudMaxContextLength;
        private TabPage tabPageMCP;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonDataGridView dgvMcpServers;
        private Krypton.Toolkit.KryptonButton btnAddMcpServer;
        private Krypton.Toolkit.KryptonButton btnEditMcpServer;
        private Krypton.Toolkit.KryptonButton btnRemoveMcpServer;
        private Krypton.Toolkit.KryptonButton btnTestMcpServer;
        private Krypton.Toolkit.KryptonButton btnLoadMcpServers;
        private Krypton.Toolkit.KryptonRichTextBox rtbMcpLog;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonLabel lblLanguage;
        private Krypton.Toolkit.KryptonComboBox cmbLanguage;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel kPanelAPIProviderSettings;
        private Krypton.Toolkit.KryptonPanel kPanelGGUFProviderSettings;
    }
}
