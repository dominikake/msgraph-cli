using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum IntelligenceProfileKind {
        [EnumMember(Value = "actor")]
        Actor,
        [EnumMember(Value = "tool")]
        Tool,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
