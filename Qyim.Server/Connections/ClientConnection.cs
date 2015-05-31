using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qyim.Server
{

    public sealed class ClientConnection
    {

        private readonly ClientConnectionManager manager;

        public string ClientId { get; private set; }

        public ClientConnection(ClientConnectionManager manager,
            string clientId)
        {
            if (manager == null || string.IsNullOrWhiteSpace(clientId))
            {
                throw new ArgumentNullException();
            }

            this.manager = manager;
            this.ClientId = clientId;
        }


    }
}
