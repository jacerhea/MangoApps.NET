using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public class TaskLifecycleRequest
    {
        [DataMember(Name = "task")]
        public LifeCycleTask Task { get; set; }
    }

    [DataContract]
    public class LifeCycleTask
    {
        [DataMember(Name = "comment")]
        public string Comment { get; set; }

        [DataMember(Name = "action")]
        public ActionTypes Action { get; set; }
    }

    [DataContract]
    public enum ActionTypes
    {
        [EnumMember(Value = "assign")]
        Assign,
        [EnumMember(Value = "start")]
        Start,
        [EnumMember(Value = "finish")]
        Finish,
        [EnumMember(Value = "deliver")]
        Deliver,
        [EnumMember(Value = "accept")]
        Accept,
        [EnumMember(Value = "reject")]
        Reject,
        [EnumMember(Value = "reopen")]
        Reopen,
        [EnumMember(Value = "restart")]
        Restart,
        [EnumMember(Value = "revert")]
        Revert
    }
}
