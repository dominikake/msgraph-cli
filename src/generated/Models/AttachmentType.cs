using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AttachmentType {
        [EnumMember(Value = "file")]
        File,
        [EnumMember(Value = "item")]
        Item,
        [EnumMember(Value = "reference")]
        Reference,
    }
}
