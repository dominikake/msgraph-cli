using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum BinaryOperator {
        [EnumMember(Value = "or")]
        Or,
        [EnumMember(Value = "and")]
        And,
    }
}
