using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 证件管理系统
{
    public partial class frmRead : Form
    {
        public frmRead()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //清空文本
            textBox1.Text = comboBox1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入学校名称！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                string key = "Data Source=.;Initial Catalog=PaperDB;Integrated Security=True";
                SqlConnection conn = new SqlConnection(key);
                conn.Open();
                string strSql = " SELECT PId,Sname,Ptype,Uname,Rdate FROM Paper WHERE Sname ='" + textBox1.Text+ "' AND Ptype='"+comboBox1.Text+"' ";
                SqlCommand cmd = new SqlCommand(strSql,conn);
                DataTable dt = new DataTable();
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                Adapter.Fill(dt);
                this.dataGridView1.DataSource = dt;
                
                if (this.dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("没有查询到结果！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                //填充数据
                this.comboBox1.DataSource = dt;
                this.comboBox1.ValueMember = "pid";
                this.comboBox1.DisplayMember = "pname";

            }


        }

        private void frmRead_Load(object sender, EventArgs e)
        {

        }
    }
}
