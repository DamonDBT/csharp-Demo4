using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace AutoEamil
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Email email = new Email();
            email.strToMailbox.Add("843321780@qq.com");


            MailMessage msg = new MailMessage();
            msg.Subject = "这是测试邮件";//邮件标题   
            msg.Body = "邮件内容:hello world!";//邮件内容  
            msg.AddAttachment(ref msg, "E:\\新建文件夹", "Jellyfish.jpg");  ////email.AddAttachment("E:\\新建文件夹");
            
            email.Send(msg);
        }
    }
}
