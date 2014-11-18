using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class CreateFolderRequest
    {
        [DataMember(Name = "folder")]
        public Folder Folder { get; set; }
    }

    [DataContract]
    public class Folder
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "parent")]
        public string Parent { get; set; }
    }
}
