using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum MeetingRequestType {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "newMeetingRequest")]
        NewMeetingRequest,
        [EnumMember(Value = "fullUpdate")]
        FullUpdate,
        [EnumMember(Value = "informationalUpdate")]
        InformationalUpdate,
        [EnumMember(Value = "silentUpdate")]
        SilentUpdate,
        [EnumMember(Value = "outdated")]
        Outdated,
        [EnumMember(Value = "principalWantsCopy")]
        PrincipalWantsCopy,
    }
}
