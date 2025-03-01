using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum MeetingMessageType {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "meetingRequest")]
        MeetingRequest,
        [EnumMember(Value = "meetingCancelled")]
        MeetingCancelled,
        [EnumMember(Value = "meetingAccepted")]
        MeetingAccepted,
        [EnumMember(Value = "meetingTenativelyAccepted")]
        MeetingTenativelyAccepted,
        [EnumMember(Value = "meetingDeclined")]
        MeetingDeclined,
    }
}
