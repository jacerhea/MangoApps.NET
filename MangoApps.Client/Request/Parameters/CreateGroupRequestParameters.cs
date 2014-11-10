using System.Runtime.Serialization;

namespace MangoApps.Client.Request.Parameters
{
    [DataContract]
    public class CreateGroupRequestParameters
    {
        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "privacy_type")]
        public PrivacyType PrivacyType { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }        
    }
}
