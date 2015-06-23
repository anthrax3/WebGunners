using Web_Gunners.Forms;
using Web_Gunners.Forms.Inputs;
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

namespace Web_Gunners
{
    public partial class FormAttacker : Form
    { 
        Dictionary<string, __HTTTPAttack_> _AtacksList_ = new Dictionary<string, __HTTTPAttack_>();

        public List<string> multi_headers = new List<string>();
        Forms.Tools.JersiProxiFrm proxySwitcherFrm_Object = new Forms.Tools.JersiProxiFrm();

        public __HTTTPAttack_ __MultidAttack = new __HTTTPAttack_(false);
        public __HTTTPAttack_ __XfrwrdAttack = new __HTTTPAttack_(false,Payload_.ip);
        public __HTTTPAttack_ __UserAgentAttack = new __HTTTPAttack_(false,Payload_.UserAgent);
        public __HTTTPAttack_ __CookieAttack = new __HTTTPAttack_(false,Payload_.cookie);
        public __HTTTPAttack_ __RefererAttack = new __HTTTPAttack_(false,Payload_.url);
        public __HTTTPAttack_ __CustomAttack = new __HTTTPAttack_(false);

        public string single_selected_header = "";

        public FormAttacker(string u ="")
        {
            InitializeComponent();
            this.TxbxUrl.Text = u;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _______idle();
            HideLabels(true);
        }

        private void _______idle()
        {
            lbl_all_code.Text = lbl_hint_all.Text=lbl_all_statue.Text = "..";
            lbl_Cookie_code.Text =  lbl_hint_cookie.Text= lbl_Cookie_statue.Text = "..";
            lbl_cust_code.Text =lbl_hint_Cust.Text= lbl_cust_statue.Text = "..";
            lbl_Referer_code.Text = lbl_hint_referer.Text= lbl_Referer_Statue.Text = "..";
            lbl_useragent_code.Text = lbl_hint_agent.Text= lbl_useragent_statue.Text = "..";
            lbl_Xforwarded_Code.Text =lbl_hint_xf.Text= lbl_XforwardedFor_statue.Text = "..";

            Give_Attack_Auth();

        }

        private void Give_Attack_Auth()
        {
            btnAttack.Enabled = ((RB_X_Forwarded_For.Checked || RB_Referer.Checked || RBCookie.Checked || rbUserAgent.Checked|| (rbCust.Checked && single_selected_header != "") || (Rb_Multi.Checked && multi_headers.Count > 0)) && TxbxUrl.Text.IsUrl());
        }


        private void lnklbl_Details___LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // string p 
          //  FormMain parent = (FormMain)this.Owner;
       
                switch ((sender as LinkLabel).Name)
                        
                {
                    case "_lnklbl_all_Details":
                        {
                            if (__MultidAttack.Processed)
                                ((FormMain)this.Owner).LoadAttackTab(this.__MultidAttack.Id); 
                            break;
                        }
                    case "_lnklbl_XForwardedFor_Details":
                        {
                            if (__XfrwrdAttack.Processed)
                                ((FormMain)this.Owner).LoadAttackTab(this.__XfrwrdAttack.Id); 
                            break;
                        }
                    case "_lnklbl_Cookie_Details":
                        {
                            if (__CookieAttack.Processed)
                                ((FormMain)this.Owner).LoadAttackTab(this.__CookieAttack.Id); 
                            break;
                        }
                    case "_lnklbl_Referer_Details":
                        {
                            if (__RefererAttack.Processed)
                                ((FormMain)this.Owner).LoadAttackTab(this.__RefererAttack.Id); 
                            break;
                        }
                    case "_lnklbl_useragent_Details":
                        {
                            if (__UserAgentAttack.Processed)
                                ((FormMain)this.Owner).LoadAttackTab(this.__UserAgentAttack.Id);
                            break;
                        }
                    case "_lnklbl_custom_Details":
                        {
                            if (__CustomAttack.Processed)
                                ((FormMain)this.Owner).LoadAttackTab(this.__CustomAttack.Id); 
                            break;
                        }
                }

            

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBox1_TextChanged(null, null);
            if (TxbxUrl.Text.Trim() == "")
                TxbxUrl.Text = "http://google.com";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AttackDetails _Atk_details = new AttackDetails();
            _Atk_details.LoadFromSettings();
            _Atk_details.Owner = "Reflector";
            _Atk_details.Payload = GetPayload(); 

