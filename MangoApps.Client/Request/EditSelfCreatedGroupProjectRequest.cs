using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class EditSelfCreatedGroupProjectRequest
    {
        public Conversation Conversation { get; set; }
    }

    [DataContract]
    public class Conversation
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Etc { get; set; }
    }
}
