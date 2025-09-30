namespace DiRAG.Forms.ProviderSettings
{
    partial class OpenAIProviderSettingsControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBaseUrl = new Krypton.Toolkit.KryptonTextBox();
            txtApiKey = new Krypton.Toolkit.KryptonTextBox();
            txtModel = new Krypton.Toolkit.KryptonTextBox();
            lblBaseUrl = new Krypton.Toolkit.KryptonLabel();
            lblApiKey = new Krypton.Toolkit.KryptonLabel();
            lblModel = new Krypton.Toolkit.KryptonLabel();
            chkUseContextInSystemMessage = new Krypton.Toolkit.KryptonCheckBox();
            SuspendLayout();
            //
            // lblBaseUrl
            //
            lblBaseUrl.Location = new Point(3, 10);
            lblBaseUrl.Margin = new Padding(3, 2, 3, 2);
            lblBaseUrl.Name = "lblBaseUrl";
            lblBaseUrl.Size = new Size(63, 20);
            lblBaseUrl.TabIndex = 0;
            lblBaseUrl.Values.Text = "Base URL:";
            //
            // txtBaseUrl
            //
            txtBaseUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBaseUrl.Location = new Point(3, 31);
            txtBaseUrl.Margin = new Padding(3, 2, 3, 2);
            txtBaseUrl.Name = "txtBaseUrl";
            txtBaseUrl.Size = new Size(290, 23);
            txtBaseUrl.TabIndex = 1;
            txtBaseUrl.Text = "http://localhost:1234";
            //
            // lblApiKey
            //
            lblApiKey.Location = new Point(3, 59);
            lblApiKey.Margin = new Padding(3, 2, 3, 2);
            lblApiKey.Name = "lblApiKey";
            lblApiKey.Size = new Size(54, 20);
            lblApiKey.TabIndex = 2;
            lblApiKey.Values.Text = "API Key:";
            //
            // txtApiKey
            //
            txtApiKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtApiKey.Location = new Point(3, 80);
            txtApiKey.Margin = new Padding(3, 2, 3, 2);
            txtApiKey.Name = "txtApiKey";
            txtApiKey.PasswordChar = '●';
            txtApiKey.Size = new Size(290, 23);
            txtApiKey.TabIndex = 3;
            txtApiKey.UseSystemPasswordChar = true;
            //
            // lblModel
            //
            lblModel.Location = new Point(3, 108);
            lblModel.Margin = new Padding(3, 2, 3, 2);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(48, 20);
            lblModel.TabIndex = 4;
            lblModel.Values.Text = "Model:";
            //
            // txtModel
            //
            txtModel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtModel.Location = new Point(3, 129);
            txtModel.Margin = new Padding(3, 2, 3, 2);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(290, 23);
            txtModel.TabIndex = 5;
            //
            // chkUseContextInSystemMessage
            //
            chkUseContextInSystemMessage.Location = new Point(3, 160);
            chkUseContextInSystemMessage.Margin = new Padding(3, 2, 3, 2);
            chkUseContextInSystemMessage.Name = "chkUseContextInSystemMessage";
            chkUseContextInSystemMessage.Size = new Size(197, 20);
            chkUseContextInSystemMessage.TabIndex = 6;
            chkUseContextInSystemMessage.Values.Text = "Use Context in System Message";
            //
            // OpenAIProviderSettingsControl
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chkUseContextInSystemMessage);
            Controls.Add(txtModel);
            Controls.Add(lblModel);
            Controls.Add(txtApiKey);
            Controls.Add(lblApiKey);
            Controls.Add(txtBaseUrl);
            Controls.Add(lblBaseUrl);
            Name = "OpenAIProviderSettingsControl";
            Size = new Size(296, 190);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtBaseUrl;
        private Krypton.Toolkit.KryptonTextBox txtApiKey;
        private Krypton.Toolkit.KryptonTextBox txtModel;
        private Krypton.Toolkit.KryptonLabel lblBaseUrl;
        private Krypton.Toolkit.KryptonLabel lblApiKey;
        private Krypton.Toolkit.KryptonLabel lblModel;
        private Krypton.Toolkit.KryptonCheckBox chkUseContextInSystemMessage;
    }
}
