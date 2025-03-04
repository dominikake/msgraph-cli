using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    /// <summary>Possible values for monitoring file activity.</summary>
    public enum DefenderMonitorFileActivity {
        /// <summary>User Defined, default value, no intent.</summary>
        [EnumMember(Value = "userDefined")]
        UserDefined,
        /// <summary>Disable monitoring file activity.</summary>
        [EnumMember(Value = "disable")]
        Disable,
        /// <summary>Monitor all files.</summary>
        [EnumMember(Value = "monitorAllFiles")]
        MonitorAllFiles,
        /// <summary> Monitor incoming files only.</summary>
        [EnumMember(Value = "monitorIncomingFilesOnly")]
        MonitorIncomingFilesOnly,
        /// <summary>Monitor outgoing files only.</summary>
        [EnumMember(Value = "monitorOutgoingFilesOnly")]
        MonitorOutgoingFilesOnly,
    }
}
