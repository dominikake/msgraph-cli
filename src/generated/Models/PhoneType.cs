using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum PhoneType {
        [EnumMember(Value = "home")]
        Home,
        [EnumMember(Value = "business")]
        Business,
        [EnumMember(Value = "mobile")]
        Mobile,
        [EnumMember(Value = "other")]
        Other,
        [EnumMember(Value = "assistant")]
        Assistant,
        [EnumMember(Value = "homeFax")]
        HomeFax,
        [EnumMember(Value = "businessFax")]
        BusinessFax,
        [EnumMember(Value = "otherFax")]
        OtherFax,
        [EnumMember(Value = "pager")]
        Pager,
        [EnumMember(Value = "radio")]
        Radio,
    }
}
