using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class DirectMessageRequest
    {
        [DataMember(Name = "feed")]
        public DirectMessageFeed Feed { get; set; }
    }

    [DataContract]
    public class DirectMessageFeed
    {
        [DataMember(Name = "attachments")]
        public List<string> Attachments { get; set; }

        [DataMember(Name = "users")]
        public ItemContainer Users { get; set; }

        [DataMember(Name = "feed_type")]
        public string FeedType { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }

    }

    [DataContract]
    public class ItemContainer
    {
        [DataMember(Name = "item")]
        public string Item { get; set; }
    }
}
