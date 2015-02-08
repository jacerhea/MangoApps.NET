using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class EditTaskResponse : TransactionResponse
    {
        [DataMember(Name = "conversation")]
        public SingleTask Task { get; set; }
    }
}
