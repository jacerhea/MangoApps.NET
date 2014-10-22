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
        private string _password;

        [DataMember(Name = "password")]
        public string Password
        {
            get { return Encoder.ToBase64String(_password); }
            set { _password = value; }
        }

        [DataMember(Name = "username")]
        public string UserName { get; set; }

        [DataMember(Name = "api_key")]
        public string APIKey { get; set; }
    }
}
