using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MangoApps.Client
{
    [DataContract]
    public class Audit
    {
        [DataMember(Name = "created_at")]
        [JsonConverter(typeof(SecondEpochConverter))]
        public DateTime CreatedAt { get; set; }

        [DataMember(Name = "updated_at")]
        [JsonConverter(typeof(SecondEpochConverter))]
        public DateTime UpdatedAt { get; set; }
    }
}
