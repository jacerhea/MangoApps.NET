using System.Runtime.Serialization;

namespace MangoApps.Client.Request.Parameters
{
    public enum PrivacyType
    {
        [EnumMember(Value = "P")]
        Public,

        [EnumMember(Value = "R")]
        Private,

        [EnumMember(Value = "S")]
        Secret
    }
}
