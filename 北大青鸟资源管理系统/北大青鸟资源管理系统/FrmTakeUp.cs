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

namespace 北大青鸟资源管理系统
{
    public partial class FrmTakeUp : Form
    {
        public FrmTakeUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //清空操作
            comboBox1.Text = textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = null;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void FrmTakeUp_Load(object sender, EventArgs e)
        {

        }

        //判断输入是否为空以及按钮是否有一个被选中
        public bool CheckInput()
        {
            if (comboBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null || textBox5.Text == null || radioButton1.Checked == false && radioButton1.Checked == false)
            {
                MessageBox.Show("信息必须完整！", "提示",MessageBoxButtons.OK);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //如果返回true则执行插入操作
            if (CheckInput()==true)
            {

            }
        }

        //数据库操作方法
        public void insert()
        {
            string key = "Data Source=.;Initial Catalog=ResourceManageSys;Integrated Security=True";
            SqlConnection conn = new SqlConnection(key);
            conn.Open();
            //判断哪个按钮被选中并插入对应文字
            string time = null;         //默认为空,避免报错
            if (radioButton1.Checked == true)
            {
                time = "上午";
            }
            else if (radioButton2.Checked == true)
            {
                time = "下午";
            }
            string strSql = "INSERT INTO ResourceInfo VALUES('"+ comboBox1.Text + "','"+ textBox1.Text +"','"+time+"','"+ textBox2.Text + "','"+ textBox3.Text + "','"+ textBox4.Text + "','"+ textBox5.Text + "');";
            SqlCommand cmd = new SqlCommand(strSql,conn);
            SqlDataReader rd = cmd.ExecuteReader();
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("占用成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            rd.Close();
        }

    }
}
