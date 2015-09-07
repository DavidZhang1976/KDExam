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
    public partial class frmDagang : Form
    {
        public frmDagang()
        {
            InitializeComponent();
        }

        private void btnDagang_Click(object sender, EventArgs e)
        {
            rtbMain.Clear();
            rtbMain.LoadFile("doc\\财经法规考试大纲.rtf");
        }

        private void frmDagang_Load(object sender, EventArgs e)
        {
            rtbMain.Clear();
            rtbMain.LoadFile("doc\\财经法规考试大纲.rtf");
        }

        private void btnZhinan_Click(object sender, EventArgs e)
        {
            rtbMain.Clear();
            rtbMain.LoadFile("doc\\报考指南.rtf");
        }

        private void btnJingyan_Click(object sender, EventArgs e)
        {
            rtbMain.Clear();
            rtbMain.LoadFile("doc\\过关经验.rtf");
        }

        private void btnWenku_Click(object sender, EventArgs e)
        {
            rtbMain.Clear();
            rtbMain.LoadFile("doc\\考试文库.rtf");
        }

        private void btnZixun_Click(object sender, EventArgs e)
        {
            rtbMain.Clear();
            rtbMain.LoadFile("doc\\考试资讯.rtf");
        }
    }
}
