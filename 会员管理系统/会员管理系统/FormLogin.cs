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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //清空输入文本
            textBoxUser.Text = null;
            textBoxPwd.Text = null;

        }

        private void FormLogin_FormClosing(object sender, FormClosedEventArgs e)
        {
           
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //确认退出提示框
            DialogResult dr = MessageBox.Show("确定退出程序吗？？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == DialogResult.OK)
            {
                //退出程序
                Application.Exit();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //测试账号登录功能
            if (textBoxUser.Text.Equals("Admin") && textBoxPwd.Text.Equals("123456"))
            {
                MessageBox.Show("登录成功！！请开始使用吧~~", "登录成功", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                FormMain FormMain = new FormMain();
                FormMain.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("登录失败，请检查账号或密码是否有误并重新输入~~", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
