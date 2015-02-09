using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class GetProjectPostsResponse : TransactionResponse
    {
        [DataMember(Name = "posts")]
        public List<Posts> Posts { get; set; }
    }

    [DataContract]
    public class Posts
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "url")]
        public string URL { get; set; }
    }
}
