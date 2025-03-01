using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum X509CertificateAuthenticationMode {
        [EnumMember(Value = "x509CertificateSingleFactor")]
        X509CertificateSingleFactor,
        [EnumMember(Value = "x509CertificateMultiFactor")]
        X509CertificateMultiFactor,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
