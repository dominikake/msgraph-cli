using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.Security {
    public enum GoogleCloudLocationType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "regional")]
        Regional,
        [EnumMember(Value = "zonal")]
        Zonal,
        [EnumMember(Value = "global")]
        Global,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
