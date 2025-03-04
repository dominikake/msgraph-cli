using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AccessPackageRequestState {
        [EnumMember(Value = "submitted")]
        Submitted,
        [EnumMember(Value = "pendingApproval")]
        PendingApproval,
        [EnumMember(Value = "delivering")]
        Delivering,
        [EnumMember(Value = "delivered")]
        Delivered,
        [EnumMember(Value = "deliveryFailed")]
        DeliveryFailed,
        [EnumMember(Value = "denied")]
        Denied,
        [EnumMember(Value = "scheduled")]
        Scheduled,
        [EnumMember(Value = "canceled")]
        Canceled,
        [EnumMember(Value = "partiallyDelivered")]
        PartiallyDelivered,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
