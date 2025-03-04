using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ConditionalAccessDevicePlatform {
        [EnumMember(Value = "android")]
        Android,
        [EnumMember(Value = "iOS")]
        IOS,
        [EnumMember(Value = "windows")]
        Windows,
        [EnumMember(Value = "windowsPhone")]
        WindowsPhone,
        [EnumMember(Value = "macOS")]
        MacOS,
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "linux")]
        Linux,
    }
}
