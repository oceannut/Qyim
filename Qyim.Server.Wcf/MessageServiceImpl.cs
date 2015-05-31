using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

using Qyim.Protocols;
using Qyim.Wcf;

namespace Qyim.Server.Wcf
{

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class MessageServiceImpl : IMessageService
    {

        internal INotifyService Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<INotifyService>();
            }
        }

        public string Transfer(string message)
        {
            OperationContext context = OperationContext.Current;
            MessageProperties properties = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty remoteEndpointProperty =
                properties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;

            Console.WriteLine(
                string.Format("request from {0}", remoteEndpointProperty.Address));
            Console.WriteLine(message);
            Callback.Notify("hello "+ message);

            return message;
        }

        public BaseData TransferData(BaseData data)
        {
            OperationContext context = OperationContext.Current;
            MessageProperties properties = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty remoteEndpointProperty =
                properties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;

            Console.WriteLine(
                string.Format("request from {0}", remoteEndpointProperty.Address));
            Console.WriteLine(data.From);
            data.To = "ha";
            Callback.NotifyData(data);

            return data;
        }

        public void KeepAlive()
        {
            throw new NotImplementedException();
        }

    }
}
