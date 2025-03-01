using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.CallRecords {
    public enum Modality {
        [EnumMember(Value = "audio")]
        Audio,
        [EnumMember(Value = "video")]
        Video,
        [EnumMember(Value = "videoBasedScreenSharing")]
        VideoBasedScreenSharing,
        [EnumMember(Value = "data")]
        Data,
        [EnumMember(Value = "screenSharing")]
        ScreenSharing,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
