using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum Importance {
        [EnumMember(Value = "low")]
        Low,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "high")]
        High,
    }
}
