using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.ExternalConnectors {
    public enum RuleOperation {
        [EnumMember(Value = "equals")]
        Equals,
        [EnumMember(Value = "notEquals")]
        NotEquals,
        [EnumMember(Value = "contains")]
        Contains,
        [EnumMember(Value = "notContains")]
        NotContains,
        [EnumMember(Value = "lessThan")]
        LessThan,
        [EnumMember(Value = "greaterThan")]
        GreaterThan,
        [EnumMember(Value = "startsWith")]
        StartsWith,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
