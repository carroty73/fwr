using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication2
{
    public partial class UpdateForm : Form {
        string url = "http://carroty.synology.me:8080/prj/fwr/update/index.htm";

        public UpdateForm()
        {
            InitializeComponent();
            versionWebBrowser.Navigate(url);            
        }

        private void versionWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            //versionWebBrowser.Navigate(url);
            //string url = txtUrl.Text;
            //versionWebBrowser.Navigate(url);
            //webBrowser1.Navigate(url);
        }

        private void loadButton_Click(object sender, EventArgs e) {
            //string url = url;
            versionWebBrowser.Navigate(url);

        }
    }
}
