using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum UserAccountSecurityType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "power")]
        Power,
        [EnumMember(Value = "administrator")]
        Administrator,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
