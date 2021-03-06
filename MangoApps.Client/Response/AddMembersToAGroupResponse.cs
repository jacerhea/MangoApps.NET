﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class AddMembersToAGroupResponse : TransactionResponse
    {
        [DataMember(Name = "group_id")]
        public string GroupId { get; set; }

        [DataMember(Name = "members")]
        public List<Member> Members { get; set; }
    }
}
