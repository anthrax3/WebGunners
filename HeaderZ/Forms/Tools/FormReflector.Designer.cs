namespace Web_Gunners
{
    partial class FormAttacker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttacker));
            this.GPXurl = new System.Windows.Forms.GroupBox();
            this.TxbxUrl = new System.Windows.Forms.TextBox();
            this.GPXResult = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.checkBox_Adv = new System.Windows.Forms.CheckBox();
            this.lnklbl_OP_single = new System.Windows.Forms.LinkLabel();
            this.lnklbl_OP_Multi_Select = new System.Windows.Forms.LinkLabel();
            this.lbl_hint_cookie = new System.Windows.Forms.Label();
            this.lbl_hint_Cust = new System.Windows.Forms.Label();
            this.lbl_hint_agent = new System.Windows.Forms.Label();
            this.lbl_hint_referer = new System.Windows.Forms.Label();
            this.lbl_hint_xf = new System.Windows.Forms.Label();
            this.lbl_hint_all = new System.Windows.Forms.Label();
            this.lbl_all_code = new System.Windows.Forms.Label();
            this.Rb_Multi = new System.Windows.Forms.RadioButton();
            this._lnklbl_all_Details = new System.Windows.Forms.LinkLabel();
            this.lbl_all_statue = new System.Windows.Forms.Label();
            this.label_Details = new System.Windows.Forms.Label();
            this.label___note__ = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cust_code = new System.Windows.Forms.Label();
            this.lbl_useragent_code = new System.Windows.Forms.Label();
            this.lbl_Cookie_code = new System.Windows.Forms.Label();
            this.lbl_Referer_code = new System.Windows.Forms.Label();
            this.lbl_Xforwarded_Code = new System.Windows.Forms.Label();
            this.rbCust = new System.Windows.Forms.RadioButton();
            this.rbUserAgent = new System.Windows.Forms.RadioButton();
            this.RBCookie = new System.Windows.Forms.RadioButton();
            this._lnklbl_custom_Details = new System.Windows.Forms.LinkLabel();
            this.RB_Referer = new System.Windows.Forms.RadioButton();
            this._lnklbl_useragent_Details = new System.Windows.Forms.LinkLabel();
            this.RB_X_Forwarded_For = new System.Windows.Forms.RadioButton();
            this._lnklbl_Cookie_Details = new System.Windows.Forms.LinkLabel();
            this.lbl_cust_statue = new System.Windows.Forms.Label();
            this._lnklbl_Referer_Details = new System.Windows.Forms.LinkLabel();
            this.lbl_useragent_statue = new System.Windows.Forms.Label();
            this._lnklbl_XForwardedFor_Details = new System.Windows.Forms.LinkLabel();
            this.lbl_Cookie_statue = new System.Windows.Forms.Label();
            this.lbl_Referer_Statue = new System.Windows.Forms.Label();
            this.lbl_XforwardedFor_statue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnklBL_Close = new System.Windows.Forms.LinkLabel();
            this.GPXurl.SuspendLayout();
            this.GPXResult.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPXurl
            // 
            this.GPXurl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GPXurl.Controls.Add(this.TxbxUrl);
            this.GPXurl.ForeColor = System.Drawing.Color.White;
            this.GPXurl.Location = new System.Drawing.Point(8, -3);
            this.GPXurl.Name = "GPXurl";
            this.GPXurl.Size = new System.Drawing.Size(837, 45);
            this.GPXurl.TabIndex = 0;
            this.GPXurl.TabStop = false;
            this.GPXurl.Text = "url";
            // 
            // TxbxUrl
            // 
            this.TxbxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxbxUrl.Location = new System.Drawing.Point(10, 15);
            this.TxbxUrl.Name = "TxbxUrl";
            this.TxbxUrl.Size = new System.Drawing.Size(821, 23);
            this.TxbxUrl.TabIndex = 0;
            this.TxbxUrl.Text = "http://localhost.com/vuln/all.php";
            this.TxbxUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GPXResult
            // 
            this.GPXResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GPXResult.BackColor = System.Drawing.Color.Transparent;
            this.GPXResult.Controls.Add(this.checkBox1);
            this.GPXResult.Controls.Add(this.btnAttack);
            this.GPXResult.Controls.Add(this.checkBox_Adv);
            this.GPXResult.Controls.Add(this.lnklbl_OP_single);
            this.GPXResult.Controls.Add(this.lnklbl_OP_Multi_Select);
            this.GPXResult.Controls.Add(this.lbl_hint_cookie);
            this.GPXResult.Controls.Add(this.lbl_hint_Cust);
            this.GPXResult.Controls.Add(this.lbl_hint_agent);
            this.GPXResult.Controls.Add(this.lbl_hint_referer);
            this.GPXResult.Controls.Add(this.lbl_hint_xf);
            this.GPXResult.Controls.Add(this.lbl_hint_all);
            this.GPXResult.Controls.Add(this.lbl_all_code);
            this.GPXResult.Controls.Add(this.Rb_Multi);
            this.GPXResult.Controls.Add(this._lnklbl_all_Details);
            this.GPXResult.Controls.Add(this.lbl_all_statue);
            this.GPXResult.Controls.Add(this.label_Details);
            this.GPXResult.Controls.Add(this.label___note__);
            this.GPXResult.Controls.Add(this.label5);
            this.GPXResult.Controls.Add(this.label3);
            this.GPXResult.Controls.Add(this.label2);
            this.GPXResult.Controls.Add(this.label1);
            this.GPXResult.Controls.Add(this.lbl_cust_code);
            this.GPXResult.Controls.Add(this.lbl_useragent_code);
            this.GPXResult.Controls.Add(this.lbl_Cookie_code);
            this.GPXResult.Controls.Add(this.lbl_Referer_code);
            this.GPXResult.Controls.Add(this.lbl_Xforwarded_Code);
            this.GPXResult.Controls.Add(this.rbCust);
            this.GPXResult.Controls.Add(this.rbUserAgent);
            this.GPXResult.Controls.Add(this.RBCookie);
            this.GPXResult.Controls.Add(this._lnklbl_custom_Details);
            this.GPXResult.Controls.Add(this.RB_Referer);
            this.GPXResult.Controls.Add(this._lnklbl_useragent_Details);
            this.GPXResult.Controls.Add(this.RB_X_Forwarded_For);
            this.GPXResult.Controls.Add(this._lnklbl_Cookie_Details);
            this.GPXResult.Controls.Add(this.lbl_cust_statue);
            this.GPXResult.Controls.Add(this._lnklbl_Referer_Details);
            this.GPXResult.Controls.Add(this.lbl_useragent_statue);
            this.GPXResult.Controls.Add(this._lnklbl_XForwardedFor_Details);
            this.GPXResult.Controls.Add(this.lbl_Cookie_statue);
            this.GPXResult.Controls.Add(this.lbl_Referer_Statue);
            this.GPXResult.Controls.Add(this.lbl_XforwardedFor_statue);
            this.GPXResult.ForeColor = System.Drawing.Color.Yellow;
            this.GPXResult.Location = new System.Drawing.Point(9, 44);
            this.GPXResult.Name = "GPXResult";
            this.GPXResult.Size = new System.Drawing.Size(842, 375);
            this.GPXResult.TabIndex = 1;
            this.GPXResult.TabStop = false;
            this.GPXResult.Text = "Result";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(786, 350);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 19);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "prox";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnAttack
            // 
            this.btnAttack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAttack.ForeColor = System.Drawing.Color.Black;
            this.btnAttack.Location = new System.Drawing.Point(366, 315);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(118, 23);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.EnabledChanged += new System.EventHandler(this.btnAttack_EnabledChanged);
            this.btnAttack.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_Adv
            // 
            this.checkBox_Adv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_Adv.AutoSize = true;
            this.checkBox_Adv.Location = new System.Drawing.Point(10, 315);
            this.checkBox_Adv.Name = "checkBox_Adv";
            this.checkBox_Adv.Size = new System.Drawing.Size(79, 19);
            this.checkBox_Adv.TabIndex = 13;
            this.checkBox_Adv.Text = "Advanced ";
            this.checkBox_Adv.UseVisualStyleBackColor = true;
            this.checkBox_Adv.CheckedChanged += new System.EventHandler(this.checkBox_Adv_CheckedChanged);
            // 
            // lnklbl_OP_single
            // 
            this.lnklbl_OP_single.AutoSize = true;
            this.lnklbl_OP_single.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lnklbl_OP_single.Location = new System.Drawing.Point(729, 250);
            this.lnklbl_OP_single.Name = "lnklbl_OP_single";
            this.lnklbl_OP_single.Size = new System.Drawing.Size(15, 15);
            this.lnklbl_OP_single.TabIndex = 12;
            this.lnklbl_OP_single.TabStop = true;
            this.lnklbl_OP_single.Text = "S";
            this.lnklbl_OP_single.Visible = false;
            this.lnklbl_OP_single.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_Cust_single_header_LinkClicked);
            // 
            // lnklbl_OP_Multi_Select
            // 
            this.lnklbl_OP_Multi_Select.AutoSize = true;
            this.lnklbl_OP_Multi_Select.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lnklbl_OP_Multi_Select.Location = new System.Drawing.Point(729, 55);
            this.lnklbl_OP_Multi_Select.Name = "lnklbl_OP_Multi_Select";
            this.lnklbl_OP_Multi_Select.Size = new System.Drawing.Size(15, 15);
            this.lnklbl_OP_Multi_Select.TabIndex = 12;
            this.lnklbl_OP_Multi_Select.TabStop = true;
            this.lnklbl_OP_Multi_Select.Text = "S";
            this.lnklbl_OP_Multi_Select.Visible = false;
            this.lnklbl_OP_Multi_Select.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_All_Option_LinkClicked);
            // 
            // lbl_hint_cookie
            // 
            this.lbl_hint_cookie.AutoSize = true;
            this.lbl_hint_cookie.Location = new System.Drawing.Point(393, 175);
            this.lbl_hint_cookie.Name = "lbl_hint_cookie";
            this.lbl_hint_cookie.Size = new System.Drawing.Size(16, 15);
            this.lbl_hint_cookie.TabIndex = 11;
            this.lbl_hint_cookie.Text = "...";
            this.lbl_hint_cookie.Visible = false;
            // 
            // lbl_hint_Cust
            // 
            this.lbl_hint_Cust.AutoSize = true;
            this.lbl_hint_Cust.Location = new System.Drawing.Point(391, 250);
            this.lbl_hint_Cust.Name = "lbl_hint_Cust";
            this.lbl_hint_Cust.Size = new System.Drawing.Size(25, 15);
            this.lbl_hint_Cust.TabIndex = 11;
            this.lbl_hint_Cust.Text = "......";
            this.lbl_hint_Cust.Visible = false;
            // 
            // lbl_hint_agent
            // 
            this.lbl_hint_agent.AutoSize = true;
            this.lbl_hint_agent.Location = new System.Drawing.Point(393, 210);
            this.lbl_hint_agent.Name = "lbl_hint_agent";
            this.lbl_hint_agent.Size = new System.Drawing.Size(16, 15);
            this.lbl_hint_agent.TabIndex = 11;
            this.lbl_hint_agent.Text = "...";
            this.lbl_hint_agent.Visible = false;
            // 
            // lbl_hint_referer
            // 
            this.lbl_hint_referer.AutoSize = true;
            this.lbl_hint_referer.Location = new System.Drawing.Point(393, 135);
            this.lbl_hint_referer.Name = "lbl_hint_referer";
            this.lbl_hint_referer.Size = new System.Drawing.Size(19, 15);
            this.lbl_hint_referer.TabIndex = 11;
            this.lbl_hint_referer.Text = "....";
            this.lbl_hint_referer.Visible = false;
            // 
            // lbl_hint_xf
            // 
            this.lbl_hint_xf.AutoSize = true;
            this.lbl_hint_xf.Location = new System.Drawing.Point(393, 95);
            this.lbl_hint_xf.Name = "lbl_hint_xf";
            this.lbl_hint_xf.Size = new System.Drawing.Size(19, 15);
            this.lbl_hint_xf.TabIndex = 11;
            this.lbl_hint_xf.Text = "....";
            this.lbl_hint_xf.Visible = false;
            // 
            // lbl_hint_all
            // 
            this.lbl_hint_all.AutoSize = true;
            this.lbl_hint_all.Location = new System.Drawing.Point(393, 55);
            this.lbl_hint_all.Name = "lbl_hint_all";
            this.lbl_hint_all.Size = new System.Drawing.Size(16, 15);
            this.lbl_hint_all.TabIndex = 11;
            this.lbl_hint_all.Text = "...";
            this.lbl_hint_all.Visible = false;
            // 
            // lbl_all_code
            // 
            this.lbl_all_code.AutoSize = true;
            this.lbl_all_code.ForeColor = System.Drawing.Color.White;
            this.lbl_all_code.Location = new System.Drawing.Point(313, 55);
            this.lbl_all_code.Name = "lbl_all_code";
            this.lbl_all_code.Size = new System.Drawing.Size(16, 15);
            this.lbl_all_code.TabIndex = 10;
            this.lbl_all_code.Text = "...";
            this.lbl_all_code.Visible = false;
            this.lbl_all_code.TextChanged += new System.EventHandler(this.lbl_all_code_TextChanged_1);
            // 
            // Rb_Multi
            // 
            this.Rb_Multi.AutoSize = true;
            this.Rb_Multi.ForeColor = System.Drawing.Color.White;
            this.Rb_Multi.Location = new System.Drawing.Point(10, 55);
            this.Rb_Multi.Name = "Rb_Multi";
            this.Rb_Multi.Size = new System.Drawing.Size(97, 19);
            this.Rb_Multi.TabIndex = 9;
            this.Rb_Multi.Text = "Multi Headers";
            this.Rb_Multi.UseVisualStyleBackColor = true;
            this.Rb_Multi.CheckedChanged += new System.EventHandler(this.OptionChanged);
            // 
            // _lnklbl_all_Details
            // 
            this._lnklbl_all_Details.AutoSize = true;
            this._lnklbl_all_Details.Location = new System.Drawing.Point(787, 55);
            this._lnklbl_all_Details.Name = "_lnklbl_all_Details";
            this._lnklbl_all_Details.Size = new System.Drawing.Size(32, 15);
            this._lnklbl_all_Details.TabIndex = 8;
            this._lnklbl_all_Details.TabStop = true;
            this._lnklbl_all_Details.Text = "View";
            this._lnklbl_all_Details.Visible = false;
            this._lnklbl_all_Details.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_Details___LinkClicked);
            // 
            // lbl_all_statue
            // 
            this.lbl_all_statue.AutoSize = true;
            this.lbl_all_statue.ForeColor = System.Drawing.Color.White;
            this.lbl_all_statue.Location = new System.Drawing.Point(216, 55);
            this.lbl_all_statue.Name = "lbl_all_statue";
            this.lbl_all_statue.Size = new System.Drawing.Size(13, 15);
            this.lbl_all_statue.TabIndex = 7;
            this.lbl_all_statue.Text = "..";
            this.lbl_all_statue.Visible = false;
            this.lbl_all_statue.TextChanged += new System.EventHandler(this._statue_lbl_TextChanged);
            // 
            // label_Details
            // 
            this.label_Details.AutoSize = true;
            this.label_Details.ForeColor = System.Drawing.Color.Magenta;
            this.label_Details.Location = new System.Drawing.Point(776, 19);
            this.label_Details.Name = "label_Details";
            this.label_Details.Size = new System.Drawing.Size(43, 15);
            this.label_Details.TabIndex = 6;
            this.label_Details.Text = "Details";
            // 
            // label___note__
            // 
            this.label___note__.AutoSize = true;
            this.label___note__.ForeColor = System.Drawing.Color.Magenta;
            this.label___note__.Location = new System.Drawing.Point(460, 19);
            this.label___note__.Name = "label___note__";
            this.label___note__.Size = new System.Drawing.Size(32, 15);
            this.label___note__.TabIndex = 6;
            this.label___note__.Text = "Note";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Magenta;
            this.label5.Location = new System.Drawing.Point(707, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Options";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(299, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Statue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(226, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Header";
            // 
            // lbl_cust_code
            // 
            this.lbl_cust_code.AutoSize = true;
            this.lbl_cust_code.ForeColor = System.Drawing.Color.White;
            this.lbl_cust_code.Location = new System.Drawing.Point(313, 250);
            this.lbl_cust_code.Name = "lbl_cust_code";
            this.lbl_cust_code.Size = new System.Drawing.Size(16, 15);
            this.lbl_cust_code.TabIndex = 5;
            this.lbl_cust_code.Text = "...";
            this.lbl_cust_code.Visible = false;
            this.lbl_cust_code.TextChanged += new System.EventHandler(this.lbl_all_code_TextChanged_1);
            // 
            // lbl_useragent_code
            // 
            this.lbl_useragent_code.AutoSize = true;
            this.lbl_useragent_code.ForeColor = System.Drawing.Color.White;
            this.lbl_useragent_code.Location = new System.Drawing.Point(313, 210);
            this.lbl_useragent_code.Name = "lbl_useragent_code";
            this.lbl_useragent_code.Size = new System.Drawing.Size(16, 15);
            this.lbl_useragent_code.TabIndex = 5;
            this.lbl_useragent_code.Text = "...";
            this.lbl_useragent_code.Visible = false;
            this.lbl_useragent_code.TextChanged += new System.EventHandler(this.lbl_all_code_TextChanged_1);
            // 
            // lbl_Cookie_code
            // 
            this.lbl_Cookie_code.AutoSize = true;
            this.lbl_Cookie_code.ForeColor = System.Drawing.Color.White;
            this.lbl_Cookie_code.Location = new System.Drawing.Point(313, 175);
            this.lbl_Cookie_code.Name = "lbl_Cookie_code";
            this.lbl_Cookie_code.Size = new System.Drawing.Size(16, 15);
            this.lbl_Cookie_code.TabIndex = 5;
            this.lbl_Cookie_code.Text = "...";
            this.lbl_Cookie_code.Visible = false;
            this.lbl_Cookie_code.TextChanged += new System.EventHandler(this.lbl_all_code_TextChanged_1);
            // 
            // lbl_Referer_code
            // 
            this.lbl_Referer_code.AutoSize = true;
            this.lbl_Referer_code.ForeColor = System.Drawing.Color.White;
            this.lbl_Referer_code.Location = new System.Drawing.Point(313, 135);
            this.lbl_Referer_code.Name = "lbl_Referer_code";
            this.lbl_Referer_code.Size = new System.Drawing.Size(16, 15);
            this.lbl_Referer_code.TabIndex = 5;
            this.lbl_Referer_code.Text = "...";
            this.lbl_Referer_code.Visible = false;
            this.lbl_Referer_code.TextChanged += new System.EventHandler(this.lbl_all_code_TextChanged_1);
            // 
            // lbl_Xforwarded_Code
            // 
            this.lbl_Xforwarded_Code.AutoSize = true;
            this.lbl_Xforwarded_Code.ForeColor = System.Drawing.Color.White;
            this.lbl_Xforwarded_Code.Location = new System.Drawing.Point(313, 95);
            this.lbl_Xforwarded_Code.Name = "lbl_Xforwarded_Code";
            this.lbl_Xforwarded_Code.Size = new System.Drawing.Size(16, 15);
            this.lbl_Xforwarded_Code.TabIndex = 5;
            this.lbl_Xforwarded_Code.Text = "...";
            this.lbl_Xforwarded_Code.Visible = false;
            this.lbl_Xforwarded_Code.TextChanged += new System.EventHandler(this.lbl_all_code_TextChanged_1);
            // 
            // rbCust
            // 
            this.rbCust.AutoSize = true;
            this.rbCust.ForeColor = System.Drawing.Color.White;
            this.rbCust.Location = new System.Drawing.Point(10, 250);
            this.rbCust.Name = "rbCust";
            this.rbCust.Size = new System.Drawing.Size(60, 19);
            this.rbCust.TabIndex = 4;
            this.rbCust.Text = "custom";
            this.rbCust.UseVisualStyleBackColor = true;
            this.rbCust.CheckedChanged += new System.EventHandler(this.OptionChanged);
            this.rbCust.TextChanged += new System.EventHandler(this.rbCust_TextChanged);
            // 
            // rbUserAgent
            // 
            this.rbUserAgent.AutoSize = true;
            this.rbUserAgent.ForeColor = System.Drawing.Color.White;
            this.rbUserAgent.Location = new System.Drawing.Point(10, 210);
            this.rbUserAgent.Name = "rbUserAgent";
            this.rbUserAgent.Size = new System.Drawing.Size(83, 19);
            this.rbUserAgent.TabIndex = 4;
            this.rbUserAgent.Text = "User-Agent";
            this.rbUserAgent.UseVisualStyleBackColor = true;
            this.rbUserAgent.CheckedChanged += new System.EventHandler(this.OptionChanged);
            // 
            // RBCookie
            // 
            this.RBCookie.AutoSize = true;
            this.RBCookie.ForeColor = System.Drawing.Color.White;
            this.RBCookie.Location = new System.Drawing.Point(10, 175);
            this.RBCookie.Name = "RBCookie";
            this.RBCookie.Size = new System.Drawing.Size(60, 19);
            this.RBCookie.TabIndex = 4;
            this.RBCookie.Text = "Cookie";
            this.RBCookie.UseVisualStyleBackColor = true;
            this.RBCookie.CheckedChanged += new System.EventHandler(this.OptionChanged);
            // 
            // _lnklbl_custom_Details
            // 
            this._lnklbl_custom_Details.AutoSize = true;
            this._lnklbl_custom_Details.Location = new System.Drawing.Point(787, 250);
            this._lnklbl_custom_Details.Name = "_lnklbl_custom_Details";
            this._lnklbl_custom_Details.Size = new System.Drawing.Size(32, 15);
            this._lnklbl_custom_Details.TabIndex = 3;
            this._lnklbl_custom_Details.TabStop = true;
            this._lnklbl_custom_Details.Text = "View";
            this._lnklbl_custom_Details.Visible = false;
            this._lnklbl_custom_Details.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_Details___LinkClicked);
            // 
            // RB_Referer
            // 
            this.RB_Referer.AutoSize = true;
            this.RB_Referer.ForeColor = System.Drawing.Color.White;
            this.RB_Referer.Location = new System.Drawing.Point(10, 135);
            this.RB_Referer.Name = "RB_Referer";
            this.RB_Referer.Size = new System.Drawing.Size(66, 19);
            this.RB_Referer.TabIndex = 4;
            this.RB_Referer.Text = "Referer";
            this.RB_Referer.UseVisualStyleBackColor = true;
            this.RB_Referer.CheckedChanged += new System.EventHandler(this.OptionChanged);
            // 
            // _lnklbl_useragent_Details
            // 
            this._lnklbl_useragent_Details.AutoSize = true;
            this._lnklbl_useragent_Details.Location = new System.Drawing.Point(787, 210);
            this._lnklbl_useragent_Details.Name = "_lnklbl_useragent_Details";
            this._lnklbl_useragent_Details.Size = new System.Drawing.Size(32, 15);
            this._lnklbl_useragent_Details.TabIndex = 3;
            this._lnklbl_useragent_Details.TabStop = true;
            this._lnklbl_useragent_Details.Text = "View";
            this._lnklbl_useragent_Details.Visible = false;
            this._lnklbl_useragent_Details.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_Details___LinkClicked);
            // 
            // RB_X_Forwarded_For
            // 
            this.RB_X_Forwarded_For.AutoSize = true;
            this.RB_X_Forwarded_For.ForeColor = System.Drawing.Color.White;
            this.RB_X_Forwarded_For.Location = new System.Drawing.Point(10, 95);
            this.RB_X_Forwarded_For.Name = "RB_X_Forwarded_For";
            this.RB_X_Forwarded_For.Size = new System.Drawing.Size(112, 19);
            this.RB_X_Forwarded_For.TabIndex = 4;
            this.RB_X_Forwarded_For.Text = "X-Forwarded-For";
            this.RB_X_Forwarded_For.UseVisualStyleBackColor = true;
            this.RB_X_Forwarded_For.CheckedChanged += new System.EventHandler(this.OptionChanged);
            // 
            // _lnklbl_Cookie_Details
            // 
            this._lnklbl_Cookie_Details.AutoSize = true;
            this._lnklbl_Cookie_Details.Location = new System.Drawing.Point(787, 175);
            this._lnklbl_Cookie_Details.Name = "_lnklbl_Cookie_Details";
            this._lnklbl_Cookie_Details.Size = new System.Drawing.Size(32, 15);
            this._lnklbl_Cookie_Details.TabIndex = 3;
            this._lnklbl_Cookie_Details.TabStop = true;
            this._lnklbl_Cookie_Details.Text = "View";
            this._lnklbl_Cookie_Details.Visible = false;
            this._lnklbl_Cookie_Details.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_Details___LinkClicked);
            // 
            // lbl_cust_statue
            // 
            this.lbl_cust_statue.AutoSize = true;
            this.lbl_cust_statue.ForeColor = System.Drawing.Color.White;
            this.lbl_cust_statue.Location = new System.Drawing.Point(216, 250);
            this.lbl_cust_statue.Name = "lbl_cust_statue";
            this.lbl_cust_statue.Size = new System.Drawing.Size(13, 15);
            this.lbl_cust_statue.TabIndex = 2;
            this.lbl_cust_statue.Text = "..";
            this.lbl_cust_statue.Visible = false;
            this.lbl_cust_statue.TextChanged += new System.EventHandler(this._statue_lbl_TextChanged);
            // 
            // _lnklbl_Referer_Details
            // 
            this._lnklbl_Referer_Details.AutoSize = true;
            this._lnklbl_Referer_Details.Location = new System.Drawing.Point(787, 135);
            this._lnklbl_Referer_Details.Name = "_lnklbl_Referer_Details";
            this._lnklbl_Referer_Details.Size = new System.Drawing.Size(32, 15);
            this._lnklbl_Referer_Details.TabIndex = 3;
            this._lnklbl_Referer_Details.TabStop = true;
            this._lnklbl_Referer_Details.Text = "View";
            this._lnklbl_Referer_Details.Visible = false;
            this._lnklbl_Referer_Details.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_Details___LinkClicked);
            // 
            // lbl_useragent_statue
            // 
            this.lbl_useragent_statue.AutoSize = true;
            this.lbl_useragent_statue.ForeColor = System.Drawing.Color.White;
            this.lbl_useragent_statue.Location = new System.Drawing.Point(216, 210);
            this.lbl_useragent_statue.Name = "lbl_useragent_statue";
            this.lbl_useragent_statue.Size = new System.Drawing.Size(13, 15);
            this.lbl_useragent_statue.TabIndex = 2;
            this.lbl_useragent_statue.Text = "..";
            this.lbl_useragent_statue.Visible = false;
            this.lbl_useragent_statue.TextChanged += new System.EventHandler(this._statue_lbl_TextChanged);
            // 
            // _lnklbl_XForwardedFor_Details
            // 
            this._lnklbl_XForwardedFor_Details.AutoSize = true;
            this._lnklbl_XForwardedFor_Details.Location = new System.Drawing.Point(787, 95);
            this._lnklbl_XForwardedFor_Details.Name = "_lnklbl_XForwardedFor_Details";
            this._lnklbl_XForwardedFor_Details.Size = new System.Drawing.Size(32, 15);
            this._lnklbl_XForwardedFor_Details.TabIndex = 3;
            this._lnklbl_XForwardedFor_Details.TabStop = true;
            this._lnklbl_XForwardedFor_Details.Text = "View";
            this._lnklbl_XForwardedFor_Details.Visible = false;
            this._lnklbl_XForwardedFor_Details.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_Details___LinkClicked);
            // 
            // lbl_Cookie_statue
            // 
            this.lbl_Cookie_statue.AutoSize = true;
            this.lbl_Cookie_statue.ForeColor = System.Drawing.Color.White;
            this.lbl_Cookie_statue.Location = new System.Drawing.Point(216, 175);
            this.lbl_Cookie_statue.Name = "lbl_Cookie_statue";
            this.lbl_Cookie_statue.Size = new System.Drawing.Size(13, 15);
            this.lbl_Cookie_statue.TabIndex = 2;
            this.lbl_Cookie_statue.Text = "..";
            this.lbl_Cookie_statue.Visible = false;
            this.lbl_Cookie_statue.TextChanged += new System.EventHandler(this._statue_lbl_TextChanged);
            this.lbl_Cookie_statue.Click += new System.EventHandler(this.lbl_Cookie_statue_Click);
            // 
            // lbl_Referer_Statue
            // 
            this.lbl_Referer_Statue.AutoSize = true;
            this.lbl_Referer_Statue.ForeColor = System.Drawing.Color.White;
            this.lbl_Referer_Statue.Location = new System.Drawing.Point(216, 135);
            this.lbl_Referer_Statue.Name = "lbl_Referer_Statue";
            this.lbl_Referer_Statue.Size = new System.Drawing.Size(13, 15);
            this.lbl_Referer_Statue.TabIndex = 2;
            this.lbl_Referer_Statue.Text = "..";
            this.lbl_Referer_Statue.Visible = false;
            this.lbl_Referer_Statue.TextChanged += new System.EventHandler(this._statue_lbl_TextChanged);
            // 
            // lbl_XforwardedFor_statue
            // 
            this.lbl_XforwardedFor_statue.AutoSize = true;
            this.lbl_XforwardedFor_statue.ForeColor = System.Drawing.Color.White;
            this.lbl_XforwardedFor_statue.Location = new System.Drawing.Point(216, 95);
            this.lbl_XforwardedFor_statue.Name = "lbl_XforwardedFor_statue";
            this.lbl_XforwardedFor_statue.Size = new System.Drawing.Size(13, 15);
            this.lbl_XforwardedFor_statue.TabIndex = 1;
            this.lbl_XforwardedFor_statue.Text = "..";
            this.lbl_XforwardedFor_statue.Visible = false;
            this.lbl_XforwardedFor_statue.TextChanged += new System.EventHandler(this._statue_lbl_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lnklBL_Close);
            this.panel1.Controls.Add(this.GPXResult);
            this.panel1.Controls.Add(this.GPXurl);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 433);
            this.panel1.TabIndex = 0;
            // 
            // lnklBL_Close
            // 
            this.lnklBL_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklBL_Close.AutoSize = true;
            this.lnklBL_Close.LinkColor = System.Drawing.Color.Red;
            this.lnklBL_Close.Location = new System.Drawing.Point(845, -3);
            this.lnklBL_Close.Name = "lnklBL_Close";
            this.lnklBL_Close.Size = new System.Drawing.Size(15, 15);
            this.lnklBL_Close.TabIndex = 14;
            this.lnklBL_Close.TabStop = true;
            this.lnklBL_Close.Text = "X";
            this.lnklBL_Close.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklBL_Close_LinkClicked);
            // 
            // FormAttacker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Web_Gunners.Properties.Resources.mic;
            this.ClientSize = new System.Drawing.Size(866, 439);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAttacker";
            this.Opacity = 0.96D;
            this.Text = "Web_Gunners";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.GPXurl.ResumeLayout(false);
            this.GPXurl.PerformLayout();
            this.GPXResult.ResumeLayout(false);
            this.GPXResult.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GPXurl;
        private System.Windows.Forms.TextBox TxbxUrl;
        private System.Windows.Forms.GroupBox GPXResult;
        private System.Windows.Forms.Label lbl_all_code;
        private System.Windows.Forms.RadioButton Rb_Multi;
        private System.Windows.Forms.LinkLabel _lnklbl_all_Details;
        private System.Windows.Forms.Label lbl_all_statue;
        private System.Windows.Forms.Label label_Details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cust_code;
        private System.Windows.Forms.Label lbl_useragent_code;
        private System.Windows.Forms.Label lbl_Cookie_code;
        private System.Windows.Forms.Label lbl_Referer_code;
        private System.Windows.Forms.Label lbl_Xforwarded_Code;
        private System.Windows.Forms.RadioButton rbCust;
        private System.Windows.Forms.RadioButton rbUserAgent;
        private System.Windows.Forms.RadioButton RBCookie;
        private System.Windows.Forms.LinkLabel _lnklbl_custom_Details;
        private System.Windows.Forms.RadioButton RB_Referer;
        private System.Windows.Forms.LinkLabel _lnklbl_useragent_Details;
        private System.Windows.Forms.RadioButton RB_X_Forwarded_For;
        private System.Windows.Forms.LinkLabel _lnklbl_Cookie_Details;
        private System.Windows.Forms.Label lbl_cust_statue;
        private System.Windows.Forms.LinkLabel _lnklbl_Referer_Details;
        private System.Windows.Forms.Label lbl_useragent_statue;
        private System.Windows.Forms.LinkLabel _lnklbl_XForwardedFor_Details;
        private System.Windows.Forms.Label lbl_Cookie_statue;
        private System.Windows.Forms.Label lbl_Referer_Statue;
        private System.Windows.Forms.Label lbl_XforwardedFor_statue;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_hint_all;
        private System.Windows.Forms.Label lbl_hint_xf;
        private System.Windows.Forms.Label lbl_hint_agent;
        private System.Windows.Forms.Label lbl_hint_referer;
        private System.Windows.Forms.Label lbl_hint_cookie;
        private System.Windows.Forms.Label label___note__;
        private System.Windows.Forms.LinkLabel lnklbl_OP_Multi_Select;
        private System.Windows.Forms.LinkLabel lnklbl_OP_single;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_Adv;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbl_hint_Cust;
        private System.Windows.Forms.LinkLabel lnklBL_Close;


    }
}

