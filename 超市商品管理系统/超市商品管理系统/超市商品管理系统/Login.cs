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

namespace 超市商品管理系统
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckInput()==true)     //用户输入合法则继续执行
            {
                if (CheckDBUser() == true)     //用户存在则打开窗口
                {
                    FormHome Home = new FormHome();
                    Home.Show();
                    this.Hide();        //隐藏当前窗体
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重试~~","登录失败",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    uName.Text = null;
                    pwd.Text = null;
                }
            }
        }

        //判断用户输入是否为空
        public bool CheckInput()
        {
            
            if (uName.Text.Equals(String.Empty))
            {
                MessageBox.Show("请输入用户名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else if (pwd.Text.Equals(String.Empty))
            {
                MessageBox.Show("请输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else
            {
                return true;
            }

        }

        //判断用户是否存在
        public bool CheckDBUser()
        {
            //登录数据库
            string key = "server=.;database=Sopping;uid=Admin;pwd=246800";
            SqlConnection connection = new SqlConnection(key);
            //打开数据库连接
            connection.Open();
            string strSql = "SELECT UName,Upwd FROM CUser WHERE UName='" + uName.Text + "' AND Upwd='" + pwd.Text + "'";
            SqlCommand cmd = new SqlCommand(strSql, connection);
            SqlDataReader rd = cmd.ExecuteReader();

            //遍历列表,如果列表中存在该账号并且账号与密码一致的话就执行登录
            if (rd.HasRows)
            {
                connection.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //退出应用程序
            Application.Exit();
        }
    }
}
