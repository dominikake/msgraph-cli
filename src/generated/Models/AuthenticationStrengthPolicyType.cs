using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AuthenticationStrengthPolicyType {
        [EnumMember(Value = "builtIn")]
        BuiltIn,
        [EnumMember(Value = "custom")]
        Custom,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
