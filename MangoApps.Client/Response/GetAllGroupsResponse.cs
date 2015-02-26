using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class GetAllGroupsResponse
    {
        [DataMember(Name = "groups")]
        public List<GetAllGroups> Groups { get; set; }
    }

    [DataContract]
    public class GetAllGroups : Audit
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "photo")]
        public string Photo { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "upload_access")]
        public string UploadAccess { get; set; }

        [DataMember(Name = "my_project")]
        public string MyProject { get; set; }

        [DataMember(Name = "privacy")]
        public string Privacy { get; set; }

        [DataMember(Name = "member_Count")]
        public int MemberCount { get; set; }

        [DataMember(Name = "CreatorId")]
        public int CreatorId { get; set; }

        [DataMember(Name = "allow_members_to_invite")]
        public bool AllowMembersToInvite { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }
    }
}
