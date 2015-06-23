namespace Web_Gunners
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.IconSettings = new System.Windows.Forms.Button();
            this.labelNotf = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_Home_Container = new System.Windows.Forms.Panel();
            this.lnklblSettings = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.lnklbl_ScanByDetector = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.lnklblRepeater = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lnklbl_AboDoma = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.panelHead = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tstrb_File = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tstrb_Tools = new System.Windows.Forms.ToolStripMenuItem();
            this.repeaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MrCodeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.reflectedDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Collector_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diggerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xsserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tstrb_Hint = new System.Windows.Forms.ToolStripMenuItem();
            this.Tstrb_proxySwitcher_ = new System.Windows.Forms.ToolStripMenuItem();
            this.requestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.Tstrb_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_Home_Container.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.Black;
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panelBody);
            this.panelMain.Controls.Add(this.panelHead);
            this.panelMain.Location = new System.Drawing.Point(1, 1);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(922, 518);
            this.panelMain.TabIndex = 0;
            this.panelMain.DockChanged += new System.EventHandler(this.panelMain_DockChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.IconSettings);
            this.panel1.Controls.Add(this.labelNotf);
            this.panel1.Location = new System.Drawing.Point(0, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 22);
            this.panel1.TabIndex = 9;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(803, 4);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Made in Egypt";
            // 
            // IconSettings
            // 
            this.IconSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IconSettings.BackgroundImage = global::Web_Gunners.Properties.Resources.Set;
            this.IconSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconSettings.ForeColor = System.Drawing.Color.Black;
            this.IconSettings.Location = new System.Drawing.Point(897, 1);
            this.IconSettings.Name = "IconSettings";
            this.IconSettings.Size = new System.Drawing.Size(19, 19);
            this.IconSettings.TabIndex = 5;
            this.IconSettings.UseVisualStyleBackColor = true;
            this.IconSettings.Visible = false;
            this.IconSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNotf
            // 
            this.labelNotf.AutoSize = true;
            this.labelNotf.Location = new System.Drawing.Point(3, 4);
            this.labelNotf.Name = "labelNotf";
            this.labelNotf.Size = new System.Drawing.Size(19, 13);
            this.labelNotf.TabIndex = 0;
            this.labelNotf.Text = "....";
            // 
            // panelBody
            // 
            this.panelBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBody.Controls.Add(this.tabControl1);
            this.panelBody.Location = new System.Drawing.Point(-4, 25);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(933, 475);
            this.panelBody.TabIndex = 8;
            this.panelBody.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBody_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(2, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 471);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.DragOver += new System.Windows.Forms.DragEventHandler(this.tabControl1_DragOver);
            this.tabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDown);
            this.tabControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseMove);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.panel_Home_Container);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(914, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // panel_Home_Container
            // 
            this.panel_Home_Container.BackColor = System.Drawing.Color.Black;
            this.panel_Home_Container.BackgroundImage = global::Web_Gunners.Properties.Resources.jd;
            this.panel_Home_Container.Controls.Add(this.lnklblSettings);
            this.panel_Home_Container.Controls.Add(this.panel2);
            this.panel_Home_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Home_Container.Location = new System.Drawing.Point(3, 3);
            this.panel_Home_Container.Name = "panel_Home_Container";
            this.panel_Home_Container.Size = new System.Drawing.Size(908, 439);
            this.panel_Home_Container.TabIndex = 0;
            // 
            // lnklblSettings
            // 
            this.lnklblSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnklblSettings.AutoSize = true;
            this.lnklblSettings.BackColor = System.Drawing.Color.Transparent;
            this.lnklblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lnklblSettings.LinkColor = System.Drawing.Color.Black;
            this.lnklblSettings.Location = new System.Drawing.Point(848, 9);
            this.lnklblSettings.Name = "lnklblSettings";
            this.lnklblSettings.Size = new System.Drawing.Size(45, 13);
            this.lnklblSettings.TabIndex = 6;
            this.lnklblSettings.TabStop = true;
            this.lnklblSettings.Text = "Settings";
            this.lnklblSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblSettings_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.linkLabel6);
            this.panel2.Controls.Add(this.lnklbl_ScanByDetector);
            this.panel2.Controls.Add(this.linkLabel5);
            this.panel2.Controls.Add(this.lnklblRepeater);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lnklbl_AboDoma);
            this.panel2.Controls.Add(this.linkLabel4);
            this.panel2.Location = new System.Drawing.Point(18, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 361);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Use";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoEllipsis = true;
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.linkLabel6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel6.Location = new System.Drawing.Point(65, 286);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(60, 20);
            this.linkLabel6.TabIndex = 6;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Ask.fm";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.social_clicked);
            // 
            // lnklbl_ScanByDetector
            // 
            this.lnklbl_ScanByDetector.AutoSize = true;
            this.lnklbl_ScanByDetector.BackColor = System.Drawing.Color.Transparent;
            this.lnklbl_ScanByDetector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lnklbl_ScanByDetector.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lnklbl_ScanByDetector.Location = new System.Drawing.Point(65, 53);
            this.lnklbl_ScanByDetector.Name = "lnklbl_ScanByDetector";
            this.lnklbl_ScanByDetector.Size = new System.Drawing.Size(271, 20);
            this.lnklbl_ScanByDetector.TabIndex = 0;
            this.lnklbl_ScanByDetector.TabStop = true;
            this.lnklbl_ScanByDetector.Text = "Scan Web App for reflected heaers";
            this.lnklbl_ScanByDetector.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_ScanByDetector_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoEllipsis = true;
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.linkLabel5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel5.Location = new System.Drawing.Point(65, 258);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(81, 20);
            this.linkLabel5.TabIndex = 5;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Facebook";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.social_clicked);
            // 
            // lnklblRepeater
            // 
            this.lnklblRepeater.AutoSize = true;
            this.lnklblRepeater.BackColor = System.Drawing.Color.Transparent;
            this.lnklblRepeater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lnklblRepeater.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lnklblRepeater.Location = new System.Drawing.Point(65, 88);
            this.lnklblRepeater.Name = "lnklblRepeater";
            this.lnklblRepeater.Size = new System.Drawing.Size(248, 20);
            this.lnklblRepeater.TabIndex = 0;
            this.lnklblRepeater.TabStop = true;
            this.lnklblRepeater.Text = "Send customized HTTP request";
            this.lnklblRepeater.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblRepeater_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Support";
            // 
            // lnklbl_AboDoma
            // 
            this.lnklbl_AboDoma.AutoSize = true;
            this.lnklbl_AboDoma.BackColor = System.Drawing.Color.Transparent;
            this.lnklbl_AboDoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lnklbl_AboDoma.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lnklbl_AboDoma.Location = new System.Drawing.Point(65, 123);
            this.lnklbl_AboDoma.Name = "lnklbl_AboDoma";
            this.lnklbl_AboDoma.Size = new System.Drawing.Size(149, 20);
            this.lnklbl_AboDoma.TabIndex = 0;
            this.lnklbl_AboDoma.TabStop = true;
            this.lnklbl_AboDoma.Text = "Collect Information";
            this.lnklbl_AboDoma.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_Collector_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoEllipsis = true;
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel4.Location = new System.Drawing.Point(65, 228);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(60, 20);
            this.linkLabel4.TabIndex = 3;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Twitter";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.social_clicked);
            // 
            // panelHead
            // 
            this.panelHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHead.Controls.Add(this.menuStrip1);
            this.panelHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelHead.Location = new System.Drawing.Point(0, 1);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(918, 22);
            this.panelHead.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstrb_File,
            this.Tstrb_Tools,
            this.Tstrb_Hint,
            this.Tstrb_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(918, 22);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tstrb_File
            // 
            this.tstrb_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromFileToolStripMenuItem});
            this.tstrb_File.Name = "tstrb_File";
            this.tstrb_File.Size = new System.Drawing.Size(37, 18);
            this.tstrb_File.Text = "File";
            // 
            // fromFileToolStripMenuItem
            // 
            this.fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
            this.fromFileToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.fromFileToolStripMenuItem.Text = "Load request";
            this.fromFileToolStripMenuItem.Click += new System.EventHandler(this.fromFileToolStripMenuItem_Click);
            // 
            // Tstrb_Tools
            // 
            this.Tstrb_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repeaterToolStripMenuItem,
            this.MrCodeBtn,
            this.reflectedDetectorToolStripMenuItem,
            this.Collector_ToolStripMenuItem,
            this.diggerToolStripMenuItem,
            this.xsserToolStripMenuItem,
            this.watcherToolStripMenuItem,
            this.scriptorToolStripMenuItem});
            this.Tstrb_Tools.Name = "Tstrb_Tools";
            this.Tstrb_Tools.Size = new System.Drawing.Size(48, 18);
            this.Tstrb_Tools.Text = "Tools";
            // 
            // repeaterToolStripMenuItem
            // 
            this.repeaterToolStripMenuItem.Name = "repeaterToolStripMenuItem";
            this.repeaterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.repeaterToolStripMenuItem.Text = "Repeater";
            this.repeaterToolStripMenuItem.Click += new System.EventHandler(this.repeaterToolStripMenuItem_Click);
            // 
            // MrCodeBtn
            // 
            this.MrCodeBtn.Name = "MrCodeBtn";
            this.MrCodeBtn.Size = new System.Drawing.Size(152, 22);
            this.MrCodeBtn.Text = "Mr Code";
            this.MrCodeBtn.Click += new System.EventHandler(this.mrCode_Click_1);
            // 
            // reflectedDetectorToolStripMenuItem
            // 
            this.reflectedDetectorToolStripMenuItem.Name = "reflectedDetectorToolStripMenuItem";
            this.reflectedDetectorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reflectedDetectorToolStripMenuItem.Text = "Reflector";
            this.reflectedDetectorToolStripMenuItem.Click += new System.EventHandler(this.reflectedDetectorToolStripMenuItem_Click);
            // 
            // Collector_ToolStripMenuItem
            // 
            this.Collector_ToolStripMenuItem.Name = "Collector_ToolStripMenuItem";
            this.Collector_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Collector_ToolStripMenuItem.Text = "Collector";
            this.Collector_ToolStripMenuItem.Click += new System.EventHandler(this.Collector_ToolStripMenuItem_Click);
            // 
            // diggerToolStripMenuItem
            // 
            this.diggerToolStripMenuItem.Name = "diggerToolStripMenuItem";
            this.diggerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.diggerToolStripMenuItem.Text = "Digger";
            this.diggerToolStripMenuItem.Click += new System.EventHandler(this.diggerToolStripMenuItem_Click);
            // 
            // xsserToolStripMenuItem
            // 
            this.xsserToolStripMenuItem.Name = "xsserToolStripMenuItem";
            this.xsserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xsserToolStripMenuItem.Text = "Xsser";
            this.xsserToolStripMenuItem.Click += new System.EventHandler(this.xsserToolStripMenuItem_Click);
            // 
            // watcherToolStripMenuItem
            // 
            this.watcherToolStripMenuItem.Name = "watcherToolStripMenuItem";
            this.watcherToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.watcherToolStripMenuItem.Text = "Watcher";
            this.watcherToolStripMenuItem.Click += new System.EventHandler(this.watcherToolStripMenuItem_Click);
            // 
            // scriptorToolStripMenuItem
            // 
            this.scriptorToolStripMenuItem.Name = "scriptorToolStripMenuItem";
            this.scriptorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.scriptorToolStripMenuItem.Text = "Scriptor";
            this.scriptorToolStripMenuItem.Click += new System.EventHandler(this.scriptorToolStripMenuItem_Click);
            // 
            // Tstrb_Hint
            // 
            this.Tstrb_Hint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tstrb_proxySwitcher_,
            this.requestsToolStripMenuItem,
            this.btnSettings});
            this.Tstrb_Hint.Name = "Tstrb_Hint";
            this.Tstrb_Hint.Size = new System.Drawing.Size(42, 18);
            this.Tstrb_Hint.Text = "Hint";
            // 
            // Tstrb_proxySwitcher_
            // 
            this.Tstrb_proxySwitcher_.Name = "Tstrb_proxySwitcher_";
            this.Tstrb_proxySwitcher_.Size = new System.Drawing.Size(152, 22);
            this.Tstrb_proxySwitcher_.Text = "Jersi Proxy";
            this.Tstrb_proxySwitcher_.Click += new System.EventHandler(this.Tstrb_proxySwitcher__Click);
            // 
            // requestsToolStripMenuItem
            // 
            this.requestsToolStripMenuItem.Enabled = false;
            this.requestsToolStripMenuItem.Name = "requestsToolStripMenuItem";
            this.requestsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.requestsToolStripMenuItem.Text = "Requests";
            this.requestsToolStripMenuItem.Click += new System.EventHandler(this.requestsToolStripMenuItem_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(152, 22);
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Tstrb_Help
            // 
            this.Tstrb_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.Tstrb_Help.Name = "Tstrb_Help";
            this.Tstrb_Help.Size = new System.Drawing.Size(44, 18);
            this.Tstrb_Help.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Web Gunner ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel_Home_Container.ResumeLayout(false);
            this.panel_Home_Container.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tstrb_File;
        private System.Windows.Forms.ToolStripMenuItem Tstrb_Tools;
        private System.Windows.Forms.ToolStripMenuItem repeaterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MrCodeBtn;
        private System.Windows.Forms.ToolStripMenuItem Tstrb_Hint;
        private System.Windows.Forms.ToolStripMenuItem requestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tstrb_Help;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel_Home_Container;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reflectedDetectorToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNotf;
        private System.Windows.Forms.ToolStripMenuItem btnSettings;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem Collector_ToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnklbl_ScanByDetector;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnklblRepeater;
        private System.Windows.Forms.LinkLabel lnklbl_AboDoma;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel lnklblSettings;
        private System.Windows.Forms.ToolStripMenuItem diggerToolStripMenuItem;
        private System.Windows.Forms.Button IconSettings;
        private System.Windows.Forms.ToolStripMenuItem xsserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Tstrb_proxySwitcher_;
        private System.Windows.Forms.ToolStripMenuItem watcherToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripMenuItem scriptorToolStripMenuItem;
    }
}