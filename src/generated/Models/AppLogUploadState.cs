using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>AppLogUploadStatus</summary>
    public enum AppLogUploadState {
        /// <summary>Default. Indicates that request is waiting to be processed or under processing.</summary>
        [EnumMember(Value = "pending")]
        Pending,
        /// <summary>Indicates that request is completed with file uploaded to Azure blob for download.</summary>
        [EnumMember(Value = "completed")]
        Completed,
        /// <summary>Indicates that request is completed with file uploaded to Azure blob for download.</summary>
        [EnumMember(Value = "failed")]
        Failed,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
