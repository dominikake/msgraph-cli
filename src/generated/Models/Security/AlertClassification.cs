using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum AlertClassification {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "falsePositive")]
        FalsePositive,
        [EnumMember(Value = "truePositive")]
        TruePositive,
        [EnumMember(Value = "informationalExpectedActivity")]
        InformationalExpectedActivity,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
