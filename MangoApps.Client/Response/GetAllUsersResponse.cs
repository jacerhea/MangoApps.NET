using System.Collections.Generic;
using System.Runtime.Serialization;
using MangoApps.Client.Converter;
using Newtonsoft.Json;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class GetAllUsersResponse
    {
        [DataMember(Name = "users")]
        public List<GetAllUsersUser> Users { get; set; } 
    }

    [DataContract]
    public class GetAllUsersUser
    {
        [DataMember(Name = "photo")]
        public string Photo { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "presence_option_id")]
        public string PresenceOptionId { get; set; }

        [DataMember(Name = "presence_string")]
        public string PresenceString { get; set; }

        [DataMember(Name = "has_default_photo")]
        [JsonConverter(typeof(YNConverter))]
        public bool HasDefaultPhoto { get; set; }

        [DataMember(Name = "custom_status")]
        public string CustomStatus { get; set; }
    }
}
