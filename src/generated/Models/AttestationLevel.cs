using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AttestationLevel {
        [EnumMember(Value = "attested")]
        Attested,
        [EnumMember(Value = "notAttested")]
        NotAttested,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
