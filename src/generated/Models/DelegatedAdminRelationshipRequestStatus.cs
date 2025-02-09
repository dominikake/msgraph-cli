using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum DelegatedAdminRelationshipRequestStatus {
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "succeeded")]
        Succeeded,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
