using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum EducationGender {
        [EnumMember(Value = "female")]
        Female,
        [EnumMember(Value = "male")]
        Male,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
