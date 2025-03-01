using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum MicrosoftAuthenticatorAuthenticationMode {
        [EnumMember(Value = "deviceBasedPush")]
        DeviceBasedPush,
        [EnumMember(Value = "push")]
        Push,
        [EnumMember(Value = "any")]
        Any,
    }
}
