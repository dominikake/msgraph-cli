using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum RecurrenceRangeType {
        [EnumMember(Value = "endDate")]
        EndDate,
        [EnumMember(Value = "noEnd")]
        NoEnd,
        [EnumMember(Value = "numbered")]
        Numbered,
    }
}
