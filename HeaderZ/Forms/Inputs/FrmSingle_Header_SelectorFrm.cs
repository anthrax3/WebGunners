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
    public partial class HeaderSelectorFrm : Form
    {
        bool _form_loaded = false;
        bool _hascustval = false;
        public HeaderSelectorFrm(string x="")
        {
            InitializeComponent();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;

            if (x != "" && x != "custom")
            {
                textBox1.Text = x;
                _hascustval = true;
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
                comboBox1.SelectedIndex = 0;
            }
            //if ( !comboBox1.Items.Contains(x) && x != "")
            //{ checkBox1.Checked = true; textBox1.Text = x; }
            //return;
            //if (x != "" && x.ToLower() != "custom")
            //{
            //    if (comboBox1.Items.Count > 0)
            //        if (comboBox1.Items.Contains(x))
            //        {
            //            int i = 0;
            //            checkBox1.Checked = false;
            //            comboBox1.Visible = true;
            //            foreach (string i0 in comboBox1.Items)
            //                if (i0.Trim() == x.Trim())
            //                {
            //                    if (i < comboBox1.Items.Count)
            //                        comboBox1.SelectedIndex = i;
            //                    break;
            //                }
            //                else i++;

            //        }
            //    textBox1.Text = x;
            //    _hascustval = true;
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Name = textBox1.Text;
           button1.Enabled = (comboBox1.Visible == false)?(textBox1.Text != ""):(comboBox1.SelectedIndex >= 0);
           if (textBox1.Text == "custom")
           {
               checkBox1.Checked = false;
               comboBox1.SelectedIndex = 0;
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (_form_loaded)
                textBox1.Text = comboBox1.SelectedItem.ToString();
            button1.Enabled = (comboBox1.Visible == false) ? (textBox1.Text != "") : (comboBox1.SelectedIndex >= 0);
        }

        private void HeaderSelectorFrm_Load(object sender, EventArgs e)
        {
            _form_loaded = true;
            if (_hascustval) 
                return;
            if(comboBox1.SelectedIndex==-1 && comboBox1.Items.Count>0 && textBox1.Text!="" && textBox1.Text.ToLower()!="custom")
            comboBox1.SelectedIndex = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            comboBox1.Visible = !checkBox1.Checked;
            button1.Enabled = (comboBox1.Visible == false) ? (textBox1.Text != "") : (comboBox1.SelectedIndex >= 0);


        }
    }
}
