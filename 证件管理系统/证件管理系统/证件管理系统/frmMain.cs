using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 证件管理系统
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

        private void 证件查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRead frmRead = new frmRead();
            frmRead.MdiParent = this;
            frmRead.Show();
        }
    }
}
