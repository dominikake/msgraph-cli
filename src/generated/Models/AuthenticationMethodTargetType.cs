using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AuthenticationMethodTargetType {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
