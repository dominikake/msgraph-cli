using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AccessPackageCatalogType {
        [EnumMember(Value = "userManaged")]
        UserManaged,
        [EnumMember(Value = "serviceDefault")]
        ServiceDefault,
        [EnumMember(Value = "serviceManaged")]
        ServiceManaged,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
