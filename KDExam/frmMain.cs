using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDExam
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.pictureBox2_Click(sender,e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmShouye frm = new frmShouye();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            frm.TopLevel = false;
            this.panMain.Controls.Clear();
            this.panMain.Controls.Add(frm);
            frm.Show();
        }

        private void picDagang_Click(object sender, EventArgs e)
        {
            frmDagang frm = new frmDagang();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            frm.TopLevel = false;
            this.panMain.Controls.Clear();
            this.panMain.Controls.Add(frm);
            frm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmShiyong frm = new frmShiyong();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            frm.TopLevel = false;
            this.panMain.Controls.Clear();
            this.panMain.Controls.Add(frm);
            frm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmLianxi frm = new frmLianxi();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);

            frm.TopLevel = false;
            this.panMain.Controls.Clear();
            this.panMain.Controls.Add(frm);
            frm.Show();
        }
    }
}
