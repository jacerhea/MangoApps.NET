using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class ChangePasswordRequest
    {
        [DataMember(Name = "user")]
        public User User { get; set; }
    }

    [DataContract]
    public class User
    {
        [DataMember(Name = "new_password")]
        public string NewPassword { get; set; }

        [DataMember(Name = "old_password")]
        public string OldPassword { get; set; }
    }
}
