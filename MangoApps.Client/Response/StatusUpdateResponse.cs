using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MangoApps.Client
{
    [DataContract]
    public class StatusUpdateResponse : TransactionResponse
    {
        [DataMember(Name = "feed")]
        public StatusFeed Feed { get; set; }
    }

    [DataContract]
    public class StatusFeed
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "feed_type")]
        public string FeedType { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }

        [DataMember(Name = "mlink")]
        public string MLink { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "is_system")]
        [JsonConverter(typeof(YNConverter))]
        public bool IsSystem { get; set; }

        [DataMember(Name = "is_link")]
        [JsonConverter(typeof(YNConverter))]
        public bool IsLink { get; set; }

        [DataMember(Name = "shareable")]
        [JsonConverter(typeof(YNConverter))]
        public string Shareable { get; set; }

        [DataMember(Name = "sub_category")]
        public string SubCategory { get; set; }

        [DataMember(Name = "session_id")]
        public string SessionId { get; set; }

        [DataMember(Name = "from_user")]
        public BasicUser FromUser { get; set; }

        [DataMember(Name = "group_id")]
        public string GroupId { get; set; }

        [DataMember(Name = "platform")]
        public string Platform { get; set; }

        [DataMember(Name = "like_count")]
        public int LikeCount { get; set; }

        [DataMember(Name = "comment_count")]
        public int CommentCount { get; set; }

        [DataMember(Name = "attachment_count")]
        public int AttachmentCount { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> Attachments { get; set; }

        [DataMember(Name = "attachment_references")]
        public List<string> AttachmentReferences { get; set; }

        [DataMember(Name = "liked")]
        public bool Liked { get; set; }

        [DataMember(Name = "liked_list")]
        public List<string> LikedList { get; set; }

        [DataMember(Name = "watched")]
        public bool Watched { get; set; }

        [DataMember(Name = "unread")]
        public bool Unread { get; set; }

        [DataMember(Name = "comments")]
        public List<string> Comments { get; set; }

        [JsonConverter(typeof(SecondEpochConverter))]
        [DataMember(Name = "created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonConverter(typeof(SecondEpochConverter))]
        [DataMember(Name = "updated_at")]
        public DateTime UpdatedAt { get; set; }

        [DataMember(Name = "visibility")]
        public string Visibility { get; set; }
    }
}
