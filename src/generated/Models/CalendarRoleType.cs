using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum CalendarRoleType {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "freeBusyRead")]
        FreeBusyRead,
        [EnumMember(Value = "limitedRead")]
        LimitedRead,
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "write")]
        Write,
        [EnumMember(Value = "delegateWithoutPrivateEventAccess")]
        DelegateWithoutPrivateEventAccess,
        [EnumMember(Value = "delegateWithPrivateEventAccess")]
        DelegateWithPrivateEventAccess,
        [EnumMember(Value = "custom")]
        Custom,
    }
}