            Notify("");
            Thread.Sleep(100);
            // allow user to customize Attack
            if (checkBox_Adv.Checked)
            {

                FrmAttackPrefix a = new FrmAttackPrefix(_Atk_details);
                if (a.ShowDialog() == DialogResult.OK)
                    _Atk_details = a.Curent_atack_Dtals;
                else
                    return;
            }
            _Atk_details.URL = TxbxUrl.Text;

            if (Rb_Multi.Checked)
            {

                if (_Atk_details.UseAdvInjection == false || _Atk_details.Payload == "")
                    _Atk_details.Payload = Payloads.GetPayload(Payload_.string_);

                __HTTTPAttack_ at = new __HTTTPAttack_();
                at.Payload = _Atk_details.Payload;
                at._Url = _Atk_details.URL;
                at.SetTargetedHeaders(this.multi_headers);
                at.owner = _Atk_details.Owner;

                lbl_all_statue.Text = at.Attack_All_Headers()?("Vulnerable"+Payloads.Percent(at.Payload)):"Not vulnerable";
                if (at.HasError)
                lbl_all_statue.Text = "Error "+ at.Message;
             

                
                 lbl_all_code.Text = at.statueCode;
                lbl_hint_all.Text = at.Message;
                lbl_hint_all.Visible = true;

                AddAttackToList(at);
                __MultidAttack = __HTTTPAttack_.Copy(at);
                this.Notify(at.Summary(),3000);
            }
            else if (RB_X_Forwarded_For.Checked) 
            {
                if (_Atk_details.UseAdvInjection == false || _Atk_details.Payload == "")
                    _Atk_details.Payload = Payloads.GetPayload(Payload_.ip);
                _Atk_details.Target = "X-Forwarded-For";
                _____ATTACK___(_Atk_details, ref lbl_XforwardedFor_statue, ref lbl_Xforwarded_Code, ref _lnklbl_XForwardedFor_Details, ref lbl_hint_xf,"xf"); // //
            }

            else if (RB_Referer.Checked)
            {
                if (_Atk_details.UseAdvInjection == false || _Atk_details.Payload == "")
                    _Atk_details.Payload = Payloads.GetPayload(Payload_.url);
                _Atk_details.Target = "Referer";
                _____ATTACK___(_Atk_details, ref lbl_Referer_Statue, ref lbl_Referer_code, ref _lnklbl_Referer_Details, ref lbl_hint_referer,"ref"); // //
         
            }
            else if (RBCookie.Checked) 
            {
                if (_Atk_details.UseAdvInjection == false || _Atk_details.Payload == "")
                    _Atk_details.Payload = Payloads.GetPayload(Payload_.cookie);
                _Atk_details.Target = "cookie";
                _____ATTACK___(_Atk_details, ref lbl_Cookie_statue, ref lbl_Cookie_code, ref _lnklbl_Cookie_Details, ref lbl_hint_cookie,"cok"); // //
            }
            else if (rbUserAgent.Checked) // user agent
            {
                if (_Atk_details.UseAdvInjection == false || _Atk_details.Payload == "")
                    _Atk_details.Payload = Payloads.GetPayload(Payload_.string_);
                _Atk_details.Target = "User-Agent";
                _____ATTACK___(_Atk_details, ref lbl_useragent_statue, ref lbl_useragent_code, ref _lnklbl_useragent_Details, ref lbl_hint_agent,"ua"); // //
            }
            else if (rbCust.Checked) // cutome header
            {
                _Atk_details.Target = rbCust.Text;
                if (_Atk_details.UseAdvInjection == false || _Atk_details.Payload == "")
                    _Atk_details.Payload = Payloads.GuessPayload(_Atk_details.Target);
                _____ATTACK___(_Atk_details, ref lbl_cust_statue, ref lbl_cust_code, ref _lnklbl_custom_Details,ref lbl_hint_Cust,"cus"); // //
            }

            Thread.Sleep(1000);
            
            CheckAttacksDetails();
        }
         

