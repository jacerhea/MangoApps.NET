using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class ProjectMembersSyncRequest
    {
        [DataMember(Name = "project")]
        public ProjectGroupSync Project { get; set; }
    }
}
