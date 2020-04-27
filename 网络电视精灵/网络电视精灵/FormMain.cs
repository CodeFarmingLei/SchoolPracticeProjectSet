using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 网络电视精灵
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            TreeNode MyTv = new TreeNode("我的电视台");
            this.treeView1.Nodes.Add(MyTv);

            TreeNode FullTV = new TreeNode("所有电视台");
            XmlDocument myXml = new XmlDocument();
            myXml.Load("FullChannels.xml");
            XmlNode TvNode = myXml.DocumentElement;

            foreach (XmlNode node in TvNode.ChildNodes)
            {
                FullTV.Nodes.Add(node.ChildNodes[1].InnerText);
            }

            this.treeView1.Nodes.Add(FullTV);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.treeView1.SelectedNode.Text.Equals("凤凰卫视"))
            {
                DataSet FhTv = new DataSet();
                FhTv.ReadXml("凤凰卫视.xml");
                this.dgvFH.DataSource = FhTv.Tables[0];
                this.dgvFH.Visible = true;
                this.dgvBJ.Visible = false;
            }
            else if (this.treeView1.SelectedNode.Text.Equals("北京电视台"))
            {
                DataSet BjTv = new DataSet();
                BjTv.ReadXml("北京电视台.xml");
                this.dgvBJ.DataSource = BjTv.Tables[0];
                this.dgvFH.Visible = false;
                this.dgvBJ.Visible = true;
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }
    }
}
