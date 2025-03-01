using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.ExternalConnectors {
    public enum Label {
        [EnumMember(Value = "title")]
        Title,
        [EnumMember(Value = "url")]
        Url,
        [EnumMember(Value = "createdBy")]
        CreatedBy,
        [EnumMember(Value = "lastModifiedBy")]
        LastModifiedBy,
        [EnumMember(Value = "authors")]
        Authors,
        [EnumMember(Value = "createdDateTime")]
        CreatedDateTime,
        [EnumMember(Value = "lastModifiedDateTime")]
        LastModifiedDateTime,
        [EnumMember(Value = "fileName")]
        FileName,
        [EnumMember(Value = "fileExtension")]
        FileExtension,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
