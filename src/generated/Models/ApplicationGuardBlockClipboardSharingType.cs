using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible values for applicationGuardBlockClipboardSharingType</summary>
    public enum ApplicationGuardBlockClipboardSharingType {
        /// <summary>Not Configured</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Block clipboard to share data both from Host to Container and from Container to Host</summary>
        [EnumMember(Value = "blockBoth")]
        BlockBoth,
        /// <summary>Block clipboard to share data from Host to Container</summary>
        [EnumMember(Value = "blockHostToContainer")]
        BlockHostToContainer,
        /// <summary>Block clipboard to share data from Container to Host</summary>
        [EnumMember(Value = "blockContainerToHost")]
        BlockContainerToHost,
        /// <summary>Block clipboard to share data neither from Host to Container nor from Container to Host</summary>
        [EnumMember(Value = "blockNone")]
        BlockNone,
    }
}
