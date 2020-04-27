using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 体检套餐管理系统
{
    public partial class FormMain : Form
    {
        //套餐类型集合组
        Dictionary<string, List<HealthCheckItem>> dic = new Dictionary<string, List<HealthCheckItem>>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //入学体检集合组
            List<HealthCheckItem> slist = new List<HealthCheckItem>()
            {
                new HealthCheckItem() { xmm = "身高", bz = "用于检查身高。", money = 5 },
                new HealthCheckItem() { xmm = "体重", bz = "用于检查体重。", money = 10 },
                new HealthCheckItem() { xmm = "肝功能", bz = "用于检查肝功能。", money = 20 }
            };

            //入职体检集合组
            List<HealthCheckItem> plist = new List<HealthCheckItem>()
            {
                new HealthCheckItem() { xmm = "肝功能", bz = "用于检查肝功能。", money = 20 },
                new HealthCheckItem() { xmm = "体重", bz = "用于检查体重。", money = 10 },
                new HealthCheckItem() { xmm = "身高", bz = "用于检查身高。", money = 5 }
            };

            //填充套餐类型集合组数据
            dic.Add("入学体检", slist);
            dic.Add("入职体检", plist);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //填充控件数据
            this.dataGridView1.DataSource = dic[this.comboBox1.Text];
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
