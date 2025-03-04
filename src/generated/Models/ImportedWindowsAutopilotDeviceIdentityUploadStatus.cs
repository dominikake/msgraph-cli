using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ImportedWindowsAutopilotDeviceIdentityUploadStatus {
        /// <summary>No upload status.</summary>
        [EnumMember(Value = "noUpload")]
        NoUpload,
        /// <summary>Pending status.</summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>Complete status.</summary>
        [EnumMember(Value = "complete")]
        Complete,
        /// <summary>Error status.</summary>
        [EnumMember(Value = "error")]
        Error,
    }
}
