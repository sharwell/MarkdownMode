namespace MarkdownMode.OptionsPages
{
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using DialogPage = Microsoft.VisualStudio.Shell.DialogPage;
    using IWin32Window = System.Windows.Forms.IWin32Window;
    using MarkdownOptions = MarkdownSharp.MarkdownOptions;
    using Point = System.Drawing.Point;

    [Guid("58C664D6-B068-41FD-9787-D55E408027D1")]
    public class RenderingOptions : DialogPage
    {
        public RenderingOptions()
        {
            // initialize to default values
            RenderUsingGitHub = false;

            // GitHub
            AccessToken = null;

            // Markdown Sharp
            Xhtml = false;
            AutoHyperlink = false;
            AutoLinkEmail = false;
            LiteralNewlines = false;
            EncodeUrlChars = false;
            StrictBoldItalic = false;
        }

        [DefaultValue(false)]
        public bool RenderUsingGitHub
        {
            get;
            set;
        }

        [DefaultValue(null)]
        public string AccessToken
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool Xhtml
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool AutoHyperlink
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool AutoLinkEmail
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool LiteralNewlines
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool EncodeUrlChars
        {
            get;
            set;
        }

        [DefaultValue(false)]
        public bool StrictBoldItalic
        {
            get;
            set;
        }

        private RenderingOptionsControl OptionsControl
        {
            get;
            set;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        protected override IWin32Window Window
        {
            get
            {
                OptionsControl = new RenderingOptionsControl(this);
                OptionsControl.Location = new Point(0, 0);
                return OptionsControl;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MarkdownOptions MarkdownOptions
        {
            get
            {
                return new MarkdownOptions
                {
                    AutoHyperlink = AutoHyperlink,
                    AutoNewlines = LiteralNewlines,
                    EmptyElementSuffix = Xhtml ? " />" : ">",
                    EncodeProblemUrlCharacters = EncodeUrlChars,
                    LinkEmails = AutoLinkEmail,
                    StrictBoldItalic = StrictBoldItalic
                };
            }
        }

        public override void SaveSettingsToStorage()
        {
            if (OptionsControl != null)
                OptionsControl.ApplyChanges();

            base.SaveSettingsToStorage();
        }
    }
}
