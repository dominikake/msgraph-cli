using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum TeamworkTagType {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
