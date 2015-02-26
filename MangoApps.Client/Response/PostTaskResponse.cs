using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class PostTaskResponse : TransactionResponse
    {
        public SingleTask Task { get; set; }
    }
}
