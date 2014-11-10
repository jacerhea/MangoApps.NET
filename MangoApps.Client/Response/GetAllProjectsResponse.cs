using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class GetAllProjectsResponse : TransactionResponse
    {
        public List<Project> Projects { get; set; }
    }

    [DataContract]
    public class Project
    {
        [DataMember]
        public string Photo { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string CreatedAt { get; set; }

        [DataMember]
        public string UploadAccess { get; set; }

        [DataMember]
        public int MemberCount { get; set; }

        [DataMember]
        public string MyProject { get; set; }

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Privacy { get; set; }

        [DataMember]
        public string CreatorId { get; set; }

        [DataMember]
        public string AllowMembersToInvite { get; set; }

        [DataMember]
        public string State { get; set; }
    }
}
