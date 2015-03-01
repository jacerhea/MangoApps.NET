using System.Runtime.Serialization;

namespace MangoApps.Client
{
    /// <summary>
    /// The privacy type indicator.
    /// </summary>
    public enum PrivacyType
    {
        /// <summary>
        /// Public
        /// </summary>
        [EnumMember(Value = "P")]
        Public,

        /// <summary>
        /// Private
        /// </summary>
        [EnumMember(Value = "R")]
        Private,

        /// <summary>
        /// Secret
        /// </summary>
        [EnumMember(Value = "S")]
        Secret
    }
}
