using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum AccessPackageAssignmentState {
        [EnumMember(Value = "delivering")]
        Delivering,
        [EnumMember(Value = "partiallyDelivered")]
        PartiallyDelivered,
        [EnumMember(Value = "delivered")]
        Delivered,
        [EnumMember(Value = "expired")]
        Expired,
        [EnumMember(Value = "deliveryFailed")]
        DeliveryFailed,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
