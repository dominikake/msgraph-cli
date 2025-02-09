using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum MailDestinationRoutingReason {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "mailFlowRule")]
        MailFlowRule,
        [EnumMember(Value = "safeSender")]
        SafeSender,
        [EnumMember(Value = "blockedSender")]
        BlockedSender,
        [EnumMember(Value = "advancedSpamFiltering")]
        AdvancedSpamFiltering,
        [EnumMember(Value = "domainAllowList")]
        DomainAllowList,
        [EnumMember(Value = "domainBlockList")]
        DomainBlockList,
        [EnumMember(Value = "notInAddressBook")]
        NotInAddressBook,
        [EnumMember(Value = "firstTimeSender")]
        FirstTimeSender,
        [EnumMember(Value = "autoPurgeToInbox")]
        AutoPurgeToInbox,
        [EnumMember(Value = "autoPurgeToJunk")]
        AutoPurgeToJunk,
        [EnumMember(Value = "autoPurgeToDeleted")]
        AutoPurgeToDeleted,
        [EnumMember(Value = "outbound")]
        Outbound,
        [EnumMember(Value = "notJunk")]
        NotJunk,
        [EnumMember(Value = "junk")]
        Junk,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
