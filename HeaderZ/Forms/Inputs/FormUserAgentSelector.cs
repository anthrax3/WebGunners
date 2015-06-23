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
    public partial class UserAgentSelectorForm : Form
    {
        public UserAgentSelectorForm()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
                return;
            if (comboBox1.SelectedItem == null)
                return;
            this.Name = comboBox1.SelectedItem.ToString();
        }

        private void UserAgentSelectorForm_Load(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count > 1)
                comboBox1.SelectedIndex = 0;
           
        }
    }
}
