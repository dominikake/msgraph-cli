using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum WorkforceIntegrationEncryptionProtocol {
        [EnumMember(Value = "sharedSecret")]
        SharedSecret,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
