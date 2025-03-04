using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible types of an Apple Volume Purchase Program token.</summary>
    public enum VppTokenAccountType {
        /// <summary>Apple Volume Purchase Program token associated with an business program.</summary>
        [EnumMember(Value = "business")]
        Business,
        /// <summary>Apple Volume Purchase Program token associated with an education program.</summary>
        [EnumMember(Value = "education")]
        Education,
    }
}
