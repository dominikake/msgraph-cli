using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ConditionalAccessClientApp {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "browser")]
        Browser,
        [EnumMember(Value = "mobileAppsAndDesktopClients")]
        MobileAppsAndDesktopClients,
        [EnumMember(Value = "exchangeActiveSync")]
        ExchangeActiveSync,
        [EnumMember(Value = "easSupported")]
        EasSupported,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
