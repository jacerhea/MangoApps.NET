using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class PostTaskResponse : TransactionResponse
    {
        public SingleTask Task { get; set; }
    }
}
