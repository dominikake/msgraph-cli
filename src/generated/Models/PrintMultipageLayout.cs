using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum PrintMultipageLayout {
        [EnumMember(Value = "clockwiseFromTopLeft")]
        ClockwiseFromTopLeft,
        [EnumMember(Value = "counterclockwiseFromTopLeft")]
        CounterclockwiseFromTopLeft,
        [EnumMember(Value = "counterclockwiseFromTopRight")]
        CounterclockwiseFromTopRight,
        [EnumMember(Value = "clockwiseFromTopRight")]
        ClockwiseFromTopRight,
        [EnumMember(Value = "counterclockwiseFromBottomLeft")]
        CounterclockwiseFromBottomLeft,
        [EnumMember(Value = "clockwiseFromBottomLeft")]
        ClockwiseFromBottomLeft,
        [EnumMember(Value = "counterclockwiseFromBottomRight")]
        CounterclockwiseFromBottomRight,
        [EnumMember(Value = "clockwiseFromBottomRight")]
        ClockwiseFromBottomRight,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
