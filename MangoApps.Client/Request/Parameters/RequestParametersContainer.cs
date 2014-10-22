using System.Runtime.Serialization;

namespace MangoApps.Client.Request.Parameters
{
    [DataContract]
    public class RequestParametersContainer<T>
    {
        [DataMember(Name = "ms_request")]
        public T Request { get; set; }
    }
}
