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

namespace 手机超市信息查询
{
    public partial class frmMobile : Form
    {
        public frmMobile()
        {
            InitializeComponent();
        }

        private void dataGridViewRead_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //读取数据库并添加数据到下拉框控件
        public void comboBoxText()
        {
            string key = "Data Source=.;Initial Catalog=MobileManafer;Integrated Security=True";
            SqlConnection conn = new SqlConnection(key);
            conn.Open();
            string strSql = @"SELECT C.Category FROM MobileInfo AS M
                              INNER JOIN CategoryInfo AS C ON M.Cid = C.Cid ";
            SqlCommand cmd = new SqlCommand(strSql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            Adapter.Fill(dt);

            //将临时数据表中的数据填充到控件中
            this.comboBoxZL.Items.Add(dt);
        }

        //查询数据库
        public void Read()
        {
            string key = "Data Source=.;Initial Catalog=MobileManafer;Integrated Security=True";
            SqlConnection conn = new SqlConnection(key);
            conn.Open();
            string strSql = @"SELECT M.Mid AS '序号',M.Brand AS '品牌',C.Category AS '手机类型',M.Type AS '型号',M.Price AS '价格' FROM MobileInfo AS M
                              INNER JOIN CategoryInfo AS C ON M.Cid = C.Cid";

            //判断用户选择查询种类
            if (comboBoxZL.Text == "全部")
            {
                //选择全部时停用查询条件输入控件
                textBoxTJ.Enabled = false;
            }
            else if (comboBoxZL.Text == "品牌")
            {
                //选择全部时启用查询条件输入控件
                textBoxTJ.Enabled = true;
                strSql += " WHERE M.Brand='" + textBoxTJ.Text + "' ";
            }
            else if (comboBoxZL.Text == "手机类型")
            {
                //选择全部时启用查询条件输入控件
                textBoxTJ.Enabled = true;
                strSql += " WHERE C.Category='" + textBoxTJ.Text + "' ";
            }

            SqlCommand cmd = new SqlCommand(strSql,conn);
            DataTable dt = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            Adapter.Fill(dt);

            //将临时数据表中的数据填充到控件中
            this.dataGridViewRead.DataSource = dt;

            //没有数据的提示框
            if(dt.Rows.Count == 0)
            {
                this.dataGridViewRead.DataSource = null;
                MessageBox.Show("没有您所要查询的手机！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        //判断输入查询条件
        public bool CheckInput()
        {
            if (comboBoxZL.Text == "")
            {
                MessageBox.Show("请选择查询种类","提示",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return false;
            }
            else if (!(comboBoxZL.Text.Equals("全部")) && textBoxTJ.Text == "")
            {
                MessageBox.Show("请输入查询条件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmMobile_Load(object sender, EventArgs e)
        {
            //加载查询方法
            Read();
        }

        private void buttonCX_Click(object sender, EventArgs e)
        {
            //输入条件方法返回true时执行查询操作
            if(CheckInput() == true)
            {
                Read();
            }
        }

        private void buttonQC_Click(object sender, EventArgs e)
        {
            //清空输入文本
            textBoxTJ.Text = null;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //退出程序
            Application.Exit();
        }

        //判断用户选择查询种类
        private void comboBoxZL_SelectedIndexChanged(object sender, EventArgs e)
        {  
            if (comboBoxZL.Text == "全部")
            {
                //选择全部时停用查询条件输入控件
                textBoxTJ.Enabled = false;
            }
            else
            {
                //选择全部时启用查询条件输入控件
                textBoxTJ.Enabled = true;              
            }
        }
    }
}
