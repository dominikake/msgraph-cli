using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible values for when accounts are deleted on a shared PC.</summary>
    public enum SharedPCAccountDeletionPolicyType {
        /// <summary>Delete immediately.</summary>
        [EnumMember(Value = "immediate")]
        Immediate,
        /// <summary>Delete at disk space threshold.</summary>
        [EnumMember(Value = "diskSpaceThreshold")]
        DiskSpaceThreshold,
        /// <summary>Delete at disk space threshold or inactive threshold.</summary>
        [EnumMember(Value = "diskSpaceThresholdOrInactiveThreshold")]
        DiskSpaceThresholdOrInactiveThreshold,
    }
}
