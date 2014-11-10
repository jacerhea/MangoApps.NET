using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class GetProjectPostsResponse : TransactionResponse
    {
        [DataMember]
        public List<Posts> Posts { get; set; }
    }

    [DataContract]
    public class Posts
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public string URL { get; set; }
    }
}
