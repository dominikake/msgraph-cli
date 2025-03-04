using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ConnectionStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "attempted")]
        Attempted,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "blocked")]
        Blocked,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
