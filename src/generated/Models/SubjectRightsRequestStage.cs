using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SubjectRightsRequestStage {
        [EnumMember(Value = "contentRetrieval")]
        ContentRetrieval,
        [EnumMember(Value = "contentReview")]
        ContentReview,
        [EnumMember(Value = "generateReport")]
        GenerateReport,
        [EnumMember(Value = "contentDeletion")]
        ContentDeletion,
        [EnumMember(Value = "caseResolved")]
        CaseResolved,
        [EnumMember(Value = "contentEstimate")]
        ContentEstimate,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
