using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class InviteUserResponse : TransactionResponse
    {
        [DataMember(Name = "user")]
        public InviteUserResponseUser User { get; set; }
    }

    public class InviteUserResponseUser
    {
        [DataMember(Name = "photo")]
        public string Photo { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }
    }
}
