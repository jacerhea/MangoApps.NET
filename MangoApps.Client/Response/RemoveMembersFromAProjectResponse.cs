using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class RemoveMembersFromAProjectResponse : TransactionResponse
    {
        [DataMember(Name = "project_id")]
        public string ProjectId { get; set; }

        [DataMember(Name = "members")]
        public List<Member> Members { get; set; } 
    }

    [DataContract]
    public class Member
    {
        [DataMember(Name = "photo")]
        public string Photo { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "presence_option_id")]
        public string PresenceOptionId { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }
    }
}
