using System.Runtime.Serialization;

namespace MangoApps.Client.Request.Parameters
{
    [DataContract]
    public class SignupRequest
    {
        public SignupUser User { get; set; }
    }

    [DataContract]
    public class SignupUser
    {
        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "first_name")]
        public string FirstName { get; set; }

        [DataMember(Name = "last_name")]
        public string LastName { get; set; }

        [DataMember(Name = "plan")]
        public string Plan { get; set; }

        [DataMember(Name = "partner_code")]
        public string PartnerCode { get; set; }
    }
}
