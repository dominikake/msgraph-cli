using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ObjectDefinitionMetadata {
        [EnumMember(Value = "PropertyNameAccountEnabled")]
        PropertyNameAccountEnabled,
        [EnumMember(Value = "PropertyNameSoftDeleted")]
        PropertyNameSoftDeleted,
        [EnumMember(Value = "IsSoftDeletionSupported")]
        IsSoftDeletionSupported,
        [EnumMember(Value = "IsSynchronizeAllSupported")]
        IsSynchronizeAllSupported,
        [EnumMember(Value = "ConnectorDataStorageRequired")]
        ConnectorDataStorageRequired,
        [EnumMember(Value = "Extensions")]
        Extensions,
        [EnumMember(Value = "BaseObjectName")]
        BaseObjectName,
    }
}
