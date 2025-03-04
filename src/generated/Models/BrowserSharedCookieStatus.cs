using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum BrowserSharedCookieStatus {
        /// <summary>A sharedcookie that has been published</summary>
        [EnumMember(Value = "published")]
        Published,
        /// <summary>A sharedcookie that has been added pending publish</summary>
        [EnumMember(Value = "pendingAdd")]
        PendingAdd,
        /// <summary>A sharedcookie that has been edited pending publish</summary>
        [EnumMember(Value = "pendingEdit")]
        PendingEdit,
        /// <summary>A sharedcookie that has been deleted pending publish</summary>
        [EnumMember(Value = "pendingDelete")]
        PendingDelete,
        /// <summary>Placeholder for evolvable enum, but this enum is never returned to the caller, so it shouldn&apos;t be necessary.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
