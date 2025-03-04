using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum CallRecordingStatus {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "failure")]
        Failure,
        [EnumMember(Value = "initial")]
        Initial,
        [EnumMember(Value = "chunkFinished")]
        ChunkFinished,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
