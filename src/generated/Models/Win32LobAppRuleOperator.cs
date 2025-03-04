using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Contains properties for detection operator.</summary>
    public enum Win32LobAppRuleOperator {
        /// <summary>Not configured.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Equal operator.</summary>
        [EnumMember(Value = "equal")]
        Equal,
        /// <summary>Not equal operator.</summary>
        [EnumMember(Value = "notEqual")]
        NotEqual,
        /// <summary>Greater than operator.</summary>
        [EnumMember(Value = "greaterThan")]
        GreaterThan,
        /// <summary>Greater than or equal operator.</summary>
        [EnumMember(Value = "greaterThanOrEqual")]
        GreaterThanOrEqual,
        /// <summary>Less than operator.</summary>
        [EnumMember(Value = "lessThan")]
        LessThan,
        /// <summary>Less than or equal operator.</summary>
        [EnumMember(Value = "lessThanOrEqual")]
        LessThanOrEqual,
    }
}
