using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;
using MSQueen.DataClass;
using MSQueen.Common;

namespace MSQueen.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageQueue MSMQ = CreateMessageQueue(@".\private$\tpmsmq");
            MSMQ.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });

            Receiver(MSMQ);
        }
        private static void Receiver(MessageQueue MSMQ)
        {
            while (true)
            {
                try
                {
                    //Message m = MSMQ.Receive();
                    Message m = MSMQ.Receive(MessageQueueTransactionType.Single);
                    var rec = m.Body.ToString();
                  

                    //var ms1 = XMLSerDe.DeXMLSerialize<MSClass>(rec);
                   var ms1 = Newtonsoft.Json.JsonConvert.DeserializeObject<MSClass>(rec);

                    Console.WriteLine(string.Format("{0} 接收方:[{1}]",
                        DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), ms1.Name+ms1.Age.ToString()+ms1.Address));
                }
                
                catch (Exception ex)
                {
                    Console.WriteLine(string.Format("{0} 接收方:{1}",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), ex.Message));
                }
            }
        }

        public static MessageQueue CreateMessageQueue(string path)
        {
            MessageQueue mq = null;

            if (MessageQueue.Exists(path))
            {
                mq = new MessageQueue(path);
            }
            else
            {
                mq = MessageQueue.Create(path, true);
            }

            return mq;
        }
    }
    
}
