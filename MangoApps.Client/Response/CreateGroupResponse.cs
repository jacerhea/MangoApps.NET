﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MangoApps.Client
{
    [DataContract]
    public class CreateGroupResponse : TransactionResponse
    {
        [DataMember(Name = "group")]
        public GroupOrProject Group { get; set; }
    }

    [DataContract]
    public class GroupOrProject
    {
        [DataMember(Name = "photo")]
        public string Photo { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "created_at")]
        [JsonConverter(typeof(SecondEpochConverter))]
        public string CreatedAt { get; set; }

        [DataMember(Name = "upload_access")]
        public string UploadAccess { get; set; }

        [DataMember(Name = "admin")]
        public GroupAdmin Admin { get; set; }

        [DataMember(Name = "tags")]
        public List<string> Tags { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "privacy")]
        public string Privacy { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "state")]
        public string State { get; set; }
    }

    public class GroupAdmin
    {
        [DataMember(Name = "photo")]
        public string Photo { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }
    }
}
