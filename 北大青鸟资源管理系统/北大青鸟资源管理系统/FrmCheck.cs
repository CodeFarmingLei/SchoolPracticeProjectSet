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

namespace 北大青鸟资源管理系统
{
    public partial class FrmCheck : Form
    {
        public FrmCheck()
        {
            InitializeComponent();
        }

        private void FrmCheck_Load(object sender, EventArgs e)
        {
            //加载方法
            Read();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //加载方法
            Read();
        }

        public void Read()
        {
            //登录数据库
            string key = "Data Source=.;Initial Catalog=ResourceManageSys;Integrated Security=True";
            SqlConnection connection = new SqlConnection(key);
            //打开数据库连接
            connection.Open();
            string strSql = " SELECT * FROM ResourceInfo ";
            if (textBox1.Text != "")
            {
                strSql += " WHERE takeDate='" + textBox1.Text + "'; ";
            }
            SqlCommand cmd = new SqlCommand(strSql, connection);
            SqlDataReader rd = cmd.ExecuteReader();

            //遍历列表,如果列表中存在该账号并且账号与密码一致的话就执行登录
            while (rd.Read())
            {
                //将读取到的数据转换成字符
                string rescName = rd["rescName"].ToString();
                string takeDate = rd["takeDate"].ToString();
                string takeTime = rd["takeTime"].ToString();
                string className = rd["className"].ToString();
                string courseName = rd["courseName"].ToString();
                string teacherName = rd["teacherName"].ToString();
                string instructorName = rd["instructorName"].ToString();

                //创建一个临时的ListViewItem
                ListViewItem item = new ListViewItem(rescName);

                //将ListViewItem的数据添加到comboBox控件
                item.SubItems.Add(className);
                item.SubItems.Add(courseName);
                item.SubItems.Add(takeDate);
                item.SubItems.Add(takeTime);
                item.SubItems.Add(teacherName);
                item.SubItems.Add(instructorName);

                //将临时的ListViewItem控件的数据添加到窗体listView1控件中
                listView1.Items.Add(item);

            }
            rd.Close();     //关闭查询
        }

    }
}
