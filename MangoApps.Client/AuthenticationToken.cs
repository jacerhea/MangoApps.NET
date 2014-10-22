using System;

namespace MangoApps.Client
{
    public class AuthenticationToken
    {
        public string Domain { get; private set; }
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string ApiKey { get; private set; }

        public AuthenticationToken(string domain, string userName, string password, string apiKey)
        {
            if (domain == null) throw new ArgumentNullException("domain");
            if (userName == null) throw new ArgumentNullException("userName");
            if (password == null) throw new ArgumentNullException("password");
            if (apiKey == null) throw new ArgumentNullException("apiKey");
            Domain = domain;
            UserName = userName;
            Password = password;
            ApiKey = apiKey;
        }
    }
}
