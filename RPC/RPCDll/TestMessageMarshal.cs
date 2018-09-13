using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Metadata;

namespace RPCDll
{
    /*创建发送消息委托*/
    public delegate void SendMessageHandler(string messge);
    public class TestMessageMarshal : MarshalByRefObject
    {
        /*创建发送消息事件*/
        public static event SendMessageHandler SendMessageEvent;

        /*发送消息*/

        [SoapMethod(XmlNamespace = "RPCDll", SoapAction = "RPCDll#SendMessage")]
        public void SendMessage(string messge)
        {
            if (SendMessageEvent != null)
                SendMessageEvent(messge);
        }
    }
}
