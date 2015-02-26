using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MangoApps.Client
{
    [DataContract]
    public class GetAllMyTasks : TransactionResponse
    {
        [DataMember(Name = "tasks")]
        public List<SingleTask> Tasks { get; set; }
    }
}
