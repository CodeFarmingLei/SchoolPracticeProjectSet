using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace 通讯录信息管理系统
{
    public partial class frmRead : Form
    {
        public frmRead()
        {
            InitializeComponent();
        }

        private void frmRead_Load(object sender, EventArgs e)
        {
            //加载方法
            Read();
        }

        public void Read()
        {
            string key = "Data Source=.;Initial Catalog=ContactsSys;Integrated Security=True";
            SqlConnection conn = new SqlConnection(key);
            conn.Open();
            string strSql;
            //当控件中有数据则进行约束查询，否则进行全部查询
            if (textBox1.Text != null)
            {
                strSql = "SELECT * FROM Contacts WHERE ContactName LIKE '%" + textBox1.Text + "%' ";
            }
            else
            {
                strSql = "SELECT * FROM Contacts";
            }
            SqlCommand cmd = new SqlCommand(strSql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            //将数据添加到窗口数据库表格控件中
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //加载方法
            Read();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //删除菜单
            MessageBox.Show("确定要删除该记录么？","删除确认",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
        }
    }
}
