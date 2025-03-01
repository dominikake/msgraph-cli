using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ThreatCategory {
        [EnumMember(Value = "undefined")]
        Undefined,
        [EnumMember(Value = "spam")]
        Spam,
        [EnumMember(Value = "phishing")]
        Phishing,
        [EnumMember(Value = "malware")]
        Malware,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
