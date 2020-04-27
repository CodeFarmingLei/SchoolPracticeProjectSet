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

namespace 超市会员管理系统
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ReadDataGridView();
        }

        //填充数据表控件数据
        public void ReadDataGridView()
        {
            string key = "Data Source=.;Initial Catalog=SuperMark;Integrated Security=True";
            SqlConnection conn = new SqlConnection(key);
            conn.Open();
            string strSql = @" SELECT U.CustomerId,U.CustomerType,U.Score,S.StatesName FROM UsersInfo AS U
                                   LEFT JOIN States AS S ON S.Id = U.statesId ";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(strSql,conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            this.dataGridView1.DataSource = dt;
        }

        //填充数据表控件数据
        public void ReadComboBox()
        {
            string key = "Data Source=.;Initial Catalog=SuperMark;Integrated Security=True";
            SqlConnection conn = new SqlConnection(key);
            conn.Open();
            string strSql = " SELECT * FROM States ";
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(strSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
        }

    }
}
