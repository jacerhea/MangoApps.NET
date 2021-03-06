﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class RemoveMembersFromAGroupResponse : TransactionResponse
    {
        [DataMember]
        public string GroupId { get; set; }

        [DataMember]
        public List<Member> Members { get; set; }
    }
}
