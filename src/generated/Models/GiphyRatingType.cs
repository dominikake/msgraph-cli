using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum GiphyRatingType {
        [EnumMember(Value = "strict")]
        Strict,
        [EnumMember(Value = "moderate")]
        Moderate,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
