﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class PostCommentRequest
    {
        [DataMember(Name = "comment")]
        public PostACommentComment Comment { get; set; }
    }

    [DataContract]
    public class PostACommentComment
    {
        [DataMember(Name = "attachments")]
        public List<string> Attachments { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }
    }
}
