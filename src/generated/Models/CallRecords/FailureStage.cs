using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.CallRecords {
    public enum FailureStage {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "callSetup")]
        CallSetup,
        [EnumMember(Value = "midcall")]
        Midcall,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
