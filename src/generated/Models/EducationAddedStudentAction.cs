using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum EducationAddedStudentAction {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "assignIfOpen")]
        AssignIfOpen,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
