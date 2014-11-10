using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class GetAllPostsResponse : TransactionResponse
    {
        public List<Post> Posts { get; set; }

    }

    [DataContract]
    public class Post
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
    }
}
