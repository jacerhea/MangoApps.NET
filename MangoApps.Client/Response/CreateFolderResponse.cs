using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class CreateFolderResponse
    {
        [DataMember(Name = "folder")]
        public Folder Folder { get; set; }
    }
}
