using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using Qyim.Protocols;
using Qyim.Wcf;
using Qyim.Client.Wcf;
using System.ServiceModel.Channels;

namespace Qyim.Client.Wcf.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {

            InstanceContext instanceContext = new InstanceContext(new NotifyServiceImpl());
            Binding tcpBinding = new NetTcpBinding();
            EndpointAddress tcpAddr = new EndpointAddress(string.Format("net.tcp://{0}:{1}/MessageService/", "127.0.0.1", 1980));
            IMessageService client = new DuplexChannelFactory<IMessageService>(instanceContext, tcpBinding, tcpAddr).CreateChannel();

            client.Transfer(new IQ
            {
                From = "zsp"
            });

            client.Transfer(new Qyim.Protocols.Message
            {
                From = "lj"
            });

            client.Transfer(new Qyim.Protocols.Presence
            {
                From = "zqy"
            });

            Console.ReadKey();

        }
    }
}
