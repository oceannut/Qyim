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

        public AuthenticationResultIQ Login(AuthenticationIQ iq)
        {
            throw new NotImplementedException();
        }

        public AuthenticationResultIQ Logout(AuthenticationIQ iq)
        {
            throw new NotImplementedException();
        }

        public void Transfer(BaseData data)
        {
            OperationContext context = OperationContext.Current;
            MessageProperties properties = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty remoteEndpointProperty =
                properties[RemoteEndpointMessageProperty.Name] as RemoteEndpointMessageProperty;

            Console.WriteLine(
                string.Format("request from {0}, {1}", remoteEndpointProperty.Address, context.SessionId));
            Console.WriteLine(data.From);
            data.To = "ha";
            Callback.Notify(data);
        }

        public void KeepAlive()
        {
            throw new NotImplementedException();
        }

    }
}
