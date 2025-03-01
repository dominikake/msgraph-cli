using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum EvidenceRole {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "contextual")]
        Contextual,
        [EnumMember(Value = "scanned")]
        Scanned,
        [EnumMember(Value = "source")]
        Source,
        [EnumMember(Value = "destination")]
        Destination,
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "added")]
        Added,
        [EnumMember(Value = "compromised")]
        Compromised,
        [EnumMember(Value = "edited")]
        Edited,
        [EnumMember(Value = "attacked")]
        Attacked,
        [EnumMember(Value = "attacker")]
        Attacker,
        [EnumMember(Value = "commandAndControl")]
        CommandAndControl,
        [EnumMember(Value = "loaded")]
        Loaded,
        [EnumMember(Value = "suspicious")]
        Suspicious,
        [EnumMember(Value = "policyViolator")]
        PolicyViolator,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
