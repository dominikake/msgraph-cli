using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum EntityType {
        [EnumMember(Value = "event")]
        Event,
        [EnumMember(Value = "message")]
        Message,
        [EnumMember(Value = "driveItem")]
        DriveItem,
        [EnumMember(Value = "externalItem")]
        ExternalItem,
        [EnumMember(Value = "site")]
        Site,
        [EnumMember(Value = "list")]
        List,
        [EnumMember(Value = "listItem")]
        ListItem,
        [EnumMember(Value = "drive")]
        Drive,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "acronym")]
        Acronym,
        [EnumMember(Value = "bookmark")]
        Bookmark,
        [EnumMember(Value = "chatMessage")]
        ChatMessage,
        [EnumMember(Value = "person")]
        Person,
    }
}
