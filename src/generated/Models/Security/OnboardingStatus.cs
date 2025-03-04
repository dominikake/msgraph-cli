using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum OnboardingStatus {
        [EnumMember(Value = "insufficientInfo")]
        InsufficientInfo,
        [EnumMember(Value = "onboarded")]
        Onboarded,
        [EnumMember(Value = "canBeOnboarded")]
        CanBeOnboarded,
        [EnumMember(Value = "unsupported")]
        Unsupported,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
