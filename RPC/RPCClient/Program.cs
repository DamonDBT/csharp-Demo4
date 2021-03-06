﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
 
using System.Threading;
using System.Runtime.Remoting.Channels.Http;

namespace RPCClient
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
                RemotingConfiguration.RegisterWellKnownClientType(typeof(MessageMarshal.TestMessageMarshal), "http://localhost:816/TestMessageMarshal");
            /*创建消息实体*/
            MessageMarshal.TestMessageMarshal TestMessage = new MessageMarshal.TestMessageMarshal();

                while (true)
                {
                    TestMessage.SendMessage("DateTime.Now:" + System.DateTime.Now.ToString());
                    Console.WriteLine("send message...");
                    Thread.Sleep(2000);
                }
            }
        
    }
}
