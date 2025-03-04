using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ServiceUpdateCategory {
        [EnumMember(Value = "preventOrFixIssue")]
        PreventOrFixIssue,
        [EnumMember(Value = "planForChange")]
        PlanForChange,
        [EnumMember(Value = "stayInformed")]
        StayInformed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
