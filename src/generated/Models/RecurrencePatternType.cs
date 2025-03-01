using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum RecurrencePatternType {
        [EnumMember(Value = "daily")]
        Daily,
        [EnumMember(Value = "weekly")]
        Weekly,
        [EnumMember(Value = "absoluteMonthly")]
        AbsoluteMonthly,
        [EnumMember(Value = "relativeMonthly")]
        RelativeMonthly,
        [EnumMember(Value = "absoluteYearly")]
        AbsoluteYearly,
        [EnumMember(Value = "relativeYearly")]
        RelativeYearly,
    }
}
