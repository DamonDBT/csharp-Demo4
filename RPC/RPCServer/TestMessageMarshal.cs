using System;
using System.Runtime.Remoting.Metadata;

/*code 释迦苦僧*/
namespace MessageMarshal
{
    /*创建发送消息委托*/
    public delegate void SendMessageHandler(string messge);
    public class TestMessageMarshal : MarshalByRefObject
    {
        /*创建发送消息事件*/
        public static event SendMessageHandler SendMessageEvent;

        /*发送消息*/

        [SoapMethod(XmlNamespace = "MessageMarshal", SoapAction = "MessageMarshal#SendMessage")]
        public void SendMessage(string messge)
        {
            if (SendMessageEvent != null)
                SendMessageEvent(messge);
        }
    }
}
