using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class InviteUserRequest
    {
        [DataMember(Name = "user")]
        public InviteUserRequestUser User { get; set; }
    }

    [DataContract]
    public class InviteUserRequestUser
    {
        [DataMember(Name = "email")]
        public InviteUserRequestIds Email { get; set; }
    }

    [DataContract]
    public class InviteUserRequestIds
    {
        [DataMember(Name = "ids")]
        public List<string> Ids { get; set; }
    }
}
