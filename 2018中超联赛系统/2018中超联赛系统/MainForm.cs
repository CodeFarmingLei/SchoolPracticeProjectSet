using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018中超联赛系统
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //退出程序
            Application.Exit();
        }

        private void 赛程添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开赛程添加窗口
            FormInsert FormInsert = new FormInsert();
            FormInsert.MdiParent = this;
            FormInsert.Show();
        }

        private void 赛程查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开赛程查询窗口
            FormRead FormRead = new FormRead();
            FormRead.MdiParent = this;
            FormRead.Show();
        }

        private void 球队管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
