using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum EducationExternalSource {
        [EnumMember(Value = "sis")]
        Sis,
        [EnumMember(Value = "manual")]
        Manual,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
