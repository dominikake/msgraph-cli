using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible types of Application</summary>
    public enum ApplicationType {
        /// <summary>The windows universal application</summary>
        [EnumMember(Value = "universal")]
        Universal,
        /// <summary>The windows desktop application</summary>
        [EnumMember(Value = "desktop")]
        Desktop,
    }
}
