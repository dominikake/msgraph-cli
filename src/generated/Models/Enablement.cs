using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible values of a property</summary>
    public enum Enablement {
        /// <summary>Device default value, no intent.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Enables the setting on the device.</summary>
        [EnumMember(Value = "enabled")]
        Enabled,
        /// <summary>Disables the setting on the device.</summary>
        [EnumMember(Value = "disabled")]
        Disabled,
    }
}
