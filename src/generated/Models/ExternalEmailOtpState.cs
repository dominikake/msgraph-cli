using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ExternalEmailOtpState {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "enabled")]
        Enabled,
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
