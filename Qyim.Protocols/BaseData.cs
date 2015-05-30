using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Qyim.Protocols
{

    [DataContract]
    public class BaseData
    {

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string From { get; set; }

        [DataMember]
        public string To { get; set; }

        [DataMember]
        public DateTimeOffset Timestamp { get; set; }

        [DataMember]
        public DataError Error { get; set; }

        public BaseData()
        {

        }

        public BaseData(string id)
        {
            this.Id = id;
        }

        public BaseData(BaseData data)
        {
            this.Id = data.Id;
            this.From = data.From;
            this.To = data.To;
            this.Timestamp = data.Timestamp;
            this.Error = data.Error;
        }

    }

}
