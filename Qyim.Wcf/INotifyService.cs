using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;

using Qyim.Protocols;

namespace Qyim.Wcf
{

    public interface INotifyService
    {

        [OperationContract(IsOneWay = true)]
        void Notify(BaseData data);

    }

}
