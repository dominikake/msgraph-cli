using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ContactRelationship {
        [EnumMember(Value = "parent")]
        Parent,
        [EnumMember(Value = "relative")]
        Relative,
        [EnumMember(Value = "aide")]
        Aide,
        [EnumMember(Value = "doctor")]
        Doctor,
        [EnumMember(Value = "guardian")]
        Guardian,
        [EnumMember(Value = "child")]
        Child,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
