using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum PrintJobProcessingState {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "processing")]
        Processing,
        [EnumMember(Value = "paused")]
        Paused,
        [EnumMember(Value = "stopped")]
        Stopped,
        [EnumMember(Value = "completed")]
        Completed,
        [EnumMember(Value = "canceled")]
        Canceled,
        [EnumMember(Value = "aborted")]
        Aborted,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
