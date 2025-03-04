using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible sync statuses associated with an Apple Volume Purchase Program token.</summary>
    public enum VppTokenSyncStatus {
        /// <summary>Default status.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Last Sync in progress.</summary>
        [EnumMember(Value = "inProgress")]
        InProgress,
        /// <summary>Last Sync completed successfully.</summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>Last Sync failed.</summary>
        [EnumMember(Value = "failed")]
        Failed,
    }
}
