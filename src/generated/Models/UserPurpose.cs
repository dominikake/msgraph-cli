using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum UserPurpose {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "linked")]
        Linked,
        [EnumMember(Value = "shared")]
        Shared,
        [EnumMember(Value = "room")]
        Room,
        [EnumMember(Value = "equipment")]
        Equipment,
        [EnumMember(Value = "others")]
        Others,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
