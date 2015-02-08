using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class CreateHuddleResponse : TransactionResponse
    {
        [DataMember(Name = "huddle")]
        public Huddle Huddle { get; set; }
    }

    [DataContract]
    public class Huddle
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "members")]
        public HuddleMembers Members { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "privacy")]
        public string Privacy { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }
    }

    [DataContract]
    public class HuddleMembers
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "huddle_status")]
        public string HuddleStatus { get; set; }

        [DataMember(Name = "huddle_joined_on")]
        public string HuddleJoinedOn { get; set; }
    }
}
