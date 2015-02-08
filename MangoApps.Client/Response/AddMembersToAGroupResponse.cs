using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class AddMembersToAGroupResponse : TransactionResponse
    {
        [DataMember(Name = "group_id")]
        public string ProjectId { get; set; }

        [DataMember(Name = "members")]
        public List<Member> Members { get; set; }
    }
}
