using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ImportedWindowsAutopilotDeviceIdentityImportStatus {
        /// <summary>Unknown status.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Pending status.</summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>Partial status.</summary>
        [EnumMember(Value = "partial")]
        Partial,
        /// <summary>Complete status.</summary>
        [EnumMember(Value = "complete")]
        Complete,
        /// <summary>Error status.</summary>
        [EnumMember(Value = "error")]
        Error,
    }
}
