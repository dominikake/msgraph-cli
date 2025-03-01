using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum PurgeType {
        [EnumMember(Value = "recoverable")]
        Recoverable,
        [EnumMember(Value = "permanentlyDeleted")]
        PermanentlyDeleted,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
