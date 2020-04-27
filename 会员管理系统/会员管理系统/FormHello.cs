using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 店铺会员管理系统;

namespace 会员管理系统
{
    public partial class FormHello : Form
    {
        public FormHello()
        {
            InitializeComponent();
        }

        //计时器事件
        private void timerLogin_Tick(object sender, EventArgs e)
        {
            //隐藏当前窗体
            this.Hide();
            //关闭计时器事件
            timerLogin.Enabled = false;
            //启动登录窗口
            FormLogin FormLogin = new FormLogin();
            FormLogin.Show();
        }

        private void FormHello_Load(object sender, EventArgs e)
        {
            //启动更改窗口布局事件计数器
            timerLogin.Enabled = true;
        }
    }
}
