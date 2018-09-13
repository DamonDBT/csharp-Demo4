using System;
using System.Runtime.Remoting.Metadata;

/*code 释迦苦僧*/
namespace MessageMarshal
{
    /*创建发送消息委托*/
    public delegate void SendMessageHandler(string messge);

    public delegate void SendMsg(string msg);

    /// <summary>
    /// 好像用接口不行，用委托、事件是可以的
    /// </summary>
    interface ISendM
    {
        void SendM(string str);
    }

    public class TestMessageMarshal : MarshalByRefObject  
    {
        /*创建发送消息事件*/
        public static event SendMessageHandler SendMessageEvent;

        public static SendMsg sendmsg;
        /*发送消息*/

        [SoapMethod(XmlNamespace = "MessageMarshal", SoapAction = "MessageMarshal#SendMessage")]
        public void SendMessage(string messge)
        {
            if (SendMessageEvent != null)
                SendMessageEvent(messge);
        }

        [SoapMethod(XmlNamespace = "MessageMarshal", SoapAction = "MessageMarshal#SendMsg")]
        public void SendMsg(string messge)
        {
            if (sendmsg != null)
                sendmsg(messge);
        }

        //public void SendM(string str)
        //{

        //}

    }
}
