namespace MarkdownMode.OptionsPages
{
    partial class RenderingOptionsControl
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
            System.Windows.Forms.GroupBox groupBox1;
            this.btnAuthorize = new System.Windows.Forms.Button();
            this.btnGitHub = new System.Windows.Forms.RadioButton();
            this.btnMarkdownSharp = new System.Windows.Forms.RadioButton();
            this.grpMarkdownSharp = new System.Windows.Forms.GroupBox();
            this.chkEncodeUrlChars = new System.Windows.Forms.CheckBox();
            this.chkStrictBoldItalic = new System.Windows.Forms.CheckBox();
            this.chkAutoLinkEmail = new System.Windows.Forms.CheckBox();
            this.chkLiteralNewlines = new System.Windows.Forms.CheckBox();
            this.chkAutoHyperlink = new System.Windows.Forms.CheckBox();
            this.chkXhtml = new System.Windows.Forms.CheckBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            this.grpMarkdownSharp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            groupBox1.Controls.Add(this.btnAuthorize);
            groupBox1.Controls.Add(this.btnGitHub);
            groupBox1.Controls.Add(this.btnMarkdownSharp);
            groupBox1.Location = new System.Drawing.Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(332, 72);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Markdown Renderer";
            // 
            // btnAuthorize
            // 
            this.btnAuthorize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAuthorize.Location = new System.Drawing.Point(220, 40);
            this.btnAuthorize.Name = "btnAuthorize";
            this.btnAuthorize.Size = new System.Drawing.Size(106, 23);
            this.btnAuthorize.TabIndex = 2;
            this.btnAuthorize.Text = "Authorize...";
            this.btnAuthorize.UseVisualStyleBackColor = true;
            this.btnAuthorize.Click += new System.EventHandler(this.HandleAuthorize_Click);
            // 
            // btnGitHub
            // 
            this.btnGitHub.AutoSize = true;
            this.btnGitHub.Location = new System.Drawing.Point(7, 43);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(58, 17);
            this.btnGitHub.TabIndex = 1;
            this.btnGitHub.TabStop = true;
            this.btnGitHub.Text = "GitHub";
            this.btnGitHub.UseVisualStyleBackColor = true;
            // 
            // btnMarkdownSharp
            // 
            this.btnMarkdownSharp.AutoSize = true;
            this.btnMarkdownSharp.Location = new System.Drawing.Point(6, 19);
            this.btnMarkdownSharp.Name = "btnMarkdownSharp";
            this.btnMarkdownSharp.Size = new System.Drawing.Size(106, 17);
            this.btnMarkdownSharp.TabIndex = 0;
            this.btnMarkdownSharp.TabStop = true;
            this.btnMarkdownSharp.Text = "Markdown Sharp";
            this.btnMarkdownSharp.UseVisualStyleBackColor = true;
            this.btnMarkdownSharp.CheckedChanged += new System.EventHandler(this.HandleMarkdownSharp_CheckedChanged);
            // 
            // grpMarkdownSharp
            // 
            this.grpMarkdownSharp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMarkdownSharp.Controls.Add(this.chkEncodeUrlChars);
            this.grpMarkdownSharp.Controls.Add(this.chkStrictBoldItalic);
            this.grpMarkdownSharp.Controls.Add(this.chkAutoLinkEmail);
            this.grpMarkdownSharp.Controls.Add(this.chkLiteralNewlines);
            this.grpMarkdownSharp.Controls.Add(this.chkAutoHyperlink);
            this.grpMarkdownSharp.Controls.Add(this.chkXhtml);
            this.grpMarkdownSharp.Location = new System.Drawing.Point(3, 81);
            this.grpMarkdownSharp.Name = "grpMarkdownSharp";
            this.grpMarkdownSharp.Size = new System.Drawing.Size(332, 157);
            this.grpMarkdownSharp.TabIndex = 1;
            this.grpMarkdownSharp.TabStop = false;
            this.grpMarkdownSharp.Text = "Markdown Sharp";
            // 
            // chkEncodeUrlChars
            // 
            this.chkEncodeUrlChars.AutoSize = true;
            this.chkEncodeUrlChars.Location = new System.Drawing.Point(6, 111);
            this.chkEncodeUrlChars.Name = "chkEncodeUrlChars";
            this.chkEncodeUrlChars.Size = new System.Drawing.Size(198, 17);
            this.chkEncodeUrlChars.TabIndex = 2;
            this.chkEncodeUrlChars.Text = "Encode problematic URL characters";
            this.chkEncodeUrlChars.UseVisualStyleBackColor = true;
            // 
            // chkStrictBoldItalic
            // 
            this.chkStrictBoldItalic.AutoSize = true;
            this.chkStrictBoldItalic.Location = new System.Drawing.Point(6, 134);
            this.chkStrictBoldItalic.Name = "chkStrictBoldItalic";
            this.chkStrictBoldItalic.Size = new System.Drawing.Size(99, 17);
            this.chkStrictBoldItalic.TabIndex = 2;
            this.chkStrictBoldItalic.Text = "Strict bold/italic";
            this.chkStrictBoldItalic.UseVisualStyleBackColor = true;
            // 
            // chkAutoLinkEmail
            // 
            this.chkAutoLinkEmail.AutoSize = true;
            this.chkAutoLinkEmail.Location = new System.Drawing.Point(6, 65);
            this.chkAutoLinkEmail.Name = "chkAutoLinkEmail";
            this.chkAutoLinkEmail.Size = new System.Drawing.Size(125, 17);
            this.chkAutoLinkEmail.TabIndex = 2;
            this.chkAutoLinkEmail.Text = "Auto-hyperlink emails";
            this.chkAutoLinkEmail.UseVisualStyleBackColor = true;
            // 
            // chkLiteralNewlines
            // 
            this.chkLiteralNewlines.AutoSize = true;
            this.chkLiteralNewlines.Location = new System.Drawing.Point(6, 88);
            this.chkLiteralNewlines.Name = "chkLiteralNewlines";
            this.chkLiteralNewlines.Size = new System.Drawing.Size(204, 17);
            this.chkLiteralNewlines.TabIndex = 2;
            this.chkLiteralNewlines.Text = "Preserve newline characters in output";
            this.chkLiteralNewlines.UseVisualStyleBackColor = true;
            // 
            // chkAutoHyperlink
            // 
            this.chkAutoHyperlink.AutoSize = true;
            this.chkAutoHyperlink.Location = new System.Drawing.Point(6, 42);
            this.chkAutoHyperlink.Name = "chkAutoHyperlink";
            this.chkAutoHyperlink.Size = new System.Drawing.Size(123, 17);
            this.chkAutoHyperlink.TabIndex = 1;
            this.chkAutoHyperlink.Text = "Auto-hyperlink URLs";
            this.chkAutoHyperlink.UseVisualStyleBackColor = true;
            // 
            // chkXhtml
            // 
            this.chkXhtml.AutoSize = true;
            this.chkXhtml.Location = new System.Drawing.Point(6, 19);
            this.chkXhtml.Name = "chkXhtml";
            this.chkXhtml.Size = new System.Drawing.Size(194, 17);
            this.chkXhtml.TabIndex = 0;
            this.chkXhtml.Text = "Generate XHTML (default is HTML)";
            this.chkXhtml.UseVisualStyleBackColor = true;
            // 
            // RenderingOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpMarkdownSharp);
            this.Controls.Add(groupBox1);
            this.Name = "RenderingOptionsControl";
            this.Size = new System.Drawing.Size(338, 244);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.grpMarkdownSharp.ResumeLayout(false);
            this.grpMarkdownSharp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAuthorize;
        private System.Windows.Forms.RadioButton btnGitHub;
        private System.Windows.Forms.RadioButton btnMarkdownSharp;
        private System.Windows.Forms.CheckBox chkEncodeUrlChars;
        private System.Windows.Forms.CheckBox chkStrictBoldItalic;
        private System.Windows.Forms.CheckBox chkAutoLinkEmail;
        private System.Windows.Forms.CheckBox chkLiteralNewlines;
        private System.Windows.Forms.CheckBox chkAutoHyperlink;
        private System.Windows.Forms.CheckBox chkXhtml;
        private System.Windows.Forms.GroupBox grpMarkdownSharp;
    }
}
