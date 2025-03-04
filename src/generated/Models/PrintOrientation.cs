using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum PrintOrientation {
        [EnumMember(Value = "portrait")]
        Portrait,
        [EnumMember(Value = "landscape")]
        Landscape,
        [EnumMember(Value = "reverseLandscape")]
        ReverseLandscape,
        [EnumMember(Value = "reversePortrait")]
        ReversePortrait,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
