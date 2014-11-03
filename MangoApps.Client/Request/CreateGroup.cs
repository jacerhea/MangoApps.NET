using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class CreateGroupRequest
    {
        [DataMember(Name = "group")]
        public CreateGroupRequestParameters Group { get; set; }
    }

    [DataContract]
    public class CreateGroupRequestParameters
    {
        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "privacy_type")]
        public string PrivacyType { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }        
    }
}
