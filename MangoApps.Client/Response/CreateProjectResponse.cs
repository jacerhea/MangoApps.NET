using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class CreateProjectResponse : TransactionResponse
    {
        [DataMember(Name = "project")]
        public GroupOrProject Project { get; set; }
    }
}
