using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class EditTaskRequest
    {
        [DataMember(Name = "task")]
        public PostTask Task { get; set; }
    }
}
