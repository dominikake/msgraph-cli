using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Partner state of this tenant.</summary>
    public enum MobileThreatPartnerTenantState {
        /// <summary>Partner is unavailable.</summary>
        [EnumMember(Value = "unavailable")]
        Unavailable,
        /// <summary>Partner is available.</summary>
        [EnumMember(Value = "available")]
        Available,
        /// <summary>Partner is enabled.</summary>
        [EnumMember(Value = "enabled")]
        Enabled,
        /// <summary>Partner is unresponsive.</summary>
        [EnumMember(Value = "unresponsive")]
        Unresponsive,
    }
}
