using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Gunners.Forms.Tools
{
    public partial class FrmWebBrowser : Form
    { 
        public FrmWebBrowser(string u="")
        {
            InitializeComponent();
           txbxUrl.Text=u;
           if (txbxUrl.Text.IsUrl())
               webBrowser1.Navigate(txbxUrl.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Visible = true;
        }

        private void GoBtn_Click(object sender, EventArgs e)
        { 
            webBrowser1.Navigate(txbxUrl.Text);
        }

        private void txbxUrl_TextChanged(object sender, EventArgs e)
        {
            GoBtn.Enabled = txbxUrl.Text.IsUrl();
        }

        private void lnklBL_Close_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((FormMain)this.Owner).RemoveCurrentTab(); 

        }
    }
}
