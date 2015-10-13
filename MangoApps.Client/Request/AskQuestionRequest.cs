using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    /// <summary>
    /// A request to ask a question amongst your followers or within project or group.
    /// </summary>
    [DataContract]
    public class AskQuestionRequest
    {
        public AskQuestionFeed Feed { get; set; }
    }

    public class AskQuestionFeed
    {
        public List<string> Attachments { get; set; }
        public string Message { get; set; }
        public string ConversationId { get; set; }
    }
}
