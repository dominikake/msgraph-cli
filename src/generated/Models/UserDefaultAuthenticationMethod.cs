using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum UserDefaultAuthenticationMethod {
        [EnumMember(Value = "push")]
        Push,
        [EnumMember(Value = "oath")]
        Oath,
        [EnumMember(Value = "voiceMobile")]
        VoiceMobile,
        [EnumMember(Value = "voiceAlternateMobile")]
        VoiceAlternateMobile,
        [EnumMember(Value = "voiceOffice")]
        VoiceOffice,
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
