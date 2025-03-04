using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models.CallRecords {
    public enum WifiRadioType {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "wifi80211a")]
        Wifi80211a,
        [EnumMember(Value = "wifi80211b")]
        Wifi80211b,
        [EnumMember(Value = "wifi80211g")]
        Wifi80211g,
        [EnumMember(Value = "wifi80211n")]
        Wifi80211n,
        [EnumMember(Value = "wifi80211ac")]
        Wifi80211ac,
        [EnumMember(Value = "wifi80211ax")]
        Wifi80211ax,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
