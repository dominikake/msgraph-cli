using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum TimeOffReasonIconType {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "car")]
        Car,
        [EnumMember(Value = "calendar")]
        Calendar,
        [EnumMember(Value = "running")]
        Running,
        [EnumMember(Value = "plane")]
        Plane,
        [EnumMember(Value = "firstAid")]
        FirstAid,
        [EnumMember(Value = "doctor")]
        Doctor,
        [EnumMember(Value = "notWorking")]
        NotWorking,
        [EnumMember(Value = "clock")]
        Clock,
        [EnumMember(Value = "juryDuty")]
        JuryDuty,
        [EnumMember(Value = "globe")]
        Globe,
        [EnumMember(Value = "cup")]
        Cup,
        [EnumMember(Value = "phone")]
        Phone,
        [EnumMember(Value = "weather")]
        Weather,
        [EnumMember(Value = "umbrella")]
        Umbrella,
        [EnumMember(Value = "piggyBank")]
        PiggyBank,
        [EnumMember(Value = "dog")]
        Dog,
        [EnumMember(Value = "cake")]
        Cake,
        [EnumMember(Value = "trafficCone")]
        TrafficCone,
        [EnumMember(Value = "pin")]
        Pin,
        [EnumMember(Value = "sunny")]
        Sunny,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
