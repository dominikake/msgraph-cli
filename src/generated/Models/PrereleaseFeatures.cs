using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible values for pre-release features.</summary>
    public enum PrereleaseFeatures {
        /// <summary>User Defined, default value, no intent.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Settings only pre-release features.</summary>
        [EnumMember(Value = "settingsOnly")]
        SettingsOnly,
        /// <summary>Settings and experimentations pre-release features.</summary>
        [EnumMember(Value = "settingsAndExperimentations")]
        SettingsAndExperimentations,
        /// <summary>Pre-release features not allowed.</summary>
        [EnumMember(Value = "notAllowed")]
        NotAllowed,
    }
}
