using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace TestRemotingServer
{
    /*code:释迦苦僧*/
    class Program
    {
        static void Main(string[] args)
        {
            //WCF、.Net Remoting和WebService的关系： 
           // .Net Remoting是普通的TCP通讯，适合于局域网，效率高； 
           // WebService是基于Http协议，适合于广域网，效率低；
            //WCF是对.Net Remoting、 WebService等的简化、统一，可以通过配置来切换不同的底层实现，代码几乎不用动。 
            //本例子是。net remoting

            Console.WriteLine("创建HTTP通道");
            /*创建HTTP通道*/
            HttpChannel channel = new HttpChannel(816);
            /*注册通道服务端*/
            ChannelServices.RegisterChannel(channel, false);
            /*服务端注册,使用Singletong激活*/
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(MessageMarshal.TestMessageMarshal), "TestMessageMarshal", WellKnownObjectMode.Singleton);

            /*接收客户端事件*/
            MessageMarshal.TestMessageMarshal.SendMessageEvent += new MessageMarshal.SendMessageHandler(TestMessageMarshal_SendMessageEvent);

            MessageMarshal.TestMessageMarshal.sendmsg += new MessageMarshal.SendMsg(SendMsg); 

            Console.Read();

        }
        static void TestMessageMarshal_SendMessageEvent(string messge)
        {
            Console.WriteLine("server write:"+messge);
        }

        static void SendMsg(string messge)
        {
            Console.WriteLine("my server write:" + messge);
        }

        
    }
}