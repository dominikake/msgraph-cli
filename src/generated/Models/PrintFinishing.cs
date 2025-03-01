using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum PrintFinishing {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "staple")]
        Staple,
        [EnumMember(Value = "punch")]
        Punch,
        [EnumMember(Value = "cover")]
        Cover,
        [EnumMember(Value = "bind")]
        Bind,
        [EnumMember(Value = "saddleStitch")]
        SaddleStitch,
        [EnumMember(Value = "stitchEdge")]
        StitchEdge,
        [EnumMember(Value = "stapleTopLeft")]
        StapleTopLeft,
        [EnumMember(Value = "stapleBottomLeft")]
        StapleBottomLeft,
        [EnumMember(Value = "stapleTopRight")]
        StapleTopRight,
        [EnumMember(Value = "stapleBottomRight")]
        StapleBottomRight,
        [EnumMember(Value = "stitchLeftEdge")]
        StitchLeftEdge,
        [EnumMember(Value = "stitchTopEdge")]
        StitchTopEdge,
        [EnumMember(Value = "stitchRightEdge")]
        StitchRightEdge,
        [EnumMember(Value = "stitchBottomEdge")]
        StitchBottomEdge,
        [EnumMember(Value = "stapleDualLeft")]
        StapleDualLeft,
        [EnumMember(Value = "stapleDualTop")]
        StapleDualTop,
        [EnumMember(Value = "stapleDualRight")]
        StapleDualRight,
        [EnumMember(Value = "stapleDualBottom")]
        StapleDualBottom,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
