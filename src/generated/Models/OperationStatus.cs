using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum OperationStatus {
        [EnumMember(Value = "NotStarted")]
        NotStarted,
        [EnumMember(Value = "Running")]
        Running,
        [EnumMember(Value = "Completed")]
        Completed,
        [EnumMember(Value = "Failed")]
        Failed,
    }
}
