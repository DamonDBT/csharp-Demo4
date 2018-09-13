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
        /// ��Ӹ���������������֣������ļ����������ļ�����������֣�ֻ��ָ�����ֵ�
        /// </summary>
        /// <param name="msgs">��չ������ʽ��ʵ�ʲ���</param>
        /// <param name="msg">�ʼ�����</param>
        /// <param name="dictoryPath">�ļ���·��</param>
        /// <param name="filename">�ļ��������к�׺</param>
        public static void AddAttachment(this MailMessage msgs, ref MailMessage msg, string dictoryPath, params string[] filename)
        {
            if (filename.Length == 0)//�����ļ��µ�ȫ��
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
                    string file = dictoryPath + "\\" + item; //string file = @"E:\�½��ļ���\Chrysanthemum.jpg"; 
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
