using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.CallRecords {
    public enum WifiBand {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "frequency24GHz")]
        Frequency24GHz,
        [EnumMember(Value = "frequency50GHz")]
        Frequency50GHz,
        [EnumMember(Value = "frequency60GHz")]
        Frequency60GHz,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
