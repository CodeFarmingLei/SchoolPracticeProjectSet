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

namespace 固定资产管理系统
{
    public partial class FormInsert : Form
    {
        public FormInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断为true时执行插入操作
            if (InputText()==true)
            {
                string key = "Data Source=.;Initial Catalog=assetsDB;Integrated Security=True";
                SqlConnection conn = new SqlConnection(key);
                conn.Open();
                string strSql = " INSERT INTO assets VALUES('" + textBox1.Text+"','"+textBox2.Text+"','"+comboBox1.Text+"','"+textBox3.Text+"');";
                SqlCommand cmd = new SqlCommand(strSql,conn);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
                if (cmd.ExecuteNonQuery()>0)
                {
                    MessageBox.Show("新增成功！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        //判断用户输入信息是否完整
        public bool InputText()
        {
            if (textBox1.Text == null || textBox2.Text == null || comboBox1.Text.Equals("请选择类型") || textBox3.Text == null)
            {
                MessageBox.Show("请完整填写信息！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
