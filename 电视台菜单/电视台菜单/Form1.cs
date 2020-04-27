using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 电视台菜单
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            switch(this.treeView1.SelectedNode.Tag.ToString())
            {
                case "北京电视台":

                    List<Class1> list1 = new List<Class1>();
                    xml.Load(@"C:\Program Files\Microsoft Visual Studio 9.0\Xml\电视台菜单\电视台菜单\北京电视台.xml");
                    XmlNode node1 = xml.LastChild;
                    
                    foreach(XmlNode x in node1.ChildNodes)
                    {
                        Class1 c1 = new Class1() 
                        {
                            PlayTime = x.ChildNodes[0].InnerText,
                            ProgramName = x.ChildNodes[2].InnerText
                        };
                        list1.Add(c1);
                    }

                    this.dataGridView1.DataSource = list1;
                    break;
                case "凤凰卫视":
                    List<Class2> list2 = new List<Class2>();
                    xml.Load(@"C:\Program Files\Microsoft Visual Studio 9.0\Xml\电视台菜单\电视台菜单\凤凰卫视.xml");
                    XmlNode node2 = xml.LastChild;

                    foreach (XmlNode x in node2.ChildNodes)
                    {
                        Class2 c2 = new Class2()
                        {
                            PlayTime = x.ChildNodes[0].InnerText,
                            ProgramName = x.ChildNodes[2].InnerText
                        };
                        list2.Add(c2);
                    }
                    this.dataGridView1.DataSource = list2;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode T1 = new TreeNode("我的电视台");
            TreeNode T2 = new TreeNode("所有电视台");
            TreeNode A1 = new TreeNode();
            TreeNode A2 = new TreeNode();

            XmlDocument xml = new XmlDocument();
            xml.Load(@"\\Pc08\电视台菜单\电视台菜单\北京电视台.xml");

            XmlNode node = xml.LastChild;

            A1.Tag = A1.Text = node.ChildNodes[0].ChildNodes[1].InnerText;
            A2.Tag = A2.Text = node.ChildNodes[1].ChildNodes[1].InnerText;

            T1.Tag = "我的电视台";
            T2.Tag = "所有电视台";

            T2.Nodes.AddRange(new TreeNode[]{A1, A2});

            this.treeView1.Nodes.Add(T1);
            this.treeView1.Nodes.Add(T2);
        }
    }
}
