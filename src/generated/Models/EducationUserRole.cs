using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum EducationUserRole {
        [EnumMember(Value = "student")]
        Student,
        [EnumMember(Value = "teacher")]
        Teacher,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
