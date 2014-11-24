using System.Runtime.Serialization;

namespace MangoApps.Client.Response
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
        public string photo { get; set; }

        [DataMember(Name = "PresenceOptionId")]
        public int PresenceOptionId { get; set; }
    }
}
