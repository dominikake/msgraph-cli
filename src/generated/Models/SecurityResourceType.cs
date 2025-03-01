using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SecurityResourceType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "attacked")]
        Attacked,
        [EnumMember(Value = "related")]
        Related,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
