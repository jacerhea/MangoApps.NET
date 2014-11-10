using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class GetWikisResponse : TransactionResponse
    {
        public List<Wiki> Wikis { get; set; }
    }
}
