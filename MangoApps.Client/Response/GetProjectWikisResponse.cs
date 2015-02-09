using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class GetProjectWikisResponse : TransactionResponse
    {
        [DataMember(Name = "wikis")]
        public List<Wiki> Wikis { get; set; }
    }

    [DataContract]
    public class Wiki
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "url")]
        public string URL { get; set; }
    }
}
