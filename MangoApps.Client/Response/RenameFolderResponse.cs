using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class RenameFolderResponse : TransactionResponse
    {
        [DataMember(Name = "folder")]
        public Folder Folder { get; set; }
    }

    [DataContract]
    public class Folder
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "conversation_id")]
        public string ConversationId { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "user_id")]
        public string UserId { get; set; }

        [DataMember(Name = "is_virtual_folder")]
        public bool IsVirtualFolder { get; set; }

        [DataMember(Name = "mlink")]
        public string MLink { get; set; }
    }
}
