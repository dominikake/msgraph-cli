using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum FilterMode {
        [EnumMember(Value = "include")]
        Include,
        [EnumMember(Value = "exclude")]
        Exclude,
    }
}
