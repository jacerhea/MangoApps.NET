using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    public abstract class TransactionResponse
    {
        [DataMember(Name = "transaction_id")]
        public int? TransactionId { get; set; }
    }
}
