using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class GroupResponse
    {
        [DataMember]
        public Group Group { get; set; }
    }

    [DataContract]
    public class Group
    {
        [DataMember]
        public string Photo { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string CreatedAt { get; set; }

        [DataMember]
        public string UploadAccess { get; set; }

        [DataMember]
        public string Admin { get; set; }

        [DataMember]
        public List<string> Tags { get; set; }

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Privacy { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string State { get; set; }
    }

    public class GroupAdmin
    {
        [DataMember]
        public string Photo { get; set; }
        
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}
