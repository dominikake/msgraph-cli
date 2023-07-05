using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum PrintQuality {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "medium")]
        Medium,
        [EnumMember(Value = "high")]
        High,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
