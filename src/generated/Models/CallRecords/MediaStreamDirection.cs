using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.CallRecords {
    public enum MediaStreamDirection {
        [EnumMember(Value = "callerToCallee")]
        CallerToCallee,
        [EnumMember(Value = "calleeToCaller")]
        CalleeToCaller,
    }
}
