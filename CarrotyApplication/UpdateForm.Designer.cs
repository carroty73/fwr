namespace WindowsApplication2
{
    partial class UpdateForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.versionWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // versionWebBrowser
            // 
            this.versionWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.versionWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.versionWebBrowser.Name = "versionWebBrowser";
            this.versionWebBrowser.Size = new System.Drawing.Size(988, 603);
            this.versionWebBrowser.TabIndex = 1;
            this.versionWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.versionWebBrowser_DocumentCompleted);
            // 
            // VersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 603);
            this.Controls.Add(this.versionWebBrowser);
            this.Name = "VersionForm";
            this.Text = "Update";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser versionWebBrowser;
    }
}