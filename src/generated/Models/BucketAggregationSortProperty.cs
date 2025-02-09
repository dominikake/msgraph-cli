using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum BucketAggregationSortProperty {
        [EnumMember(Value = "count")]
        Count,
        [EnumMember(Value = "keyAsString")]
        KeyAsString,
        [EnumMember(Value = "keyAsNumber")]
        KeyAsNumber,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
