using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client
{
    /// <summary>
    ///  The error response.  Represents the "ms_errors" json object.
    /// </summary>
    [DataContract]
    public class ErrorResponse : TransactionResponse
    {
        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        /// <value>
        /// The errors.
        /// </value>
        [DataMember(Name = "error")]
        public List<string> Errors { get; set; }
    }
}
