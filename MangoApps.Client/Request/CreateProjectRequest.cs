using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class CreateProjectRequest
    {
        public CreateProjectRequestParameters Project { get; set; }
    }

    public class CreateProjectRequestParameters
    {
        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "privacy_type")]
        public string PrivacyType { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
