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

namespace 店铺会员管理系统
{
    public partial class FormRead : Form
    {
        public FormRead()
        {
            InitializeComponent();
        }

        private void FormRead_Load(object sender, EventArgs e)
        {
            //读取数据库并填充数据
            string key = "Data Source=.;Initial Catalog=MembershipManagementSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(key);
            conn.Open();
            DataTable dt = new DataTable();
            string strSql = " SELECT * FROM VIPUser ";
            SqlCommand cmd = new SqlCommand(strSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //获得当前选中的行 
            int rowindex = e.RowIndex;
            //获得当前行的第0列的值(ID)
            string value0 = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            //读取数据库并填充数据
            string key = "Data Source=.;Initial Catalog=MembershipManagementSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(key);
            conn.Open();
            DataTable dt = new DataTable();
            string strSql = " SELECT * FROM VIPUser WHERE VID='"+ value0 + "' ";
            SqlCommand cmd = new SqlCommand(strSql, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string VID = rd["VID"].ToString();                                              //会员卡号
                textboxVID.Text = VID;
                string VType = rd["VType"].ToString();                                      //会员类型
                textboxVType.Text = VType;
                string VMoney = rd["VMoney"].ToString();                               //账户余额
                textboxVMoney.Text = VMoney;
                string VCount = rd["VCount"].ToString();                                  //业务体验次数
                textboxVCount.Text = VCount;
                string InsertDateTime = rd["InsertDateTime"].ToString();          //开户时间
                textboxInsertDateTime.Text = InsertDateTime;
                string VRemarks = rd["VRemarks"].ToString();                           //备注信息
                textboxVRemarks.Text = VRemarks;

                string VName = rd["VName"].ToString();                                  //姓名
                textboxVName.Text = VName;
                string VSex = rd["VSex"].ToString();                                          //姓别
                textboxVSex.Text = VSex;
                string VAge = rd["VAge"].ToString();                                        //年龄
                textboxVAge.Text = VAge;
                string VPhone = rd["VPhone"].ToString();                                 //电话
                textboxVPhone.Text = VPhone;
                string VAddress = rd["VAddress"].ToString();                            //地址
                textboxVAddress.Text = VAddress;
                string VEmail = rd["VEmail"].ToString();                                    //E - mail 邮箱
                textboxVEmail.Text = VEmail;
                string VOtherRemarks = rd["VOtherRemarks"].ToString();         //其他备注信息
                RTBVOtherRemarks.Text = VOtherRemarks;
            }
            rd.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //读取数据库并填充数据
            string key = "Data Source=.;Initial Catalog=MembershipManagementSystem;Integrated Security=True";
            SqlConnection conn = new SqlConnection(key);
            conn.Open();
            DataTable dt = new DataTable();
            string strSql = " SELECT * FROM VIPUser ";
            if (textBox1.Text != "")
            {
                strSql = " SELECT * FROM VIPUser WHERE VID='" + textBox1.Text + "' ";
            }
            SqlCommand cmd = new SqlCommand(strSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            this.dataGridView1.DataSource = dt;

            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("没有查询到该会员ID的用户信息","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //清空文本框
            textBox1.Text = null;
        }
    }
}
