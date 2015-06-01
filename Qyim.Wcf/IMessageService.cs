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

        [OperationContract(IsInitiating = true, IsTerminating = false)]
        AuthenticationResultIQ Login(AuthenticationIQ iq);

        [OperationContract(IsInitiating = false, IsTerminating = true)]
        AuthenticationResultIQ Logout(AuthenticationIQ iq);

        [OperationContract]
        void Transfer(BaseData data);

        [OperationContract]
        void KeepAlive();

    }

}
