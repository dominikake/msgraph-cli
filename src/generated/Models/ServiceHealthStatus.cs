using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ServiceHealthStatus {
        [EnumMember(Value = "serviceOperational")]
        ServiceOperational,
        [EnumMember(Value = "investigating")]
        Investigating,
        [EnumMember(Value = "restoringService")]
        RestoringService,
        [EnumMember(Value = "verifyingService")]
        VerifyingService,
        [EnumMember(Value = "serviceRestored")]
        ServiceRestored,
        [EnumMember(Value = "postIncidentReviewPublished")]
        PostIncidentReviewPublished,
        [EnumMember(Value = "serviceDegradation")]
        ServiceDegradation,
        [EnumMember(Value = "serviceInterruption")]
        ServiceInterruption,
        [EnumMember(Value = "extendedRecovery")]
        ExtendedRecovery,
        [EnumMember(Value = "falsePositive")]
        FalsePositive,
        [EnumMember(Value = "investigationSuspended")]
        InvestigationSuspended,
        [EnumMember(Value = "resolved")]
        Resolved,
        [EnumMember(Value = "mitigatedExternal")]
        MitigatedExternal,
        [EnumMember(Value = "mitigated")]
        Mitigated,
        [EnumMember(Value = "resolvedExternal")]
        ResolvedExternal,
        [EnumMember(Value = "confirmed")]
        Confirmed,
        [EnumMember(Value = "reported")]
        Reported,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
