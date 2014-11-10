using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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
