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

namespace _2018中超联赛系统
{
    public partial class FormInsert : Form
    {
        public FormInsert()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //关闭当前窗口
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //清空全部信息
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = comboBox1.Text = comboBox2.Text = null;
        }

        private void FormInsert_Load(object sender, EventArgs e)
        {
            //登录数据库
            string key = "Data Source=.;Initial Catalog=FootballScheduleManager;Integrated Security=True";
            SqlConnection connection = new SqlConnection(key);
            //打开数据库连接
            connection.Open();
            string strSql = " SELECT teamName FROM TeamInfo ";
            SqlCommand cmd = new SqlCommand(strSql, connection);
            SqlDataReader rd = cmd.ExecuteReader();

            //遍历数据库列表
            while (rd.Read())
            {
                //将读取到的数据转换成字符
                string BN = rd["teamName"].ToString();

                //创建一个临时的ListViewItem
                ListViewItem item = new ListViewItem(BN);

                //将ListViewItem的数据添加到comboBox控件
                comboBox1.Items.Add(BN);
                comboBox2.Items.Add(BN);
            }
            rd.Close();     //关闭查询
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //输入格式正确时执行插入
            if (CheckInput() == true)
            {
                //登录数据库
                string key = "Data Source=.;Initial Catalog=FootballScheduleManager;Integrated Security=True";
                SqlConnection connection = new SqlConnection(key);
                //打开数据库连接
                connection.Open();
                string strSql = " INSERT INTO ScheduleInfo VALUES('" + textBox1.Text + "','" + comboBox1.SelectedIndex + "','" + comboBox2.SelectedIndex + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "',default )";
                SqlCommand cmd = new SqlCommand(strSql, connection);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("信息录入成功！！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

            }
        }

        //判断输入格式是否正确
        public bool CheckInput()
        {
            if (textBox1.Text == null && textBox2.Text == null && textBox3.Text == null && textBox4.Text == null && textBox5.Text == null && comboBox1.Text == null && comboBox2.Text == null)
            {
                MessageBox.Show("赛程信息输入不完整，请完善！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (comboBox1.Text.Equals(comboBox2.Text))
            {
                MessageBox.Show("主队和客队不能是同一个队伍！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else
            {
                return true;
            }
        }

    }
 }