        private string GetPayload()
        {
            if (Rb_Multi.Checked)
                return __MultidAttack.Payload;
            else if (rbCust.Checked)
                    return __CustomAttack.Payload;
            if (RBCookie.Checked)
                return __CookieAttack.Payload;
            if (RB_X_Forwarded_For.Checked)
                return __XfrwrdAttack.Payload;
            if (RB_Referer.Checked)
                return __RefererAttack.Payload;

            if (rbUserAgent.Checked)
                return __UserAgentAttack.Payload;
            else
                return Payloads.GetPayload(Payload_.string_);
        }

        private void AddAttackToList(__HTTTPAttack_ at)
        {
            ((FormMain)this.Owner).AddNewAttack(at);
        }

        private void CheckAttacksDetails()
        {
            _lnklbl_all_Details.Visible = __MultidAttack.Processed;
            _lnklbl_XForwardedFor_Details.Visible = __XfrwrdAttack.Processed;
            _lnklbl_Referer_Details.Visible = __RefererAttack.Processed;
           _lnklbl_useragent_Details.Visible = __UserAgentAttack.Processed;
            _lnklbl_Cookie_Details.Visible = __CookieAttack.Processed;
            _lnklbl_custom_Details.Visible = __CustomAttack.Processed;

         //   label_Details.Visible = (_lnklbl_all_Details.Visible||_lnklbl_XForwardedFor_Details.Visible || _lnklbl_Referer_Details.Visible || _lnklbl_useragent_Details.Visible || _lnklbl_Cookie_Details.Visible || _lnklbl_custom_Details.Visible);

        }
         
        private void _____ATTACK___(AttackDetails _Atk_details, ref Label L_statue, ref Label L_code, ref LinkLabel L_source,ref Label hint,string attacker="")
        {
            Notify(_Atk_details.Target+" Attacking ");
            L_statue.Text = L_code.Text = "...";
        
            __HTTTPAttack_ at = new __HTTTPAttack_();
            at.Payload = _Atk_details.Payload;
            at._Url = _Atk_details.URL;
            at.SetTargetHeader(_Atk_details.Target);
            at.Attack_Current_Header();
            at.owner = _Atk_details.Owner;

            if (at.Succeeded)
            {
                if (at.IsCurrentHeaderVulnerable())
                    L_statue.Text = "Vulnerable " + Payloads.Percent(at.Payload);
                else
                    L_statue.Text = "Not Vulnerable";
            }
            else
                L_statue.Text = "Error ";

                L_code.Text = at.statueCode; 
            AddAttackToList(at);
            L_code.Visible = true;
            switch(attacker.ToLower().Trim())
            { 
                case "cus": __CustomAttack = __HTTTPAttack_.Copy(at); break;
                case "xf":
                case "x-forwarded-for": __XfrwrdAttack = __HTTTPAttack_.Copy(at); break;
                case "cok":
                case "cookie": __CookieAttack = __HTTTPAttack_.Copy(at); break;
                case "ua": case "useragent": 
                case "user-agent": __UserAgentAttack = __HTTTPAttack_.Copy(at); break;
                case "ref":
                case "referer": __RefererAttack = __HTTTPAttack_.Copy(at); break;
                case "mul":
                case "multi": __MultidAttack = __HTTTPAttack_.Copy(at); break;
            }
            hint.Text = at.Message;
            hint.Visible = true;
            this.Notify(at.Summary(),3000);
        }

    
        private void _statue_lbl_TextChanged(object sender, EventArgs e)
        {
            string sender____Text = (sender as Label).Text;
            if (sender____Text.Contains("Not"))
                (sender as Label).ForeColor = Color.LimeGreen;
            else
            { //237
                Color c = Color.Red;
                if (sender____Text.Contains("%"))
                {
                    string[] sepd = sender____Text.Split(new char[] { '%' });
                    int n = int.Parse(sepd[1]);

                    if (n < 30)
                        c = Color.FromArgb(245, 102, 33);
                    if (n < 50)
                        c = Color.FromArgb(255, 121, 70);
                    else if (n < 70)
                        c = Color.OrangeRed;

                    else if (n < 90)
                      c = Color.FromArgb(157, 13, 96);
                    else
                        c = Color.Red;
                        
                } 

                    (sender as Label).ForeColor = c;
            }

            (sender as Label).Visible = !((sender as Label).Text == "..");
        
        }

