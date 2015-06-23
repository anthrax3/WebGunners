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
    public partial class FrmAttackPrefix : Form
    {
        public AttackDetails Curent_atack_Dtals = new AttackDetails();
        public FrmAttackPrefix()
        {
            InitializeComponent();
        }
        public FrmAttackPrefix(AttackDetails ad)
        {
            InitializeComponent();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Curent_atack_Dtals = ad;
            if (Curent_atack_Dtals == null)
                Curent_atack_Dtals = new AttackDetails();
            checkBox_Injection.Checked = Curent_atack_Dtals.UseAdvInjection;
             rtxbx_Injection.Text = Curent_atack_Dtals.Payload;
            rtxbxUserAgent.Text = Curent_atack_Dtals.UserAgentString;
        }
        public FrmAttackPrefix(bool x)
        {
            Curent_atack_Dtals = new AttackDetails();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        
        private void rtxbxUserAgent_TextChanged(object sender, EventArgs e)
        {
            Curent_atack_Dtals.UserAgentString = rtxbxUserAgent.Text;
        }

        private void rtxbx_Injection_TextChanged(object sender, EventArgs e)
        {
            if (checkBox_Injection.Checked)
                Curent_atack_Dtals.Payload = rtxbx_Injection.Text;
        }

        private void checkBox_Injection_CheckedChanged(object sender, EventArgs e)
        {
            rtxbx_Injection.Enabled = Curent_atack_Dtals.UseAdvInjection = checkBox_Injection.Checked;
        }

        private void FrmAttackDetails_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.MinimumSize = this.Size;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Curent_atack_Dtals.timout = int.Parse(numericUpDown1.Value.ToString());
        }
    }
}
