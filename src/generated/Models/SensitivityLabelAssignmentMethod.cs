using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SensitivityLabelAssignmentMethod {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "privileged")]
        Privileged,
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
