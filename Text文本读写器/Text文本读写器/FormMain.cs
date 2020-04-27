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

namespace Text文本读写器
{
    public partial class FormMain : Form
    {
        //存储读取的文本
        public string content;

        public FormMain()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //打开选择文件对话框
            openFileDialogRead.ShowDialog();

            //将路径控件文本改成至当前选择路径
            textBox1.Text = openFileDialogRead.FileName;

            //启动写入控件
            buttonInsert.Enabled = true;

            //创建文件流
            string path = textBox1.Text;    //文件地址
            FileStream myFs = new FileStream(path, FileMode.Open);

            //创建读取器
            StreamReader mySr = new StreamReader(myFs,Encoding.GetEncoding("gb2312"));
            content = mySr.ReadToEnd();  //读取整个文本文档
            richTextBox1.Text = content; //将读取的文本写入到控件
            mySr.Close();   //关闭读取器
            myFs.Close();   //关闭文件流
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //窗口加载默认禁用写入控件
            if (textBox1.Text == "")
            {
                buttonInsert.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //文本路径地址为空时提示选择路径
            if (textBox1.Text == "")
            {
                MessageBox.Show("请选择文本文件路径", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //创建文件流
                string path = textBox1.Text;    //文件地址
                FileStream myFs = new FileStream(path, FileMode.Create);

                //创建写入器
                StreamWriter mySw = new StreamWriter(myFs);
                mySw.Write(richTextBox1.Text);  //将控件文本写入文件
                mySw.Close();   //关闭写入器
                myFs.Close();   //关闭文件流

                //结果反馈
                MessageBox.Show("写入成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            //打开保存文件对话框
            saveFileDialogInsert.ShowDialog();

            //将路径控件文本改成至当前选择路径
            textBox1.Text = saveFileDialogInsert.FileName;

            //启动写入控件
            buttonInsert.Enabled = true;

            //创建文件流
            string path = textBox1.Text;    //文件地址
            FileStream myFs = new FileStream(path, FileMode.Create);

            //创建写入器
            StreamWriter mySw = new StreamWriter(myFs);
            mySw.Write(richTextBox1.Text);  //将控件文本写入文件
            mySw.Close();   //关闭写入器
            myFs.Close();   //关闭文件流

            if (File.Exists(saveFileDialogInsert.FileName))
            {
                //结果反馈
                MessageBox.Show("创建成功！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                //结果反馈
                MessageBox.Show("该问文件已存在！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void saveFileDialogInsert_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
