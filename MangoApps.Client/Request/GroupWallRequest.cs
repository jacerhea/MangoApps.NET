using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class GroupWallRequest
    {
        [DataMember(Name = "feed")]
        public GroupWallFeed Feed { get; set; }
    }

    [DataContract]
    public abstract class GroupWallFeed
    {
        [DataMember(Name = "body")]
        public string Body { get; set; }

        [DataMember(Name = "group_id")]
        public string GroupId { get; set; }

        [DataMember(Name = "feed_type")]
        public string FeedType { get; set; }
    }
}
