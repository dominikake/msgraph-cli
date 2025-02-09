using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum PrinterFeedOrientation {
        [EnumMember(Value = "longEdgeFirst")]
        LongEdgeFirst,
        [EnumMember(Value = "shortEdgeFirst")]
        ShortEdgeFirst,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
