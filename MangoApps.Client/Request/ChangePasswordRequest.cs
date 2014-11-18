using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class ChangePasswordRequest
    {
        public User User { get; set; }
    }

    [DataContract]
    public class User
    {
        public string NewPassword { get; set; }
        public string OldPassword { get; set; }
    }
}
