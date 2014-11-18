using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class SignupRequest
    {
        [DataMember(Name = "user")]
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
        public PlanTypes? Plan { get; set; }

        [DataMember(Name = "partner_code")]
        public string PartnerCode { get; set; }
    }

    [DataContract]
    public enum PlanTypes
    {
        [DataMember(Name = "basic")]
        Basic,

        [DataMember(Name = "premiere")]
        Premiere,

        [DataMember(Name = "enterprise")]
        Enterprise
    }
}
