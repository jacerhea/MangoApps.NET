using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class RemoveMembersFromAProjectResponse : TransactionResponse
    {
        public string project_id { get; set; }

        public List<Member> Members { get; set; } 
    }

    [DataContract]
    public class Member
    {
        public string Photo { get; set; }
        public string Name { get; set; }
        public string PresenceOptionId { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
    }
}
