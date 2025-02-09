using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum MediaDirection {
        [EnumMember(Value = "inactive")]
        Inactive,
        [EnumMember(Value = "sendOnly")]
        SendOnly,
        [EnumMember(Value = "receiveOnly")]
        ReceiveOnly,
        [EnumMember(Value = "sendReceive")]
        SendReceive,
    }
}
