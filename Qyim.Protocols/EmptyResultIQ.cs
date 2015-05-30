using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qyim.Protocols
{
    public class EmptyResultIQ : IQ
    {

        public EmptyResultIQ()
        {
            this.Type = IQ.IQType.Result;
        }

        public EmptyResultIQ(IQ request)
            : this()
        {
            if (!(request.Type == IQType.Get || request.Type == IQType.Set))
            {
                throw new ArgumentException(
                        "IQ must be of type 'Get' or 'Set'. Original IQ: " + request);
            }
            this.Id = request.Id;
            this.From = request.To;
            this.To = request.From;
        }

    }
}
