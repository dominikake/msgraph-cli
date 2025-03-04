using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum UserExperienceAnalyticsHealthState {
        /// <summary>Indicates that the health state is unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Indicates that the health state is insufficient data.</summary>
        [EnumMember(Value = "insufficientData")]
        InsufficientData,
        /// <summary>Indicates that the health state needs attention.</summary>
        [EnumMember(Value = "needsAttention")]
        NeedsAttention,
        /// <summary>Indicates that the health state is meeting goals.</summary>
        [EnumMember(Value = "meetingGoals")]
        MeetingGoals,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
