using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AppKeyCredentialRestrictionType {
        [EnumMember(Value = "asymmetricKeyLifetime")]
        AsymmetricKeyLifetime,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
