using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum GroupType {
        [EnumMember(Value = "unifiedGroups")]
        UnifiedGroups,
        [EnumMember(Value = "azureAD")]
        AzureAD,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
