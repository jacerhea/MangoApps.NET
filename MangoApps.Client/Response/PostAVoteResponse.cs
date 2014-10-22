using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class PostAVoteResponse
    {
        [DataMember(Name = "comment")]
        public PostAVoteComment Comment { get; set; }
    }

    [DataContract]
    public class PostAVoteComment
    {
        [DataMember(Name = "body")]
        public string Body { get; set; }

        [DataMember(Name = "response")]
        public string Response { get; set; }
    }
}
