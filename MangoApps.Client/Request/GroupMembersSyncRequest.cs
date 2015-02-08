using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class GroupMembersSyncRequest
    {
        [DataMember(Name = "group")]
        public ProjectGroupSync Group { get; set; }
    }

    [DataContract]
    public class ProjectGroupSync
    {
        [DataMember(Name = "add_member_emails")]
        public List<string> AddMemberEmails { get; set; }

        [DataMember(Name = "add_member_ids")]
        public List<int> AddMemberIds { get; set; }

        [DataMember(Name = "remove_member_ids")]
        public List<int> RemoveMemberIds { get; set; }
    }
}
