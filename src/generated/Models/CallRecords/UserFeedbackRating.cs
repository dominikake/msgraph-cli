using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.CallRecords {
    public enum UserFeedbackRating {
        [EnumMember(Value = "notRated")]
        NotRated,
        [EnumMember(Value = "bad")]
        Bad,
        [EnumMember(Value = "poor")]
        Poor,
        [EnumMember(Value = "fair")]
        Fair,
        [EnumMember(Value = "good")]
        Good,
        [EnumMember(Value = "excellent")]
        Excellent,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
