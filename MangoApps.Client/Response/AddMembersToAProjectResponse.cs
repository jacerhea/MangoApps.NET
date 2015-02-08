using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class AddMembersToAProjectResponse : TransactionResponse
    {
        [DataMember(Name = "project_id")]
        public string ProjectId { get; set; }

        [DataMember(Name = "members")]
        public List<Member> Members { get; set; }
    }
}
