using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nega.Modularity;

namespace Qyim.Server
{
    public sealed class ClientConnectionManager : BasicModule
    {

        public override string Name
        {
            get { return "Client Connection Manager"; }
        }

        protected override void OnInitialize()
        {
            throw new NotImplementedException();
        }

        protected override void OnDestroy()
        {
            throw new NotImplementedException();
        }

    }
}
