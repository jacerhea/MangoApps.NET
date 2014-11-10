﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class ErrorResponse : TransactionResponse
    {
        [DataMember(Name = "error")]
        public List<string> Errors { get; set; }
    }
}
