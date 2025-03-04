using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum PlannerContainerType {
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "roster")]
        Roster,
    }
}
