using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Generic visibility state.</summary>
    public enum VisibilitySetting {
        /// <summary>Not configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Hide.</summary>
        [EnumMember(Value = "hide")]
        Hide,
        /// <summary>Show.</summary>
        [EnumMember(Value = "show")]
        Show,
    }
}
