using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>The reason for which a user has been flagged</summary>
    public enum ManagedAppFlaggedReason {
        /// <summary>No issue.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>The app registration is running on a rooted/unlocked device.</summary>
        [EnumMember(Value = "rootedDevice")]
        RootedDevice,
    }
}
