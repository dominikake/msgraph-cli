using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum OutlierContainerType {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
