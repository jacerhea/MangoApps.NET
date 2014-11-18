using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class CreateHuddleRequest
    {
        [DataMember(Name = "huddle")]
        public Huddle Huddle { get; set; }
    }

    [DataContract]
    public class Huddle
    {
        [DataMember(Name = "email_id")]
        public string EmailId { get; set; }

        [DataMember(Name = "user_name")]
        public string UserName { get; set; }

        [DataMember(Name = "member_list")]
        public List<string> MemberList { get; set; } 
    }
}
