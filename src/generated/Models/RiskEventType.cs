using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum RiskEventType {
        [EnumMember(Value = "unlikelyTravel")]
        UnlikelyTravel,
        [EnumMember(Value = "anonymizedIPAddress")]
        AnonymizedIPAddress,
        [EnumMember(Value = "maliciousIPAddress")]
        MaliciousIPAddress,
        [EnumMember(Value = "unfamiliarFeatures")]
        UnfamiliarFeatures,
        [EnumMember(Value = "malwareInfectedIPAddress")]
        MalwareInfectedIPAddress,
        [EnumMember(Value = "suspiciousIPAddress")]
        SuspiciousIPAddress,
        [EnumMember(Value = "leakedCredentials")]
        LeakedCredentials,
        [EnumMember(Value = "investigationsThreatIntelligence")]
        InvestigationsThreatIntelligence,
        [EnumMember(Value = "generic")]
        Generic,
        [EnumMember(Value = "adminConfirmedUserCompromised")]
        AdminConfirmedUserCompromised,
        [EnumMember(Value = "mcasImpossibleTravel")]
        McasImpossibleTravel,
        [EnumMember(Value = "mcasSuspiciousInboxManipulationRules")]
        McasSuspiciousInboxManipulationRules,
        [EnumMember(Value = "investigationsThreatIntelligenceSigninLinked")]
        InvestigationsThreatIntelligenceSigninLinked,
        [EnumMember(Value = "maliciousIPAddressValidCredentialsBlockedIP")]
        MaliciousIPAddressValidCredentialsBlockedIP,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
