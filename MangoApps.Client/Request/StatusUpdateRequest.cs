using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class StatusUpdateRequest
    {
        [DataMember(Name = "feed")]
        public StatusUpdateFeed Feed { get; set; }
    }

    [DataContract]
    public class StatusUpdateFeed
    {
        [DataMember(Name = "feed_type")]
        public string FeedType { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }
    }
}
