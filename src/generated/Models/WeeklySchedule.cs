using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible values for a weekly schedule.</summary>
    public enum WeeklySchedule {
        /// <summary>User Defined, default value, no intent.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Everyday.</summary>
        [EnumMember(Value = "everyday")]
        Everyday,
        /// <summary>Sunday.</summary>
        [EnumMember(Value = "sunday")]
        Sunday,
        /// <summary>Monday.</summary>
        [EnumMember(Value = "monday")]
        Monday,
        /// <summary>Tuesday.</summary>
        [EnumMember(Value = "tuesday")]
        Tuesday,
        /// <summary>Wednesday.</summary>
        [EnumMember(Value = "wednesday")]
        Wednesday,
        /// <summary>Thursday.</summary>
        [EnumMember(Value = "thursday")]
        Thursday,
        /// <summary>Friday.</summary>
        [EnumMember(Value = "friday")]
        Friday,
        /// <summary>Saturday.</summary>
        [EnumMember(Value = "saturday")]
        Saturday,
    }
}
