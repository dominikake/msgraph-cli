using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum EducationSubmissionStatus {
        [EnumMember(Value = "working")]
        Working,
        [EnumMember(Value = "submitted")]
        Submitted,
        [EnumMember(Value = "released")]
        Released,
        [EnumMember(Value = "returned")]
        Returned,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
        [EnumMember(Value = "reassigned")]
        Reassigned,
    }
}
