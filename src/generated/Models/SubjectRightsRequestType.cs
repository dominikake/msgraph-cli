using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SubjectRightsRequestType {
        [EnumMember(Value = "export")]
        Export,
        [EnumMember(Value = "delete")]
        Delete,
        [EnumMember(Value = "access")]
        Access,
        [EnumMember(Value = "tagForAction")]
        TagForAction,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
