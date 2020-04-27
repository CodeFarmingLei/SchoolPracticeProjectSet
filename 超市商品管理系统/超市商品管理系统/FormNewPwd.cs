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
    public partial class FormNewPwd : Form
    {
        public FormNewPwd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //登录数据库
            string key = "server=.;database=Sopping;uid=Admin;pwd=246800";
            SqlConnection connection = new SqlConnection(key);
            //打开数据库连接
            connection.Open();
            string strSql = "SELECT UName,Upwd FROM CUser ";
            SqlCommand cmd = new SqlCommand(strSql, connection);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                connection.Close();
                //两次新密码输入密码相同的话则修改密码
                if (NewPwd.Text.Equals(NewPwd2.Text))
                {
                    connection.Open();
                    string strSql2 = "UPDATE CUser SET Upwd = '"+NewPwd.Text+"'  WHERE Upwd='" + pwd.Text+"' ";
                    SqlCommand cmd2 = new SqlCommand(strSql2, connection);
                    SqlDataReader rd2 = cmd2.ExecuteReader();
                    connection.Close();
                    connection.Open();
                    if (cmd2.ExecuteNonQuery() >= 0)
                    {
                        MessageBox.Show("密码修改成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        pwd.Text = null;
                        NewPwd.Text = null;
                        NewPwd2.Text = null;
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("原密码错误，请重新输入~~", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                pwd.Text = null;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
