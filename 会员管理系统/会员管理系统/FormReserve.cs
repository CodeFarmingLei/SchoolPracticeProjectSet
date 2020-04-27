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

namespace 店铺会员管理系统
{
    public partial class FormReserve : Form
    {
        public FormReserve()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckInput() != false)
            {
                //登录数据库
                string key = "Data Source=.;Initial Catalog=MembershipManagementSystem;Integrated Security=True";
                SqlConnection connection = new SqlConnection(key);
                //打开数据库连接
                connection.Open();
                string strSql = " INSERT INTO ReservationRegistration VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1 + "','" + comboBox1.Text + "','" + richTextBox1.Text + "')";
                SqlCommand cmd = new SqlCommand(strSql, connection);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("预约成功！！", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        //判断录入信息是否有误
        public bool CheckInput()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入会员姓名","提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("请输入会员联系电话", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("请选择预约时间段", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
