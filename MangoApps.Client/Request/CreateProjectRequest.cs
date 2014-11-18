using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class CreateProjectRequest
    {
        [DataMember(Name = "user")]
        public CreateProjectUser Project { get; set; }
    }

    [DataContract]
    public class CreateProjectUser
    {
        [DataMember(Name = "email")]
        public string Email { get; set; }
    }
}
