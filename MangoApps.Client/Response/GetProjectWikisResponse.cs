using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class GetProjectWikisResponse : TransactionResponse
    {
        public List<Wiki> Wikis { get; set; }
    }

    [DataContract]
    public class Wiki
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
    }
}
