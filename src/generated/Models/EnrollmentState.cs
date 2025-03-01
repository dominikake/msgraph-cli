using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum EnrollmentState {
        /// <summary>Device enrollment state is unknown</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Device is Enrolled.</summary>
        [EnumMember(Value = "enrolled")]
        Enrolled,
        /// <summary>Enrolled but it&apos;s enrolled via enrollment profile and the enrolled profile is different from the assigned profile.</summary>
        [EnumMember(Value = "pendingReset")]
        PendingReset,
        /// <summary>Not enrolled and there is enrollment failure record.</summary>
        [EnumMember(Value = "failed")]
        Failed,
        /// <summary>Device is imported but not enrolled.</summary>
        [EnumMember(Value = "notContacted")]
        NotContacted,
    }
}
