using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ScopeOperatorType {
        [EnumMember(Value = "Binary")]
        Binary,
        [EnumMember(Value = "Unary")]
        Unary,
    }
}
