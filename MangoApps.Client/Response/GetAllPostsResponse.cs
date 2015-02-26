using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class GetAllPostsResponse : TransactionResponse
    {
        [DataMember(Name = "posts")]
        public List<Post> Posts { get; set; }

    }

    [DataContract]
    public class GetAllPinnedPostsResponse : TransactionResponse
    {
        [DataMember(Name = "posts")]
        public List<Post> Posts { get; set; }

    }

    [DataContract]
    public class Post
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "url")]
        public string URL { get; set; }
    }
}
