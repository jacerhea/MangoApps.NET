using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class EditSelfCreatedGroupOrProjectResponse : TransactionResponse
    {
        [DataMember(Name = "photo")]
        public Conversation Conversation { get; set; }
    }

    [DataContract]
    public class Conversation
    {
        [DataMember(Name = "photo")]
        public string Photo { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "is_group")]
        public string IsGroup { get; set; }

        [DataMember(Name = "creator_id")]
        public string CreatorId { get; set; }

        [DataMember(Name = "has_default_photo")]
        public string HasDefaultPhoto { get; set; }
    }
}
