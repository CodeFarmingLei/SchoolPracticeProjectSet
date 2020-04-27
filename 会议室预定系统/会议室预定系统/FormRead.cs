using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 会议室预定系统
{
    public partial class FormRead : Form
    {
        public FormRead()
        {
            InitializeComponent();
        }

        private void FormRead_Load(object sender, EventArgs e)
        {
            BindView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindView();
        }

        public void BindView()
        {
            //局部公用变量
            string strSql;
            //数据库连接钥匙
            string key = "Data Source=.;Initial Catalog=BoardScheduleManager;Integrated Security=True";
            SqlConnection conn = new SqlConnection(key);
            //打开数据库连接
            conn.Open();
            //当控件中有数据则进行约束查询，否则进行全部查询
            if (textBox1.Text != null)
            {
                strSql = "SELECT * FROM ScheduleInfo WHERE intendedName LIKE '%" + textBox1.Text + "%' ";
            }
            else
            {
                strSql = "SELECT * FROM ScheduleInfo";
            }
            //执行数据库查询操作
            SqlCommand cmd = new SqlCommand(strSql, conn);
            //内存中新建一个临时表格
            DataTable dt = new DataTable();
            //查询数据库数据
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //将数据添加到临时表格中
            adapter.Fill(dt);
            //提示框：显示共几条数据
            MessageBox.Show("共 " + dt.Rows.Count.ToString() + " 条数据", "查询完成", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //将数据添加到窗口数据库表格控件中
            this.dataGridView1.DataSource = dt;
        }

    }
}
