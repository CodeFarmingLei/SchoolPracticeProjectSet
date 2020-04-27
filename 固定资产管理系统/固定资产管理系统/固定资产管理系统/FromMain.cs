using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 固定资产管理系统
{
    public partial class FromMain : Form
    {
        public FromMain()
        {
            InitializeComponent();
        }

        private void 新增固定资产ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInsert FormInsert = new FormInsert();
            FormInsert.MdiParent = this;
            FormInsert.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 查询固定资产ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRead FormRead = new FormRead();
            FormRead.MdiParent = this;
            FormRead.Show();        }
    }
}
