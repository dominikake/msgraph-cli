using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum Fido2RestrictionEnforcementType {
        [EnumMember(Value = "allow")]
        Allow,
        [EnumMember(Value = "block")]
        Block,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
