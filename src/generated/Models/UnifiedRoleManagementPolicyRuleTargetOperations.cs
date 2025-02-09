using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum UnifiedRoleManagementPolicyRuleTargetOperations {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "activate")]
        Activate,
        [EnumMember(Value = "deactivate")]
        Deactivate,
        [EnumMember(Value = "assign")]
        Assign,
        [EnumMember(Value = "update")]
        Update,
        [EnumMember(Value = "remove")]
        Remove,
        [EnumMember(Value = "extend")]
        Extend,
        [EnumMember(Value = "renew")]
        Renew,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
