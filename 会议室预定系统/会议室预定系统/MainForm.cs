using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 会议室预定系统
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //结束程序
            Application.Exit();
        }

        private void 预定会议室ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开预定会议室窗口
            FormYD YD = new FormYD();
            YD.MdiParent = this;
            YD.Show();
        }

        private void 查询预定情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRead read = new FormRead();
            read.MdiParent = this;
            read.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void 会议室管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
