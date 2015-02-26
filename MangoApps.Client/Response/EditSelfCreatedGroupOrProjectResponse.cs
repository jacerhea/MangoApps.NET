using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class EditSelfCreatedGroupOrProjectResponse : TransactionResponse
    {
        [DataMember(Name = "conversation")]
        public Conversation Conversation { get; set; }
    }

    [DataContract]
    public class Conversation : Audit
    {
        [DataMember(Name = "photo")]
        public string Photo { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "is_group")]
        [JsonConverter(typeof(YNConverter))]
        public bool IsGroup { get; set; }

        [DataMember(Name = "creator_id")]
        public string CreatorId { get; set; }

        [DataMember(Name = "has_default_photo")]
        public bool HasDefaultPhoto { get; set; }
    }
}
