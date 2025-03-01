using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible values of the compliance app list.</summary>
    public enum AppListType {
        /// <summary>Default value, no intent.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>The list represents the apps that will be considered compliant (only apps on the list are compliant).</summary>
        [EnumMember(Value = "appsInListCompliant")]
        AppsInListCompliant,
        /// <summary>The list represents the apps that will be considered non compliant (all apps are compliant except apps on the list).</summary>
        [EnumMember(Value = "appsNotInListCompliant")]
        AppsNotInListCompliant,
    }
}
