using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Edition Upgrade License type</summary>
    public enum EditionUpgradeLicenseType {
        /// <summary>Product Key Type</summary>
        [EnumMember(Value = "productKey")]
        ProductKey,
        /// <summary>License File Type</summary>
        [EnumMember(Value = "licenseFile")]
        LicenseFile,
    }
}
