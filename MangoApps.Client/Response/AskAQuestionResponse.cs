using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class AskAQuestionResponse : TransactionResponse
    {
        [DataMember(Name = "limit")]
        public int Limit { get; set; }
    }
}
