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
    public partial class FrmXsser : Form
    { 
        public List<StrBool> Get_Pars = new List<StrBool>();
        public FrmXsser()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            string inj="";
            __HTTTPAttack_ h = new __HTTTPAttack_();
            if (checkBoxGet.Checked)
            {
                h.ParameterizeGET(textBox1.Text);
                foreach (StrBool s in this.Get_Pars)
                    if (s.statue_)
                        h.AddGetparameter(s.string_, s.string_ + inj);
                h.GET_XSSER();
                MessageBox.Show(h.GetXsserSummary());
                if (h.Succeeded)
                    this.setNotification("Succeeeded");

            }
            else
            {
                // post


            }
        }

        private void setNotification(string p)
        {
            ((FormMain)this.Owner).SetNotification(p);
        }

        private void FrmXsser_Load(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "http://localhost/vuln/xss.php?c=1&p=2";

            formloaded = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ConstructParameters();
        }

        private void ConstructParameters()
        {
            if (checkBoxGet.Checked)
            {
                ConstructGet();
            }
            else
            {


            }
        }

        private void ConstructGet()
        {
            bool AllowMas_Ass = checkBox_MassAssgi.Checked;
            this.checkedListBox_GET_Pars.Items.Clear();
            
            string[] Returned_pars = __HTTTPAttack_.GetParamers(textBox1.Text);
            List<StrBool> tempDic = new List<StrBool>();
            if(Returned_pars!=null)
                if (Returned_pars.Length > 0)
                {
                    foreach (string i in Returned_pars)
                    {
                        bool found = false;
                        string s = i.Variable();
                        if (s == "")
                            continue;

                        StrBool curentObj = new StrBool(s, this.GetOldValue(s));
                        foreach (StrBool sb in tempDic)
                            if (sb.string_ == curentObj.string_)
                                found = true;

                        if (!found || AllowMas_Ass)
                            tempDic.Add(curentObj);
                    }
                }
            this.Get_Pars.Clear();
             foreach (StrBool s in tempDic)
                this.Get_Pars.Add(new StrBool(s.string_, GetOldValue(s.string_)));

            // this.CurrentlyAding = true;
             Fill_GET_ListBox(); 
            //this.CurrentlyAding = false;


        }

        private void Fill_GET_ListBox()
        {
            checkedListBox_GET_Pars.Items.Clear();
            foreach(StrBool s in this.Get_Pars)
                checkedListBox_GET_Pars.Items.Add(s.string_,s.statue_);
        }

        private bool GetOldValue(string s)
        {
            foreach (StrBool kb in this.Get_Pars)
                if (kb.string_ == s)
                    return kb.statue_;
            return true;

        }

        private void checkedListBox_GET_Pars_SelectedIndexChanged(object sender, EventArgs e)
        {
            GET_CheckedMembersChanged();
        }
        private void GET_CheckedMembersChanged()
        {

            if (!this.formloaded || CurrentlyAding)
                return;

           // CurrentlyAding = true;
 
                for (int i = 0; i < this.Get_Pars.Count; i++)
                    Get_Pars[i].statue_ = false;

                foreach (int i in checkedListBox_GET_Pars.CheckedIndices)
                    if (Get_Pars.Count > i)
                        Get_Pars[i].statue_ = true;
            //CurrentlyAding = false;
        }

        private void checkedListBox_GET_Pars_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            GET_CheckedMembersChanged();
        }

        public bool formloaded = false;

        public bool CurrentlyAding { get; set; }

        private void checkBox_MassAssgi_CheckedChanged(object sender, EventArgs e)
        {
            ConstructParameters();
        }

        private void checkBoxGet_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxPOST.Checked = !checkBoxGet.Checked;
        }

        private void checkBoxPOST_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxGet.Checked = !checkBoxPOST.Checked;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text="";

            foreach (StrBool s in this.Get_Pars)
                richTextBox1.Text += (s.string_ + ":" + s.statue_.ToString() + Environment.NewLine);
        }
    }

    class human
    {
        private string name;
        private int age;
        public string GetName()
        {
            return name;

        }
        public void SetName(string s)
        {
            name = s;
        }
        public int getAge()
        {
            return age;
        }
        public void SetAge(int i)
        {
            age = i;
        }
    }
    public class  subclas  // extends name 
    {
        private string altergo;
        public string GetName()
        {
            return altergo;

        }
        public void SetName(string s)
        {
            altergo = s;
        }
        public override string ToString()
        {
            return altergo;
        }

    }
}
