using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Threading;

/*code 释迦苦僧*/
namespace TestRemotingClient
{
    class Program
    {
        static void Main(string[] args)
        {
            /*创建通道*/
            HttpChannel channel = new HttpChannel();
            /*注册通道*/
            ChannelServices.RegisterChannel(channel, false);
            /*注册通道 的 远程处理类型*/
            RemotingConfiguration.RegisterWellKnownClientType(typeof(MessageMarshal.TestMessageMarshal),
                                                                     "http://localhost:816/TestMessageMarshal");

            ///*创建消息实体*/
            MessageMarshal.TestMessageMarshal TestMessage = new MessageMarshal.TestMessageMarshal();

            while (true)
            {
                //sendmessage在client和dll中都没有指定怎么实现，是在server中指定了实现，但是client却可以调用。这就让是。net remote 
                TestMessage.SendMessage("DateTime.Now:" + System.DateTime.Now.ToString());
                TestMessage.SendMsg("--DateTime.Now:" + System.DateTime.Now.ToString());

                //MessageMarshal.TestMessageMarshal.sendmsg("dasdf");//一般的程序，这样是可以调用委托的，但是这里提示null

                Console.WriteLine("send message...");
                Thread.Sleep(2000);
            }
        }
    }
}