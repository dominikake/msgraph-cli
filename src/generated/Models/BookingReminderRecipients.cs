using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum BookingReminderRecipients {
        [EnumMember(Value = "allAttendees")]
        AllAttendees,
        [EnumMember(Value = "staff")]
        Staff,
        [EnumMember(Value = "customer")]
        Customer,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
