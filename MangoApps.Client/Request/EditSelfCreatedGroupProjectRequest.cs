using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class EditSelfCreatedGroupProjectRequest
    {
        [DataMember(Name = "conversation")]
        public Conversation Conversation { get; set; }
    }

    [DataContract]
    public class Conversation
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}
