using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible states associated with an Apple Volume Purchase Program token.</summary>
    public enum VppTokenState {
        /// <summary>Default state.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Token is valid.</summary>
        [EnumMember(Value = "valid")]
        Valid,
        /// <summary>Token is expired.</summary>
        [EnumMember(Value = "expired")]
        Expired,
        /// <summary>Token is invalid.</summary>
        [EnumMember(Value = "invalid")]
        Invalid,
        /// <summary>Token is managed by another MDM Service.</summary>
        [EnumMember(Value = "assignedToExternalMDM")]
        AssignedToExternalMDM,
    }
}
