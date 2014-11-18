using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class ProjectWallRequest
    {
        [DataMember(Name = "feed")]
        public ProjectWallFeed Feed { get; set; }
    }

    //todo: not sure about attachments
    [DataContract]
    public class ProjectWallFeed
    {
        [DataMember(Name = "project_id")]
        public string ProjectId { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> Attachments { get; set; }

        [DataMember(Name = "feed_type")]
        public string FeedType { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }
    }
}
