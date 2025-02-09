using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AppLogDecryptionAlgorithm {
        /// <summary>decrypting using Aes256.</summary>
        [EnumMember(Value = "aes256")]
        Aes256,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
