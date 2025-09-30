using Krypton.Toolkit;

namespace DiRAG.Forms.ProviderSettings
{
    public partial class OpenAIProviderSettingsControl : UserControl, IProviderSettingsControl
    {
        public OpenAIProviderSettingsControl()
        {
            InitializeComponent();
        }

        public void LoadSettings()
        {
            txtBaseUrl.Text = Properties.Settings.Default.OpenAI_BaseUrl;
            txtApiKey.Text = Properties.Settings.Default.OpenAI_ApiKey;
            txtModel.Text = string.IsNullOrEmpty(Properties.Settings.Default.OpenAI_Model)
                ? "gpt-4o"
                : Properties.Settings.Default.OpenAI_Model;
            chkUseContextInSystemMessage.Checked = Properties.Settings.Default.UseContextInSystemMessage;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.OpenAI_BaseUrl = txtBaseUrl.Text;
            Properties.Settings.Default.OpenAI_ApiKey = txtApiKey.Text;
            Properties.Settings.Default.OpenAI_Model = txtModel.Text;
            Properties.Settings.Default.UseContextInSystemMessage = chkUseContextInSystemMessage.Checked;
        }

        public bool ValidateSettings()
        {
            return !string.IsNullOrEmpty(txtApiKey.Text) && !string.IsNullOrEmpty(txtModel.Text);
        }

        public string GetValidationError()
        {
            if (string.IsNullOrEmpty(txtApiKey.Text))
                return "API Key is required";
            if (string.IsNullOrEmpty(txtModel.Text))
                return "Model is required";
            return string.Empty;
        }
    }
}
