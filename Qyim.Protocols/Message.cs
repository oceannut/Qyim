using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qyim.Protocols
{

    [DataContract]
    public class Message : BaseData
    {

        [DataMember]
        public MessageType Type { get; set; }

        [DataMember]
        public string Body { get; set; }

        [DataMember]
        public IList<MessageProperty> Properties { get; set; }

        [DataContract]
        public enum MessageType
        {
            [EnumMember]
            Chat,
            [EnumMember]
            GroupChat,
            [EnumMember]
            Headline,
            [EnumMember]
            Ex,
            [EnumMember]
            Error
        }

        [DataContract]
        public class MessageProperty
        {
            [DataMember]
            public string Key { get; set; }

            [DataMember]
            public object Value { get; set; }
        }

    }

}
