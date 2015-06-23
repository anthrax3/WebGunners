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
    public partial class FrmParser : Form
    {
        private string[] p;

        public FrmParser(string s="")
        {
            InitializeComponent();


            this.webBrowser1.DocumentText = s;
        }
 

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.webBrowser1.Visible = true;
        }

        private void FrmParser_Load(object sender, EventArgs e)
        {

        }
    }
}
