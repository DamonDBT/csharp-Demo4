﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Metadata;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
 
 

namespace RPCServer
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("创建HTTP通道");
            /*创建HTTP通道*/            
            HttpChannel channel = new HttpChannel(816);
            /*注册通道服务端*/
            ChannelServices.RegisterChannel(channel, false);
            /*服务端注册,使用Singletong激活*/
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(MessageMarshal.TestMessageMarshal), "TestMessageMarshal", WellKnownObjectMode.Singleton);

            /*接收客户端事件*/
            MessageMarshal.TestMessageMarshal.SendMessageEvent += new MessageMarshal.SendMessageHandler(TestMessageMarshal_SendMessageEvent);

             
            Console.Read();
        }
            static void TestMessageMarshal_SendMessageEvent(string messge)
           {
                Console.WriteLine(messge);
            }
         
    }
}
