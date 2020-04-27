using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通讯录信息管理系统
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 查看通讯录信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开窗口
            frmRead frmRead = new frmRead();
            frmRead.MdiParent = this;
            frmRead.Show();
        }
    }
}
