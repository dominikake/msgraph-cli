using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum FileHashType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "sha1")]
        Sha1,
        [EnumMember(Value = "sha256")]
        Sha256,
        [EnumMember(Value = "md5")]
        Md5,
        [EnumMember(Value = "authenticodeHash256")]
        AuthenticodeHash256,
        [EnumMember(Value = "lsHash")]
        LsHash,
        [EnumMember(Value = "ctph")]
        Ctph,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
