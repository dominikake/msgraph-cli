using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum FreeBusyStatus {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "free")]
        Free,
        [EnumMember(Value = "tentative")]
        Tentative,
        [EnumMember(Value = "busy")]
        Busy,
        [EnumMember(Value = "oof")]
        Oof,
        [EnumMember(Value = "workingElsewhere")]
        WorkingElsewhere,
    }
}
