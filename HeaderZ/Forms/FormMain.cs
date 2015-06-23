using Web_Gunners.Forms;
using Web_Gunners.Forms.Tools;
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

namespace Web_Gunners
{
    public partial class FormMain : Form
    {
        List<__HTTTPAttack_> _Atacks_List_ = new List<__HTTTPAttack_>();
        JersiProxiFrm __proxySwitcherFrm_Object;
        FrmAttacks __Attacks_Frm_Obj = new FrmAttacks();
        FormAttacker __FormAttacker_Obje = new FormAttacker();
        private int LasTSelectedIndex = -1;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            ///
            ///
            ///
            // debugging
           // LoadReflectorTab();
            //tabControl1.SelectedIndex = 1;
            
           // LoadScriptorTab(true);
        }

        public void LoadReflectorTab(bool nav = false, string url = "")
        {

            if (IsOpenedBefore(  TabPageType.Reflector))
            {
                flashTabpage("Reflector");
                tabControl1.SelectedIndex = BrotherIndex(TabPageType.Reflector);
                if (url != "")
                    __FormAttacker_Obje.SetUrl(url);
                return;
            }

            TabPage tp = new TabPage();
            tp.Text = tp.Name = "Reflector";
            tp.ToolTipText = TabPageType.Reflector.ToString();


            //  this.panel_Home_Container.Controls.Clear();
            this.tabControl1.TabPages.Add(tp);
            int selind = tabControl1.TabCount - 1;

             __FormAttacker_Obje = new FormAttacker(url); __FormAttacker_Obje.Owner = this;
            this.IsMdiContainer = true;
            __FormAttacker_Obje.TopLevel = false;
            this.tabControl1.TabPages[selind].Controls.Add(__FormAttacker_Obje);
            __FormAttacker_Obje.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            __FormAttacker_Obje.Dock = DockStyle.Fill;
            __FormAttacker_Obje.Show();
            if (nav)
                tabControl1.SelectedIndex = selind;

        }
        
        bool IsOpenedBefore(TabPageType tpgtype,string p="")
        {
            bool checkid = (p != "");
            // prevent duplicated tabpages
            foreach (TabPage t in tabControl1.TabPages)
                if (t.ToolTipText.ToLower().Trim() == tpgtype.ToString().ToLower().Trim() )
                {
                    if (checkid==false)
                        return true;
                    else 
                    {
                        if (t.Name == p || t.Text == p)
                            return true;
                        
                    } 
                }

            return false;
        }
      public  int  BrotherIndex(TabPageType tpgtype)
        {
            // prevent duplicated tabpages
            int i = 0; 
          foreach (TabPage t in tabControl1.TabPages)
            {
                if ( t.ToolTipText.ToLower() == tpgtype.ToString().ToLower())
                     return i;
                i++;

            }
            return -1;
        }

        private void about_Click(object sender, EventArgs e)
        {
            LoadAboutTab(true);
        }


