using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class GetPinnedPostsResponse : TransactionResponse
    {
        public List<Post> Posts { get; set; }
    }
}
