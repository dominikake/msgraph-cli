using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SignInFrequencyAuthenticationType {
        [EnumMember(Value = "primaryAndSecondaryAuthentication")]
        PrimaryAndSecondaryAuthentication,
        [EnumMember(Value = "secondaryAuthentication")]
        SecondaryAuthentication,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
