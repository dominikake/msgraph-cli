using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum EvidenceRemediationStatus {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "remediated")]
        Remediated,
        [EnumMember(Value = "prevented")]
        Prevented,
        [EnumMember(Value = "blocked")]
        Blocked,
        [EnumMember(Value = "notFound")]
        NotFound,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
