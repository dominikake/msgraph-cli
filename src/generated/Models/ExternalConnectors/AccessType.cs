using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.ExternalConnectors {
    public enum AccessType {
        [EnumMember(Value = "grant")]
        Grant,
        [EnumMember(Value = "deny")]
        Deny,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
