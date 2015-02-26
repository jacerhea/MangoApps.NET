using System;
using System.Runtime.Serialization;

namespace MangoApps.Client
{
    /// <summary>
    /// The request was unable to be fulfilled by the mango server and this exception contains the response.
    /// </summary>
    [Serializable]
    public class MangoException : Exception
    {
        public MangoException(string message, Exception exception) : base(message, exception)
        {
            
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }

        /// <summary>
        /// Gets or sets the error response.
        /// </summary>
        /// <value>
        /// The error from the Mango server.
        /// </value>
        public ErrorResponse ErrorResponse { get; set; }
    }
}
