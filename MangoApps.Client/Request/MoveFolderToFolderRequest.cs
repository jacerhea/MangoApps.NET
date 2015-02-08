using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class MoveFolderToFolderRequest
    {
        [DataMember(Name = "files")]
        public Folders Folders { get; set; }
    }

    [DataContract]
    public class Folders
    {
        [DataMember(Name = "source")]
        public string Source { get; set; }

        [DataMember(Name = "destination")]
        public string Destination { get; set; }
    }
}
