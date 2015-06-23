using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Gunners.Forms.Tools
{
    public partial class FrmCollector : Form
    {
        public FrmCollector()
        {
            InitializeComponent();
        }
         
        List<string> linkler;
        List<string> Formler;



        private void btnEval_Click(object sender, EventArgs e)
        {
            if (txtURL.Text.StartsWith("http") == false)
                txtURL.Text = "http://" + txtURL.Text;

            txtReport.Clear();
             
            SetNotfictaion( "Retrieving information");
            Thread.Sleep(100);
            this.GetResponseHeaders();
            Thread.Sleep(100);

            SetNotfictaion ( " information has been received");
            this.LinkleriAl();

        }

        private void LinkleriAl()
        {
            try
            {
                linkler = new List<string>();
                Formler = new List<string>();

                HtmlWeb hw = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument(); doc.LoadHtml(this.DocumentText);//hw.Load(txtURL.Text);

                
               
                List<string> hrefTags = new List<string>();
                doc.DocumentNode.SelectNodes("//a[@href]");
                foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//a"))
                {
                    // Linkleri listeye atıyoruz.
                    string l = node.GetAttributeValue("href", null);
                    if (l.StartsWith("javascript") )
                        continue;

                    if (l.IsUrl() == false)
                        l = txtURL.Text + l;

                        linkler.Add(l);
                }


                doc.DocumentNode.SelectNodes("//form");
                foreach (HtmlNode node in doc.DocumentNode.SelectNodes("//form"))
                   Formler.Add(node.OuterHtml);
                
            }
            catch
            {
                this.SetNotfictaion("Links retrieving error has occurred.");
            }
            Fill_ListBoxes();

            CheckLinkLabels();
        }

        private void Fill_ListBoxes()
        {
            listBoxURLS.Items.Clear();
            foreach (string element in linkler)
            {
                if (element == null)
                    continue;
                if (element.Trim().Length < 1)
                    continue;
                if (element[0] == '/')
                    listBoxURLS.Items.Add(element.StripStart('/'));
                else
                    listBoxURLS.Items.Add(element);
            }
            listBoxForms.Items.Clear();
            foreach (string el in Formler)
                listBoxForms.Items.Add(el);
        }

        private void CheckLinkLabels()
        {
            linkLabelCopyAll_links.Visible = listBoxURLS.Items.Count > 0;
            linkLabelCopySingle_link.Visible =linkLabelLoadSource.Visible= linkLabelSendReflector.Visible = (listBoxURLS.SelectedIndex > -1);
            

        }

        private void GetResponseHeaders()
        {
            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(txtURL.Text);
                myRequest.Method = "GET";
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
                WebHeaderCollection myHeaders = myResponse.Headers;
                txtReport.Text = "Adres: " + txtURL.Text;
                txtReport.AppendText(Environment.NewLine);
                txtReport.AppendText(Environment.NewLine);
                txtReport.AppendText("Title Information:");
                txtReport.AppendText(Environment.NewLine);

                __HTTTPAttack_ a = new __HTTTPAttack_(txtURL.Text);
                a.LoadFromSettings(false);
                a.SendRequest();
                txtReport.AppendText(a.ReturnResponseHeaders());
                this.DocumentText = a.DocumentText;
                this.addAttack(a);

                progressBar1.Value += 100;
            }
            catch
            {
                this.SetNotfictaion("URL incorrect or unreachable");
            }
        }

        private void addAttack(__HTTTPAttack_ a)
        {

            ((FormMain)this.Owner).AddNewAttack(a);
        }


        private void FrmAboDoma_Load(object sender, EventArgs e)
        { 

        }

        private void SetNotfictaion(string hataMetni)
        {
            ((FormMain)this.Owner).SetNotification(hataMetni); 
        }

        private void lnklBL_Close_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((FormMain)this.Owner).RemoveCurrentTab(); 

        }

        private void listBoxURLS_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckLinkLabels();
        }

        private void linkLabelCopySingle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(listBoxURLS.SelectedItem.ToString());
            this.SetNotfictaion("Copied");
        }

        private void linkLabelCopyAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string r = "";
            for (int i = 0; i < listBoxURLS.Items.Count; i++)
                r += listBoxURLS.Items[i].ToString() + Environment.NewLine;

            this.SetNotfictaion("All Copied ");

        }

        private void linkLabelSendReflector_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((FormMain)this.Owner).LoadReflectorTab(false, this.listBoxURLS.SelectedItem.ToString());
        }

        private void linkLabelLoadSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ((FormMain)this.Owner).LoadDiggerTab(listBoxURLS.SelectedItem.ToString());

        }

        private void FrmCollector_Resize(object sender, EventArgs e)
        {
            listBoxURLS.Location = new Point(0, 20);
            listBoxURLS.Size = new Size(panelListBXX.Size.Width/2-3,panelListBXX.Size.Height-20);

            listBoxForms.Location = new Point(listBoxURLS.Size.Width+3, 20);
            listBoxForms.Size = new Size(panelListBXX.Size.Width/2-3, panelListBXX.Size.Height - 20);

        }

        private void linkLabelCopySingle_Form_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(listBoxURLS.SelectedItem.ToString());
            this.SetNotfictaion("Copied");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string r = "";
            for (int i = 0; i < listBoxForms.Items.Count; i++)
                r += listBoxForms.Items[i].ToString() + Environment.NewLine;

            this.SetNotfictaion("All Copied ");
        }


        public string DocumentText { get; set; }
    }
}
