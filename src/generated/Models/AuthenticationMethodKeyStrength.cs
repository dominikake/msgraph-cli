using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AuthenticationMethodKeyStrength {
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "weak")]
        Weak,
        [EnumMember(Value = "unknown")]
        Unknown,
    }
}
