using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class CreateGroupRequest
    {
        [DataMember(Name = "group")]
        public CreateGroupRequestParameters Group { get; set; }
    }
}
