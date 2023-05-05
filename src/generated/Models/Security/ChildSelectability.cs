using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum ChildSelectability {
        [EnumMember(Value = "One")]
        One,
        [EnumMember(Value = "Many")]
        Many,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
