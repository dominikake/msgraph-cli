using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum RoutingType {
        [EnumMember(Value = "forwarded")]
        Forwarded,
        [EnumMember(Value = "lookup")]
        Lookup,
        [EnumMember(Value = "selfFork")]
        SelfFork,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
