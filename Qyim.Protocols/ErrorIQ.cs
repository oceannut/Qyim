using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qyim.Protocols
{
    public class ErrorIQ : IQ
    {

        public ErrorIQ(DataError error)
        {
            if (error == null)
            {
                throw new ArgumentNullException();
            }
            this.Type = IQ.IQType.Error;
            this.Error = error;
        }

    }
}
