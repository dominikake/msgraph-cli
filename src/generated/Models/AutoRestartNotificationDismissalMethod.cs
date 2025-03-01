using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Auto restart required notification dismissal method</summary>
    public enum AutoRestartNotificationDismissalMethod {
        /// <summary>Not configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Auto dismissal Indicates that the notification is automatically dismissed without user intervention</summary>
        [EnumMember(Value = "automatic")]
        Automatic,
        /// <summary>User dismissal. Allows the user to dismiss the notification</summary>
        [EnumMember(Value = "user")]
        User,
        /// <summary>Evolvable enum member</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
