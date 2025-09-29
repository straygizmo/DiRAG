using DiRAG.Models;
using Krypton.Toolkit;

namespace DiRAG.Forms
{
    public partial class McpServerDialog : KryptonForm
    {
        public McpServerConfig ServerConfig { get; private set; }

        public McpServerDialog(McpServerConfig? config = null)
        {
            InitializeComponent();

            if (config != null)
            {
                ServerConfig = config;
                LoadConfig();
            }
            else
            {
                ServerConfig = new McpServerConfig();
            }
        }

        private void LoadConfig()
        {
            txtName.Text = ServerConfig.Name;
            txtCommand.Text = ServerConfig.Command;
            txtArguments.Text = ServerConfig.Arguments ?? string.Empty;
            txtWorkingDirectory.Text = ServerConfig.WorkingDirectory ?? string.Empty;
            txtDescription.Text = ServerConfig.Description ?? string.Empty;
            cmbTransportType.SelectedIndex = (int)ServerConfig.TransportType;
            chkEnabled.Checked = ServerConfig.IsEnabled;

            if (ServerConfig.EnvironmentVariables != null)
            {
                foreach (var kvp in ServerConfig.EnvironmentVariables)
                {
                    dgvEnvironmentVariables.Rows.Add(kvp.Key, kvp.Value);
                }
            }
        }

        private void SaveConfig()
        {
            ServerConfig.Name = txtName.Text.Trim();
            ServerConfig.Command = txtCommand.Text.Trim();
            ServerConfig.Arguments = string.IsNullOrWhiteSpace(txtArguments.Text) ? null : txtArguments.Text.Trim();
            ServerConfig.WorkingDirectory = string.IsNullOrWhiteSpace(txtWorkingDirectory.Text) ? null : txtWorkingDirectory.Text.Trim();
            ServerConfig.Description = string.IsNullOrWhiteSpace(txtDescription.Text) ? null : txtDescription.Text.Trim();
            ServerConfig.TransportType = (McpTransportType)cmbTransportType.SelectedIndex;
            ServerConfig.IsEnabled = chkEnabled.Checked;

            ServerConfig.EnvironmentVariables = new Dictionary<string, string>();
            foreach (DataGridViewRow row in dgvEnvironmentVariables.Rows)
            {
                if (!row.IsNewRow)
                {
                    var key = row.Cells[0].Value?.ToString()?.Trim();
                    var value = row.Cells[1].Value?.ToString() ?? string.Empty;
                    if (!string.IsNullOrEmpty(key))
                    {
                        ServerConfig.EnvironmentVariables[key] = value;
                    }
                }
            }
        }

        private void btnBrowseCommand_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "Executable files (*.exe;*.bat;*.cmd;*.ps1;*.py;*.js)|*.exe;*.bat;*.cmd;*.ps1;*.py;*.js|All files (*.*)|*.*";
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtCommand.Text = dialog.FileName;
                }
            }
        }

        private void btnBrowseWorkingDirectory_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.ShowNewFolderButton = false;

                if (!string.IsNullOrWhiteSpace(txtWorkingDirectory.Text) && Directory.Exists(txtWorkingDirectory.Text))
                {
                    dialog.SelectedPath = txtWorkingDirectory.Text;
                }

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtWorkingDirectory.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a server name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCommand.Text))
            {
                MessageBox.Show("Please enter a command.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCommand.Focus();
                return;
            }

            SaveConfig();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}