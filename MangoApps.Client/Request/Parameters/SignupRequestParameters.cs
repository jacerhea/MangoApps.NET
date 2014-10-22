using System.Runtime.Serialization;

namespace MangoApps.Client.Request.Parameters
{
    [DataContract]
    public class SignupRequestParameters
    {
        [DataMember(Name = "user")]
        public UserField User { get; set; }
    }

    public class UserField
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Plan { get; set; }
        public string PartnerCode { get; set; }
    }
}
