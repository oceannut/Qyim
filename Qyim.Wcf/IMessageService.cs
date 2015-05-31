using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;

using Qyim.Protocols;

namespace Qyim.Wcf
{

    [ServiceContract(SessionMode = SessionMode.Required,
        CallbackContract = typeof(INotifyService))]
    public interface IMessageService
    {

        [OperationContract]
        string Transfer(string message);

        [OperationContract]
        BaseData TransferData(BaseData data);

        [OperationContract]
        void KeepAlive();

    }

}
