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

namespace 固定资产管理系统
{
    public partial class FormRead : Form
    {
        public FormRead()
        {
            InitializeComponent();
        }

        private void FormRead_Load(object sender, EventArgs e)
        {
            Read();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Read();
        }

        public void Read()
        {
            string key = "Data Source=.;Initial Catalog=assetsDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(key);
            conn.Open();
            string strSql = " SELECT assetId,assetName,assetType,mtoDate FROM assets ";
            if (textBox1.Text != "")
            {
                strSql = @" SELECT assetId,assetName,assetType,mtoDate FROM assets
                                  WHERE assetId LIKE '%" + textBox1.Text+ "%' OR assetType LIKE '"+comboBox1.Text+"' ";
            }
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(strSql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            this.dataGridView1.DataSource = dt;

            if (this.dataGridView1 == null)
            {
                MessageBox.Show("没有查询到信息！","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }
    }
}
