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
    public partial class FrmDigger : Form
    {
        public FrmDigger(string p ="")
        {
            InitializeComponent();
            Thread.Sleep(100);
            txbxUrl.Text = p;
            GoBtn_Click(null, null);
        }

        private void GoBtn_Click(object sender, EventArgs e)
        {
            if(txbxUrl.Text.IsUrl())
            RtxbxSource.Text = __HTTTPAttack_.DownloadString(txbxUrl.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void txbxUrl_TextChanged(object sender, EventArgs e)
        {
            GoBtn.Enabled = txbxUrl.Text.IsUrl();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            RtxbxSource.HighlightNo(Color.Black);
            RtxbxSource.HighlightText(txbxPatern.Text.Trim(), Color.Red);
            timer1.Stop();
        }
    }
}
