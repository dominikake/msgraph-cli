using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SimulationAutomationRunStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "skipped")]
        Skipped,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
