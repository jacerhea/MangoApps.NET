using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class MarkMultipleFeedAsReadResponse : TransactionResponse
    {
        [DataMember(Name = "marked_read_count")]
        public int MarkedReadCount { get; set; }

        [DataMember(Name = "unread_counts")]
        public int UnreadCounts { get; set; }

        [DataMember(Name = "direct_messages_count")]
        public int DirectMessagesCount { get; set; }

        [DataMember(Name = "whats_new_count")]
        public int WhatsNewCount { get; set; }

        [DataMember(Name = "mention_count")]
        public int MentionCount { get; set; }
    }
}
