using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ActivityType {
        [EnumMember(Value = "signin")]
        Signin,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "servicePrincipal")]
        ServicePrincipal,
    }
}
