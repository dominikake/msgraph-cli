using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.TermStore {
    public enum RelationType {
        [EnumMember(Value = "pin")]
        Pin,
        [EnumMember(Value = "reuse")]
        Reuse,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
