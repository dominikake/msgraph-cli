using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum TokenIssuerType {
        [EnumMember(Value = "AzureAD")]
        AzureAD,
        [EnumMember(Value = "ADFederationServices")]
        ADFederationServices,
        [EnumMember(Value = "UnknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "AzureADBackupAuth")]
        AzureADBackupAuth,
        [EnumMember(Value = "ADFederationServicesMFAAdapter")]
        ADFederationServicesMFAAdapter,
        [EnumMember(Value = "NPSExtension")]
        NPSExtension,
    }
}
