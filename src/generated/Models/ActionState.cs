using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>State of the action on the device</summary>
    public enum ActionState {
        /// <summary>Not a valid action state</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Action is pending</summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>Action has been cancelled.</summary>
        [EnumMember(Value = "canceled")]
        Canceled,
        /// <summary>Action is active.</summary>
        [EnumMember(Value = "active")]
        Active,
        /// <summary>Action completed without errors.</summary>
        [EnumMember(Value = "done")]
        Done,
        /// <summary>Action failed</summary>
        [EnumMember(Value = "failed")]
        Failed,
        /// <summary>Action is not supported.</summary>
        [EnumMember(Value = "notSupported")]
        NotSupported,
    }
}
