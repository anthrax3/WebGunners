using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Gunners.Forms.Tools
{
    public partial class FrmScriptBoy : Form
    {
        ScriptAnalysiz Original_document = new ScriptAnalysiz();
        ScriptAnalysiz Last_documetn = new ScriptAnalysiz();

        public FrmScriptBoy(string url ="")
        {
            InitializeComponent();
            this.textBox1.Text = url;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(RbFile.Checked)
                 LoadDocumentFromFile();    
            else 
                loadOriginalDocument(); 
           /// AnalyzOrignal
           /// 

            ScriptAnalysiz a = AnalyzlDocument(Original_document.Document);
            this.Original_document.Scripts = a.Scripts;
            this.Original_document.InLinkScript = a.InLinkScript;
            CheckResults();
        }
         

        private void LoadDocumentFromFile()
        {
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.rtxbx_document.Text=this.Original_document.Document = File.ReadAllText(textBox1.Text);
                }

                catch
                { this.setNotification("Falied to load File"); }
            }

        }
        private void setNotification(string p)
        {
            labelNotf.Text=p;
        }

        

        private ScriptAnalysiz LoadNewDoc(string Coming_doc)
        {
            try
            {
                int script_link = 0;
                int script = 0;

                string new_cod = "";
                HtmlWeb hw = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(Coming_doc);

                foreach (HtmlNode n in doc.DocumentNode.ChildNodes)
                {
                    if (n.Name == "script")
                    {
                        script++;
                        if (n.InnerText.Trim() == "")
                        {
                            script_link++;

                            string link = n.GetAttributeValue("src", "");//Attributes["scr"].Value;
                            new_cod += "<!-- Generated Script(" + script_link.ToString() + ") Headers.Scriptor -->" + Environment.NewLine;
                            new_cod += "<script>" + __HTTTPAttack_.LoadScriptSource(link) + "<script>" + Environment.NewLine;
                            continue;
                        }
                    }

                    new_cod += (Environment.NewLine + n.OuterHtml);
                }


                tabControl1.SelectedIndex = 1;
                return new ScriptAnalysiz(new_cod, script, script_link);
            }
            catch { return new ScriptAnalysiz(); }
        }
        private ScriptAnalysiz AnalyzlDocument(string coming_doc,bool change=false)

        {
            try
            {
                List<string> Formler = new List<string>();
                int script_link = 0;
                int script = 0;
                string doc2_ = "";

                HtmlWeb hw = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(coming_doc);


                foreach (HtmlNode n in doc.DocumentNode.ChildNodes)
                {
                    if (n.Name == "script")
                        script++;
                    if (n.InnerText.Trim() == "")
                        script_link++;
                }
                this.Original_document.Scripts= script;
                this.Original_document.InLinkScript = script_link;
                return new ScriptAnalysiz(((!change) ? coming_doc : doc2_), script, script_link);
            }
            catch { return new ScriptAnalysiz(); }
        }

        private 
          bool  loadOriginalDocument()
        {
            __HTTTPAttack_ h = new __HTTTPAttack_(textBox1.Text);
            h.LoadFromSettings(false);
            h.SendRequest();
            this.rtxbx_document .Text= this.Original_document.Document=h.DocumentText;
            ScriptAnalysiz a =  AnalyzlDocument(rtxbx_document.Text);

            return h.Succeeded;
        }

        private void txbxSearchpatern_TextChanged(object sender, EventArgs e)
        {
            timerTicks = 0;
            timer1.Start();
        }
        private void ColorText()
        {
            int m = 0;
            if(tabControl1.SelectedIndex==0)
            {

                rtxbx_document.HighlightNo(Color.Black);
              m=  rtxbx_document.HighlightText(this.txbxSearchpatern.Text, Color.LimeGreen);
            }
            else 
                if (tabControl1.SelectedIndex==1)
                {

                    rtxbx_document_new.HighlightNo(Color.Black);
                    m = rtxbx_document_new.HighlightText(this.txbxSearchpatern.Text, Color.LimeGreen);
                }
            lblMatches.Text = m.ToString()+" Matches";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timerTicks++;
            if (this.timerTicks == 2)
            {
                ColorText();
                timer1.Stop();
                timerTicks = 0;
            }
        }

        public int timerTicks { get; set; }

        private void btnLoadCurrent_Click(object sender, EventArgs e)
        {
            string doc = GetActiveDocumetText();
            Last_documetn = ScriptAnalysiz.Copy(LoadNewDoc(doc));
            this.rtxbx_document_new.Text = Last_documetn.Document;
            CheckResults();
        }

        private string GetActiveDocumetText()
        {
            if (tabControl1.SelectedIndex == 0)
                return rtxbx_document.Text;
            else
                return rtxbx_document_new.Text;
        }

        private void CheckResults()
        {
            if(tabControl1.SelectedIndex==0)
            {
                labelAllscripts.Text = "All scripts ="+Original_document.Scripts.ToString();
                labelInLinkScript.Text = "in-Link scripts =" + Original_document.InLinkScript.ToString();
            }
            else
            {

                labelAllscripts.Text = "All scripts =" + this.Last_documetn.Scripts.ToString();
                labelInLinkScript.Text = "in-Link scripts =" + Last_documetn.InLinkScript.ToString();
            }

            checkControls();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckResults();
        }

        private void checkControls()
        {
            btnSubmit.Enabled=(     (RbFile.Checked && File.Exists(textBox1.Text))    ||  (RbURL.Checked && textBox1.Text.IsUrl() )     );
            btnSubmit.Enabled=( (tabControl1.SelectedIndex==0 && Original_document.InLinkScript>0) || (tabControl1.SelectedIndex>0 && Last_documetn.InLinkScript>0) );
        }

        private void labelInLinkScript_TextChanged(object sender, EventArgs e)
        { 
            if(sender==null)
                return;
            string    x =(sender as Label).Text;
            if(tabControl1.SelectedIndex==0)
            {
                if (x.ToLower().Contains("link"))
                    (sender as Label).Visible = Original_document.InLinkScript>0;
                else
                    (sender as Label).Visible = Original_document.Scripts > 0;

            }
            else
            {

                if (x.ToLower().Contains("link"))
                    (sender as Label).Visible = Last_documetn.InLinkScript > 0;
                else
                    (sender as Label).Visible = Last_documetn.Scripts > 0;
            }
        }
    }
}
