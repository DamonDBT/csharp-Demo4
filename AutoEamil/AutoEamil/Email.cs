using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace AutoEamil
{
    public class Email
    {
        private string strFromMailbox = "843321780@qq.com";
        private string strPassword = "eqrtwfcpzhbfbdef";//用SMTP的授权码，不是自己的登录密码
        private string strShowName = "邓比涛";

        /// <summary>
        /// 收件人列表
        /// </summary>
        public List<string> strToMailbox = new List<string>();
        /// <summary>
        /// 抄送人列表
        /// </summary>
        public List<string> strCCMailbox = new List<string>();


        private Encoding myEncoding = Encoding.UTF8;
        private SmtpClient client = null;
        private MailAddress mads = null;
        private List<Attachment> aths = new List<Attachment>();
        public Email()
        {
            client = new SmtpClient();
            client.Credentials = new NetworkCredential(strFromMailbox, strPassword); //上述写你的邮箱和密码   
            client.Port = 587;//邮箱使用的端口    
            client.Host = "smtp.qq.com";
            client.EnableSsl = true;//经过ssl加密 
            mads = new MailAddress(strFromMailbox, strShowName, myEncoding);
        }
         
        public void Send(MailMessage msg)
        {
            foreach (var item in strToMailbox)
                msg.To.Add(item);
            foreach (var item in strCCMailbox)
                msg.CC.Add(item);

            msg.From = mads;
            msg.SubjectEncoding = myEncoding;//邮件标题编码                
            msg.BodyEncoding = myEncoding;//邮件内容编码                
            msg.IsBodyHtml = true;//是否是HTML邮件  
            msg.Priority = MailPriority.High;//邮件优先级   


            //用smtpclient对象里attachments属性，添加上面设置好的myattachment
            //foreach (var item in aths)
            //{
            //    msg.Attachments.Add(item);
            //}


            //发送
            object userState = msg;
            try
            {
                client.SendAsync(msg, userState);
            }
            catch (SmtpException ex)
            {
                throw ex;
            }
        }

        #region 采用扩展方法之前使用
        /// <summary>
        /// 添加附件，如果不给名字，则发送文件夹下所有文件，如果有名字，只发指定名字的
        /// </summary>
        /// <param name="dictoryPath">文件夹路径</param>
        /// <param name="filename">文件名，含有后缀</param>
        //public void AddAttachment(string dictoryPath, params string[] filename)
        //{
        //    if (filename.Length == 0)//发送文件下的全部
        //    {
        //        DirectoryInfo dir = new DirectoryInfo(dictoryPath);
        //        FileInfo[] fil = dir.GetFiles();
        //        foreach (var item in fil)
        //        {
        //            AddOneAttachment(item.FullName);
        //        }
        //    }
        //    else
        //    {
        //        foreach (var item in filename)
        //        {
        //            string file = dictoryPath + "\\" + item; //string file = @"E:\新建文件夹\Chrysanthemum.jpg"; 
        //            AddOneAttachment(file);
        //        }
        //    }

        //}
        //private void AddOneAttachment(string file)
        //{
        //    Attachment myAttachment = new Attachment(file, System.Net.Mime.MediaTypeNames.Application.Octet);
        //    System.Net.Mime.ContentDisposition disposition = myAttachment.ContentDisposition;
        //    disposition.CreationDate = System.IO.File.GetCreationTime(file);
        //    disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
        //    disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
        //    aths.Add(myAttachment);
        //}
        #endregion
    }
}
