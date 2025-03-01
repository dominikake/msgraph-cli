using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ChatType {
        [EnumMember(Value = "oneOnOne")]
        OneOnOne,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "meeting")]
        Meeting,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
