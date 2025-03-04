using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.CallRecords {
    public enum NetworkTransportProtocol {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "udp")]
        Udp,
        [EnumMember(Value = "tcp")]
        Tcp,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