        private void repeaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadRepeaterTab(new __HTTTPAttack_("x"),true);
        }
        public void LoadRepeaterTab(__HTTTPAttack_ h, bool navigate = false)
        {
            if (IsOpenedBefore(  TabPageType.repeater,h.Id))
            {
                flashTabpage(h.Id);
                int broth = BrotherIndex(TabPageType.repeater);

                 return;
            }
            TabPage tp = new TabPage();
            tp.Text = "Repeater";
            tp.ToolTipText = TabPageType.repeater.ToString();
            tp.Name = h.Id;

            Panel cont = new Panel();
            cont.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(tp);
            int selind = tabControl1.TabCount - 1;
            //FrmRepeater_Object
            FrmRepeater FrmRepeater_Object = new FrmRepeater(h); FrmRepeater_Object.Owner = this;
            this.IsMdiContainer = true;
            FrmRepeater_Object.TopLevel = false;


            this.tabControl1.TabPages[selind].Controls.Clear();

            this.tabControl1.TabPages[selind].Controls.Add(cont);
            this.tabControl1.TabPages[selind].Controls[0].Controls.Add(FrmRepeater_Object);
            FrmRepeater_Object.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FrmRepeater_Object.Dock = DockStyle.Fill;
            FrmRepeater_Object.Show();

            if (navigate)
                tabControl1.SelectedIndex = selind;
        }

        private void flashTabpage(string p,bool nav=false)
        {
            for (int i = 0; i < tabControl1.TabCount; i++)
                if (tabControl1.TabPages[i].Name == p)
                {
                    SetTabHeader(tabControl1.TabPages[i], Color.Red); 
                    activ = i;
                    if (nav)
                        tabControl1.SelectedIndex = i;
                }
        } 
         /*
        public void LoadAttackDetailsTab(__HTTTPAttack_ _atk_, bool navigate = false)
        {
            if (IsOpenedBefore(_atk_.Id, TabPageType.Details))
            {
                flashTabpage(_atk_.Id);
                return;
            }

            TabPage tp = new TabPage();
            tp.Text = "Details ";/// +_atk_._Url.GetHost();
            tp.Name = _atk_.Id;

            Panel cont = new Panel();
            cont.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(tp);
            int selind = tabControl1.TabCount - 1;


            FrmAttackProcessDetails objForm = new FrmAttackProcessDetails(_atk_); objForm.Owner = this;
            this.IsMdiContainer = true;
            objForm.Owner = this;
            objForm.TopLevel = false;


            this.tabControl1.TabPages[selind].Controls.Clear();

            this.tabControl1.TabPages[selind].Controls.Add(cont);
            this.tabControl1.TabPages[selind].Controls[0].Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();

            if (navigate)
                tabControl1.SelectedIndex = selind;
        }
       */
        public void LoadAttackTab(string id = "", bool navigate = false)
        { 
            int brotherIndex = -1;

            if (IsOpenedBefore(  TabPageType.Attacks))
            { 
                flashTabpage("Attacks");
               
                if (id == "")
                    return;
                else
                {
                    brotherIndex = BrotherIndex(TabPageType.Attacks);

                    this.IndexChanged = true;
                    for (int i = 0; i < this._Atacks_List_.Count; i++)
                        if (_Atacks_List_[i].Id == id)
                        {
                            this.LasTSelectedIndex = i;
                            this.__Attacks_Frm_Obj.SelectThisIndex(i);
                        }
                }
                return;
            }
            TabPage tp = new TabPage();
            tp.Text = "Attacks ";
            tp.Name = "Attacks";
            tp.ToolTipText = TabPageType.Attacks.ToString();

            Panel cont = new Panel();
            cont.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(tp);
            int selind = tabControl1.TabCount - 1;

            int ix = __Attacks_Frm_Obj.getGridIndex();
            __Attacks_Frm_Obj = new FrmAttacks(_Atacks_List_, id,ix);  
            this.IsMdiContainer = true;
            __Attacks_Frm_Obj.Owner = this;
            __Attacks_Frm_Obj.TopLevel = false;


            this.tabControl1.TabPages[selind].Controls.Clear();

            this.tabControl1.TabPages[selind].Controls.Add(cont);
            this.tabControl1.TabPages[selind].Controls[0].Controls.Add(__Attacks_Frm_Obj);
            __Attacks_Frm_Obj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            __Attacks_Frm_Obj.Dock = DockStyle.Fill;
            __Attacks_Frm_Obj.Show();

            if (navigate)
                tabControl1.SelectedIndex = selind;
        }


        private void SetTabHeader(TabPage page, Color color)
        {
            tabControl1.Invalidate();
        }
        int activ = -1;
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //////// coloring
            e.DrawBackground();
            Color brushing_Col = (e.Index == tabControl1.SelectedIndex) ? (Color.OrangeRed) : Color.White;// ((e.Index % 2 == 0) ? Color.Gray : Color.White);

            if (brushing_Col == Color.White && e.Index % 2 ==0)
                brushing_Col = Color.LightGray;

            if (e.Index == activ && activ != -1)
                brushing_Col = Color.Orange;
            Brush br = new SolidBrush(brushing_Col);

            e.Graphics.FillRectangle(br, e.Bounds);
            SizeF sz = e.Graphics.MeasureString(tabControl1.TabPages[e.Index].Text, e.Font);
            e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + (e.Bounds.Width - sz.Width) / 2, e.Bounds.Top + (e.Bounds.Height - sz.Height) / 2 + 1);


        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == activ)
                activ = -1;
            IconSettings.Visible = (tabControl1.SelectedTab.Text.Trim() == "Reflector");
        }

        private void Tstrb_proxySwitcher__Click(object sender, EventArgs e)
        {
            if (SettingsManager.Use_ProxyInIsolatedWindow())
            {
                __proxySwitcherFrm_Object = new Forms.Tools.JersiProxiFrm();
                __proxySwitcherFrm_Object.Show();
            }
            else
                LoadProxyTab(true);
        }

        private void LoadProxyTab(bool p)
        {
            if (IsOpenedBefore(TabPageType.SystemProxy))
            {
                flashTabpage("SystemProxy");
                tabControl1.SelectedIndex += 1;
                return;
            }
            TabPage tp = new TabPage();
            tp.Text = tp.Name = "SystemProxy";
            tp.ToolTipText = TabPageType.SystemProxy.ToString();

            Panel cont = new Panel();
            cont.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(tp);
            int selind = tabControl1.TabCount - 1;


            JersiProxiFrm objForm = new JersiProxiFrm(false); objForm.Owner = this;
            this.IsMdiContainer = true;
            objForm.TopLevel = false;


            this.tabControl1.TabPages[selind].Controls.Clear();

            this.tabControl1.TabPages[selind].Controls.Add(cont);
            this.tabControl1.TabPages[selind].Controls[0].Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();


            if (p)
                tabControl1.SelectedIndex = selind;
        
        }

        private void fromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog o = new OpenFileDialog();
            o.Title = "Select a file to load ";
            if (o.ShowDialog() == DialogResult.OK)
            {
                if (o.FileName.ValidTextFile())
                {
                    LoadRepeaterTab(o.FileName, true);
                    Notifications("Loaded "+o.FileName);
                }
                else
                    Notifications("Invalid " + o.FileName);

            }
        }

        private void Notifications(string p)
        {
            labelNotf.Text = p;
        }

        private void LoadRepeaterTab(string FileName, bool p2)
        {
            if (IsOpenedBefore( TabPageType.repeater))
            {
                flashTabpage(FileName);
                tabControl1.SelectedIndex += 1;
                return;
            }

            TabPage tp = new TabPage();
            tp.Text = tp.Name = "Repeater";
            

            Panel cont = new Panel();
            cont.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(tp);
            int selind = tabControl1.TabCount - 1;

            FrmRepeater objForm = new FrmRepeater(FileName); objForm.Owner = this;
            this.IsMdiContainer = true;
            objForm.TopLevel = false;


            this.tabControl1.TabPages[selind].Controls.Clear();

            this.tabControl1.TabPages[selind].Controls.Add(cont);
            this.tabControl1.TabPages[selind].Controls[0].Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();

            if (p2)
                tabControl1.SelectedIndex = selind;

        }

        //




        internal void RemoveCurrentTab()
        {
            this.tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            this.panelMain.Location = new Point(11, 11);
        }

        private void reflectedDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadReflectorTab(true);
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoadAboutTab(true);

        }

        private void LoadAboutTab(bool p =false)
        {
            if (IsOpenedBefore(TabPageType.about))
            {
                flashTabpage("about");
                tabControl1.SelectedIndex += 1;
                return;
            }
            TabPage tp = new TabPage();
            tp.Text = tp.Name = "about";
            tp.ToolTipText = TabPageType.about.ToString();

            Panel cont = new Panel();
            cont.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(tp);
            int selind = tabControl1.TabCount - 1;


            FrmAbout objForm = new FrmAbout(); objForm.Owner = this;
            this.IsMdiContainer = true;
            objForm.TopLevel = false;


            this.tabControl1.TabPages[selind].Controls.Clear();

            this.tabControl1.TabPages[selind].Controls.Add(cont);
            this.tabControl1.TabPages[selind].Controls[0].Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();


            if (p)
                tabControl1.SelectedIndex = selind;
        
        }

        private void panelMain_DockChanged(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            LoadSettingsTab(true);
        }

        private void LoadSettingsTab(bool navigate,int ti=0)
        {
            if (IsOpenedBefore(  TabPageType.settings))
            {
                flashTabpage("settings",navigate); 
                return;
            }
            TabPage tp = new TabPage();
            tp.Text = tp.Name = "settings";
            tp.ToolTipText = TabPageType.settings.ToString();

            Panel cont = new Panel();
            cont.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(tp);
            int selind = tabControl1.TabCount - 1;


            FrmSettings objForm = new FrmSettings(ti); objForm.Owner = this;
            this.IsMdiContainer = true;
            objForm.TopLevel = false;


            this.tabControl1.TabPages[selind].Controls.Clear();

            this.tabControl1.TabPages[selind].Controls.Add(cont);
            this.tabControl1.TabPages[selind].Controls[0].Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();


            if (navigate)
                tabControl1.SelectedIndex = selind;
        
        }

        private void mrCode_Click_1(object sender, EventArgs e)
        {
            LoadMRCodeTab(true);

        }

        private void LoadMRCodeTab(bool navigate)
        {
            if (IsOpenedBefore(  TabPageType.MRCode))
            {
                flashTabpage("Mr Code");
                tabControl1.SelectedIndex = BrotherIndex(TabPageType.MRCode);
                return;
            }
            TabPage tp = new TabPage();
            tp.Text = tp.Name = "Mr Code";
            tp.ToolTipText = TabPageType.MRCode.ToString();

            Panel cont = new Panel();
            cont.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(tp);
            int selind = tabControl1.TabCount - 1;


            FrmMRCode objForm = new FrmMRCode(); objForm.Owner = this;
            this.IsMdiContainer = true;
            objForm.TopLevel = false;


            this.tabControl1.TabPages[selind].Controls.Clear();

            this.tabControl1.TabPages[selind].Controls.Add(cont);
            this.tabControl1.TabPages[selind].Controls[0].Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();


            if (navigate)
                tabControl1.SelectedIndex = selind;
        
        }

        internal void AddNewAttack(__HTTTPAttack_ at)
        {
            _Atacks_List_.Add(__HTTTPAttack_.Copy(at));
            requestsToolStripMenuItem.Enabled = _Atacks_List_.Count > 0;
            this.__Attacks_Frm_Obj.AddNewRecord(at);
             
        }

        private void requestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAttackTab("",true);
        }

        private Point DragStartPosition = Point.Empty;

        private void tabControl1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            DragStartPosition = new Point(e.X, e.Y);
        }


        private void tabControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            Rectangle r = new Rectangle(DragStartPosition, Size.Empty);
            r.Inflate(SystemInformation.DragSize);

            TabPage tp = HoverTab();

            if (tp != null)
            {
                if (!r.Contains(e.X, e.Y))
                    tabControl1.DoDragDrop(tp, DragDropEffects.All);
            }
            DragStartPosition = Point.Empty;
        }


        private void tabControl1_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            TabPage hover_Tab = HoverTab();
            if (hover_Tab == null)
                e.Effect = DragDropEffects.None;
            else
            {
                if (e.Data.GetDataPresent(typeof(TabPage)))
                {
                    e.Effect = DragDropEffects.Move;
                    TabPage drag_tab = (TabPage)e.Data.GetData(typeof(TabPage));

                    if (hover_Tab == drag_tab) return;

                    Rectangle TabRect = tabControl1.GetTabRect(tabControl1.TabPages.IndexOf(hover_Tab));
                    TabRect.Inflate(-3, -3);
                    if (TabRect.Contains(tabControl1.PointToClient(new Point(e.X, e.Y))))
                    {
                        SwapTabPages(drag_tab, hover_Tab);
                        tabControl1.SelectedTab = drag_tab;
                    }
                }
            }
        }


        private TabPage HoverTab()
        {
            for (int index = 0; index <= tabControl1.TabCount - 1; index++)
            {
                if (tabControl1.GetTabRect(index).Contains(tabControl1.PointToClient(Cursor.Position)))
                    return tabControl1.TabPages[index];
            }
            return null;
        }


        private void SwapTabPages(TabPage tp1, TabPage tp2)
        {
            int Index1 = tabControl1.TabPages.IndexOf(tp1);
            int Index2 = tabControl1.TabPages.IndexOf(tp2);
            tabControl1.TabPages[Index1] = tp2;
            tabControl1.TabPages[Index2] = tp1;
        }





        internal void Set_LasTSelectedIndex(int p)
        {
            this.LasTSelectedIndex= p;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (__Attacks_Frm_Obj == null)
                return;
            this.__Attacks_Frm_Obj.__Attacks_List.Clear();
            foreach (__HTTTPAttack_ h in this._Atacks_List_)
                this.__Attacks_Frm_Obj.__Attacks_List.Add(__HTTTPAttack_.Copy(h));
        }

        public bool IndexChanged { get; set; }

        internal int GetLastIndex()
        {
            return this.LasTSelectedIndex;
        }

        public __HTTTPAttack_ ToRepeater { get; set; }

        internal void SetNotification(string p,int s=1)
        {
            Thread.Sleep(s);

            labelNotf.Text = p;
            Thread.Sleep(1000);


        }

        private void Collector_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCollectorTab(true);
        }

        private void LoadCollectorTab(bool nav=false)
        {
            if (IsOpenedBefore(TabPageType.Collector))
            {
                flashTabpage("Collector");
                if (nav)
                    tabControl1.SelectedIndex = BrotherIndex(TabPageType.Collector);

                return;
            }

            TabPage tp = new TabPage();
            tp.Text = tp.Name = "Collector";
            tp.ToolTipText = TabPageType.Collector.ToString();


            //  this.panel_Home_Container.Controls.Clear();
            this.tabControl1.TabPages.Add(tp);
            int selind = tabControl1.TabCount - 1;


            FrmCollector objForm = new FrmCollector(); objForm.Owner = this;
            this.IsMdiContainer = true;
            objForm.TopLevel = false;
            this.tabControl1.TabPages[selind].Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();

            if (nav)
                tabControl1.SelectedIndex = selind;
            }

        private void lnklblRepeater_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadRepeaterTab(new __HTTTPAttack_("x"), true);

        }

        private void lnklbl_ScanByDetector_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadReflectorTab(true);

        }

        private void lnklbl_Collector_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadCollectorTab(true);

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LoadBrowserTab(string url="",bool navigate=false)
        {
            //this.browsingNow = url;
            //if (IsOpenedBefore(TabPageType.Browser))
            //{
            //    flashTabpage("Browser",true);
            //  //  int broth = BrotherIndex(TabPageType.Browser);
            //    return;
            //}
            TabPage tp = new TabPage();
            tp.Text = "Browser";
            tp.ToolTipText = TabPageType.Browser.ToString();
            tp.Name = "Browser";//h.Id;

            Panel cont = new Panel();
            cont.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(tp);
            int selind = tabControl1.TabCount - 1;

            FrmWebBrowser objForm = new FrmWebBrowser(url); objForm.Owner = this;
            this.IsMdiContainer = true;
            objForm.TopLevel = false;


            this.tabControl1.TabPages[selind].Controls.Clear();

            this.tabControl1.TabPages[selind].Controls.Add(cont);
            this.tabControl1.TabPages[selind].Controls[0].Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();

            if (navigate)
                tabControl1.SelectedIndex = selind;
        
        }

        public string browsingNow { get; set; }

        private void social_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string tex = (sender as LinkLabel).Text;
            if (tex.ToLower().Contains("ask"))
                tex = "http://ask.fm/yassergersy";
            else
                tex = "https://" + tex + ".com";
            LoadBrowserTab(tex, true);
           
        }

        private void lnklblSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadSettingsTab(true);

        }

        internal void LoadDiggerTab(string p, bool navigate = false)
        {
            if (IsOpenedBefore(  TabPageType.Digger,p))
            {
                flashTabpage(p,true); 
                 return;
            }
            TabPage tp = new TabPage();
            tp.Text = "Digger";
            tp.ToolTipText = TabPageType.Digger.ToString();
            tp.Name = p;

            Panel cont = new Panel();
            cont.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(tp);
            int selind = tabControl1.TabCount - 1;
            //FrmRepeater_Object
            FrmDigger FrmRepeater_Object = new FrmDigger(p); FrmRepeater_Object.Owner = this;
            this.IsMdiContainer = true;
            FrmRepeater_Object.TopLevel = false;


            this.tabControl1.TabPages[selind].Controls.Clear();

            this.tabControl1.TabPages[selind].Controls.Add(cont);
            this.tabControl1.TabPages[selind].Controls[0].Controls.Add(FrmRepeater_Object);
            FrmRepeater_Object.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FrmRepeater_Object.Dock = DockStyle.Fill;
            FrmRepeater_Object.Show();

            if (navigate)
                tabControl1.SelectedIndex = selind;
        
        }

        private void diggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadDiggerTab("",true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadSettingsTab(true,1);
        }

        private void xsserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadXsserTab(true);
        }

        private void LoadXsserTab(bool p)
        {
            if (IsOpenedBefore(TabPageType.Xsser))
            {
                flashTabpage("Xsser");
                tabControl1.SelectedIndex += 1;
                return;
            }
            TabPage tp = new TabPage();
            tp.Text = tp.Name = "Xsser";
            tp.ToolTipText = TabPageType.Xsser.ToString();

            Panel cont = new Panel();
            cont.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(tp);
            int selind = tabControl1.TabCount - 1;
             
            FrmXsser objForm = new FrmXsser(); objForm.Owner = this;
            this.IsMdiContainer = true;
            objForm.TopLevel = false;


            this.tabControl1.TabPages[selind].Controls.Clear();

            this.tabControl1.TabPages[selind].Controls.Add(cont);
            this.tabControl1.TabPages[selind].Controls[0].Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();


            if (p)
                tabControl1.SelectedIndex = selind;
        
        }

        private void watcherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Plz Do not use this tool"+Environment.NewLine+"it is a dirty-coded tool and it may affect on your computer performance","Watcher");
            LoadWatcherTab(true);
        }

        private void LoadWatcherTab(bool nav=false)
        {
            if (IsOpenedBefore(TabPageType.Watcher))
            {
                flashTabpage("Watcher", nav);
                return;
            }
            TabPage tp = new TabPage();
            tp.Text = "Watcher";
            tp.ToolTipText = TabPageType.Watcher.ToString();
            tp.Name = "Watcher";

            Panel cont = new Panel();
            cont.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(tp);
            int selind = tabControl1.TabCount - 1;
            //FrmRepeater_Object
            FrmInterCeptor FrmRepeater_Object = new FrmInterCeptor(); FrmRepeater_Object.Owner = this;
            this.IsMdiContainer = true;
            FrmRepeater_Object.TopLevel = false;


            this.tabControl1.TabPages[selind].Controls.Clear();

            this.tabControl1.TabPages[selind].Controls.Add(cont);
            this.tabControl1.TabPages[selind].Controls[0].Controls.Add(FrmRepeater_Object);
            FrmRepeater_Object.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FrmRepeater_Object.Dock = DockStyle.Fill;
            FrmRepeater_Object.Show();

            if (nav)
                tabControl1.SelectedIndex = selind;
        
       
        }

        private void scriptorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadScriptorTab(true);
        }

        private void LoadScriptorTab(bool navigate = false, string url = "")
        {
            if (IsOpenedBefore(TabPageType.Digger, ""))
            {
                flashTabpage(TabPageType.Scriptor.ToString(), true);
                return;
            }
            TabPage tp = new TabPage();
            tp.Text = "Digger";
            tp.ToolTipText = TabPageType.Scriptor.ToString();
            tp.Name = TabPageType.Scriptor.ToString();

            Panel cont = new Panel();
            cont.Dock = DockStyle.Fill;

            tabControl1.TabPages.Add(tp);
            int selind = tabControl1.TabCount - 1;
            //FrmRepeater_Object
            FrmScriptBoy FrmRepeater_Object = new FrmScriptBoy(url); FrmRepeater_Object.Owner = this;
            this.IsMdiContainer = true;
            FrmRepeater_Object.TopLevel = false;


            this.tabControl1.TabPages[selind].Controls.Clear();

            this.tabControl1.TabPages[selind].Controls.Add(cont);
            this.tabControl1.TabPages[selind].Controls[0].Controls.Add(FrmRepeater_Object);
            FrmRepeater_Object.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            FrmRepeater_Object.Dock = DockStyle.Fill;
            FrmRepeater_Object.Show();

            if (navigate)
                tabControl1.SelectedIndex = selind;
        
        }
         
    }
    public enum TabPageType { settings, home, proxer, repeater, Details, Reflector, MRCode, Attacks, about, Browser, Digger, Collector, SystemProxy, Xsser, Watcher, Scriptor }
}
