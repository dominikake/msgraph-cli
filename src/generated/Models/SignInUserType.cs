using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SignInUserType {
        [EnumMember(Value = "member")]
        Member,
        [EnumMember(Value = "guest")]
        Guest,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
