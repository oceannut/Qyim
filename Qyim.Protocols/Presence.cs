using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qyim.Protocols
{

    [DataContract]
    public class Presence : BaseData
    {

        public PresenceType Type { get; set; }

        public PresenceMode Mode { get; set; }

        public string Status { get; set; }

        public int Priority { get; set; }

        public bool IsAvailable
        {
            get
            {
                return Type == PresenceType.Available;    
            }
        }

        public bool IsAway
        {
            get
            {
                return Type == PresenceType.Available 
                    && (Mode == PresenceMode.Away || Mode == PresenceMode.Xa || Mode == PresenceMode.Dnd); 
            }
        }

        [DataContract]
        public enum PresenceType
        {
            [EnumMember]
            Available,
            [EnumMember]
            Unavailable,
            [EnumMember]
            Error
        }

        [DataContract]
        public enum PresenceMode
        {
            [EnumMember]
            Available,
            [EnumMember]
            Chat,
            [EnumMember]
            Away,
            [EnumMember]
            Xa,
            [EnumMember]
            Dnd
        }

    }

}
