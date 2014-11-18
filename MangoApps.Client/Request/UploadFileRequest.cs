using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class UploadFileRequest
    {
        [DataMember(Name = "task")]
        public LifeCycleTask Task { get; set; }
    }
}
