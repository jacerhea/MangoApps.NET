using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class CreateFolderResponse
    {
        [DataMember(Name = "folder")]
        public Folder Folder { get; set; }
    }
}
