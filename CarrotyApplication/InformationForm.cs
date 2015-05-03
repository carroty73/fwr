using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class InfoForm : Form {
        //string url = "http://carroty.synology.me:8080/prj/fwr/update/index.htm";
        string intro_url = "http://carroty.synology.me:8080/prj/fwr/intro/article.xml";
        string update_url = "http://carroty.synology.me:8080/prj/fwr/update/article.xml";
        string usage_url= "http://carroty.synology.me:8080/prj/fwr/usage/article.xml";
        

        public InfoForm() {
            InitializeComponent();
            webBrowser.Navigate(intro_url);
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            initTreeView();
            if (this != null) {
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
            else {
                this.Activate();
            }
        }

        public void initTreeView() {
            TreeNode node = treeView.Nodes.Add("소개");
            //treeView.Nodes.Add("소개");
            treeView.Nodes.Add("개발자용 설명서");
            treeView.Nodes.Add("사용자용 설명서");
            treeView.Nodes.Add("개발 히스토리");
            treeView.ExpandAll();
        }

        private void versionWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
        }

        private void treeView_AfterSelect(object sender, EventArgs e) {
            //string selectNodeString = treeView.SelectedNode.ToString();
            //string selectNodeString = e.Node.Name;
            //string selectNodeString = treeView.SelectedNode.ToString();
            string selectNodeString = treeView.SelectedNode.Text;
            //MessageBox.Show(selectNodeString);

            switch (selectNodeString) {
                case "소개": webBrowser.Navigate(intro_url); webBrowser.Focus(); break;
                case "개발자용 설명서": webBrowser.Navigate(update_url); webBrowser.Focus(); break;
                case "사용자용 설명서": webBrowser.Navigate(usage_url);  webBrowser.Focus(); break;
                case "개발 히스토리": webBrowser.Navigate(intro_url);  webBrowser.Focus(); break;
                default: webBrowser.Navigate(intro_url); webBrowser.Focus(); break;
            }
        }
    }
}
