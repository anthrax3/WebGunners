using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Gunners.Forms.Inputs
{
    public partial class FrmAuthGetter : Form
    {
        public FrmAuthGetter(string s = "")
        {

            InitializeComponent();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            if (s.Contains("Basic"))
            { // Basic YWRtaW46YTdh
                if (!s.Contains(" "))
                    return;
                string[] sepdbysp = s.Split(new char []{' '});
                string encd = sepdbysp[sepdbysp.Length - 1];
                string decd = MisterCoder.Base64Decode(encd);
                // admin:55
                if(!decd.Contains(":"))
                {
                    txbxUsername.Text = decd; return;
                }
                string[] sepdbycolon = decd.Split(new char []{':'});
                txbxUsername.Text = sepdbycolon[0];
                txbxPass.Text = sepdbycolon[1];
                cmbxMethod.SelectedIndex = 0;
            }
            else if (s.Contains("%Digest"))
            { //%Digest%(%a7a%:%fuck%)
                //123456789
                string[] sepdbyperc = s.Split(new char[] { '%' });
                txbxUsername.Text = sepdbyperc[3];
                txbxPass.Text = sepdbyperc[5];
                cmbxMethod.SelectedIndex = 1;
            }
        }

        private void FrmAuthGetter_Load(object sender, EventArgs e)
        { 
            if(cmbxMethod.SelectedIndex<0)
                this.cmbxMethod.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            if (cmbxMethod.SelectedIndex == 0)
                this.Name = "Basic "+MisterCoder.Base64Encode(txbxUsername.Text + ":" + txbxPass.Text);
            else
                this.Name = "%Digest%(%" + txbxUsername.Text + "%:%" + txbxPass.Text + "%)";
            this.Close();

        }

        private void txbxUsername_TextChanged(object sender, EventArgs e)
        {
            ActiveButton();
        }

        private void ActiveButton()
        {
            btnOK.Enabled=(txbxPass.Text.Trim()!="" && txbxUsername.Text.Trim()!="" && cmbxMethod.SelectedIndex>=0);
        }

        private void txbxPass_TextChanged(object sender, EventArgs e)
        {
            ActiveButton();

        }

        private void cmbxMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveButton();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
