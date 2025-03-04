using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SynchronizationStatusCode {
        [EnumMember(Value = "NotConfigured")]
        NotConfigured,
        [EnumMember(Value = "NotRun")]
        NotRun,
        [EnumMember(Value = "Active")]
        Active,
        [EnumMember(Value = "Paused")]
        Paused,
        [EnumMember(Value = "Quarantine")]
        Quarantine,
    }
}
