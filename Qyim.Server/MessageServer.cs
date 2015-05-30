using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Nega.Common;
using Nega.Modularity;

namespace Qyim.Server
{
    public class MessageServer : BasicModule
    {

        private readonly ILogger logger;

        public override string Name
        {
            get { return "Message Server"; }
        }

        public MessageServer()
        {
            this.logger = LogManager.GetLogger(typeof(MessageServer));
        }

        protected override void OnInitialize()
        {
            logger.Info("Initialize");
        }

        protected override void OnDestroy()
        {
            logger.Info("Destroy");
        }

    }

}
