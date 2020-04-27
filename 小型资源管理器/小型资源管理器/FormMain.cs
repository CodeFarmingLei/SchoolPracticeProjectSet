using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 小型资源管理器
{
    public partial class FormMain : Form
    {
        //公共文件夹路径
        public string path = "E:\\";
        //公共节点
        TreeNode temp = new TreeNode();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //添加根目录节点
            TreeNode PathMain = new TreeNode(path);
            this.treeView1.Nodes.Add(PathMain);

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            TreeNode node = new TreeNode();
            DirectoryInfo[] dirs = directoryInfo.GetDirectories();
            
            foreach (DirectoryInfo di in dirs)
            {
                temp.Text = di.Name;
                temp.Tag = di.FullName;
                PathMain.Nodes.Add(temp);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(temp.Nodes.ToString());
            FileInfo[] fileInfo = directoryInfo.GetFiles();
            List<MyFile> files = new List<MyFile>();  //MyFile类用来存储文件信息
            foreach (FileInfo myFile in fileInfo)
            {
                MyFile file = new MyFile();
                file.FileName = myFile.Name;
                file.FileLength = myFile.Length;
                file.FileType = myFile.Extension;
                file.FilePath = myFile.FullName;
                files.Add(file);
            }

            this.dataGridView1.DataSource = files;
        }
    }
}
