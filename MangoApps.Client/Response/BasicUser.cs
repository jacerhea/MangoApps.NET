using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class BasicUser
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "photo")]
        public string Photo { get; set; }

        [DataMember(Name = "presence_option_id")]
        public int PresenceOptionId { get; set; }
    }
}
