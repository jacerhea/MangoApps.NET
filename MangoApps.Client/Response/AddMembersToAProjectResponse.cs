﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class AddMembersToAProjectResponse : TransactionResponse
    {
        [DataMember]
        public string ProjectId { get; set; }

        [DataMember]
        public List<Member> Members { get; set; }
    }
}
