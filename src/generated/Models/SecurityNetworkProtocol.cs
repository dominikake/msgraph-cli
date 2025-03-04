using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum SecurityNetworkProtocol {
        [EnumMember(Value = "unknown")]
        Unknown,
        [EnumMember(Value = "ip")]
        Ip,
        [EnumMember(Value = "icmp")]
        Icmp,
        [EnumMember(Value = "igmp")]
        Igmp,
        [EnumMember(Value = "ggp")]
        Ggp,
        [EnumMember(Value = "ipv4")]
        Ipv4,
        [EnumMember(Value = "tcp")]
        Tcp,
        [EnumMember(Value = "pup")]
        Pup,
        [EnumMember(Value = "udp")]
        Udp,
        [EnumMember(Value = "idp")]
        Idp,
        [EnumMember(Value = "ipv6")]
        Ipv6,
        [EnumMember(Value = "ipv6RoutingHeader")]
        Ipv6RoutingHeader,
        [EnumMember(Value = "ipv6FragmentHeader")]
        Ipv6FragmentHeader,
        [EnumMember(Value = "ipSecEncapsulatingSecurityPayload")]
        IpSecEncapsulatingSecurityPayload,
        [EnumMember(Value = "ipSecAuthenticationHeader")]
        IpSecAuthenticationHeader,
        [EnumMember(Value = "icmpV6")]
        IcmpV6,
        [EnumMember(Value = "ipv6NoNextHeader")]
        Ipv6NoNextHeader,
        [EnumMember(Value = "ipv6DestinationOptions")]
        Ipv6DestinationOptions,
        [EnumMember(Value = "nd")]
        Nd,
        [EnumMember(Value = "raw")]
        Raw,
        [EnumMember(Value = "ipx")]
        Ipx,
        [EnumMember(Value = "spx")]
        Spx,
        [EnumMember(Value = "spxII")]
        SpxII,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
