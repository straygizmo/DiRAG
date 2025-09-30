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
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            cmbClaudeModel = new Krypton.Toolkit.KryptonComboBox();
            txtClaudeCodePath = new Krypton.Toolkit.KryptonTextBox();
            cmbAPIProvider = new Krypton.Toolkit.KryptonComboBox();
            lblAPIProvider = new Krypton.Toolkit.KryptonLabel();
            lblClaudeCodePath = new Krypton.Toolkit.KryptonLabel();
            lblClaudeModel = new Krypton.Toolkit.KryptonLabel();
            txtModel = new Krypton.Toolkit.KryptonTextBox();
            txtBaseUrl = new Krypton.Toolkit.KryptonTextBox();
            lblModel = new Krypton.Toolkit.KryptonLabel();
            lblBaseUrl = new Krypton.Toolkit.KryptonLabel();
            lblLanguage = new Krypton.Toolkit.KryptonLabel();
            cmbLanguage = new Krypton.Toolkit.KryptonComboBox();
            txtApiKey = new Krypton.Toolkit.KryptonTextBox();
            lblApiKey = new Krypton.Toolkit.KryptonLabel();
            chkUseContextInSystemMessage = new Krypton.Toolkit.KryptonCheckBox();
            btnSaveChatSettings = new Krypton.Toolkit.KryptonButton();
            tabPageRAG = new TabPage();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            txtMaxContextLength = new Krypton.Toolkit.KryptonTextBox();
            lblMaxContextLength = new Krypton.Toolkit.KryptonLabel();
            txtTopKChunks = new Krypton.Toolkit.KryptonTextBox();
            lblTopKChunks = new Krypton.Toolkit.KryptonLabel();
            txtChunkOverlap = new Krypton.Toolkit.KryptonTextBox();
            txtChunkSize = new Krypton.Toolkit.KryptonTextBox();
            txtContextLength = new Krypton.Toolkit.KryptonTextBox();
            txtEmbeddingModel = new Krypton.Toolkit.KryptonTextBox();
            txtEmbeddingUrl = new Krypton.Toolkit.KryptonTextBox();
            lblEmbeddingUrl = new Krypton.Toolkit.KryptonLabel();
            lblEmbeddingModel = new Krypton.Toolkit.KryptonLabel();
            lblContextLength = new Krypton.Toolkit.KryptonLabel();
            lblChunkSize = new Krypton.Toolkit.KryptonLabel();
            lblChunkOverlap = new Krypton.Toolkit.KryptonLabel();
            chkUseNativeEmbedding = new Krypton.Toolkit.KryptonCheckBox();
            btnSaveRAGSettings = new Krypton.Toolkit.KryptonButton();
            tabPageTheme = new TabPage();
            kryptonThemeListBox1 = new Krypton.Toolkit.KryptonThemeListBox();
            tabPageMCP = new TabPage();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            rtbMcpLog = new Krypton.Toolkit.KryptonRichTextBox();
            dgvMcpServers = new Krypton.Toolkit.KryptonDataGridView();
            btnAddMcpServer = new Krypton.Toolkit.KryptonButton();
            btnEditMcpServer = new Krypton.Toolkit.KryptonButton();
            btnRemoveMcpServer = new Krypton.Toolkit.KryptonButton();
            btnTestMcpServer = new Krypton.Toolkit.KryptonButton();
            btnLoadMcpServers = new Krypton.Toolkit.KryptonButton();
            kryptonManager1 = new Krypton.Toolkit.KryptonManager(components);
            toolTip1 = new ToolTip(components);
            kryptonStatusStrip1 = new Krypton.Toolkit.KryptonStatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            splitContainerMain = new SplitContainer();
            tabMain.SuspendLayout();
            tabPageDir.SuspendLayout();
            kToolStripDirTree.SuspendLayout();
            tabPageSettings.SuspendLayout();
            tabSettings.SuspendLayout();
            tabPageChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbClaudeModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbAPIProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbLanguage).BeginInit();
            tabPageRAG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            tabPageTheme.SuspendLayout();
            tabPageMCP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMcpServers).BeginInit();
            kryptonStatusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            SuspendLayout();
            // 
            // blazorWebView1
            // 
            blazorWebView1.Dock = DockStyle.Fill;
            blazorWebView1.Location = new Point(0, 0);
            blazorWebView1.Name = "blazorWebView1";
            blazorWebView1.Size = new Size(821, 597);
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
            tabMain.Size = new Size(346, 597);
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
            tabPageDir.Size = new Size(338, 569);
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
            ktvFolderTree.Size = new Size(332, 538);
            ktvFolderTree.TabIndex = 0;
            // 
            // kToolStripDirTree
            // 
            kToolStripDirTree.Font = new Font("Segoe UI", 9F);
            kToolStripDirTree.Items.AddRange(new ToolStripItem[] { tsbIndexing, tspRefresh });
            kToolStripDirTree.Location = new Point(3, 2);
            kToolStripDirTree.Name = "kToolStripDirTree";
            kToolStripDirTree.Size = new Size(332, 25);
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
            lblRagStatus.Location = new Point(3, 565);
            lblRagStatus.Margin = new Padding(3, 2, 3, 2);
            lblRagStatus.Name = "lblRagStatus";
            lblRagStatus.Size = new Size(332, 2);
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
            tabPageSettings.Size = new Size(338, 569);
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
            tabSettings.Size = new Size(320, 553);
            tabSettings.TabIndex = 15;
            // 
            // tabPageChat
            // 
            tabPageChat.Controls.Add(kryptonPanel2);
            tabPageChat.Controls.Add(btnSaveChatSettings);
            tabPageChat.Location = new Point(4, 24);
            tabPageChat.Margin = new Padding(3, 2, 3, 2);
            tabPageChat.Name = "tabPageChat";
            tabPageChat.Padding = new Padding(3, 2, 3, 2);
            tabPageChat.Size = new Size(312, 525);
            tabPageChat.TabIndex = 0;
            tabPageChat.Text = "Chat Settings";
            tabPageChat.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(cmbClaudeModel);
            kryptonPanel2.Controls.Add(txtClaudeCodePath);
            kryptonPanel2.Controls.Add(cmbAPIProvider);
            kryptonPanel2.Controls.Add(lblAPIProvider);
            kryptonPanel2.Controls.Add(lblClaudeCodePath);
            kryptonPanel2.Controls.Add(lblClaudeModel);
            kryptonPanel2.Controls.Add(txtModel);
            kryptonPanel2.Controls.Add(txtBaseUrl);
            kryptonPanel2.Controls.Add(lblModel);
            kryptonPanel2.Controls.Add(lblBaseUrl);
            kryptonPanel2.Controls.Add(lblLanguage);
            kryptonPanel2.Controls.Add(cmbLanguage);
            kryptonPanel2.Controls.Add(txtApiKey);
            kryptonPanel2.Controls.Add(lblApiKey);
            kryptonPanel2.Controls.Add(chkUseContextInSystemMessage);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(3, 2);
            kryptonPanel2.Margin = new Padding(3, 2, 3, 2);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(306, 491);
            kryptonPanel2.TabIndex = 0;
            // 
            // cmbClaudeModel
            // 
            cmbClaudeModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClaudeModel.DropDownWidth = 250;
            cmbClaudeModel.Items.AddRange(new object[] { "sonnet", "opus", "haiku" });
            cmbClaudeModel.Location = new Point(3, 165);
            cmbClaudeModel.Name = "cmbClaudeModel";
            cmbClaudeModel.Size = new Size(282, 22);
            cmbClaudeModel.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbClaudeModel.TabIndex = 17;
            cmbClaudeModel.Visible = false;
            // 
            // txtClaudeCodePath
            // 
            txtClaudeCodePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClaudeCodePath.Location = new Point(3, 71);
            txtClaudeCodePath.Margin = new Padding(3, 2, 3, 2);
            txtClaudeCodePath.Name = "txtClaudeCodePath";
            txtClaudeCodePath.Size = new Size(289, 23);
            txtClaudeCodePath.TabIndex = 15;
            txtClaudeCodePath.Text = "claude";
            txtClaudeCodePath.Visible = false;
            // 
            // cmbAPIProvider
            // 
            cmbAPIProvider.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAPIProvider.DropDownWidth = 250;
            cmbAPIProvider.Items.AddRange(new object[] { "OpenAI Compatible", "Claude Code" });
            cmbAPIProvider.Location = new Point(3, 26);
            cmbAPIProvider.Name = "cmbAPIProvider";
            cmbAPIProvider.Size = new Size(282, 22);
            cmbAPIProvider.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbAPIProvider.TabIndex = 1;
            toolTip1.SetToolTip(cmbAPIProvider, "Select an API provider");
            cmbAPIProvider.SelectedIndexChanged += cmbAPIProvider_SelectedIndexChanged;
            // 
            // lblAPIProvider
            // 
            lblAPIProvider.Location = new Point(3, 7);
            lblAPIProvider.Margin = new Padding(3, 2, 3, 2);
            lblAPIProvider.Name = "lblAPIProvider";
            lblAPIProvider.Size = new Size(80, 20);
            lblAPIProvider.TabIndex = 14;
            lblAPIProvider.Values.Text = "API Provider:";
            // 
            // lblClaudeCodePath
            // 
            lblClaudeCodePath.Location = new Point(3, 51);
            lblClaudeCodePath.Margin = new Padding(3, 2, 3, 2);
            lblClaudeCodePath.Name = "lblClaudeCodePath";
            lblClaudeCodePath.Size = new Size(131, 20);
            lblClaudeCodePath.TabIndex = 16;
            lblClaudeCodePath.Values.Text = "Claude Code CLI Path:";
            lblClaudeCodePath.Visible = false;
            // 
            // lblClaudeModel
            // 
            lblClaudeModel.Location = new Point(3, 147);
            lblClaudeModel.Margin = new Padding(3, 2, 3, 2);
            lblClaudeModel.Name = "lblClaudeModel";
            lblClaudeModel.Size = new Size(48, 20);
            lblClaudeModel.TabIndex = 18;
            lblClaudeModel.Values.Text = "Model:";
            lblClaudeModel.Visible = false;
            // 
            // txtModel
            // 
            txtModel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtModel.Location = new Point(3, 165);
            txtModel.Margin = new Padding(3, 2, 3, 2);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(289, 23);
            txtModel.TabIndex = 4;
            // 
            // txtBaseUrl
            // 
            txtBaseUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBaseUrl.Location = new Point(3, 71);
            txtBaseUrl.Margin = new Padding(3, 2, 3, 2);
            txtBaseUrl.Name = "txtBaseUrl";
            txtBaseUrl.Size = new Size(289, 23);
            txtBaseUrl.TabIndex = 2;
            txtBaseUrl.Text = "http://localhost:/1234";
            toolTip1.SetToolTip(txtBaseUrl, "Leave empty for OpenAI, or enter custom endpoint for compatible APIs");
            // 
            // lblModel
            // 
            lblModel.Location = new Point(3, 147);
            lblModel.Margin = new Padding(3, 2, 3, 2);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(48, 20);
            lblModel.TabIndex = 5;
            lblModel.Values.Text = "Model:";
            // 
            // lblBaseUrl
            // 
            lblBaseUrl.Location = new Point(3, 51);
            lblBaseUrl.Margin = new Padding(3, 2, 3, 2);
            lblBaseUrl.Name = "lblBaseUrl";
            lblBaseUrl.Size = new Size(63, 20);
            lblBaseUrl.TabIndex = 0;
            lblBaseUrl.Values.Text = "Base URL:";
            //
            // lblLanguage
            //
            lblLanguage.Location = new Point(3, 208);
            lblLanguage.Margin = new Padding(3, 2, 3, 2);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(66, 20);
            lblLanguage.TabIndex = 13;
            lblLanguage.Values.Text = "Language:";
            //
            // cmbLanguage
            //
            cmbLanguage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.DropDownWidth = 289;
            cmbLanguage.Location = new Point(3, 230);
            cmbLanguage.Margin = new Padding(3, 2, 3, 2);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(289, 21);
            cmbLanguage.TabIndex = 14;
            cmbLanguage.SelectedIndexChanged += cmbLanguage_SelectedIndexChanged;
            //
            // txtApiKey
            // 
            txtApiKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtApiKey.Location = new Point(3, 118);
            txtApiKey.Margin = new Padding(3, 2, 3, 2);
            txtApiKey.Name = "txtApiKey";
            txtApiKey.PasswordChar = '●';
            txtApiKey.Size = new Size(289, 23);
            txtApiKey.TabIndex = 3;
            txtApiKey.UseSystemPasswordChar = true;
            // 
            // lblApiKey
            // 
            lblApiKey.Location = new Point(3, 99);
            lblApiKey.Margin = new Padding(3, 2, 3, 2);
            lblApiKey.Name = "lblApiKey";
            lblApiKey.Size = new Size(54, 20);
            lblApiKey.TabIndex = 3;
            lblApiKey.Values.Text = "API Key:";
            // 
            // chkUseContextInSystemMessage
            //
            chkUseContextInSystemMessage.Location = new Point(3, 360);
            chkUseContextInSystemMessage.Margin = new Padding(3, 2, 3, 2);
            chkUseContextInSystemMessage.Name = "chkUseContextInSystemMessage";
            chkUseContextInSystemMessage.Size = new Size(197, 20);
            chkUseContextInSystemMessage.TabIndex = 6;
            toolTip1.SetToolTip(chkUseContextInSystemMessage, "When checked, RAG context will be sent as a system message (OpenAI Compatible only)");
            chkUseContextInSystemMessage.Values.Text = "Use Context in System Message";
            // 
            // btnSaveChatSettings
            // 
            btnSaveChatSettings.Dock = DockStyle.Bottom;
            btnSaveChatSettings.Location = new Point(3, 493);
            btnSaveChatSettings.Margin = new Padding(3, 2, 3, 2);
            btnSaveChatSettings.Name = "btnSaveChatSettings";
            btnSaveChatSettings.Size = new Size(306, 30);
            btnSaveChatSettings.TabIndex = 1;
            btnSaveChatSettings.Values.DropDownArrowColor = Color.Empty;
            btnSaveChatSettings.Values.Text = "Save";
            btnSaveChatSettings.Click += btnSave_Click;
            // 
            // tabPageRAG
            // 
            tabPageRAG.Controls.Add(kryptonPanel3);
            tabPageRAG.Controls.Add(btnSaveRAGSettings);
            tabPageRAG.Location = new Point(4, 24);
            tabPageRAG.Margin = new Padding(3, 2, 3, 2);
            tabPageRAG.Name = "tabPageRAG";
            tabPageRAG.Padding = new Padding(3, 2, 3, 2);
            tabPageRAG.Size = new Size(312, 525);
            tabPageRAG.TabIndex = 1;
            tabPageRAG.Text = "RAG Settings";
            tabPageRAG.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(txtMaxContextLength);
            kryptonPanel3.Controls.Add(lblMaxContextLength);
            kryptonPanel3.Controls.Add(txtTopKChunks);
            kryptonPanel3.Controls.Add(lblTopKChunks);
            kryptonPanel3.Controls.Add(txtChunkOverlap);
            kryptonPanel3.Controls.Add(txtChunkSize);
            kryptonPanel3.Controls.Add(txtContextLength);
            kryptonPanel3.Controls.Add(txtEmbeddingModel);
            kryptonPanel3.Controls.Add(txtEmbeddingUrl);
            kryptonPanel3.Controls.Add(lblEmbeddingUrl);
            kryptonPanel3.Controls.Add(lblEmbeddingModel);
            kryptonPanel3.Controls.Add(lblContextLength);
            kryptonPanel3.Controls.Add(lblChunkSize);
            kryptonPanel3.Controls.Add(lblChunkOverlap);
            kryptonPanel3.Controls.Add(chkUseNativeEmbedding);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(3, 2);
            kryptonPanel3.Margin = new Padding(3, 2, 3, 2);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(306, 491);
            kryptonPanel3.TabIndex = 0;
            // 
            // txtMaxContextLength
            // 
            txtMaxContextLength.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMaxContextLength.Location = new Point(3, 352);
            txtMaxContextLength.Margin = new Padding(3, 2, 3, 2);
            txtMaxContextLength.Name = "txtMaxContextLength";
            txtMaxContextLength.Size = new Size(289, 23);
            txtMaxContextLength.TabIndex = 21;
            txtMaxContextLength.Text = "6000";
            // 
            // lblMaxContextLength
            // 
            lblMaxContextLength.Location = new Point(3, 332);
            lblMaxContextLength.Margin = new Padding(3, 2, 3, 2);
            lblMaxContextLength.Name = "lblMaxContextLength";
            lblMaxContextLength.Size = new Size(163, 20);
            lblMaxContextLength.TabIndex = 20;
            lblMaxContextLength.Values.Text = "Max Context Length (chars):";
            // 
            // txtTopKChunks
            // 
            txtTopKChunks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTopKChunks.Location = new Point(3, 304);
            txtTopKChunks.Margin = new Padding(3, 2, 3, 2);
            txtTopKChunks.Name = "txtTopKChunks";
            txtTopKChunks.Size = new Size(289, 23);
            txtTopKChunks.TabIndex = 19;
            txtTopKChunks.Text = "3";
            // 
            // lblTopKChunks
            // 
            lblTopKChunks.Location = new Point(3, 284);
            lblTopKChunks.Margin = new Padding(3, 2, 3, 2);
            lblTopKChunks.Name = "lblTopKChunks";
            lblTopKChunks.Size = new Size(88, 20);
            lblTopKChunks.TabIndex = 18;
            lblTopKChunks.Values.Text = "Top K Chunks:";
            // 
            // txtChunkOverlap
            // 
            txtChunkOverlap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtChunkOverlap.Location = new Point(3, 220);
            txtChunkOverlap.Margin = new Padding(3, 2, 3, 2);
            txtChunkOverlap.Name = "txtChunkOverlap";
            txtChunkOverlap.Size = new Size(289, 23);
            txtChunkOverlap.TabIndex = 16;
            txtChunkOverlap.Text = "100";
            // 
            // txtChunkSize
            // 
            txtChunkSize.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtChunkSize.Location = new Point(3, 172);
            txtChunkSize.Margin = new Padding(3, 2, 3, 2);
            txtChunkSize.Name = "txtChunkSize";
            txtChunkSize.Size = new Size(289, 23);
            txtChunkSize.TabIndex = 14;
            txtChunkSize.Text = "500";
            // 
            // txtContextLength
            // 
            txtContextLength.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContextLength.Location = new Point(3, 124);
            txtContextLength.Margin = new Padding(3, 2, 3, 2);
            txtContextLength.Name = "txtContextLength";
            txtContextLength.Size = new Size(289, 23);
            txtContextLength.TabIndex = 12;
            txtContextLength.Text = "2048";
            // 
            // txtEmbeddingModel
            // 
            txtEmbeddingModel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmbeddingModel.Location = new Point(3, 75);
            txtEmbeddingModel.Margin = new Padding(3, 2, 3, 2);
            txtEmbeddingModel.Name = "txtEmbeddingModel";
            txtEmbeddingModel.Size = new Size(289, 23);
            txtEmbeddingModel.TabIndex = 10;
            txtEmbeddingModel.Text = "text-embedding-embeddinggemma-300m";
            // 
            // txtEmbeddingUrl
            // 
            txtEmbeddingUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmbeddingUrl.Location = new Point(3, 28);
            txtEmbeddingUrl.Margin = new Padding(3, 2, 3, 2);
            txtEmbeddingUrl.Name = "txtEmbeddingUrl";
            txtEmbeddingUrl.Size = new Size(289, 23);
            txtEmbeddingUrl.TabIndex = 8;
            txtEmbeddingUrl.Text = "http://localhost:/1234";
            // 
            // lblEmbeddingUrl
            // 
            lblEmbeddingUrl.Location = new Point(3, 10);
            lblEmbeddingUrl.Margin = new Padding(3, 2, 3, 2);
            lblEmbeddingUrl.Name = "lblEmbeddingUrl";
            lblEmbeddingUrl.Size = new Size(101, 20);
            lblEmbeddingUrl.TabIndex = 7;
            lblEmbeddingUrl.Values.Text = "Embedding URL:";
            // 
            // lblEmbeddingModel
            // 
            lblEmbeddingModel.Location = new Point(3, 57);
            lblEmbeddingModel.Margin = new Padding(3, 2, 3, 2);
            lblEmbeddingModel.Name = "lblEmbeddingModel";
            lblEmbeddingModel.Size = new Size(114, 20);
            lblEmbeddingModel.TabIndex = 9;
            lblEmbeddingModel.Values.Text = "Embedding Model:";
            // 
            // lblContextLength
            // 
            lblContextLength.Location = new Point(3, 104);
            lblContextLength.Margin = new Padding(3, 2, 3, 2);
            lblContextLength.Name = "lblContextLength";
            lblContextLength.Size = new Size(97, 20);
            lblContextLength.TabIndex = 11;
            lblContextLength.Values.Text = "Context Length:";
            // 
            // lblChunkSize
            // 
            lblChunkSize.Location = new Point(3, 152);
            lblChunkSize.Margin = new Padding(3, 2, 3, 2);
            lblChunkSize.Name = "lblChunkSize";
            lblChunkSize.Size = new Size(73, 20);
            lblChunkSize.TabIndex = 13;
            lblChunkSize.Values.Text = "Chunk Size:";
            // 
            // lblChunkOverlap
            // 
            lblChunkOverlap.Location = new Point(3, 200);
            lblChunkOverlap.Margin = new Padding(3, 2, 3, 2);
            lblChunkOverlap.Name = "lblChunkOverlap";
            lblChunkOverlap.Size = new Size(94, 20);
            lblChunkOverlap.TabIndex = 15;
            lblChunkOverlap.Values.Text = "Chunk Overlap:";
            // 
            // chkUseNativeEmbedding
            // 
            chkUseNativeEmbedding.Location = new Point(3, 250);
            chkUseNativeEmbedding.Margin = new Padding(3, 2, 3, 2);
            chkUseNativeEmbedding.Name = "chkUseNativeEmbedding";
            chkUseNativeEmbedding.Size = new Size(166, 20);
            chkUseNativeEmbedding.TabIndex = 17;
            chkUseNativeEmbedding.Values.Text = "Use Native C# Embedding";
            chkUseNativeEmbedding.Visible = false;
            // 
            // btnSaveRAGSettings
            // 
            btnSaveRAGSettings.Dock = DockStyle.Bottom;
            btnSaveRAGSettings.Location = new Point(3, 493);
            btnSaveRAGSettings.Margin = new Padding(3, 2, 3, 2);
            btnSaveRAGSettings.Name = "btnSaveRAGSettings";
            btnSaveRAGSettings.Size = new Size(306, 30);
            btnSaveRAGSettings.TabIndex = 2;
            btnSaveRAGSettings.Values.DropDownArrowColor = Color.Empty;
            btnSaveRAGSettings.Values.Text = "Save";
            btnSaveRAGSettings.Click += btnSave_Click;
            // 
            // tabPageTheme
            // 
            tabPageTheme.Controls.Add(kryptonThemeListBox1);
            tabPageTheme.Location = new Point(4, 24);
            tabPageTheme.Name = "tabPageTheme";
            tabPageTheme.Size = new Size(310, 487);
            tabPageTheme.TabIndex = 2;
            tabPageTheme.Text = "Theme";
            tabPageTheme.UseVisualStyleBackColor = true;
            // 
            // kryptonThemeListBox1
            // 
            kryptonThemeListBox1.DefaultPalette = Krypton.Toolkit.PaletteMode.Microsoft365Blue;
            kryptonThemeListBox1.Dock = DockStyle.Fill;
            kryptonThemeListBox1.Location = new Point(0, 0);
            kryptonThemeListBox1.Name = "kryptonThemeListBox1";
            kryptonThemeListBox1.Size = new Size(310, 487);
            kryptonThemeListBox1.TabIndex = 0;
            kryptonThemeListBox1.SelectedIndexChanged += KryptonThemeListBox1_SelectedIndexChanged;
            // 
            // tabPageMCP
            // 
            tabPageMCP.Controls.Add(kryptonPanel1);
            tabPageMCP.Location = new Point(4, 24);
            tabPageMCP.Name = "tabPageMCP";
            tabPageMCP.Size = new Size(310, 487);
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
            kryptonPanel1.Size = new Size(310, 487);
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
            // kryptonStatusStrip1
            // 
            kryptonStatusStrip1.Font = new Font("Segoe UI", 9F);
            kryptonStatusStrip1.ImageScalingSize = new Size(20, 20);
            kryptonStatusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            kryptonStatusStrip1.Location = new Point(0, 597);
            kryptonStatusStrip1.Name = "kryptonStatusStrip1";
            kryptonStatusStrip1.ProgressBars = null;
            kryptonStatusStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            kryptonStatusStrip1.Size = new Size(1171, 22);
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
            splitContainerMain.Size = new Size(1171, 597);
            splitContainerMain.SplitterDistance = 346;
            splitContainerMain.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 619);
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
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbClaudeModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbAPIProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbLanguage).EndInit();
            tabPageRAG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            tabPageTheme.ResumeLayout(false);
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
        private Krypton.Toolkit.KryptonLabel lblBaseUrl;
        private Krypton.Toolkit.KryptonTextBox txtBaseUrl;
        private Krypton.Toolkit.KryptonLabel lblApiKey;
        private Krypton.Toolkit.KryptonTextBox txtApiKey;
        private Krypton.Toolkit.KryptonLabel lblModel;
        private Krypton.Toolkit.KryptonTextBox txtModel;
        private Krypton.Toolkit.KryptonLabel lblEmbeddingUrl;
        private Krypton.Toolkit.KryptonTextBox txtEmbeddingUrl;
        private Krypton.Toolkit.KryptonLabel lblEmbeddingModel;
        private Krypton.Toolkit.KryptonTextBox txtEmbeddingModel;
        private Krypton.Toolkit.KryptonLabel lblLanguage;
        private Krypton.Toolkit.KryptonComboBox cmbLanguage;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private ToolTip toolTip1;
        private Krypton.Toolkit.KryptonStatusStrip kryptonStatusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl tabSettings;
        private TabPage tabPageChat;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private TabPage tabPageRAG;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonButton btnSaveChatSettings;
        private Krypton.Toolkit.KryptonButton btnSaveRAGSettings;
        private TabPage tabPageTheme;
        private Krypton.Toolkit.KryptonThemeListBox kryptonThemeListBox1;
        private Krypton.Toolkit.KryptonLabel lblContextLength;
        private Krypton.Toolkit.KryptonTextBox txtContextLength;
        private Krypton.Toolkit.KryptonLabel lblChunkSize;
        private Krypton.Toolkit.KryptonTextBox txtChunkSize;
        private Krypton.Toolkit.KryptonLabel lblChunkOverlap;
        private Krypton.Toolkit.KryptonTextBox txtChunkOverlap;
        private Krypton.Toolkit.KryptonCheckBox chkUseNativeEmbedding;
        private Krypton.Toolkit.KryptonToolStrip kToolStripDirTree;
        private ToolStripButton tsbIndexing;
        private ToolStripButton tspRefresh;
        private SplitContainer splitContainerMain;
        private Krypton.Toolkit.KryptonComboBox cmbAPIProvider;
        private Krypton.Toolkit.KryptonLabel lblAPIProvider;
        private Krypton.Toolkit.KryptonTextBox txtClaudeCodePath;
        private Krypton.Toolkit.KryptonLabel lblClaudeCodePath;
        private Krypton.Toolkit.KryptonComboBox cmbClaudeModel;
        private Krypton.Toolkit.KryptonLabel lblClaudeModel;
        private Krypton.Toolkit.KryptonLabel lblTopKChunks;
        private Krypton.Toolkit.KryptonTextBox txtTopKChunks;
        private Krypton.Toolkit.KryptonLabel lblMaxContextLength;
        private Krypton.Toolkit.KryptonTextBox txtMaxContextLength;
        private Krypton.Toolkit.KryptonCheckBox chkUseContextInSystemMessage;
        private TabPage tabPageMCP;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonDataGridView dgvMcpServers;
        private Krypton.Toolkit.KryptonButton btnAddMcpServer;
        private Krypton.Toolkit.KryptonButton btnEditMcpServer;
        private Krypton.Toolkit.KryptonButton btnRemoveMcpServer;
        private Krypton.Toolkit.KryptonButton btnTestMcpServer;
        private Krypton.Toolkit.KryptonButton btnLoadMcpServers;
        private Krypton.Toolkit.KryptonRichTextBox rtbMcpLog;
    }
}
