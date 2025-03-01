using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ImageTaggingChoice {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "basic")]
        Basic,
        [EnumMember(Value = "enhanced")]
        Enhanced,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
