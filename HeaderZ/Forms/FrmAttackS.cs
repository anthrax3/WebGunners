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
    public partial class FrmAttacks : Form
    {
        public __HTTTPAttack_ __Selected_Attack = new __HTTTPAttack_();
        public List<__HTTTPAttack_> __Attacks_List = new List<__HTTTPAttack_>();
        public int TheIndex = 0;
        public bool showned = false;

        public FrmAttacks()
        {
            InitializeComponent();
        }
   
        public FrmAttacks(List<__HTTTPAttack_> AttaksListp,string id="",int im =-1)
        {
            int selind = -1;
            InitializeComponent(); 
            __Attacks_List.Clear(); 

            foreach (__HTTTPAttack_ h in AttaksListp)
                __Attacks_List.Add(__HTTTPAttack_.Copy(h));
             
            /// setting up grid
            SetUpGrid();
            SetGridSize();
            dataGridView1.Rows.Clear();
            FillGrid(this.__Attacks_List);
            
            int AskedIndex = GetIndexOfAttack(id);
            if (id == "")
                selind = im;

            if (__Attacks_List.Count > 0)
            {
                __Selected_Attack = __HTTTPAttack_.Copy(__Attacks_List[0]);
                LoadDetailsOfCurrentAttack();
            }
            SelectThisIndex(-1);
            txbxSearchReQuest_TextChanged(null, null);
            txbxSearchResponse_TextChanged(null, null);
        }

        public void SelectThisIndex(int p)
        {
            if (p == -1)
                p++;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                dataGridView1.Rows[i].Selected = (i == p);

            this.TheIndex = p;
        }

        public int GetIndexOfAttack(string id)
        {
            int c = 0; 
            foreach (__HTTTPAttack_ h in this.__Attacks_List) 
            {   
                if (h.Id == id)
                    return  c;
                c++;
            }
            return -1;
        }

        private void SetUpGrid()
        {
            dataGridView1.Columns.Add("0", "Id");
            dataGridView1.Columns.Add("1", "Url ");
            dataGridView1.Columns.Add("2", "Statue");
            dataGridView1.Columns.Add("3", "Method");
            dataGridView1.Columns.Add("4", "Reflected ");
            dataGridView1.Columns.Add("5", "PID");
            dataGridView1.Columns.Add("6", "Sender");

            this.GridHasSetUp = true;

        }
        private void SetGridSize()
        {
           
                dataGridView1.Columns[0].Width = groupBox_Requests.Size.Width / 12;//380;
                dataGridView1.Columns[1].Width = (groupBox_Requests.Size.Width * 5 / 16 > 200) ? 100 : groupBox_Requests.Size.Width * 5 / 16;//380;
                dataGridView1.Columns[2].Width = groupBox_Requests.Size.Width / 10;//380;
                dataGridView1.Columns[3].Width = groupBox_Requests.Size.Width / 10;//380;
                dataGridView1.Columns[4].Width = groupBox_Requests.Size.Width / 8;//380;
                dataGridView1.Columns[5].Width = groupBox_Requests.Size.Width / 10;//380;
                dataGridView1.Columns[6].Width = groupBox_Requests.Size.Width / 10;//380;


            
        }
        private void LoadDetailsOfCurrentAttack()
        {
            string page = __Selected_Attack._Url.GetPage();
                rtxbxRequest.Text = __Selected_Attack._Method + " " +(( page=="")?"/":page)+"HTTP/1.1"+ Environment.NewLine;
            rtxbxRequest.Text += "Host: " + __Selected_Attack._Url.GetHost() + Environment.NewLine;
            if (__Selected_Attack != null)
            {
                if (this.__Selected_Attack.Request_Headers != null)
                {
                    foreach (KeyValuePair<string, string> kv in __Selected_Attack.Request_Headers)
                        rtxbxRequest.Text += (kv.Key + ": " + kv.Value + Environment.NewLine);

                }
                if (__Selected_Attack.Response_Headers != null)
                {
                    RTXBXResponse.Text = "";
                    foreach (KeyValuePair<string, string> kv in __Selected_Attack.Response_Headers)
                        RTXBXResponse.Text += (kv.Key + ": " + kv.Value + Environment.NewLine);

                }
            }
            lnklblUrl.Text = __Selected_Attack._Url;
            this.SetDocumentText(__Selected_Attack.DocumentText);
            RTXBXResponse.Text += (Environment.NewLine + Environment.NewLine + __Selected_Attack.DocumentText);
            txbxSearchReQuest.Text = txbxSearchResponse.Text = this.__Selected_Attack.Payload;
        }

        private void SetDocumentText(string p)
        {
            if(this.FormLoaded)
            webBrowser1.DocumentText = p;
        }

        private void ColorThisWord(string p,ref RichTextBox r )
        
        {

            r.Find(p);
            return;
            string f = r.Text;
            r.Text = "";
            Color s = r.SelectionColor;
            foreach(string w in f.Split(new char [] {' '}))
            {
                r.SelectionColor = s;
                if(w.ToLower()==p.ToLower())
                {

                    int length = r.TextLength;  // at end of text
                    r.AppendText(w+" ");
                    r.SelectionStart = length;
                    r.SelectionLength = p.Length;
                    r.SelectionColor = Color.Black;
                }
                else
                {

                    int length = r.TextLength;  // at end of text
                    r.AppendText(w+" ");
                    r.SelectionStart = length;
                    r.SelectionLength = p.Length;
                    r.SelectionColor = Color.Red;
                }

            }


            return;
            int length2 = RTXBXResponse.TextLength;  // at end of text
            RTXBXResponse.AppendText(p);
            RTXBXResponse.SelectionStart = length2;
            RTXBXResponse.SelectionLength = p.Length;
            RTXBXResponse.SelectionColor = Color.Red;
        }

        private void linkLabelSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void DocumentDisplayer_Load(object sender, EventArgs e)
        {
            FormLoaded = true;
            SetGridSize();
            this.showned = true;
            dataGridView1.Columns[1].Width=600;
        }

        private void lblCookie_TextChanged(object sender, EventArgs e)
        {
            bool hide = false;
            if ((sender as Label).Text.Contains(":") == false)
                hide = true;
            else
            {
                string x = (sender as Label).Text;
                string[] sepd = x.Split(new char []{':'});
                if (sepd[1].Trim().Length < 1)
                    hide = true;
                else hide = false;

            }
            (sender as Label).Visible = !hide;
        }
          
        private void btnExpHtml_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void rtxbxRequest_TextChanged(object sender, EventArgs e)
        {
            lnklblExport.Enabled =( RTXBXResponse.Lines.Length > 2);
            lnklbl_SEndeToRepeater.Enabled = (rtxbxRequest.Lines.Length > 2);
        }

        private void groupBox_Requests_VisibleChanged(object sender, EventArgs e)
        {
            if(groupBox_Requests.Visible)
                panelCenter.Location=new Point(3, 144);
            else
                panelCenter.Location = new Point(3, 0);


        }

        private void lnklBL_Close_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.showned = false;
            ((FormMain)this.Owner).RemoveCurrentTab(); 
            

        }

        private void groupBox_Requests_SizeChanged(object sender, EventArgs e)
        {
            SetGridSize();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {    
                 
            if (dataGridView1.CurrentCell.RowIndex < 0)
                return;
            
            __Selected_Attack=__HTTTPAttack_.Copy(__Attacks_List[dataGridView1.CurrentCell.RowIndex]);
            LoadDetailsOfCurrentAttack();
     
            }
            catch { }

        }

       private void CheckNewAttacks()
        {
            int co = dataGridView1.CurrentCell.RowIndex;
            FillGrid(__Attacks_List);
            SelectThisIndex(co);
       }

        private void FillGrid(List<__HTTTPAttack_> AttacksList)
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            if (TheIndex == -1)
                TheIndex++;

            foreach (__HTTTPAttack_ h in this.__Attacks_List)
            {
                dataGridView1.Rows.Add(i+1, h._Url, h.statueCode, h._Method, h.infected, h.Id,h.owner);
                dataGridView1.Rows[i].Selected = (i==TheIndex);
                i++;
            }  
        }
         

        internal int getGridIndex()
        {
            try { return dataGridView1.CurrentCell.RowIndex; }
            catch { return -1; }
        }

        
        internal void AddNewRecord(__HTTTPAttack_ h)
        {
            this.__Attacks_List.Add(__HTTTPAttack_.Copy(h));
            if (this.GridHasSetUp == false)
                this.SetUpGrid();
            dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, h._Url, h.statueCode, h._Method, h.infected, h.Id, h.owner);
           
        }

        public bool GridHasSetUp = false;

        private void txbxSearchResponse_TextChanged(object sender, EventArgs e)
        {
            RTXBXResponse.HighlightNo(Color.Black);
            RTXBXResponse.HighlightText(this.txbxSearchResponse.Text, Color.Red);

        }

        private void txbxSearchReQuest_TextChanged(object sender, EventArgs e)
        {
            rtxbxRequest.HighlightNo(Color.Black);

            rtxbxRequest.HighlightText(this.txbxSearchReQuest.Text, Color.Red);

        }

        private void FrmAttacks_SizeChanged(object sender, EventArgs e)
        {
            panelCenter.Location = new Point(3, groupBox_Requests.Size.Height+4);
            panelRequest.Location = new Point(3, 22);
            panelRequest.Size = new Size(panelCenter.Size.Width / 2 , panelCenter.Size.Height - 42);
            panelResponse.Location = new Point(panelRequest.Size.Width+5,22);
            panelResponse.Size = new Size(panelCenter.Size.Width / 2 , panelCenter.Size.Height - 42);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Save As";
                s.FileName = this.__Selected_Attack._Url.GetHost() + "  .html";

                if (s.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(s.FileName, this.__Selected_Attack.DocumentText);
                    label_notf.Text = "Saved to " + s.FileName;
                }
            }
            catch (Exception exc) { label_notf.Text = exc.Message; }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FormMain parent = (FormMain)this.Owner;
            parent.LoadRepeaterTab(this.__Selected_Attack);
            label_notf.Text = "Sent To repeater";
        }

        public bool FormLoaded = false;
    }
}
