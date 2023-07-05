using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum DelegatedAdminAccessContainerType {
        [EnumMember(Value = "securityGroup")]
        SecurityGroup,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
