using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class GetAllGroupsResponse
    {
        [DataMember(Name = "groups")]
        public List<GetAllGroups> Groups { get; set; }
    }

    [DataContract]
    public class GetAllGroups
    {
        [DataMember(Name = "photo")]
        public string Photo { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        [DataMember(Name = "upload_access")]
        public string UploadAccess { get; set; }

        [DataMember(Name = "my_project")]
        public string MyProject { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "Privacy")]
        public string privacy { get; set; }

        [DataMember(Name = "CreatorId")]
        public string CreatorId { get; set; }

        [DataMember(Name = "allow_members_to_invite")]
        public string AllowMembersToInvite { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }
    }
}
