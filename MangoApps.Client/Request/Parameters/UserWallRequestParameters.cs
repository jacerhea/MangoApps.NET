using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Request.Parameters
{
    [DataContract]
    public class UserWallRequestParameters
    {
        [DataMember(Name = "feed")]
        public UserWallFeed Feed { get; set; }
    }

    [DataContract]
    public class UserWallFeed
    {
        [DataMember(Name = "attachments")]
        public List<string> Attachments { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }
    }

}
