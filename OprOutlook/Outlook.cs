using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Outlook;

namespace OprOutlook
{
    class Outlook
    {
        public void Getmail()
        {
            ApplicationClass ac = new ApplicationClass();
            NameSpace ns = ac.GetNamespace("MAPI");

            ns.Logon("016056@cisdi.com.cn", "DBTdbt111", false, false);

            MAPIFolder apiFold = ns.GetDefaultFolder(OlDefaultFolders.olFolderInbox);

            int count = apiFold.Items.Count;


            foreach (var item in apiFold.Items)
            {
                MailItem mail = item as MailItem;
                if (mail != null)
                {
                    string sendername = mail.SenderName;

                    var att = mail.Attachments;
                    if (att.Count > 0)
                    {
                        int cnt = 0;
                        for (int i = att.Count; i > 0; i--)
                        {
                            cnt++;
                            if (att[i].DisplayName.EndsWith("xls"))
                            {
                                att[i].SaveAsFile(@"E:\codeStudy\8-C#\Demo4\OpOutlook\atts\" +

                                    cnt + "--" +
                                 att[i].FileName);
                            }

                        }

                    }




                }
            }
        }

    }
}
