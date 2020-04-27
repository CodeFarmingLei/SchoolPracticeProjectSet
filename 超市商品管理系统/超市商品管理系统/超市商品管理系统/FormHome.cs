using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 超市商品管理系统
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void 修改密码PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewPwd NewPwd = new FormNewPwd();
            NewPwd.Show();
        }
    }
}
