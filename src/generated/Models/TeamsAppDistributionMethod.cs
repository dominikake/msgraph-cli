using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum TeamsAppDistributionMethod {
        [EnumMember(Value = "store")]
        Store,
        [EnumMember(Value = "organization")]
        Organization,
        [EnumMember(Value = "sideloaded")]
        Sideloaded,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
