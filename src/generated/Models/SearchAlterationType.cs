using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SearchAlterationType {
        [EnumMember(Value = "suggestion")]
        Suggestion,
        [EnumMember(Value = "modification")]
        Modification,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
