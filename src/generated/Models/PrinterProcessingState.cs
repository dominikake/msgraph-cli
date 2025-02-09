using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum PrinterProcessingState {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "idle")]
        Idle,
        [EnumMember(Value = "processing")]
        Processing,
        [EnumMember(Value = "stopped")]
        Stopped,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
