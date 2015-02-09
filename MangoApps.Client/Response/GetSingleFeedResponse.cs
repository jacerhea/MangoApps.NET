using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class GetSingleFeedResponse : TransactionResponse
    {
        [DataMember(Name = "tasks")]
        public List<SingleFeed> Tasks { get; set; }
    }

    [DataContract]
    public class SingleFeed
    {
        [DataMember(Name = "attachments")]
        public List<string> Id { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> FeedType { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> Body { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> MLink { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> Category { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> IsSystem { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> IsLink { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> Shareable { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> SubCategory { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> SessionId { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> FromUser { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> GroupId { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> Platform { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> LikeCount { get; set; }


        [DataMember(Name = "attachments")]
        public List<string> CommentCount { get; set; }


        [DataMember(Name = "attachments")]
        public List<string> AttachmentCount { get; set; }


        [DataMember(Name = "attachments")]
        public List<string> Attachments { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> Liked { get; set; }

        [DataMember(Name = "attachments")]
        public List<string> LikedList { get; set; }


        [DataMember(Name = "attachments")]
        public List<string> Platform { get; set; }

    }
}
