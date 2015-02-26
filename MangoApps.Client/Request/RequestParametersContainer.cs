using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class RequestParametersContainer<T>
    {
        [DataMember(Name = "ms_request")]
        public T Request { get; set; }
    }
}
