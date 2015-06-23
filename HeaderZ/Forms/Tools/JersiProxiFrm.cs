using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Gunners.Forms.Tools
{
    public partial class JersiProxiFrm : Form
    {
        public JersiProxiFrm(bool closebtn=true)
        {
            InitializeComponent();
            btn_close.Visible = closebtn;
         
        }

        private void Rb_custom_CheckedChanged(object sender, EventArgs e)
        {
            txbxIp.Enabled = NmPort.Enabled = rb_Custom.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblChange.Text = lblCPS.Text = "...";
            this.MaximumSize = MinimumSize = Size;
            EnableOkButtonOrDis();
            CurrentProxyStatue();
            Load_proxy();

        }
        public string TrimProxyString(string defp)
        {

            if (defp[defp.Length - 1] == '/')
                defp = defp.Substring(0, defp.Length - 1);
            bool passedfirstdot = false;
            string org_prox = "";
            foreach (char c in defp)
            {
                if (passedfirstdot && c != '/')
                {
                    org_prox += c.ToString();
                }
                else if (c == '/' || (c >= '0' && c <= '9'))
                    passedfirstdot = true;
            }
            if (org_prox.Contains(":") == false)
                return defp;
            return org_prox;
        }
        private void Load_proxy()
        {
            try
            {
                RbNone.Checked = true;
                string prox_str = GetCurrentProxyString();
                string org_prox = TrimProxyString(prox_str);
                if (org_prox.Contains(":") == false)
                    return;
                rb_Custom.Checked = true;

                string[] splidbycolon = org_prox.Split(new char[] { ':' });
                txbxIp.Text = splidbycolon[0];
                NmPort.Value = decimal.Parse(splidbycolon[1]);

            }
            catch
            {
                MessageBox.Show("Could not load current proxy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txbxIp_TextChanged(object sender, EventArgs e)
        {
            EnableOkButtonOrDis();
            lblChange.Text = "...";
        }

        private void EnableOkButtonOrDis()
        {
            btnOk.Enabled = (RbNone.Checked) ? true : Regex.Match(txbxIp.Text, @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}").Success;

        }

        private void rb_Custom_CheckedChanged(object sender, EventArgs e)
        {
            EnableOkButtonOrDis();
            txbxIp.Enabled = NmPort.Enabled = rb_Custom.Checked;
        }

        private void RbNone_CheckedChanged(object sender, EventArgs e)
        {
            EnableOkButtonOrDis();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (RbNone.Checked)
                    ProxyHandler.setProxy("", false);
                else
                    ProxyHandler.setProxy(txbxIp.Text + ":" + NmPort.Value.ToString(), true);
                lblChange.Text = ("Changed");

            }
            catch (Exception ss) { MessageBox.Show(ss.Message, "Error"); lblChange.Text = ("Error"); }
            CurrentProxyStatue();
        }
         

        private void loadProfile(string p)
        {
            if (p.Contains(":") == false)
                return;
            string[] sepd = p.Split(new char[] { ':' });
            txbxIp.Text = sepd[0];

            if (sepd.Length < 2)
                return;
            int hash = 0;
            bool isrealnum = int.TryParse(sepd[1], out hash);
            if (isrealnum)
                NmPort.Value = int.Parse(sepd[1]);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CurrentProxyStatue();
            this.Close();
        }

        private void CurrentProxyStatue()
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");

            // Obtain the 'Proxy' of the  Default browser.  
            IWebProxy proxy = myWebRequest.Proxy;
            // Print the Proxy Url to the console.
            if (proxy != null)
            {
                string prx = TrimProxyString(proxy.GetProxy(myWebRequest.RequestUri).ToString());
                string res = string.Format("Proxy: {0}", prx);
                lblCPS.Text = "Current  " + res;
                if (res.Contains("micro"))
                    lblCPS.Text = "No proxy";

            }
            else
            {
                lblCPS.Text = "No proxy";
            }
        }

        private string GetCurrentProxyString()
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");

            // Obtain the 'Proxy' of the  Default browser.  
            IWebProxy proxy = myWebRequest.Proxy;
            // Print the Proxy Url to the console.
            if (proxy != null)
            {
                string res = proxy.GetProxy(myWebRequest.RequestUri).ToString();//string.Format("Proxy: {0}", );
                if (res.Contains("micro"))
                    return "No proxy";
                else return res;
            }
            else
            {
                return "No proxy";
            }
        }

        private void lblChange_TextChanged(object sender, EventArgs e)
        {
            lblChange.ForeColor = (lblChange.Text.Contains("changed") == false) ? Color.LimeGreen : Color.Red;
        }
    }
}
