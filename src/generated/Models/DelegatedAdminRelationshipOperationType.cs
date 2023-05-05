using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum DelegatedAdminRelationshipOperationType {
        [EnumMember(Value = "delegatedAdminAccessAssignmentUpdate")]
        DelegatedAdminAccessAssignmentUpdate,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
