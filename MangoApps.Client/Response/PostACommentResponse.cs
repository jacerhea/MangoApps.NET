using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class PostACommentResponse
    {
        [DataMember(Name = "comment")]
        public PostAComment Comment { get; set; }
    }

    [DataContract]
    public class PostAComment
    {
        [DataMember(Name = "create_at")]
        public string CreatedAt { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }

        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "feed_id")]
        public string FeedId { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> Attachments { get; set; }

        [DataMember(Name = "user")]
        public PostACommentUser User { get; set; }

        [DataMember(Name = "platform")]
        public string Platform { get; set; }
    }

    [DataContract]
    public class PostACommentUser
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "photo")]
        public string Photo { get; set; }

        [DataMember(Name = "presence_option_id")]
        public string PresenceOptionId { get; set; }
    }
}
