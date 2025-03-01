using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum InitiatorType {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "application")]
        Application,
        [EnumMember(Value = "system")]
        System,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
