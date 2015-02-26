using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class GetWikisResponse : TransactionResponse
    {
        [DataMember(Name = "wikis")]
        public List<Wiki> Wikis { get; set; }
    }
}
