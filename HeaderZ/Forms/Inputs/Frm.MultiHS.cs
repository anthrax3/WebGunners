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
    public partial class MultiHSFrm : Form
    {
        public MultiHSFrm()
        {
            InitializeComponent();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public MultiHSFrm(List<string> multi_headers)
        {

            InitializeComponent();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         foreach(Control cn in panelMain.Controls)
         {
             if(cn is CheckBox)
             {
                 if (multi_headers.Contains((cn as CheckBox).Text))
                     (cn as CheckBox).Checked = true;
             }
         }

        }
        public List<string> _Headers = new List<string>();
        private void button_select_all_Click(object sender, EventArgs e)
        {
            foreach ( Control cnt in panelMain.Controls)
            {
                if (cnt is CheckBox)
                    (cnt as CheckBox).Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control cnt in panelMain.Controls)
            {
                if (cnt is CheckBox)
                    (cnt as CheckBox).Checked = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._Headers.Clear();
            foreach(Control cv in panelMain.Controls)
            {
                if (cv is  CheckBox)
                {
                    if ((cv as CheckBox).Checked == false)
                        continue;
                    if(this._Headers.Contains((cv as CheckBox).Text))
                        continue;
                    if ((cv as CheckBox).Text == "")
                        continue;
                    this._Headers.Add((cv as CheckBox).Text.Trim());
                        
                        
                }
             
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Chedkd_ALL___CheckedChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = false;
            foreach (Control c in panelMain.Controls)
            
                if ((c is CheckBox))
                    if ((c as CheckBox).Checked)
                    { btnOK.Enabled = true; return; }
            
        }

        private void txbx_Search_TextChanged(object sender, EventArgs e)
        {
            string patr = txbx_Search.Text.TrimStart();
            patr = patr.Trim();

            foreach (Control c in this.panelMain.Controls)
                if (c is CheckBox)
                {
                    if (patr == "")
                        c.BackColor = Color.FromArgb(64, 64, 64);
                    else if (c.Text.ToLower().Contains(patr.ToLower()))

                        c.BackColor = Color.FromArgb(64, 164, 64);

                    else
                        c.BackColor = Color.FromArgb(64, 64, 64);
                }
        }
    }
}
