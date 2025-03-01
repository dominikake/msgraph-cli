using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum PrintDuplexMode {
        [EnumMember(Value = "flipOnLongEdge")]
        FlipOnLongEdge,
        [EnumMember(Value = "flipOnShortEdge")]
        FlipOnShortEdge,
        [EnumMember(Value = "oneSided")]
        OneSided,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
