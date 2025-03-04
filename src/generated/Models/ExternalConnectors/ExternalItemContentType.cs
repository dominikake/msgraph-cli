using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.ExternalConnectors {
    public enum ExternalItemContentType {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
