using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AccessPackageSubjectType {
        [EnumMember(Value = "notSpecified")]
        NotSpecified,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "servicePrincipal")]
        ServicePrincipal,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
