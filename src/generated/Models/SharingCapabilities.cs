using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SharingCapabilities {
        [EnumMember(Value = "disabled")]
        Disabled,
        [EnumMember(Value = "externalUserSharingOnly")]
        ExternalUserSharingOnly,
        [EnumMember(Value = "externalUserAndGuestSharing")]
        ExternalUserAndGuestSharing,
        [EnumMember(Value = "existingExternalUserSharingOnly")]
        ExistingExternalUserSharingOnly,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
