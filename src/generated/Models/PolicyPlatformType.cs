using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Supported platform types for policies.</summary>
    public enum PolicyPlatformType {
        /// <summary>Android.</summary>
        [EnumMember(Value = "android")]
        Android,
        /// <summary>AndroidForWork.</summary>
        [EnumMember(Value = "androidForWork")]
        AndroidForWork,
        /// <summary>iOS.</summary>
        [EnumMember(Value = "iOS")]
        IOS,
        /// <summary>MacOS.</summary>
        [EnumMember(Value = "macOS")]
        MacOS,
        /// <summary>WindowsPhone 8.1.</summary>
        [EnumMember(Value = "windowsPhone81")]
        WindowsPhone81,
        /// <summary>Windows 8.1 and later</summary>
        [EnumMember(Value = "windows81AndLater")]
        Windows81AndLater,
        /// <summary>Windows 10 and later.</summary>
        [EnumMember(Value = "windows10AndLater")]
        Windows10AndLater,
        /// <summary>All platforms.</summary>
        [EnumMember(Value = "all")]
        All,
    }
}