        private void rbCust_CheckedChanged__(object sender, EventArgs e)
        {
            Give_Attack_Auth();
            lnklbl_OP_single.Visible = rbCust.Checked;
            if (rbCust.Checked == false)
                return;

            string x = lbl_Xforwarded_Code.Text;
            if (rbCust.Checked)
                if (rbCust.Text.ToLower() == "custom")
                {
                    HeaderSelectorFrm u = new HeaderSelectorFrm();
                    if (u.ShowDialog() == DialogResult.OK)
                        rbCust.Text = u.Name;
                }

            HideLabels();
        }

        private void SettingsClicker_Click(object sender, EventArgs e)
        {
            FrmSettings f = new FrmSettings();
            f.ShowDialog();
        }


   

        private void btnSettings_Click(object sender, EventArgs e)
        {
            }

        private void rbUserAgent_CheckedChanged__(object sender, EventArgs e)
        {
        }

        private void HideLabels(bool hideHints=false)
        {
            if (hideHints)
            {
                lbl_hint_agent.Visible = rbUserAgent.Checked;
                lbl_hint_all.Visible = Rb_Multi.Checked;
                lbl_hint_cookie.Visible = RBCookie.Checked;
                lbl_hint_referer.Visible = RB_Referer.Checked;
                lbl_hint_xf.Visible = RB_X_Forwarded_For.Checked;
               lbl_hint_all.Visible= Rb_Multi.Checked;
               lbl_hint_Cust.Visible= rbCust.Checked;
            }
            

            /////////////Selectors
            lnklbl_OP_Multi_Select.Visible = Rb_Multi.Checked;
            lnklbl_OP_single.Visible = rbCust.Checked;

            btnAttack.Enabled = TxbxUrl.Text.IsUrl();
            if (Rb_Multi.Checked)
                btnAttack.Enabled = (TxbxUrl.Text.IsUrl() && single_selected_header != "");

        }

        private void Rb_all_CheckedChanged__(object sender, EventArgs e)
        {
            HideLabels();
            Give_Attack_Auth();
            Notify((sender as RadioButton).Text + " Ready");


        }

        private void Rb_all_CheckedChanged_(object sender, EventArgs e)
        {
            lnklbl_OP_Multi_Select.Visible = Rb_Multi.Checked;
            if (Rb_Multi.Checked == false) return;
            Notify(((multi_headers.Count == 1) ? (multi_headers[0]) : ("Multi Attack")) + " ready" );
            if (this.multi_headers.Count < 1)
            {
                MultiHSFrm m = new MultiHSFrm(multi_headers);
                if (m.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    this.multi_headers = m._Headers;
            }

            if (multi_headers.Count < 1)
                Notify("No headers selected , Click option " );

            Give_Attack_Auth();

        }

        private void Notify(string p,int i=1 )
        {  

            ((FormMain)this.Owner).SetNotification(p,i); 

       

        }
        bool In_The_Function = false;
        private void lnklbl_All_Option_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MultiHSFrm m = new MultiHSFrm(multi_headers);
            if (m.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { this.multi_headers = m._Headers; Notify(m._Headers.Count + " Headers Selected"); }
            Give_Attack_Auth();
            lnklbl_OP_Multi_Select.Text = ("E") + ((multi_headers.Count > 0) ? "=" + multi_headers.Count.ToString() : "");

        }
       

        private void lnklbl_Cust_single_header_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HeaderSelectorFrm u = new HeaderSelectorFrm(rbCust.Text);
            if (u.ShowDialog() == DialogResult.OK)
            {
                rbCust.Text = single_selected_header = u.Name.Trim();
            }
            Give_Attack_Auth();
            Notify(single_selected_header + " Ready");

        }

        private void rbCust_TextChanged(object sender, EventArgs e)
        {
            if (rbCust.Text.Length > 35)
                rbCust.Text = rbCust.Text.Substring(0, 33) + "..";
            Give_Attack_Auth();

        }

        private void Tstrb_proxySwitcher__Click(object sender, EventArgs e)
        {
            proxySwitcherFrm_Object = new Forms.Tools.JersiProxiFrm();
            proxySwitcherFrm_Object.Show();
            Give_Attack_Auth();

        }

