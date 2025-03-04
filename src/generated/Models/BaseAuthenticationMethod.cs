using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum BaseAuthenticationMethod {
        [EnumMember(Value = "password")]
        Password,
        [EnumMember(Value = "voice")]
        Voice,
        [EnumMember(Value = "hardwareOath")]
        HardwareOath,
        [EnumMember(Value = "softwareOath")]
        SoftwareOath,
        [EnumMember(Value = "sms")]
        Sms,
        [EnumMember(Value = "fido2")]
        Fido2,
        [EnumMember(Value = "windowsHelloForBusiness")]
        WindowsHelloForBusiness,
        [EnumMember(Value = "microsoftAuthenticator")]
        MicrosoftAuthenticator,
        [EnumMember(Value = "temporaryAccessPass")]
        TemporaryAccessPass,
        [EnumMember(Value = "email")]
        Email,
        [EnumMember(Value = "x509Certificate")]
        X509Certificate,
        [EnumMember(Value = "federation")]
        Federation,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
