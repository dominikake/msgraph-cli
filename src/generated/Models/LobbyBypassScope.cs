using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum LobbyBypassScope {
        [EnumMember(Value = "organizer")]
        Organizer,
        [EnumMember(Value = "organization")]
        Organization,
        [EnumMember(Value = "organizationAndFederated")]
        OrganizationAndFederated,
        [EnumMember(Value = "everyone")]
        Everyone,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "invited")]
        Invited,
        [EnumMember(Value = "organizationExcludingGuests")]
        OrganizationExcludingGuests,
    }
}
