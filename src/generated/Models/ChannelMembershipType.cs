using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ChannelMembershipType {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "private")]
        Private,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "shared")]
        Shared,
    }
}
