using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Gunners.Forms.Tools
{
    public partial class FrmRepeater : Form
    {
        public FrmRepeater()
        {
            InitializeComponent();
        }

        public FrmRepeater(__HTTTPAttack_ atk)
        {
            InitializeComponent();
            LoadRequest(atk);
            lblHost.Text = atk.GetURI();
            

        }

        public FrmRepeater(string FileName)
        {
            InitializeComponent();

            if(System.IO.File.Exists(FileName))
            this.RtxbxRequest.Text = FileName.ReadFileTXT();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ChbxColors_CheckedChanged(object sender, EventArgs e)
        {
            if(ChbxColors.Checked)
            {
                panelContainer.BackColor = Color.DarkGray;
                gpxRequest.BackColor = gpxResponse.BackColor = Color.Blue;
                rtxbx_response.BackColor = RtxbxRequest.BackColor = Color.White;
                rtxbx_response.ForeColor = RtxbxRequest.ForeColor = Color.FromKnownColor(KnownColor.Black);

            }
            else
            {

                panelContainer.BackColor = Color.DimGray;
                gpxRequest.BackColor = gpxResponse.BackColor = Color.LightGray;
                rtxbx_response.BackColor = RtxbxRequest.BackColor = Color.FromKnownColor(KnownColor.InfoText);
                rtxbx_response.ForeColor = RtxbxRequest.ForeColor = Color.FromKnownColor(KnownColor.White);

            }
            rtxbx_response_TextChanged(null, null);
            RtxbxRequest_TextChanged(null, null);

        }

        private void FrmRepeater_Load(object sender, EventArgs e)
        {
            this.MinimumSize = ClientSize;
            ChbxColors.Checked = false;
            lastText = RtxbxRequest.Text;
            timer1.Start();
                if(HosTEntered)
                    return; 
        }

        private void RtxbxRequest_TextChanged(object sender, EventArgs e)
        {
        }
        bool txChangingnow = false;
        private void txtChanged()
        {
            return;
            txChangingnow = true;
            Color BackingColor=Color.FromKnownColor(KnownColor.GrayText);
            string []doc = RtxbxRequest.Lines;
            RtxbxRequest.Text = "";

            bool DocStarted = false;
            for (int i = 0; i < doc.Length-1; i++)
            {
                AddBColoredLine(RtxbxRequest, (i % 2 == 0) ? BackingColor : RtxbxRequest.ForeColor, doc[i] + Environment.NewLine, DocStarted);
                i++;
                RtxbxRequest.AppendText(doc[i]+Environment.NewLine);
                //if (doc[i] == "")
                //    DocStarted = true;
            }
          //  RtxbxRequest.ForeColor=Color.White;
          
            txChangingnow = false;

        }
        public void AddBColoredLine(RichTextBox r , Color c , string l,bool DontColor=false)
        {
            if (DontColor) 
            {
                r.AppendText(l);
                return;
            }
            Color saved = r.BackColor;
            int i = r.TextLength ;
            r.AppendText(l);
            r.SelectionStart = (i>1)?i-1:0;
            r.SelectionLength = l.Length;
            r.SelectionBackColor = c;
           if(DontColor)
            r.Select();//i,l.Length);
            r.SelectionColor = saved;
        }
        private void rtxbx_response_TextChanged(object sender, EventArgs e)
        {
            linkLabel1.Enabled = rtxbx_response.Text != "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PromptHostPort();

           // new FrmHostPortInputcs().ShowDialog();
        }
        private string lastText = "";
        private __HTTTPAttack_ atk;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (((FormMain)this.Owner).ToRepeater!=null)
            //if(this.atk.Id !=((FormMain)this.Owner).ToRepeater.Id)
              //  this.LoadRequest(((FormMain)this.Owner).ToRepeater);
            if (ReqChanged)
            {
                RtxbxRequest.HighlightNo((this.ChbxColors.Checked) ? Color.Black : Color.White);
                RtxbxRequest.HighlightText(txbxPaternRequest_.Text, Color.Red);
                ReqChanged = false;
            
            }
            if(ResChanged)
            {
                rtxbx_response.HighlightNo((this.ChbxColors.Checked) ? Color.Black : Color.White);
                rtxbx_response.HighlightText(txbxPaternResponse.Text, Color.Red);
                ResChanged = false;
            }
            timer1.Stop();
            //if (RtxbxRequest.Text == lastText)
            //    return;

            //if (RtxbxRequest.Text == "" || txChangingnow)
            //    return;

            //txtChanged();
            //lastText = RtxbxRequest.Text;
            
        }

        private void LoadRequest(__HTTTPAttack_ a)
        {
            this.atk = __HTTTPAttack_.Copy(a);

            RtxbxRequest.Text = atk.GetMethod() + atk._Url.GetPage() + " /HTTP/1.1" + Environment.NewLine;
            RtxbxRequest.Text += "User-Agent:" + atk._UserAgentString + Environment.NewLine;

          if(a._Url.Trim()!="")
              RtxbxRequest.Text += "Host:" + atk._Url.GetHost() + Environment.NewLine;

            foreach (KeyValuePair<string, string> h in atk.Request_Headers)
                if (h.Key.ToLower().Trim() != "user-agent")
                    RtxbxRequest.Text += (h.Key + ": " + h.Value + Environment.NewLine);
        }

        private void panelContainer_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmRepeater_SizeChanged(object sender, EventArgs e)
        {
           // gpxResponse.Location=;

            gpxRequest.Size =gpxResponse.Size= new Size((panelDAD.Size.Width - 10) / 2, panelDAD.Size.Height);
            gpxResponse.Location = new Point(gpxRequest.Size.Width + 10, 3);

        } 
      public  RequestDetails HostAndPort = new RequestDetails(80);
        private void btnSend_Click(object sender, EventArgs e)
        {
            this.SetNotification("");
            Thread.Sleep(100);

            btnSend.Enabled = false ;
            if (HosTEntered == false)
                if (TryDigging() == false)
                    if (PromptHostPort() == false)
                        return;
            

            this.SetNotification("Sending");
            rtxbx_response .Text= "";

            Thread.Sleep(100);
            SendRequest();
           btnSend.Enabled = true;
               
        }

        private bool TryDigging()
        {

            string[] lines = RtxbxRequest.Lines;
            foreach(string line in lines)
            {
                if (line.Trim() == "")
                    continue;
                else if (line.ToLower().StartsWith("host"))
                {
                    if(line.Contains(":")==false)
                        continue;
                    string[] sepd = line.Split(new char[] { ':' });
                    this.HostAndPort.host = sepd[1];
                    lblHost.Text = this.HostAndPort.GetUrl();
                     
                    return true;

                }
            }
            return false;
        }

        private void SendRequest()
        {
            __HTTTPAttack_ a = new __HTTTPAttack_();
            a.SetFromHoleRequest(RtxbxRequest.Lines);
            a._Url = this.HostAndPort.GetUrl();
            a.TimeOut = HostAndPort.TimeOut;
            a.SendRequest();

            Thread.Sleep(100);
            if (a.Succeeded)
            {
                rtxbx_response.Text = a.ReturnHoleResponse();
                this.DocumentText = a.DocumentText;
                a.owner = "Repeater";
                ((FormMain)this.Owner).AddNewAttack(a);
            }

            this.SetNotification(a.Message);


            
        }

        private bool PromptHostPort()
        {
            if (this.HostAndPort.IsDefaulTimeOut())
                this.HostAndPort.TimeOut = global::Web_Gunners.Properties.Settings.Default.TimeOut;

            FrmHostPortIInput h = new FrmHostPortIInput(this.HostAndPort);
            if (h.ShowDialog() == DialogResult.OK)
            {
                
                this.lblHost.Text = h.HostAndPort.GetUrl();
                this.HostAndPort.host= h.HostAndPort.host;
                this.HostAndPort.port = h.HostAndPort.port;
                this.HostAndPort.useHttps = h.HostAndPort.useHttps;
                this.HostAndPort.TimeOut = h.HostAndPort.TimeOut;
                this.HosTEntered = true;
                return true;

            }
            return false;
        }

        private void SetNotification(string p)
        {
            ((FormMain)this.Owner).SetNotification(p); 
 
        }

        private void lnklBL_Close_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((FormMain)this.Owner).RemoveCurrentTab(); 
        }




        public bool HosTEntered { get; set; }

        private void parser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmParser f = new FrmParser(this.DocumentText);
            f.ShowDialog();
        }


        public string DocumentText { get; set; }

        private void lblHost_TextChanged(object sender, EventArgs e)
        {
            if (lblHost.Text == "http://:80")
                lblHost.Text = "Host";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            if (!this.ResChanged)
            {
                this.ResChanged = true;
                timer1.Start();

            }
        }

        private void txbxPaternRequest__TextChanged(object sender, EventArgs e)
        {
            if (!this.ReqChanged)
            {
                this.ReqChanged = true;
                timer1.Start();
            }


        }

        public bool ReqChanged { get; set; }

        public bool ResChanged { get; set; }
    }
}
