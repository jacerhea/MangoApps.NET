using System;

namespace MangoApps.Client.Response
{
    public class MangoException : Exception
    {
        public MangoException(string message, Exception exception) : base(message, exception)
        {
            
        }

        public ErrorResponse ErrorResponse { get; set; }
    }
}
