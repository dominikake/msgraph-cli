using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Notification Settings Alert Type.</summary>
    public enum IosNotificationAlertType {
        /// <summary>Device default value, no intent.</summary>
        [EnumMember(Value = "deviceDefault")]
        DeviceDefault,
        /// <summary>Banner.</summary>
        [EnumMember(Value = "banner")]
        Banner,
        /// <summary>Modal.</summary>
        [EnumMember(Value = "modal")]
        Modal,
        /// <summary>None.</summary>
        [EnumMember(Value = "none")]
        None,
    }
}
