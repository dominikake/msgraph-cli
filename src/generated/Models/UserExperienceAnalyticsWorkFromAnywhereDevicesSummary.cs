using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// The user experience analytics Work From Anywhere metrics devices summary.
    /// </summary>
    public class UserExperienceAnalyticsWorkFromAnywhereDevicesSummary : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The user experience analytics work from anywhere Autopilot devices summary. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserExperienceAnalyticsAutopilotDevicesSummary? AutopilotDevicesSummary { get; set; }
#nullable restore
#else
        public UserExperienceAnalyticsAutopilotDevicesSummary AutopilotDevicesSummary { get; set; }
#endif
        /// <summary>The user experience analytics work from anywhere Cloud Identity devices summary. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserExperienceAnalyticsCloudIdentityDevicesSummary? CloudIdentityDevicesSummary { get; set; }
#nullable restore
#else
        public UserExperienceAnalyticsCloudIdentityDevicesSummary CloudIdentityDevicesSummary { get; set; }
#endif
        /// <summary>The user experience analytics work from anywhere Cloud management devices summary. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserExperienceAnalyticsCloudManagementDevicesSummary? CloudManagementDevicesSummary { get; set; }
#nullable restore
#else
        public UserExperienceAnalyticsCloudManagementDevicesSummary CloudManagementDevicesSummary { get; set; }
#endif
        /// <summary>Total number of co-managed devices. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? CoManagedDevices { get; set; }
        /// <summary>The count of intune devices that are not autopilot registerd. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? DevicesNotAutopilotRegistered { get; set; }
        /// <summary>The count of intune devices not autopilot profile assigned. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? DevicesWithoutAutopilotProfileAssigned { get; set; }
        /// <summary>The count of devices that are not cloud identity. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? DevicesWithoutCloudIdentity { get; set; }
        /// <summary>The count of intune devices that are not autopilot registerd. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? IntuneDevices { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Total count of tenant attach devices. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? TenantAttachDevices { get; set; }
        /// <summary>The total count of devices. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? TotalDevices { get; set; }
        /// <summary>The count of Windows 10 devices that have unsupported OS versions. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? UnsupportedOSversionDevices { get; set; }
        /// <summary>The count of windows 10 devices. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? Windows10Devices { get; set; }
        /// <summary>The user experience analytics work from anywhere Windows 10 devices summary. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserExperienceAnalyticsWindows10DevicesSummary? Windows10DevicesSummary { get; set; }
#nullable restore
#else
        public UserExperienceAnalyticsWindows10DevicesSummary Windows10DevicesSummary { get; set; }
#endif
        /// <summary>The count of windows 10 devices that are Intune and co-managed. Read-only. Valid values -2147483648 to 2147483647</summary>
        public int? Windows10DevicesWithoutTenantAttach { get; set; }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsWorkFromAnywhereDevicesSummary and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsWorkFromAnywhereDevicesSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserExperienceAnalyticsWorkFromAnywhereDevicesSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsWorkFromAnywhereDevicesSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"autopilotDevicesSummary", n => { AutopilotDevicesSummary = n.GetObjectValue<UserExperienceAnalyticsAutopilotDevicesSummary>(UserExperienceAnalyticsAutopilotDevicesSummary.CreateFromDiscriminatorValue); } },
                {"cloudIdentityDevicesSummary", n => { CloudIdentityDevicesSummary = n.GetObjectValue<UserExperienceAnalyticsCloudIdentityDevicesSummary>(UserExperienceAnalyticsCloudIdentityDevicesSummary.CreateFromDiscriminatorValue); } },
                {"cloudManagementDevicesSummary", n => { CloudManagementDevicesSummary = n.GetObjectValue<UserExperienceAnalyticsCloudManagementDevicesSummary>(UserExperienceAnalyticsCloudManagementDevicesSummary.CreateFromDiscriminatorValue); } },
                {"coManagedDevices", n => { CoManagedDevices = n.GetIntValue(); } },
                {"devicesNotAutopilotRegistered", n => { DevicesNotAutopilotRegistered = n.GetIntValue(); } },
                {"devicesWithoutAutopilotProfileAssigned", n => { DevicesWithoutAutopilotProfileAssigned = n.GetIntValue(); } },
                {"devicesWithoutCloudIdentity", n => { DevicesWithoutCloudIdentity = n.GetIntValue(); } },
                {"intuneDevices", n => { IntuneDevices = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"tenantAttachDevices", n => { TenantAttachDevices = n.GetIntValue(); } },
                {"totalDevices", n => { TotalDevices = n.GetIntValue(); } },
                {"unsupportedOSversionDevices", n => { UnsupportedOSversionDevices = n.GetIntValue(); } },
                {"windows10Devices", n => { Windows10Devices = n.GetIntValue(); } },
                {"windows10DevicesSummary", n => { Windows10DevicesSummary = n.GetObjectValue<UserExperienceAnalyticsWindows10DevicesSummary>(UserExperienceAnalyticsWindows10DevicesSummary.CreateFromDiscriminatorValue); } },
                {"windows10DevicesWithoutTenantAttach", n => { Windows10DevicesWithoutTenantAttach = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<UserExperienceAnalyticsAutopilotDevicesSummary>("autopilotDevicesSummary", AutopilotDevicesSummary);
            writer.WriteObjectValue<UserExperienceAnalyticsCloudIdentityDevicesSummary>("cloudIdentityDevicesSummary", CloudIdentityDevicesSummary);
            writer.WriteObjectValue<UserExperienceAnalyticsCloudManagementDevicesSummary>("cloudManagementDevicesSummary", CloudManagementDevicesSummary);
            writer.WriteIntValue("coManagedDevices", CoManagedDevices);
            writer.WriteIntValue("devicesNotAutopilotRegistered", DevicesNotAutopilotRegistered);
            writer.WriteIntValue("devicesWithoutAutopilotProfileAssigned", DevicesWithoutAutopilotProfileAssigned);
            writer.WriteIntValue("devicesWithoutCloudIdentity", DevicesWithoutCloudIdentity);
            writer.WriteIntValue("intuneDevices", IntuneDevices);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("tenantAttachDevices", TenantAttachDevices);
            writer.WriteIntValue("totalDevices", TotalDevices);
            writer.WriteIntValue("unsupportedOSversionDevices", UnsupportedOSversionDevices);
            writer.WriteIntValue("windows10Devices", Windows10Devices);
            writer.WriteObjectValue<UserExperienceAnalyticsWindows10DevicesSummary>("windows10DevicesSummary", Windows10DevicesSummary);
            writer.WriteIntValue("windows10DevicesWithoutTenantAttach", Windows10DevicesWithoutTenantAttach);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
