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
        [DataMember(Name = "huddle")]
        public string Name { get; set; }

        [DataMember(Name = "huddle")]
        public string Status { get; set; }

        [DataMember(Name = "huddle")]
        public HuddleMembers Members { get; set; }

        [DataMember(Name = "huddle")]
        public string Id { get; set; }

        [DataMember(Name = "huddle")]
        public string Privacy { get; set; }

        [DataMember(Name = "huddle")]
        public string Description { get; set; }

        [DataMember(Name = "huddle")]
        public string State { get; set; }
    }

    [DataContract]
    public class HuddleMembers
    {
        [DataMember(Name = "huddle")]
        public string Name { get; set; }

        [DataMember(Name = "huddle")]
        public string Id { get; set; }

        [DataMember(Name = "huddle")]
        public string Email { get; set; }

        [DataMember(Name = "huddle")]
        public string HuddleStatus { get; set; }

        [DataMember(Name = "huddle")]
        public string HuddleJoinedOn { get; set; }
    }
}
