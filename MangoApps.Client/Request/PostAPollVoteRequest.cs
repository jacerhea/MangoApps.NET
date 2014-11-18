using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class PostAPollVoteRequest
    {
        [DataMember(Name = "comment")]
        public PostAPollComment Comment { get; set; }
    }

    [DataContract]
    public class PostAPollComment
    {
        [DataMember(Name = "body")]
        public string Body { get; set; }

        [DataMember(Name = "response")]
        public string Response { get; set; }
    }
}
