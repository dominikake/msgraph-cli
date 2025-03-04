using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.ExternalConnectors {
    public enum PropertyType {
        [EnumMember(Value = "string")]
        String,
        [EnumMember(Value = "int64")]
        Int64,
        [EnumMember(Value = "double")]
        Double,
        [EnumMember(Value = "dateTime")]
        DateTime,
        [EnumMember(Value = "boolean")]
        Boolean,
        [EnumMember(Value = "stringCollection")]
        StringCollection,
        [EnumMember(Value = "int64Collection")]
        Int64Collection,
        [EnumMember(Value = "doubleCollection")]
        DoubleCollection,
        [EnumMember(Value = "dateTimeCollection")]
        DateTimeCollection,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
