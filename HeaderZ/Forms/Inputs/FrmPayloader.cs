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
    public partial class FrmPayloader : Form
    {
        public FrmPayloader()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = "";

            switch(comboBox1.SelectedIndex)
            {
                case 0: txbx.Text="http://a7a.me"; break;
                case 1: txbx.Text = "2014"; break;
                case 2: txbx.Text = "41.41.41.41"; break;
                case 3: txbx.Text = "FE80::0202:B3FF:FE1E:8329"; break;
                case 4: txbx.Text = "fill@empty.pok"; break;
                case 5: txbx.Text = "this_is_random"; break;
                case 6: txbx.Text = "009141478789137"; break;
                case 7: txbx.Text = "+1-212-9876543"; break;
                case 8: txbx.Text = "<a href='s' >mylink</a>"; break;
                case 9: txbx.Text = "alert('vuln');"; break;
                case 10: txbx.Text = "vuln.host.net"; break;
                case 11: txbx.Text = "12345"; break;
            }
        }

        private void FrmPayloader_Load(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            comboBox1.SelectedIndex = 0;
        }

        private void rBENabled_CheckedChanged(object sender, EventArgs e)
        {
            btnOk.Enabled=(RbDisabled.Checked)?true:( (txbx.Text.Length>1)?true:false  );
            txbx.Enabled = comboBox1.Enabled = rBENabled.Checked;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (rBENabled.Checked)
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void txbx_TextChanged(object sender, EventArgs e)
        {
            this.Name = txbx.Text;
        }
    }
}
