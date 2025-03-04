using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SynchronizationMetadata {
        [EnumMember(Value = "GalleryApplicationIdentifier")]
        GalleryApplicationIdentifier,
        [EnumMember(Value = "GalleryApplicationKey")]
        GalleryApplicationKey,
        [EnumMember(Value = "IsOAuthEnabled")]
        IsOAuthEnabled,
        [EnumMember(Value = "IsSynchronizationAgentAssignmentRequired")]
        IsSynchronizationAgentAssignmentRequired,
        [EnumMember(Value = "IsSynchronizationAgentRequired")]
        IsSynchronizationAgentRequired,
        [EnumMember(Value = "IsSynchronizationInPreview")]
        IsSynchronizationInPreview,
        [EnumMember(Value = "OAuthSettings")]
        OAuthSettings,
        [EnumMember(Value = "SynchronizationLearnMoreIbizaFwLink")]
        SynchronizationLearnMoreIbizaFwLink,
        [EnumMember(Value = "ConfigurationFields")]
        ConfigurationFields,
    }
}