        private void repeaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallRepeater();
        }
        public void CallRepeater()
        {
            Forms.Tools.FrmRepeater FormRepeater = new Forms.Tools.FrmRepeater();
            FormRepeater.Show();
        }
        public void CallRepeater(__HTTTPAttack_ atk)
        {
            Forms.Tools.FrmRepeater FormRepeater = new Forms.Tools.FrmRepeater(atk);
            FormRepeater.Show();
        }

      

        private void OptionChanged(object sender, EventArgs e)
        {
            if (In_The_Function)
                return;
            In_The_Function = true;

            HideLabels();
            Give_Attack_Auth();
            if (sender == null || sender == null)
                return;
            string Selected_rB = ((Rb_Multi.Checked) ? (Rb_Multi.Name) : ((RB_X_Forwarded_For.Checked) ? (RB_X_Forwarded_For.Name) : ((RB_Referer.Checked) ? (RB_Referer.Name) : ((RBCookie.Checked) ? (RBCookie.Name) : ((rbCust.Checked) ? (rbCust.Name) : (rbUserAgent.Name))))));
            string Selected_op = ((Rb_Multi.Checked) ? (Rb_Multi.Text) : ((RB_X_Forwarded_For.Checked) ? (RB_X_Forwarded_For.Text) : ((RB_Referer.Checked) ? (RB_Referer.Text) : ((RBCookie.Checked) ? (RBCookie.Text) : ((rbCust.Checked) ? (rbCust.Text) : (rbUserAgent.Text))))));
           
            switch (Selected_rB)
            {
                case "Rb_Multi": 
                              string nm = (multi_headers.Count>0)?(">>>" + ((multi_headers.Count>1)?("Multi Attack "):(multi_headers[0]) )+ "<<< Ready"):("No headers selected , Click option ");
                            //  if(this.multi_headers.Count<1)    lnklbl_All_Option_LinkClicked(null, null);
                              if (this.multi_headers.Count < 1)
                                    Notify(nm);//, (nm.Contains("No headers")) ? (Color.Red) : (Color.Green));
                              break;
                case "RB_X_Forwarded_For": break;
                case "RB_Referer": break;
                case "RBCookie": break;
                case "rbUserAgent": break;
                case "rbCust": break; lnklbl_Cust_single_header_LinkClicked(null, null);

            }

             if(rbCust.Checked && rbCust.Text.ToLower()=="custom")
                Notify("No header specified");

            else if (!Rb_Multi.Checked )
                Notify(">>>"+Selected_op+"<<< ready");

             In_The_Function = false;

        }

        private void base64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Tools.FrmMRCode f = new Forms.Tools.FrmMRCode();
            f.Show();
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAbout().Show();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSettings_Click(null, null);
        }

        private void lbl_Cookie_statue_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(!checkBox1.Checked)
                   ProxyHandler.setProxy("", false);
            else

                ProxyHandler.setProxy("127.0.0.1:8080", true);
        }

         
        

        private void lbl_all_code_TextChanged_1(object sender, EventArgs e)
        {
            (sender as Label).Visible = ((sender as Label).Text != "...") && (sender as Label).Text != "..";

        }

        private void checkBox_Adv_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Adv.Checked)
            {
                this.btnAttack.BackgroundImage = global::Web_Gunners.Properties.Resources.fire;
                this.btnAttack.ForeColor = Color.Yellow;
            }
            else
            {
                this.btnAttack.BackgroundImage = null;// = global::Web_Gunners.Properties.Resources.fire;
                this.btnAttack.ForeColor = Color.Black;
            }
        }

        private void btnAttack_EnabledChanged(object sender, EventArgs e)
        {
            checkBox_Adv.Enabled = btnAttack.Enabled;
            if (checkBox_Adv.Enabled == false)
                checkBox_Adv.Checked = false;
        }

        private void Tstrb_Tools_Click(object sender, EventArgs e)
        {

        }

        private void lnklBL_Close_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((FormMain)this.Owner).RemoveCurrentTab(); 
            
        }







        internal void SetUrl(string url)
        {
            if (url == "")
                return;
            this.TxbxUrl.Text = url;
        }
    }
  }
