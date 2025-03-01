using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Windows 10 Edition type.</summary>
    public enum Windows10EditionType {
        /// <summary>Windows 10 Enterprise</summary>
        [EnumMember(Value = "windows10Enterprise")]
        Windows10Enterprise,
        /// <summary>Windows 10 EnterpriseN</summary>
        [EnumMember(Value = "windows10EnterpriseN")]
        Windows10EnterpriseN,
        /// <summary>Windows 10 Education</summary>
        [EnumMember(Value = "windows10Education")]
        Windows10Education,
        /// <summary>Windows 10 EducationN</summary>
        [EnumMember(Value = "windows10EducationN")]
        Windows10EducationN,
        /// <summary>Windows 10 Mobile Enterprise</summary>
        [EnumMember(Value = "windows10MobileEnterprise")]
        Windows10MobileEnterprise,
        /// <summary>Windows 10 Holographic Enterprise</summary>
        [EnumMember(Value = "windows10HolographicEnterprise")]
        Windows10HolographicEnterprise,
        /// <summary>Windows 10 Professional</summary>
        [EnumMember(Value = "windows10Professional")]
        Windows10Professional,
        /// <summary>Windows 10 ProfessionalN</summary>
        [EnumMember(Value = "windows10ProfessionalN")]
        Windows10ProfessionalN,
        /// <summary>Windows 10 Professional Education</summary>
        [EnumMember(Value = "windows10ProfessionalEducation")]
        Windows10ProfessionalEducation,
        /// <summary>Windows 10 Professional EducationN</summary>
        [EnumMember(Value = "windows10ProfessionalEducationN")]
        Windows10ProfessionalEducationN,
        /// <summary>Windows 10 Professional for Workstations</summary>
        [EnumMember(Value = "windows10ProfessionalWorkstation")]
        Windows10ProfessionalWorkstation,
        /// <summary>Windows 10 Professional for Workstations N</summary>
        [EnumMember(Value = "windows10ProfessionalWorkstationN")]
        Windows10ProfessionalWorkstationN,
    }
}
