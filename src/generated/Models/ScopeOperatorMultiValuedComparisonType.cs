using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ScopeOperatorMultiValuedComparisonType {
        [EnumMember(Value = "All")]
        All,
        [EnumMember(Value = "Any")]
        Any,
    }
}
