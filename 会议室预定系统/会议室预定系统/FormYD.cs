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
    public partial class FormYD : Form
    {
        int i = 0;
        public FormYD()
        {
            InitializeComponent();
        }

        private void FormYD1_Load(object sender, EventArgs e)
        {
            //登录数据库
            string key = "Data Source=.;Initial Catalog=BoardScheduleManager;Integrated Security=True";
            SqlConnection connection = new SqlConnection(key);
            //打开数据库连接
            connection.Open();
            string strSql = " SELECT boardName FROM BoardroomInfo ";
            SqlCommand cmd = new SqlCommand(strSql, connection);
            SqlDataReader rd = cmd.ExecuteReader();

            //遍历列表,如果列表中存在该账号并且账号与密码一致的话就执行登录
            while (rd.Read())
            {
                //将读取到的数据转换成字符
                string BN = rd["boardName"].ToString();

                //创建一个临时的ListViewItem
                ListViewItem item = new ListViewItem(BN);

                //将ListViewItem的数据添加到comboBox控件
                comboBox1.Items.Add(BN);
            }
            rd.Close();     //关闭查询
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //关闭当前窗体
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = null;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckInput() == true)
            {
                if (textBox1.Text.Equals("1号会议室"))
                {
                    i = 1;
                }
                else if (textBox1.Text.Equals("2号会议室"))
                {
                    i = 2;
                }
                else if (textBox1.Text.Equals("3号会议室"))
                {
                    i = 3;
                }

                //登录数据库
                string key = "Data Source=.;Initial Catalog=BoardScheduleManager;Integrated Security=True";
                SqlConnection connection = new SqlConnection(key);
                //打开数据库连接
                connection.Open();
                string strSql = " INSERT INTO ScheduleInfo VALUES('" + i + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "') ";
                SqlCommand cmd = new SqlCommand(strSql, connection);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("信息录入成功！！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        //判断输入格式是否符合规范
        public bool CheckInput()
        {
            if (comboBox1.Text == null)
            {
                MessageBox.Show("预定信息不完整！\n请选择会议室", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (textBox1.Text == null)
            {
                MessageBox.Show("预定信息不完整！\n请输入预订人姓名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (textBox2.Text == null)
            {
                MessageBox.Show("预定信息不完整！\n请输入预订开始时间", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (textBox3.Text == null)
            {
                MessageBox.Show("预定信息不完整！\n请输入预订时长", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (textBox4.Text == null)
            {
                MessageBox.Show("预定信息不完整！\n请输入录入人姓名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (textBox5.Text == null)
            {
                MessageBox.Show("预定信息不完整！\n请输入预订原因", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
