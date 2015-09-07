using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; 

namespace KDExam
{
    public partial class frmLianxi : Form
    {
        public frmLianxi()
        {
            InitializeComponent();
        }

        private void frmLianxi_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString ="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=KJJC.accdb";
            conn.Open();
            string sql="select * from Chapter order by CCode";
            OleDbDataAdapter da = new OleDbDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "chapter");

            //foreach (DataRow row in ds.Tables[0].Rows)
            //{
            //    TreeNode node = new TreeNode(row["CDesr"].ToString());
            //    node.Name = row["CCode"].ToString();
            //    treeView1.Nodes.Add(node);
            //}

            Bind_Tv(ds.Tables[0], treeView1.Nodes, null, "id字段", "父id字段", "CDesr");

            conn.Close();
        }

        /// <summary>
        /// 绑定TreeView（利用TreeNodeCollection）
        /// </summary>
        /// <param name="tnc">TreeNodeCollection（TreeView的节点集合）</param>
        /// <param name="pid_val">父id的值</param>
        /// <param name="id">数据库 id 字段名</param>
        /// <param name="pid">数据库 父id 字段名</param>
        /// <param name="text">数据库 文本 字段值</param>
        private void Bind_Tv(DataTable dt, TreeNodeCollection tnc, string pid_val, string id, string pid, string text)
        {
            DataView dv = new DataView(dt);//将DataTable存到DataView中，以便于筛选数据
            TreeNode tn;//建立TreeView的节点（TreeNode），以便将取出的数据添加到节点中
            //以下为三元运算符，如果父id为空，则为构建“父id字段 is null”的查询条件，否则构建“父id字段=父id字段值”的查询条件
            string filter = string.IsNullOrEmpty(pid_val) ? pid + " is null" : string.Format(pid + "='{0}'", pid_val);
            dv.RowFilter = filter;//利用DataView将数据进行筛选，选出相同 父id值 的数据
            foreach (DataRowView drv in dv)
            {
                tn = new TreeNode();//建立一个新节点（学名叫：一个实例）
                tn.Name = drv[id].ToString();//节点的Value值，一般为数据库的id值
                tn.Text = drv[text].ToString();//节点的Text，节点的文本显示
                tnc.Add(tn);//将该节点加入到TreeNodeCollection（节点集合）中
                Bind_Tv(dt, tn.Nodes, tn.Name, id, pid, text);//递归（反复调用这个方法，直到把数据取完为止）
            }
        }
    }
}
