using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client
{
    public class GetFilesInsideATeam : TransactionResponse
    {
        [DataMember(Name = "count")]
        public int Count { get; set; }

        [DataMember(Name = "attachments")]
        public List<Attachment> Attachments { get; set; }
    }

    public class Attachment
    {
        [DataMember(Name = "filename")]
        public string FileName { get; set; }

        [DataMember(Name = "size")]
        public string Size { get; set; }

        [DataMember(Name = "content_type")]
        public string ContentType { get; set; }

        [DataMember(Name = "short_url")]
        public string ShortURL { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "user_id")]
        public string UserId { get; set; }

        [DataMember(Name = "mlink")]
        public string MLink { get; set; }

        [DataMember(Name = "preview_url")]
        public string PreviewURL { get; set; }
    }
}
