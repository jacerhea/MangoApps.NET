using System.Runtime.Serialization;

namespace MangoApps.Client.Request.Parameters
{
    [DataContract]
    public class LoginRequestParameters
    {
        [DataMember(Name = "user")]
        public LoginUser User { get; set; }
    }

    [DataContract]
    public class LoginUser
    {
        [DataMember(Name = "password")]
        public string Password { get; set; }

        [DataMember(Name = "username")]
        public string UserName { get; set; }

        [DataMember(Name = "api_key")]
        public string APIKey { get; set; }
    }
}
