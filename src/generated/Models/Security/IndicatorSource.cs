using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum IndicatorSource {
        [EnumMember(Value = "microsoft")]
        Microsoft,
        [EnumMember(Value = "osint")]
        Osint,
        [EnumMember(Value = "public")]
        Public,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
