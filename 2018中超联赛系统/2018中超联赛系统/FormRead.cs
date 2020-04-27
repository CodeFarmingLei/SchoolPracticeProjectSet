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
    public partial class FormRead : Form
    {
        public FormRead()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //关闭当前窗口
            this.Hide();
        }

        private void FormRead_Load(object sender, EventArgs e)
        {
            //加载查询方法
            BindView();
        }

        public void BindView()
        {
            //局部公用变量
            string strSql;
            string key = "Data Source=.;Initial Catalog=FootballScheduleManager;Integrated Security=True";
            SqlConnection conn = new SqlConnection(key);
            conn.Open();

            //当控件中有数据则进行约束查询，否则进行全部查询
            if (textBox1.Text != null)
            {
                strSql = @"SELECT S.count,T1.teamName,T2.teamName,S.competitionTime,S.competitionPosition,S.score,S.entryPerson,S.entryTime FROM ScheduleInfo AS S
                                  inner JOIN TeamInfo AS T1 ON T1.id = S.hostTeamId
                                  inner JOIN TeamInfo AS T2 ON T2.id = S.awayTeamId
                                  WHERE T1.teamName LIKE '%" + textBox1.Text + "%' ";
            }
            else
            {
                strSql = @"SELECT S.count,T1.teamName,T2.teamName,S.competitionTime,S.competitionPosition,S.score,S.entryPerson,S.entryTime FROM ScheduleInfo AS S
                                  inner JOIN TeamInfo AS T1 ON T1.id = S.hostTeamId
                                  inner JOIN TeamInfo AS T2 ON T2.id = S.awayTeamId";
            }
            SqlCommand cmd = new SqlCommand(strSql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);

            //提示框：显示共几条数据
            MessageBox.Show("共 " + dt.Rows.Count.ToString() + " 条数据", "查询完成", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
            //将数据添加到窗口数据库表格控件中
            this.dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //加载查询方法
            BindView();
        }
    }
}
