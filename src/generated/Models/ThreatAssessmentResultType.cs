using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ThreatAssessmentResultType {
        [EnumMember(Value = "checkPolicy")]
        CheckPolicy,
        [EnumMember(Value = "rescan")]
        Rescan,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
