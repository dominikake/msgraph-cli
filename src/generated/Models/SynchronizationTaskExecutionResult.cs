using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SynchronizationTaskExecutionResult {
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "EntryLevelErrors")]
        EntryLevelErrors,
    }
}
