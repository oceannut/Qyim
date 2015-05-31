using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

using Nega.WcfUnity;

using Qyim.Server.Wcf;

namespace Qyim.Server.Wcf.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {

            UnityServiceHostFactory factory = new UnityServiceHostFactory();
            Type serviceType = typeof(MessageServiceImpl);
            ServiceHost serviceHost = factory.CreateServiceHost(serviceType);
            serviceHost.Open();

            Console.WriteLine("Server is starting...");
            Console.WriteLine("Press any key and exit.");
            Console.ReadKey();

            serviceHost.Close();

        }
    }
}
