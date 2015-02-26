using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class ResponseContainer<T>
    {
        [DataMember(Name = "ms_response")]
        public T Response { get; set; }
    }
}
