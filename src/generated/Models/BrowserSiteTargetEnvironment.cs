using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum BrowserSiteTargetEnvironment {
        /// <summary>Open in Internet Explorer Mode</summary>
        [EnumMember(Value = "internetExplorerMode")]
        InternetExplorerMode,
        /// <summary>Open in standalone Internet Explorer 11</summary>
        [EnumMember(Value = "internetExplorer11")]
        InternetExplorer11,
        /// <summary>Open in Microsoft Edge</summary>
        [EnumMember(Value = "microsoftEdge")]
        MicrosoftEdge,
        /// <summary>Configurable type</summary>
        [EnumMember(Value = "configurable")]
        Configurable,
        /// <summary>Open in the browser the employee chooses.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Placeholder for evolvable enum, but this enum is never returned to the caller, so it shouldn&apos;t be necessary.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
