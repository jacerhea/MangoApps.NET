﻿using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class CreateProjectRequest
    {
        [DataMember(Name = "project")]
        public CreateGroupRequestParameters Project { get; set; }
    }
}
