using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ConditionalAccessGrantControl {
        [EnumMember(Value = "block")]
        Block,
        [EnumMember(Value = "mfa")]
        Mfa,
        [EnumMember(Value = "compliantDevice")]
        CompliantDevice,
        [EnumMember(Value = "domainJoinedDevice")]
        DomainJoinedDevice,
        [EnumMember(Value = "approvedApplication")]
        ApprovedApplication,
        [EnumMember(Value = "compliantApplication")]
        CompliantApplication,
        [EnumMember(Value = "passwordChange")]
        PasswordChange,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
