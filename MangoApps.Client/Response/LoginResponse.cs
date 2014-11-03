using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MangoApps.Client.Converter;
using Newtonsoft.Json;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class LoginResponse
    {
        [DataMember(Name = "transaction_id")]
        public string TransactionId { get; set; }

        [DataMember(Name = "user")]
        public LoggedInUser User { get; set; }
    }

    [DataContract]
    public class LoggedInUser
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "aka")]
        public string AKA { get; set; }

        [DataMember(Name = "photo")]
        public string Photo { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "followers")]
        public int Followers { get; set; }

        [DataMember(Name = "following")]
        public int Following { get; set; }

        [DataMember(Name = "about_me")]
        public string AboutMe { get; set; }

        [DataMember(Name = "expertise")]
        public string Expertise { get; set; }

        [DataMember(Name = "dob")]
        public string DOB { get; set; }

        [DataMember(Name = "significant_other")]
        public string SignificantOther { get; set; }

        [DataMember(Name = "created_at")]
        [JsonConverter(typeof(SecondEpochConverter))]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include, NullValueHandling = NullValueHandling.Include)]
        public DateTime? CreatedAt { get; set; }

        [DataMember(Name = "time_zone")]
        public string TimeZone { get; set; }

        [DataMember(Name = "shar_im_link")]
        public string ShareIMLink { get; set; }

        [DataMember(Name = "user_type")]
        public string UserType { get; set; }

        [DataMember(Name = "socket_uri")]
        public string SocketURI { get; set; }

        [DataMember(Name = "http_uri")]
        public string HttpURI { get; set; }

        [DataMember(Name = "presence_option_id")]
        public string PresenceOptionId { get; set; }

        [DataMember(Name = "push_URL")]
        public string PushURI { get; set; }

        [DataMember(Name = "push_secondary_url")]
        public string PushSecondaryURI { get; set; }

        [DataMember(Name = "session_id")]
        public string SessionnId { get; set; }

        [DataMember(Name = "email_addresses")]
        public List<LoggedInUserEmail> EmailAddresses { get; set; }

        [DataMember(Name = "phone_numbers")]
        public List<LoggedInUserPhoneNumbers> PhoneNumbers { get; set; }

        [DataMember(Name = "education")]
        public List<LoginResponseSchool> Education { get; set; }

        [DataMember(Name = "experience")]
        public List<LoginResponseExperience> Experience { get; set; }
    }

    [DataContract]
    public class LoginResponseExperience
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "start_year")]
        public int StartYear { get; set; }

        [DataMember(Name = "end_year")]
        public int EndYear { get; set; }
    }

    [DataContract]
    public class LoginResponseSchool
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "degree")]
        public string Degree { get; set; }

        [DataMember(Name = "start_year")]
        public int StartYear { get; set; }

        [DataMember(Name = "end_year")]
        public int EndYear { get; set; }

    }

    [DataContract]
    public class LoggedInUserPhoneNumbers
    {
        [DataMember(Name = "location")]
        public string Location { get; set; }

        [DataMember(Name = "mobile_number")]
        public string Mobile { get; set; }

        [DataMember(Name = "landline_number")]
        public string Landline { get; set; }

        [DataMember(Name = "ext")]
        public string Extension { get; set; }

        [DataMember(Name = "fax")]
        public string Fax { get; set; }

    }

    [DataContract]
    public class LoggedInUserEmail
    {
        [DataMember(Name = "location")]
        public string Location { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }
    }
}
