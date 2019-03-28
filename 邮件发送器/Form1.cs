using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;


namespace 邮件发送器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sendtoo.Text == null)
            {
                MessageBox.Show("请填写收件人邮箱");
            }
            else if (titlee.Text == null)
            {
                MessageBox.Show("请填写发件主题");
            }
            else if (sendtoo.Text == null && filee.Text == null)
            {
                MessageBox.Show("请检查发送内容或者附件");

            }
            else
            {
                Email.SendEmail(titlee.Text, bodyy.Text, sendtoo.Text, filee.Text);
            }
        }

        private void filechoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            this.filee.Text = file.FileName;//SafeFileName为不含路径的文件名
            //privatevoid btnSelectPath_Click(object sender, EventArgs e) //弹出一个选择目录的对话框
            //{
            //    FolderBrowserDialog path = new FolderBrowserDialog();
            //    path.ShowDialog();
            //    this.txtPath.Text = path.SelectedPath;
            //}//选择文件夹
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(System.Environment.CurrentDirectory + "\\一键开启计算机25端口.lnk");
        }


    }
}



