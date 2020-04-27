using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 店铺会员管理系统
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //加载会员信息查询窗体
            FormRead FormRead = new FormRead();
            FormRead.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //加载会员预约登记窗体
            FormReserve FormReserve = new FormReserve();
            FormReserve.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //加载会员预约信息查询窗体
            FormReserveRead FormReserveRead = new FormReserveRead();
            FormReserveRead.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //提示功能暂不可用
            MessageBox.Show("该功能正在开发中，请期待后续版本更新~~","开发中，敬请期待",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //提示功能暂不可用
            MessageBox.Show("该功能正在开发中，请期待后续版本更新~~", "开发中，敬请期待", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
