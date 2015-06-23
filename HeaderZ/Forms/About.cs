using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Gunners.Forms
{
    public partial class FrmAbout : Form
    {
        string url = "http://ask.fm/YasserGersy";

        public FrmAbout()
        {
            InitializeComponent();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if((sender as LinkLabel).Text.IsUrl()==false)
                return;
            System.Diagnostics.Process.Start((sender as LinkLabel).Text);
        }

        private void lnklBL_Close_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((FormMain)this.Owner).RemoveCurrentTab(); 

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.tabControl2.SelectedIndex==tabControl2.TabCount-1)
                webBrowser1.Navigate(url);
                
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.DocumentText.Contains("Make sure the web address ") || webBrowser1.DocumentText.Contains("Navigation was canceled"))
                setNotification("Your internet seems to be down");

            else
            {
                webBrowser1.Visible = true;
                setNotification("Loaded");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.setNotification("Loading");
            webBrowser1.Visible = false;
            string sender_ = (sender as RadioButton).Text;

            if (sender_.Contains("witter"))
                url = "https://twitter.com/YasserGersy";

            else if (sender_.Contains("acebok"))
                url = "https://facebook.com/prince.gersy2";

            else url = "http://ask.fm/YasserGersy";

            webBrowser1.Navigate(url);
        }

        private void setNotification(string p)
        {
            ((FormMain)this.Owner).SetNotification(p); 
        }
    }
}
