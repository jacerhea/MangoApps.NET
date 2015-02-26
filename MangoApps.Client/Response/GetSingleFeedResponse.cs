using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class GetSingleFeedResponse : TransactionResponse
    {
        [DataMember(Name = "marked_read_count")]
        public List<StatusFeed> Feed { get; set; }
    }
}
