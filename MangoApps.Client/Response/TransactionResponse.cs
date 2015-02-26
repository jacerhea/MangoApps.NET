using System.Runtime.Serialization;

namespace MangoApps.Client
{
    /// <summary>
    /// The base class for all responses. Represents the ms_response json object.
    /// </summary>
    public abstract class TransactionResponse
    {
        /// <summary>
        /// Gets or sets the transaction identifier.
        /// </summary>
        /// <value>
        /// The transaction identifier.
        /// </value>
        [DataMember(Name = "transaction_id")]
        public int? TransactionId { get; set; }
    }
}
