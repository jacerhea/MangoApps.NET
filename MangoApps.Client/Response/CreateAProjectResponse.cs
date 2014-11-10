using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class CreateAProjectResponse : TransactionResponse
    {
        public CreateProject Project { get; set; }
    }

    [DataContract]
    public class CreateProject
    {
        public string Photo { get; set; }
        public string Name { get; set; }
        public string CreatedAt { get; set; }
        public string UploadAccess { get; set; }
        public Admin Admin { get; set; }
        public List<string> Tags { get; set; }
        public string Id { get; set; }
        public string Privacy { get; set; }
        public string State { get; set; }
    }

    [DataContract]
    public class Admin
    {
        public string Photo { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
    }
}
