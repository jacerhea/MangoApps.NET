using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MangoApps.Client
{
    [DataContract]
    public class UserWallResponse : TransactionResponse
    {
        [DataMember(Name = "feed")]
        public UserWallFeedResponse Feed { get; set; }
    }

    [DataContract]
    public class UserWallFeedResponse
    {
        [DataMember(Name = "like_count")]
        public int LikeCount { get; set; }

        [DataMember(Name = "sub_category")]
        public string SubCategory { get; set; }

        [DataMember(Name = "created_at")]
        [JsonConverter(typeof(SecondEpochConverter))]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "category")]
        public string Category { get; set; }

        [DataMember(Name = "comments")]
        public List<string> Comments { get; set; }

        [DataMember(Name = "from_wall")]
        public List<UserWallToFromUser> FromUser { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }

        [DataMember(Name = "updated_at")]
        [JsonConverter(typeof(SecondEpochConverter))]
        public DateTime UpdatedAt { get; set; }

        [DataMember(Name = "unread")]
        public string Unread { get; set; }

        [DataMember(Name = "session_id")]
        public string SessionId { get; set; }

        [DataMember(Name = "group_id")]
        public string GroupId { get; set; }

        [DataMember(Name = "shareable")]
        public string Shareable { get; set; }

        [DataMember(Name = "feed_type")]
        public string FeedType { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "like")]
        public string Liked { get; set; }

        [DataMember(Name = "comment_count")]
        public string CommentCount { get; set; }

        [DataMember(Name = "to_user")]
        public UserWallToFromUser ToUser { get; set; }

        [DataMember(Name = "watched")]
        public string Watched { get; set; }

        [DataMember(Name = "liked_list")]
        public List<string> LikedList { get; set; }

        [DataMember(Name = "attachment_count")]
        public int AttachmentCount { get; set; }

        [DataMember(Name = "is_link")]
        public string IsLink { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> Attachments { get; set; }

        [DataMember(Name = "mlink")]
        public string MLink { get; set; }

        [DataMember(Name = "platform")]
        public string Platform { get; set; }

        [DataMember(Name = "is_system")]
        public string IsSystem { get; set; }
    }

    [DataContract]
    public class UserWallToFromUser
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
