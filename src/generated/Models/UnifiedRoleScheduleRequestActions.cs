using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum UnifiedRoleScheduleRequestActions {
        [EnumMember(Value = "adminAssign")]
        AdminAssign,
        [EnumMember(Value = "adminUpdate")]
        AdminUpdate,
        [EnumMember(Value = "adminRemove")]
        AdminRemove,
        [EnumMember(Value = "selfActivate")]
        SelfActivate,
        [EnumMember(Value = "selfDeactivate")]
        SelfDeactivate,
        [EnumMember(Value = "adminExtend")]
        AdminExtend,
        [EnumMember(Value = "adminRenew")]
        AdminRenew,
        [EnumMember(Value = "selfExtend")]
        SelfExtend,
        [EnumMember(Value = "selfRenew")]
        SelfRenew,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
