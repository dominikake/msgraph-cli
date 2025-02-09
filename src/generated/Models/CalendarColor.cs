using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum CalendarColor {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "lightBlue")]
        LightBlue,
        [EnumMember(Value = "lightGreen")]
        LightGreen,
        [EnumMember(Value = "lightOrange")]
        LightOrange,
        [EnumMember(Value = "lightGray")]
        LightGray,
        [EnumMember(Value = "lightYellow")]
        LightYellow,
        [EnumMember(Value = "lightTeal")]
        LightTeal,
        [EnumMember(Value = "lightPink")]
        LightPink,
        [EnumMember(Value = "lightBrown")]
        LightBrown,
        [EnumMember(Value = "lightRed")]
        LightRed,
        [EnumMember(Value = "maxColor")]
        MaxColor,
    }
}
