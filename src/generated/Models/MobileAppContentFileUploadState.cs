using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Contains properties for upload request states.</summary>
    public enum MobileAppContentFileUploadState {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "transientError")]
        TransientError,
        [EnumMember(Value = "error")]
        Error,
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "azureStorageUriRequestSuccess")]
        AzureStorageUriRequestSuccess,
        [EnumMember(Value = "azureStorageUriRequestPending")]
        AzureStorageUriRequestPending,
        [EnumMember(Value = "azureStorageUriRequestFailed")]
        AzureStorageUriRequestFailed,
        [EnumMember(Value = "azureStorageUriRequestTimedOut")]
        AzureStorageUriRequestTimedOut,
        [EnumMember(Value = "azureStorageUriRenewalSuccess")]
        AzureStorageUriRenewalSuccess,
        [EnumMember(Value = "azureStorageUriRenewalPending")]
        AzureStorageUriRenewalPending,
        [EnumMember(Value = "azureStorageUriRenewalFailed")]
        AzureStorageUriRenewalFailed,
        [EnumMember(Value = "azureStorageUriRenewalTimedOut")]
        AzureStorageUriRenewalTimedOut,
        [EnumMember(Value = "commitFileSuccess")]
        CommitFileSuccess,
        [EnumMember(Value = "commitFilePending")]
        CommitFilePending,
        [EnumMember(Value = "commitFileFailed")]
        CommitFileFailed,
        [EnumMember(Value = "commitFileTimedOut")]
        CommitFileTimedOut,
    }
}
