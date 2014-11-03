using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class CreateAHuddleRequest
    {
        [DataMember]
        public CreateAHuddleRequestParameters Huddle { get; set; }
    }

    [DataContract]
    public class CreateAHuddleRequestParameters
    {
        [DataMember(Name = "email_id")]
        public string EmailId { get; set; }

        [DataMember(Name = "user_name")]
        public string UserName { get; set; }

        [DataMember(Name = "member_list")]
        public List<string> MemberList { get; set; } 
    }
}
