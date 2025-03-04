using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>The current status of the Exchange Connector.</summary>
    public enum DeviceManagementExchangeConnectorStatus {
        /// <summary>No Connector exists.</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Pending Connection to the Exchange Environment.</summary>
        [EnumMember(Value = "connectionPending")]
        ConnectionPending,
        /// <summary>Connected to the Exchange Environment</summary>
        [EnumMember(Value = "connected")]
        Connected,
        /// <summary>Disconnected from the Exchange Environment</summary>
        [EnumMember(Value = "disconnected")]
        Disconnected,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
