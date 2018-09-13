using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;

namespace AutoEamil
{
    public static class ExtendMailMessage
    {
        private static List<Attachment> aths = new List<Attachment>();
        /// <summary>
        /// 添加附件，如果不给名字，则发送文件夹下所有文件，如果有名字，只发指定名字的
        /// </summary>
        /// <param name="msgs">扩展方法格式，实际不用</param>
        /// <param name="msg">邮件内容</param>
        /// <param name="dictoryPath">文件夹路径</param>
        /// <param name="filename">文件名，含有后缀</param>
        public static void AddAttachment(this MailMessage msgs, ref MailMessage msg, string dictoryPath, params string[] filename)
        {
            if (filename.Length == 0)//发送文件下的全部
            {
                DirectoryInfo dir = new DirectoryInfo(dictoryPath);
                FileInfo[] fil = dir.GetFiles(); 
                foreach (var item in fil)
                {
                    AddOneAttachment(item.FullName);
                }
            }
            else
            {
                foreach (var item in filename)
                {
                    string file = dictoryPath + "\\" + item; //string file = @"E:\新建文件夹\Chrysanthemum.jpg"; 
                    AddOneAttachment(file);
                }
            }
            foreach (var item in aths)
            {
                msg.Attachments.Add(item);
            }

        }
        private static void AddOneAttachment(string file)
        {
            Attachment myAttachment = new Attachment(file, System.Net.Mime.MediaTypeNames.Application.Octet);
            System.Net.Mime.ContentDisposition disposition = myAttachment.ContentDisposition;
            disposition.CreationDate = System.IO.File.GetCreationTime(file);
            disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
            disposition.ReadDate = System.IO.File.GetLastAccessTime(file);
            aths.Add(myAttachment);
        }

    }
}
