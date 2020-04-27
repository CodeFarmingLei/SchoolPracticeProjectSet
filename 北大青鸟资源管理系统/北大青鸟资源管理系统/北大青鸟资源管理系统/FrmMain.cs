using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 北大青鸟资源管理系统
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void 占用教室机房ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开窗体
            FrmTakeUp FrmTakeUp = new FrmTakeUp();
            FrmTakeUp.MdiParent = this;
            FrmTakeUp.Show();
        }

        private void 教室机房占用情况查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开窗体
            FrmCheck FrmCheck = new FrmCheck();
            FrmCheck.MdiParent = this;
            FrmCheck.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //退出程序
            Application.Exit();
        }
    }
}
