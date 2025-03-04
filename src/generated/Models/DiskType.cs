using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum DiskType {
        /// <summary>Enum member for unknown or default diskType.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>Enum member for HDD devices.</summary>
        [EnumMember(Value = "hdd")]
        Hdd,
        /// <summary>Enum member for SSD devices.</summary>
        [EnumMember(Value = "ssd")]
        Ssd,
        /// <summary>Evolvable enumeration sentinel value.Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
