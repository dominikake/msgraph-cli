using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum EndpointType {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "voicemail")]
        Voicemail,
        [EnumMember(Value = "skypeForBusiness")]
        SkypeForBusiness,
        [EnumMember(Value = "skypeForBusinessVoipPhone")]
        SkypeForBusinessVoipPhone,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
