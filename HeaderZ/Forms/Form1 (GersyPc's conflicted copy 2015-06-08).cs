using HeaderZ.Forms;
using HeaderZ.Forms.Inputs;
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

namespace HeaderZ
{
    public partial class FormMain : Form
    {
        Dictionary<string, AttackProcess> reqs = new Dictionary<string, AttackProcess>();
        Dictionary<string, __HTTTPAttack_> _AtacksList_ = new Dictionary<string, __HTTTPAttack_>();

        public List<string> multi_headers = new List<string>();
        Forms.Tools.proxySwitcherFrm proxySwitcherFrm_Object = new Forms.Tools.proxySwitcherFrm();

        public __HTTTPAttack_ __MultidAttack = new __HTTTPAttack_(false);
        public __HTTTPAttack_ __XfrwrdAttack = new __HTTTPAttack_(false);
        public __HTTTPAttack_ __UserAgentAttack = new __HTTTPAttack_(false);
        public __HTTTPAttack_ __CookieAttack = new __HTTTPAttack_(false);
        public __HTTTPAttack_ __RefererAttack = new __HTTTPAttack_(false);
        public __HTTTPAttack_ __CustomAttack = new __HTTTPAttack_(false);

        public string single_selected_header = "";

        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _______idle();
        }

        private void _______idle()
        {
            lbl_all_code.Text = lbl_all_statue.Text = "..";
            lbl_Cookie_code.Text = lbl_Cookie_statue.Text = "..";
            lbl_cust_code.Text = lbl_cust_statue.Text = "..";
            lbl_Referer_code.Text = lbl_Referer_Statue.Text = "..";
            lbl_useragent_code.Text = lbl_useragent_statue.Text = "..";
            lbl_Xforwarded_Code.Text = lbl_XforwardedFor_statue.Text = "..";
            Give_Attack_Auth();

        }

        private void Give_Attack_Auth()
        {
            btnAttack.Enabled = ((RB_X_Forwarded_For.Checked || RB_Referer.Checked || RBCookie.Checked || rbUserAgent.Checked|| (rbCust.Checked && single_selected_header != "") || (Rb_Multi.Checked && multi_headers.Count > 0)) && TxbxUrl.Text.IsUrl());
        }


        private void lnklbl_Details___LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           // string p 
                switch ((sender as LinkLabel).Name)
                {
                    case "lnklbl_all_Details": FrmAttackProcessDetails d = new FrmAttackProcessDetails(__MultidAttack);
                        d.Show(); break;
                    case "lnklbl_XForwardedFor_Details": FrmAttackProcessDetails d2 = new FrmAttackProcessDetails(__XfrwrdAttack);if(__XfrwrdAttack.Processed)
                        d2.Show(); break;
                    case "lnklblCookie_Details": FrmAttackProcessDetails d21 = new FrmAttackProcessDetails(__CookieAttack); if (__CookieAttack.Processed)
                        d21.Show(); break;
                    case "lnklblReferer_Details": FrmAttackProcessDetails d22 = new FrmAttackProcessDetails(__RefererAttack); if (__RefererAttack.Processed)
                        d22.Show(); break;
                    case "lnklbluseragent_Details": FrmAttackProcessDetails d3 = new FrmAttackProcessDetails(__UserAgentAttack); if (__UserAgentAttack.Processed)
                        d3.Show(); break;
                    case "lnklbl_custom_Details": FrmAttackProcessDetails d33 = new FrmAttackProcessDetails(__CustomAttack); if (__CustomAttack.Processed)
                        d33.Show(); break;
                }



            //} catch { notflbl.Text = "Respons not found or , request not sent"; }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            textBox1_TextChanged(null, null);
            this.MinimumSize = this.MaximumSize = this.Size;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("You havve downloaded the up to dated version :( it is under developing");
            AttackDetails _Atk_details = new AttackDetails();
            _Atk_details.LoadFromSettings(); // cookie ___user-agent ___auth


            foreach (Control cint in GPXResult.Controls)
                if (cint is RadioButton)
                    if ((cint as RadioButton).Checked && Rb_Multi.Checked==false)
                        _Atk_details.Payload = Payloads.GuessPayload((cint as RadioButton).Text);
            // editing attack details before launching
         
            if (checkBox_Adv.Checked)
            {
                FrmAttackPrefix a = new FrmAttackPrefix(_Atk_details);
                if (a.ShowDialog() == DialogResult.OK)
                    _Atk_details = a.Curent_atack_Dtals;
            }
            _Atk_details.URL = TxbxUrl.Text;

            Thread.Sleep(100);
            if (Rb_Multi.Checked)
            {

                if (_Atk_details.UseAdvInjection == false || _Atk_details.Payload == "")
                    _Atk_details.Payload = Payloads.GetPayload(Payload_.string_);

                __HTTTPAttack_ at = new __HTTTPAttack_();
                at.Payload = _Atk_details.Payload;
                at._Url = _Atk_details.URL;
                at.SetTargetedHeaders(this.multi_headers);
               
                lbl_all_statue.Text = at.Attack_All_Headers()?("Vulnerable="):"Not vulnerable";
                lbl_all_code.Text = at.statueCode; 
                lbl_hint_all.Text = at.Message;
                lbl_hint_all.Visible = true;
                
                _AtacksList_.Add(lnklbl_all_Details.Name+this._AtacksList_.Count.ToString(), at);
                __MultidAttack = __HTTTPAttack_.Copy(at);
            }
            else if (RB_X_Forwarded_For.Checked) 
            {
                if (_Atk_details.UseAdvInjection == false || _Atk_details.Payload == "")
                    _Atk_details.Payload = Payloads.GetPayload(Payload_.ip);
                _Atk_details.Target = "X-Forwarded-For";
                _____ATTACK___(_Atk_details, ref lbl_XforwardedFor_statue, ref lbl_Xforwarded_Code, ref lnklbl_XForwardedFor_Details, ref lbl_hint_xf,"xf"); // //
            }

            else if (RB_Referer.Checked)
            {
                if (_Atk_details.UseAdvInjection == false || _Atk_details.Payload == "")
                    _Atk_details.Payload = Payloads.GetPayload(Payload_.url);
                _Atk_details.Target = "Referer";
                _____ATTACK___(_Atk_details, ref lbl_Referer_Statue, ref lbl_Referer_code, ref lnklblReferer_Details, ref lbl_hint_referer,"ref"); // //
         
            }
            else if (RBCookie.Checked) 
            {
                if (_Atk_details.UseAdvInjection == false || _Atk_details.Payload == "")
                    _Atk_details.Payload = Payloads.GetPayload(Payload_.cookie);
                _Atk_details.Target = "cookie";
                _____ATTACK___(_Atk_details, ref lbl_Cookie_statue, ref lbl_Cookie_code, ref lnklblCookie_Details, ref lbl_hint_cookie,"cok"); // //
            }
            else if (rbUserAgent.Checked) // user agent
            {
                if (_Atk_details.UseAdvInjection == false || _Atk_details.Payload == "")
                    _Atk_details.Payload = Payloads.GetPayload(Payload_.string_);
                _Atk_details.Target = "User-Agent";
                _____ATTACK___(_Atk_details, ref lbl_useragent_statue, ref lbl_useragent_code, ref lnklbluseragent_Details, ref lbl_hint_agent,"ua"); // //
            }
            else if (rbCust.Checked) // cutome header
            {
                _Atk_details.Target = rbCust.Text;
                if (_Atk_details.UseAdvInjection == false || _Atk_details.Payload == "")
                    _Atk_details.Payload = Payloads.GuessPayload(_Atk_details.Target);
                _____ATTACK___(_Atk_details, ref lbl_cust_statue, ref lbl_cust_code, ref lnklbl_custom_Details,ref lbl_hint_Ref,"cus"); // //
            }

            Thread.Sleep(1000);
            Notify("Ready", notflbl.ForeColor);
             
        }
         
        private void _____ATTACK___(AttackDetails _Atk_details, ref Label L_statue, ref Label L_code, ref LinkLabel L_source,ref Label hint,string attacker="")
        {
            Notify(_Atk_details.Target+" Attacking ", Color.Yellow);
            L_statue.Text = L_code.Text = "...";
        
            __HTTTPAttack_ at = new __HTTTPAttack_();
            at.Payload = _Atk_details.Payload;
            at._Url = _Atk_details.URL;
            at.SetTargetHeader(_Atk_details.Target);
            at.Attack_Current_Header();

            if (at.IsCurrentHeaderVulnerable())
                L_statue.Text = "Vulnerable"; 
            else
                L_statue.Text = "Not Vulnerable";  


            L_code.Text = at.statueCode;
            _AtacksList_.Add(L_source.Name + _AtacksList_.Count.ToString(), at);
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
        }

    
        private void XforwardedFor_statue_lbl_TextChanged(object sender, EventArgs e)
        {
            if (!(sender as Label).Text.Contains("Not"))
                (sender as Label).ForeColor = Color.LimeGreen;
            else
                (sender as Label).ForeColor = Color.Red;


            (sender as Label).Visible = !((sender as Label).Text == "..");
            /*switch((sender as Label).Name)
            {
                case "lbl_all_statue":
                    (sender as Label).Location = ((sender as Label).Text.ToLower() == "not vulnerable") ? new Point(184, 57) : new Point(210, 57); break;
                
                case "lbl_XforwardedFor_statue":
                    (sender as Label).Location = ((sender as Label).Text.ToLower() == "not vulnerable") ? new Point(184, 98) : new Point(210, 98); break;

                case "lbl_Referer_Statue":
                    (sender as Label).Location = ((sender as Label).Text.ToLower() == "not vulnerable") ? new Point(184, 148) : new Point(210, 148); break;
                    
                case "lbl_Cookie_statue" :
                    (sender as Label).Location = ((sender as Label).Text.ToLower() == "not vulnerable") ? new Point(184, 195) : new Point(210, 195);break;
               
                case "lbl_useragent_statue":
                    (sender as Label).Location = ((sender as Label).Text.ToLower() == "not vulnerable") ? new Point(184, 242) : new Point(210, 242);break;
                case "lbl_cust_statue":
                    (sender as Label).Location = ((sender as Label).Text.ToLower() == "not vulnerable") ? new Point(184, 279) : new Point(210, 279);break;
                
               
            } 
             */
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
            FrmSettings f = new FrmSettings();
            f.ShowDialog();
        }

        private void rbUserAgent_CheckedChanged__(object sender, EventArgs e)
        {
        }

        private void HideLabels()
        {
            ////////// payloadders
            lnklbl_Op_Referer_Payload.Visible = lbl_hint_referer.Visible;
            lnklbl_Op_Xfrwd_Payload.Visible = lbl_hint_xf.Visible;
            lnklbl_Op_Cookie_Payload.Visible = lbl_hint_cookie.Visible;
            lnklbl_Op_UAGent_Payload.Visible = rbUserAgent.Checked;
            lnklbl_Op_Multi_Payload.Visible = lbl_hint_all.Visible;

            /////////hints
            /*
            lbl_hint_agent.Visible = rbUserAgent.Checked;
            lbl_hint_all.Visible = Rb_Multi.Checked;
            lbl_hint_cookie.Visible = RBCookie.Checked;
            lbl_hint_referer.Visible = RB_Referer.Checked;
            lbl_hint_xf.Visible = RB_X_Forwarded_For.Checked;*/
            

            /////////////Selectors
            label___note__.Visible = (!rbCust.Checked);
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
            Notify((sender as RadioButton).Text + " Ready", Color.Green);


        }

        private void Rb_all_CheckedChanged_(object sender, EventArgs e)
        {
            lnklbl_OP_Multi_Select.Visible = Rb_Multi.Checked;
            if (Rb_Multi.Checked == false) return;
            Notify(((multi_headers.Count == 1) ? (multi_headers[0]) : ("Multi Attack")) + " ready", Color.Green);
            if (this.multi_headers.Count < 1)
            {
                MultiHSFrm m = new MultiHSFrm(multi_headers);
                if (m.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    this.multi_headers = m._Headers;
            }

            if (multi_headers.Count < 1)
                Notify("No headers selected , Click option , or me", Color.Red);

            Give_Attack_Auth();

        }

        private void Notify(string p, Color color)
        {
            notflbl.Text = p;
            notflbl.ForeColor = color;

        }
        bool In_The_Function = false;
        private void lnklbl_All_Option_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MultiHSFrm m = new MultiHSFrm(multi_headers);
            if (m.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { this.multi_headers = m._Headers; Notify(m._Headers.Count + " Headers Selected", Color.Green); }
            Give_Attack_Auth();
            lnklbl_OP_Multi_Select.Text = ("E") + ((multi_headers.Count > 0) ? "=" + multi_headers.Count.ToString() : "");

        }
       

        private void lnklbl_Cust_single_header_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HeaderSelectorFrm u = new HeaderSelectorFrm(rbCust.Text);
            if (u.ShowDialog() == DialogResult.OK)
            {
                if (isSelectedCommonHeader(u.Name.Trim()) == false)
                    rbCust.Text = single_selected_header = u.Name.Trim();
            }
            Give_Attack_Auth();
            Notify(single_selected_header + " Ready", Color.Green);

        }

        private bool isSelectedCommonHeader(string p)
        {
            if (p.Trim().ToLower() == RB_Referer.Text.ToLower())
            {
                RB_Referer.Checked = true;
                return true;

            }
            else if (p.Trim().ToLower() == RBCookie.Text.ToLower())
            {
                RBCookie.Checked = true;
                return true;
            }
            else if (p.Trim().ToLower() == rbUserAgent.Text.ToLower())
            {
                rbUserAgent.Checked = true;
                return true;

            }
            else if (p.Trim().ToLower() == RB_X_Forwarded_For.Text.ToLower())
            {
                RB_X_Forwarded_For.Checked = true;
                return true;

            }
            return false;
                
        }

        private void rbCust_TextChanged(object sender, EventArgs e)
        {
            if (rbCust.Text.Length > 35)
                rbCust.Text = rbCust.Text.Substring(0, 33) + "..";
            Give_Attack_Auth();

        }

        private void Tstrb_proxySwitcher__Click(object sender, EventArgs e)
        {
            proxySwitcherFrm_Object = new Forms.Tools.proxySwitcherFrm();
            proxySwitcherFrm_Object.Show();
            Give_Attack_Auth();

        }

        private void repeaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Tools.FrmRepeater FormRepeater = new Forms.Tools.FrmRepeater();
            FormRepeater.ShowDialog();
        }

        private void notflbl_Click(object sender, EventArgs e)
        {
            switch (notflbl.Text)
            {
                case "No headers selected , Click option , or me": lnklbl_All_Option_LinkClicked(null, null); break;
                case "No header specified": lnklbl_Cust_single_header_LinkClicked(null, null); break;

            }
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
                              string nm = (multi_headers.Count>0)?(">>>" + ((multi_headers.Count>1)?("Multi Attack "):(multi_headers[0]) )+ "<<< Ready"):("No headers selected , Click option , or me");
                            //  if(this.multi_headers.Count<1)    lnklbl_All_Option_LinkClicked(null, null);
                              if (this.multi_headers.Count < 1)
                                    Notify(nm, (nm.Contains("No headers")) ? (Color.Red) : (Color.Green));
                              break;
                case "RB_X_Forwarded_For": break;
                case "RB_Referer": break;
                case "RBCookie": break;
                case "rbUserAgent": break;
                case "rbCust": break; lnklbl_Cust_single_header_LinkClicked(null, null);

            }

             if(rbCust.Checked && rbCust.Text.ToLower()=="custom")
                Notify("No header specified", Color.Red);

            else if (!Rb_Multi.Checked )
                Notify(">>>"+Selected_op+"<<< ready",Color.Green);

             In_The_Function = false;

        }

        private void base64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Tools.FrmBase64 f = new Forms.Tools.FrmBase64();
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

       

       
        

    }
  }
