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
    public partial class FrmMRCode : Form
    {
        public FrmMRCode()
        {
            InitializeComponent();
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            string outed = "";

            if (Base64Decode.Checked)
                outed = MisterCoder.Base64Decode(richTextBox_String.Text);

            else if (Base64Encode.Checked)
                outed = MisterCoder.Base64Encode(richTextBox_String.Text);

            else if (URLEncode.Checked)
                outed = MisterCoder.UrlEncode(richTextBox_String.Text);

            else if (URLDecode.Checked)
                outed = MisterCoder.Base64Decode(richTextBox_String.Text);

            else if (HTMLEncode.Checked)
                outed = MisterCoder.HtmlEncode(richTextBox_String.Text);

            else if (HTMLDecode.Checked)
                outed = MisterCoder.HtmlDecode(richTextBox_String.Text);
            else if (FromAscii.Checked) 
            {
                string sep = (comboBox_FromAscii.SelectedIndex==0)?" ":comboBox_FromAscii.SelectedItem.ToString();
                if (richTextBox_String.Text.Contains(sep))
                {
                    outed = MisterCoder.FromAscci(richTextBox_String.Text, sep);
                }
                else
                    this.Notify("Separator not found on text , plz change it ");
                }
            else if (ToAscii.Checked)
                { 
                    string  sep="";
                    if (comboBoxToAscii.SelectedItem != null)
                        sep = (comboBoxToAscii.SelectedIndex == 0) ? " " : comboBoxToAscii.SelectedItem.ToString().Trim();
                    if (checkBox_Use_separatorToAscii.Checked == false)
                        sep = "";
                    outed = MisterCoder.ToAscii(richTextBox_String.Text,sep);
                }

            richTextBox_Result.Text = outed;
            this.Notify("Done");
        }

        private void Notify(string p)
        {
            ((FormMain)this.Owner).SetNotification(p); 

        }

        private void btnEnc_Click(object sender, EventArgs e)
        {
            richTextBox_String.Text = MisterCoder.Base64Encode(richTextBox_Result.Text);

        }

        private void richTextBox_Dec_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void richTextBox_Enc_TextChanged(object sender, EventArgs e)
        {
            btnProc.Enabled = richTextBox_String.Text.Length > 1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //string x = richTextBox_String.Text;
            //richTextBox_String.Text="";
            //for (int i = x.Length-1; i >= 0; i--)
              //  richTextBox_String.Text += x[i];
            richTextBox_String.Text = richTextBox_String.Text.Revers();
        }

        private void lnklBL_Close_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((FormMain)this.Owner).RemoveCurrentTab(); 

        }

        private void linkLabel_Rev_Result_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            richTextBox_Result.Text = richTextBox_Result.Text.Revers();

        }

        private void CopyOutput_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(richTextBox_Result.Text);
        }

        private void CopyInput_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(richTextBox_String.Text);

        }

        private void buttonEx_Click(object sender, EventArgs e)
        {
            string i = richTextBox_Result.Text;
            string i2 = richTextBox_String.Text;

            richTextBox_Result.Text = i2;
            richTextBox_String.Text = i;
        }

        private void Base64_CheckedChanged(object sender, EventArgs e)
        {
            btnProc.Text=(Base64Encode.Checked || URLEncode.Checked || HTMLEncode.Checked || ToAscii.Checked)?"Encode":"Decode";
        }

        private void linkLabelLoadFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenFileDialog o = new OpenFileDialog();
                if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    richTextBox_String.Text = System.IO.File.ReadAllText(o.FileName);
                    FormMain parent = (FormMain)this.Owner;
                    parent.SetNotification("Loaded " + o.FileName);
                }
            }
            catch { }
        }

        private void Save_Clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                SaveFileDialog o = new SaveFileDialog();
                if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.File.WriteAllText(o.FileName, richTextBox_Result.Text);
                    FormMain parent = (FormMain)this.Owner;
                    parent.SetNotification("Saved " + o.FileName);
                }
            }
            catch { }  
        }

        private void Ascii_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Use_separatorToAscii.Enabled = ToAscii.Checked;
        }

        private void checkBox_Use_separator_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxToAscii.Enabled = checkBox_Use_separatorToAscii.Checked;
        }

        private void FrmMRCode_Load(object sender, EventArgs e)
        {
            comboBox_FromAscii.SelectedIndex = 1;
        }

        private void FromAscii_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_FromAscii.Enabled = FromAscii.Checked;
        }
    }
}
