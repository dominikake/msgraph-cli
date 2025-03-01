using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum ServiceSource {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "microsoftDefenderForEndpoint")]
        MicrosoftDefenderForEndpoint,
        [EnumMember(Value = "microsoftDefenderForIdentity")]
        MicrosoftDefenderForIdentity,
        [EnumMember(Value = "microsoftDefenderForCloudApps")]
        MicrosoftDefenderForCloudApps,
        [EnumMember(Value = "microsoftDefenderForOffice365")]
        MicrosoftDefenderForOffice365,
        [EnumMember(Value = "microsoft365Defender")]
        Microsoft365Defender,
        [EnumMember(Value = "azureAdIdentityProtection")]
        AzureAdIdentityProtection,
        [EnumMember(Value = "microsoftAppGovernance")]
        MicrosoftAppGovernance,
        [EnumMember(Value = "dataLossPrevention")]
        DataLossPrevention,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "microsoftDefenderForCloud")]
        MicrosoftDefenderForCloud,
    }
}
