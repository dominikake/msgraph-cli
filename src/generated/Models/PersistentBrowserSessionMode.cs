using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum PersistentBrowserSessionMode {
        [EnumMember(Value = "always")]
        Always,
        [EnumMember(Value = "never")]
        Never,
    }
}
