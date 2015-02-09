using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client.Response
{
    [DataContract]
    public class GetAllMyTasks : TransactionResponse
    {
        [DataMember(Name = "tasks")]
        public List<SingleTask> Tasks { get; set; }
    }
}
