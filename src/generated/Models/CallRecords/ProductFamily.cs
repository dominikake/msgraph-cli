using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.CallRecords {
    public enum ProductFamily {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "teams")]
        Teams,
        [EnumMember(Value = "skypeForBusiness")]
        SkypeForBusiness,
        [EnumMember(Value = "lync")]
        Lync,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "azureCommunicationServices")]
        AzureCommunicationServices,
    }
}
