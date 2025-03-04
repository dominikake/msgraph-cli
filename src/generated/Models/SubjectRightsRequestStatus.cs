using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SubjectRightsRequestStatus {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "closed")]
        Closed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
