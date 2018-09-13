using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Messaging;
using System.Xml.Serialization;
using System.Threading;
using MSQueen.DataClass;
using MSQueen.Common;


namespace MSQueen
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageQueue MSMQ = CreateMessageQueue(@".\private$\tpmsmq");
            MSMQ.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });

            Console.WriteLine("是否继续发送消息:Y/N?");
            string cmd = Console.ReadLine();

            while (true)
            {
                Sender(MSMQ);

                Thread.Sleep(2000);
            }


            Console.WriteLine("按任意键以停止...");
            Console.ReadKey();
        }
        private static void Sender(MessageQueue MSMQ)
        {
            try
            {
                string random = GenerateRandom();
                string obj = string.Format("{0} 发送方:{1}",
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), random);

                MSClass ms = new MSClass();
                ms.Name = "zhangsan";
                ms.Age = 12;
                ms.Address = "chongqing";
                ms.Scrores = new List<int> { 12, 34, 324, 2342 };

                //var str = XMLSerDe.XMLSerialize(ms);
                var str = Newtonsoft.Json.JsonConvert.SerializeObject(ms);

                MSMQ.Send(str, MessageQueueTransactionType.Single);
                //MSMQ.Send(str);
                //MSMQ.Send(obj, MessageQueueTransactionType.Single);

                Console.WriteLine(obj);

            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("{0} 发送方:{1}",
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), ex.Message));
            }
        }

        public static MessageQueue CreateMessageQueue(string path)
        {
            MessageQueue mq = null;
            if (MessageQueue.Exists(path))
                mq = new MessageQueue(path);
            else
                mq = MessageQueue.Create(path, true);
            return mq;
        }
        public static string GenerateRandom()
        {
            int seed = GetRandomSeed();
            return new Random(seed)
                .Next(Int32.MaxValue).ToString();
        }

        /// <summary>
        /// 创建加密随机数生成器 生成强随机种子
        /// </summary>
        /// <returns></returns>
        private static int GetRandomSeed()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng
                = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            return BitConverter.ToInt32(bytes, 0);
        }
    }


}
