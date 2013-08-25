namespace MarkdownMode.OptionsPages
{
    using EventArgs = System.EventArgs;
    using UserControl = System.Windows.Forms.UserControl;

    public partial class RenderingOptionsControl : UserControl
    {
        private string _accessToken;

        public RenderingOptionsControl(RenderingOptions optionsPage)
        {
            InitializeComponent();
            OptionsPage = optionsPage;
            ReloadOptions();
        }

        private RenderingOptions OptionsPage
        {
            get;
            set;
        }

        public string AccessToken
        {
            get
            {
                return _accessToken;
            }

            set
            {
                _accessToken = value;
                if (string.IsNullOrEmpty(value))
                    btnAuthorize.Text = "Authorize...";
                else
                    btnAuthorize.Text = "Authorized";
            }
        }

        public void ReloadOptions()
        {
            btnMarkdownSharp.Checked = !OptionsPage.RenderUsingGitHub;
            btnGitHub.Checked = OptionsPage.RenderUsingGitHub;
            AccessToken = OptionsPage.AccessToken;

            chkXhtml.Checked = OptionsPage.Xhtml;
            chkAutoHyperlink.Checked = OptionsPage.AutoHyperlink;
            chkAutoLinkEmail.Checked = OptionsPage.AutoLinkEmail;
            chkLiteralNewlines.Checked = OptionsPage.LiteralNewlines;
            chkEncodeUrlChars.Checked = OptionsPage.EncodeUrlChars;
            chkStrictBoldItalic.Checked = OptionsPage.StrictBoldItalic;

            grpMarkdownSharp.Enabled = btnMarkdownSharp.Checked;
        }

        public void ApplyChanges()
        {
            OptionsPage.RenderUsingGitHub = btnGitHub.Checked;
            OptionsPage.AccessToken = AccessToken;

            OptionsPage.Xhtml = chkXhtml.Checked;
            OptionsPage.AutoHyperlink = chkAutoHyperlink.Checked;
            OptionsPage.AutoLinkEmail = chkAutoLinkEmail.Checked;
            OptionsPage.LiteralNewlines = chkLiteralNewlines.Checked;
            OptionsPage.EncodeUrlChars = chkEncodeUrlChars.Checked;
            OptionsPage.StrictBoldItalic = chkStrictBoldItalic.Checked;
        }

        private void HandleAuthorize_Click(object sender, EventArgs e)
        {
            using (var form = new GitHubAuthorizationForm())
            {
                form.ShowDialog();
                if (!string.IsNullOrEmpty(form.Token))
                {
                    AccessToken = form.Token;
                }
            }
        }

        private void HandleMarkdownSharp_CheckedChanged(object sender, EventArgs e)
        {
            grpMarkdownSharp.Enabled = btnMarkdownSharp.Checked;
        }
    }
}
