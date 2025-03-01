using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Partner App Type.</summary>
    public enum DeviceManagementPartnerAppType {
        /// <summary>Partner App type is unknown.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Partner App is Single tenant in AAD.</summary>
        [EnumMember(Value = "singleTenantApp")]
        SingleTenantApp,
        /// <summary>Partner App is Multi tenant in AAD.</summary>
        [EnumMember(Value = "multiTenantApp")]
        MultiTenantApp,
    }
}
