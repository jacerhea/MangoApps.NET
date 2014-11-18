using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class MoveFilesToFolderRequest
    {
        [DataMember(Name = "files")]
        public Files Files { get; set; }
    }

    [DataContract]
    public class Files
    {
        [DataMember(Name = "source")]
        public string Source { get; set; }

        [DataMember(Name = "Destination")]
        public string Destination { get; set; }
    }
}
