namespace DiRAG.Forms
{
    partial class McpServerDialog
    {
        private System.ComponentModel.IContainer components = null;
        private Krypton.Toolkit.KryptonLabel lblName;
        private Krypton.Toolkit.KryptonTextBox txtName;
        private Krypton.Toolkit.KryptonLabel lblCommand;
        private Krypton.Toolkit.KryptonTextBox txtCommand;
        private Krypton.Toolkit.KryptonButton btnBrowseCommand;
        private Krypton.Toolkit.KryptonLabel lblArguments;
        private Krypton.Toolkit.KryptonTextBox txtArguments;
        private Krypton.Toolkit.KryptonLabel lblWorkingDirectory;
        private Krypton.Toolkit.KryptonTextBox txtWorkingDirectory;
        private Krypton.Toolkit.KryptonButton btnBrowseWorkingDirectory;
        private Krypton.Toolkit.KryptonLabel lblTransportType;
        private Krypton.Toolkit.KryptonComboBox cmbTransportType;
        private Krypton.Toolkit.KryptonLabel lblDescription;
        private Krypton.Toolkit.KryptonTextBox txtDescription;
        private Krypton.Toolkit.KryptonCheckBox chkEnabled;
        private Krypton.Toolkit.KryptonLabel lblEnvironmentVariables;
        private Krypton.Toolkit.KryptonDataGridView dgvEnvironmentVariables;
        private Krypton.Toolkit.KryptonButton btnOK;
        private Krypton.Toolkit.KryptonButton btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName = new Krypton.Toolkit.KryptonLabel();
            this.txtName = new Krypton.Toolkit.KryptonTextBox();
            this.lblCommand = new Krypton.Toolkit.KryptonLabel();
            this.txtCommand = new Krypton.Toolkit.KryptonTextBox();
            this.btnBrowseCommand = new Krypton.Toolkit.KryptonButton();
            this.lblArguments = new Krypton.Toolkit.KryptonLabel();
            this.txtArguments = new Krypton.Toolkit.KryptonTextBox();
            this.lblWorkingDirectory = new Krypton.Toolkit.KryptonLabel();
            this.txtWorkingDirectory = new Krypton.Toolkit.KryptonTextBox();
            this.btnBrowseWorkingDirectory = new Krypton.Toolkit.KryptonButton();
            this.lblTransportType = new Krypton.Toolkit.KryptonLabel();
            this.cmbTransportType = new Krypton.Toolkit.KryptonComboBox();
            this.lblDescription = new Krypton.Toolkit.KryptonLabel();
            this.txtDescription = new Krypton.Toolkit.KryptonTextBox();
            this.chkEnabled = new Krypton.Toolkit.KryptonCheckBox();
            this.lblEnvironmentVariables = new Krypton.Toolkit.KryptonLabel();
            this.dgvEnvironmentVariables = new Krypton.Toolkit.KryptonDataGridView();
            this.btnOK = new Krypton.Toolkit.KryptonButton();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTransportType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvironmentVariables)).BeginInit();
            this.SuspendLayout();

            // lblName
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Values.Text = "Name:";

            // txtName
            this.txtName.Location = new System.Drawing.Point(120, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(400, 23);
            this.txtName.TabIndex = 1;

            // lblCommand
            this.lblCommand.Location = new System.Drawing.Point(12, 44);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(67, 20);
            this.lblCommand.TabIndex = 2;
            this.lblCommand.Values.Text = "Command:";

            // txtCommand
            this.txtCommand.Location = new System.Drawing.Point(120, 41);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(319, 23);
            this.txtCommand.TabIndex = 3;

            // btnBrowseCommand
            this.btnBrowseCommand.Location = new System.Drawing.Point(445, 41);
            this.btnBrowseCommand.Name = "btnBrowseCommand";
            this.btnBrowseCommand.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseCommand.TabIndex = 4;
            this.btnBrowseCommand.Values.Text = "Browse...";
            this.btnBrowseCommand.Click += new System.EventHandler(this.btnBrowseCommand_Click);

            // lblArguments
            this.lblArguments.Location = new System.Drawing.Point(12, 73);
            this.lblArguments.Name = "lblArguments";
            this.lblArguments.Size = new System.Drawing.Size(71, 20);
            this.lblArguments.TabIndex = 5;
            this.lblArguments.Values.Text = "Arguments:";

            // txtArguments
            this.txtArguments.Location = new System.Drawing.Point(120, 70);
            this.txtArguments.Name = "txtArguments";
            this.txtArguments.Size = new System.Drawing.Size(400, 23);
            this.txtArguments.TabIndex = 6;

            // lblWorkingDirectory
            this.lblWorkingDirectory.Location = new System.Drawing.Point(12, 102);
            this.lblWorkingDirectory.Name = "lblWorkingDirectory";
            this.lblWorkingDirectory.Size = new System.Drawing.Size(109, 20);
            this.lblWorkingDirectory.TabIndex = 7;
            this.lblWorkingDirectory.Values.Text = "Working Directory:";

            // txtWorkingDirectory
            this.txtWorkingDirectory.Location = new System.Drawing.Point(120, 99);
            this.txtWorkingDirectory.Name = "txtWorkingDirectory";
            this.txtWorkingDirectory.Size = new System.Drawing.Size(319, 23);
            this.txtWorkingDirectory.TabIndex = 8;

            // btnBrowseWorkingDirectory
            this.btnBrowseWorkingDirectory.Location = new System.Drawing.Point(445, 99);
            this.btnBrowseWorkingDirectory.Name = "btnBrowseWorkingDirectory";
            this.btnBrowseWorkingDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseWorkingDirectory.TabIndex = 9;
            this.btnBrowseWorkingDirectory.Values.Text = "Browse...";
            this.btnBrowseWorkingDirectory.Click += new System.EventHandler(this.btnBrowseWorkingDirectory_Click);

            // lblTransportType
            this.lblTransportType.Location = new System.Drawing.Point(12, 131);
            this.lblTransportType.Name = "lblTransportType";
            this.lblTransportType.Size = new System.Drawing.Size(91, 20);
            this.lblTransportType.TabIndex = 10;
            this.lblTransportType.Values.Text = "Transport Type:";

            // cmbTransportType
            this.cmbTransportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransportType.DropDownWidth = 121;
            this.cmbTransportType.Items.AddRange(new object[] {
            "Stdio",
            "HTTP"});
            this.cmbTransportType.Location = new System.Drawing.Point(120, 128);
            this.cmbTransportType.Name = "cmbTransportType";
            this.cmbTransportType.Size = new System.Drawing.Size(121, 21);
            this.cmbTransportType.TabIndex = 11;
            this.cmbTransportType.SelectedIndex = 0;

            // lblDescription
            this.lblDescription.Location = new System.Drawing.Point(12, 160);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(73, 20);
            this.lblDescription.TabIndex = 12;
            this.lblDescription.Values.Text = "Description:";

            // txtDescription
            this.txtDescription.Location = new System.Drawing.Point(120, 157);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 50);
            this.txtDescription.TabIndex = 13;

            // chkEnabled
            this.chkEnabled.Location = new System.Drawing.Point(120, 213);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(67, 20);
            this.chkEnabled.TabIndex = 14;
            this.chkEnabled.Values.Text = "Enabled";
            this.chkEnabled.Checked = true;

            // lblEnvironmentVariables
            this.lblEnvironmentVariables.Location = new System.Drawing.Point(12, 239);
            this.lblEnvironmentVariables.Name = "lblEnvironmentVariables";
            this.lblEnvironmentVariables.Size = new System.Drawing.Size(131, 20);
            this.lblEnvironmentVariables.TabIndex = 15;
            this.lblEnvironmentVariables.Values.Text = "Environment Variables:";

            // dgvEnvironmentVariables
            this.dgvEnvironmentVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnvironmentVariables.Columns.Add("Key", "Key");
            this.dgvEnvironmentVariables.Columns.Add("Value", "Value");
            this.dgvEnvironmentVariables.Columns[0].Width = 150;
            this.dgvEnvironmentVariables.Columns[1].Width = 250;
            this.dgvEnvironmentVariables.Location = new System.Drawing.Point(120, 265);
            this.dgvEnvironmentVariables.Name = "dgvEnvironmentVariables";
            this.dgvEnvironmentVariables.RowTemplate.Height = 25;
            this.dgvEnvironmentVariables.Size = new System.Drawing.Size(400, 120);
            this.dgvEnvironmentVariables.TabIndex = 16;

            // btnOK
            this.btnOK.Location = new System.Drawing.Point(364, 400);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 17;
            this.btnOK.Values.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(445, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Values.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // McpServerDialog
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 441);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvEnvironmentVariables);
            this.Controls.Add(this.lblEnvironmentVariables);
            this.Controls.Add(this.chkEnabled);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.cmbTransportType);
            this.Controls.Add(this.lblTransportType);
            this.Controls.Add(this.btnBrowseWorkingDirectory);
            this.Controls.Add(this.txtWorkingDirectory);
            this.Controls.Add(this.lblWorkingDirectory);
            this.Controls.Add(this.txtArguments);
            this.Controls.Add(this.lblArguments);
            this.Controls.Add(this.btnBrowseCommand);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "McpServerDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MCP Server Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.cmbTransportType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvironmentVariables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}