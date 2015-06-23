using Web_Gunners.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Gunners
{
    public partial class FrmSettings : Form
    {
        public FrmSettings(int i=0)
        {
            InitializeComponent();
            tabControl1.SelectedIndex = i;
        }
        bool FormLoaded = false;
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            /// first tab 
            checkBox_Isolated_window.Checked = global::Web_Gunners.Properties.Settings.Default.Use_ProxyInIsolatedWindow;

            //second tab
            checkBoxCookie.Checked = SettingsManager.UseCookie();
            rtxbxCookie.Text = SettingsManager.GetCookieString();

            checkBox_UserAgent.Checked = SettingsManager.UserAgent();
            Rtxbxuseragent.Text = SettingsManager.GetUserAgentString();
            
            rtxbxAuth.Text = SettingsManager.GetAuthString();
            this.chkbx_Authorization.Checked = SettingsManager.UseAuthorization();
         
            txbxHost.Text = SettingsManager.GetHostString();
            nmPort.Value = SettingsManager.GetPortNumber();
            chkbxProxy.Checked = SettingsManager.UseProxy();


            // third tab
            ColorPanel.BackColor = SettingsManager.TextSearchColor();


            checkBox_in_Tab_Page.Checked = !checkBox_Isolated_window.Checked;
            FormLoaded = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.FormLoaded)
            {
                SettingsManager.Save();
                this.SetNotification("Saved");

            }
        }

        private void SetNotification(string p)
        {
            if(FormLoaded)
            ((FormMain)this.Owner).SetNotification(p); 
        }

        private void rtxbxCookie_TextChanged(object sender, EventArgs e)
        {

            SettingsManager.SetCookieString(rtxbxCookie.Text);
        }

        private void Rtxbxuseragent_TextChanged(object sender, EventArgs e)
        {
            if (Rtxbxuseragent.Text.Length < 3)
                return;
                SettingsManager.SetUserAgentString(Rtxbxuseragent.Text);
            
        }

       

        private void lnklblLoadUserAgent_Click(object sender, EventArgs e)
        {
            
        }

        private void lnklblLoadUserAgent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserAgentSelectorForm s = new UserAgentSelectorForm();
            if (s.ShowDialog() == DialogResult.OK)
                Rtxbxuseragent.Text = s.Name;
        }

        private void checkBoxCookie_CheckedChanged(object sender, EventArgs e)
        {
            global::Web_Gunners.Properties.Settings.Default.use_cookie = checkBoxCookie.Checked;
        }

        private void lnklblLoadAuth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Inputs.FrmAuthGetter f = new Forms.Inputs.FrmAuthGetter(rtxbxAuth.Text);
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtxbxAuth.Text = f.Name;
            else
                chkbx_Authorization.Checked = false;
        }

        private void chkbx_Authorization_CheckedChanged(object sender, EventArgs e)
        {
            if (rtxbxAuth.Text == "")
                lnklblLoadAuth_LinkClicked(null,null);
            lnklblLoadAuth.Enabled = rtxbxAuth.Enabled = chkbx_Authorization.Checked;
        }

        private void rtxbxAuth_TextChanged(object sender, EventArgs e)
        {
            global::Web_Gunners.Properties.Settings.Default.Auth_String = rtxbxAuth.Text;
        }
 

        private void linkLabelClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((FormMain)this.Owner).RemoveCurrentTab(); 

        }

        private void chkbxProxy_CheckedChanged(object sender, EventArgs e)
        {
            txbxHost.Enabled = nmPort.Enabled = chkbxProxy.Checked;
        }

        private void nmPort_ValueChanged(object sender, EventArgs e)
        {
            ChangeProxy();
        }

        private void ChangeProxy()
        {
            string prox = txbxHost.Text.Trim() + ":" + nmPort.Value.ToString();
            if (prox.IsValidProxyString())
            {
                global::Web_Gunners.Properties.Settings.Default.Proxy_String = prox;
                SetNotification("Valid Proxy");
            }
        }

        private void txbxHost_TextChanged(object sender, EventArgs e)
        {
            ChangeProxy();
        }

        private void checkBox_Isolated_window_CheckedChanged_1(object sender, EventArgs e)
        {
            global::Web_Gunners.Properties.Settings.Default.Use_ProxyInIsolatedWindow = checkBox_Isolated_window.Checked;
        }

        private void ColorPanel_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
                ColorPanel.BackColor = c.Color;
        }

        private void ColorPanel_BackColorChanged(object sender, EventArgs e)
        {
            global::Web_Gunners.Properties.Settings.Default.TextSearchColor = ColorPanel.ForeColor=ColorPanel.BackColor;
        }
    }
}
