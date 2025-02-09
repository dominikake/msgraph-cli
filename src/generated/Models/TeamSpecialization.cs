using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum TeamSpecialization {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "educationStandard")]
        EducationStandard,
        [EnumMember(Value = "educationClass")]
        EducationClass,
        [EnumMember(Value = "educationProfessionalLearningCommunity")]
        EducationProfessionalLearningCommunity,
        [EnumMember(Value = "educationStaff")]
        EducationStaff,
        [EnumMember(Value = "healthcareStandard")]
        HealthcareStandard,
        [EnumMember(Value = "healthcareCareCoordination")]
        HealthcareCareCoordination,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
