using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class RenameFolderRequest
    {
        [DataMember(Name = "folder")]
        public FolderRename Folder { get; set; }
    }

    [DataContract]
    public class FolderRename
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
