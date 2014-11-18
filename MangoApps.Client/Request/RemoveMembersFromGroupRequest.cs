using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class RemoveMembersFromGroupRequest
    {
        public Group Group { get; set; }
    }

    [DataContract]
    public class Group
    {
        public List<string> AddMemberEmails { get; set; }
        public List<string> AddMemberIds { get; set; }
        public List<string> RemoveMembersIds { get; set; }
    }
}
