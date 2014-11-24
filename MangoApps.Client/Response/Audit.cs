using System;
using System.Runtime.Serialization;
using MangoApps.Client.Converter;
using Newtonsoft.Json;

namespace MangoApps.Client.Response
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
