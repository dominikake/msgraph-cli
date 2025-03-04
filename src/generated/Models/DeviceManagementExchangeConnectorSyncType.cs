using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>The type of Exchange Connector sync requested.</summary>
    public enum DeviceManagementExchangeConnectorSyncType {
        /// <summary>Discover all the device in Exchange.</summary>
        [EnumMember(Value = "fullSync")]
        FullSync,
        /// <summary>Discover only the device in Exchange which have updated during the delta sync window.</summary>
        [EnumMember(Value = "deltaSync")]
        DeltaSync,
    }
}
