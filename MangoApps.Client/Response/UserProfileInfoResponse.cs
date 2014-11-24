using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MangoApps.Client.Converter;
using Newtonsoft.Json;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class UserProfileInfoResponse : TransactionResponse
    {
        [DataMember(Name = "user")]
        public UserProfileInfo User { get; set; }
    }

    [DataContract]
    public class UserProfileInfo
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "user_type")]
        public string UserType { get; set; }

        [DataMember(Name = "user_mention")]
        public string UserMention { get; set; }

        [DataMember(Name = "aka")]
        public string AKA { get; set; }

        [DataMember(Name = "photo")]
        public string Photo { get; set; }

        [DataMember(Name = "image_url")]
        public string ImageURL { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "followers")]
        public int Followers { get; set; }

        [DataMember(Name = "following")]
        public int Following { get; set; }

        [DataMember(Name = "is_following")]
        [JsonConverter(typeof(YNConverter))]
        public bool IsFollowing { get; set; }

        [DataMember(Name = "following_me")]
        [JsonConverter(typeof(YNConverter))]
        public bool FollowingMe { get; set; }

        [DataMember(Name = "about_me")]
        public string AboutMe { get; set; }

        [DataMember(Name = "expertise")]
        public string Expertise { get; set; }

        [DataMember(Name = "dob")]
        public DateTime? DateOfBith { get; set; }

        [DataMember(Name = "significant_other")]
        public string SignificantOther { get; set; }

        [DataMember(Name = "created_at")]
        [JsonConverter(typeof(SecondEpochConverter))]
        public DateTime CreatedAt{ get; set; }

        [DataMember(Name = "time_zone")]
        public string TimeZone { get; set; }

        [DataMember(Name = "share_im_link")]
        public string ShareIMLink{ get; set; }

        [DataMember(Name = "socket_uri")]
        public string SocketURI { get; set; }

        [DataMember(Name = "http_uri")]
        public string HttpURI { get; set; }

        [DataMember(Name = "is_first_login")]
        public bool? IsFirstLogin { get; set; }

        [DataMember(Name = "comments_order")]
        public string CommentsOrder { get; set; }

        [DataMember(Name = "presence_option_id")]
        public int? PresenceOptionId { get; set; }

        [DataMember(Name = "presence_string")]
        public string PresenceString { get; set; }

        [DataMember(Name = "push_url")]
        public string PushURL { get; set; }

        [DataMember(Name = "push_secondary_url")]
        public string PushSecondaryURL { get; set; }

        [DataMember(Name = "session_id")]
        public string SessionId { get; set; }

        [DataMember(Name = "home_address")]
        public string HomeAddress { get; set; }

        [DataMember(Name = "work_address")]
        public string WorkAddress { get; set; }

        [DataMember(Name = "email_addresses")]
        public UserProfileEmailAddresses EmailAddresses { get; set; }

        [DataMember(Name = "phone_numbers")]
        public UserProfilePhoneNumbers PhoneNumbers { get; set; }
    }

    [DataContract]
    public class UserProfileEmailAddresses
    {
        [DataMember(Name = "email_address")]
        public List<UserProfileEmail> EmailAddresses { get; set; }        
    }

    [DataContract]
    public class UserProfilePhoneNumbers
    {
        [DataMember(Name = "phone_number")]
        public List<UserProfilePhoneNumber> PhoneNumbers { get; set; }
    }

    [DataContract]
    public class UserProfilePhoneNumber
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
    public class UserProfileEmail
    {
        [DataMember(Name = "location")]
        public string Location { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }
    }
}
