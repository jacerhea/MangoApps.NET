using System.Runtime.Serialization;

namespace MangoApps.Client.Request
{
    [DataContract]
    public enum UserStates
    {
        [DataMember(Name = "A")]
        Activated,
        
        [DataMember(Name = "S")]
        Deactivated
    }
}
