using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum Sensitivity {
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "personal")]
        Personal,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "confidential")]
        Confidential,
    }
}
