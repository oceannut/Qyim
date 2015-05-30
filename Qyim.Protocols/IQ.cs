using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qyim.Protocols
{

    [DataContract]
    public class IQ : BaseData
    {

        [DataMember]
        public IQType Type { get; set; }

        [DataContract]
        public enum IQType
        {
            [EnumMember]
            Get,
            [EnumMember]
            Set,
            [EnumMember]
            Result,
            [EnumMember]
            Error
        }

    }
}
