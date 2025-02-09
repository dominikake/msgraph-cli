using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum TeamworkCallEventType {
        [EnumMember(Value = "call")]
        Call,
        [EnumMember(Value = "meeting")]
        Meeting,
        [EnumMember(Value = "screenShare")]
        ScreenShare,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
