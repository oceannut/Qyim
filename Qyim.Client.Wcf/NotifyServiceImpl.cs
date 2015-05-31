using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Qyim.Protocols;
using Qyim.Wcf;

namespace Qyim.Client.Wcf
{
    public class NotifyServiceImpl : INotifyService
    {

        public void Notify(string message)
        {
            Console.WriteLine(message);
        }

        public void NotifyData(BaseData data)
        {
            Console.WriteLine(data.From);
        }

    }
}
