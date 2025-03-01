using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// The user experience analytics device for work from anywhere report.
    /// </summary>
    public class UserExperienceAnalyticsWorkFromAnywhereDevice : Entity, IParsable {
        /// <summary>When TRUE, indicates the intune device&apos;s autopilot profile is assigned. When FALSE, indicates it&apos;s not Assigned. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? AutoPilotProfileAssigned { get; set; }
        /// <summary>When TRUE, indicates the intune device&apos;s autopilot is registered. When FALSE, indicates it&apos;s not registered. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? AutoPilotRegistered { get; set; }
        /// <summary>The Azure Active Directory (Azure AD) device Id. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureAdDeviceId { get; set; }
#nullable restore
#else
        public string AzureAdDeviceId { get; set; }
#endif
        /// <summary>The work from anywhere device&apos;s Azure Active Directory (Azure AD) join type. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureAdJoinType { get; set; }
#nullable restore
#else
        public string AzureAdJoinType { get; set; }
#endif
        /// <summary>When TRUE, indicates the device&apos;s Azure Active Directory (Azure AD) is registered. When False, indicates it&apos;s not registered. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? AzureAdRegistered { get; set; }
        /// <summary>Indicates per device cloud identity score. Valid values 0 to 100. Value -1 means associated score is unavailable. Supports: $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudIdentityScore { get; set; }
        /// <summary>Indicates per device cloud management score. Valid values 0 to 100. Value -1 means associated score is unavailable. Supports: $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudManagementScore { get; set; }
        /// <summary>Indicates per device cloud provisioning score. Valid values 0 to 100. Value -1 means associated score is unavailable. Supports: $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? CloudProvisioningScore { get; set; }
        /// <summary>When TRUE, indicates the device&apos;s compliance policy is set to intune. When FALSE, indicates it&apos;s not set to intune. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? CompliancePolicySetToIntune { get; set; }
        /// <summary>The Intune device id of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>The name of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; set; }
#nullable restore
#else
        public string DeviceName { get; set; }
#endif
        /// <summary>The healthStatus property</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
        /// <summary>When TRUE, indicates the device&apos;s Cloud Management Gateway for Configuration Manager is enabled. When FALSE, indicates it&apos;s not enabled. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? IsCloudManagedGatewayEnabled { get; set; }
        /// <summary>The management agent of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedBy { get; set; }
#nullable restore
#else
        public string ManagedBy { get; set; }
#endif
        /// <summary>The manufacturer name of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer { get; set; }
#nullable restore
#else
        public string Manufacturer { get; set; }
#endif
        /// <summary>The model name of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model { get; set; }
#nullable restore
#else
        public string Model { get; set; }
#endif
        /// <summary>When TRUE, indicates OS check failed for device to upgrade to the latest version of windows. When FALSE, indicates the check succeeded. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? OsCheckFailed { get; set; }
        /// <summary>The OS description of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsDescription { get; set; }
#nullable restore
#else
        public string OsDescription { get; set; }
#endif
        /// <summary>The OS version of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion { get; set; }
#nullable restore
#else
        public string OsVersion { get; set; }
#endif
        /// <summary>When TRUE, indicates the device&apos;s other workloads is set to intune. When FALSE, indicates it&apos;s not set to intune. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? OtherWorkloadsSetToIntune { get; set; }
        /// <summary>Ownership of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ownership { get; set; }
#nullable restore
#else
        public string Ownership { get; set; }
#endif
        /// <summary>When TRUE, indicates processor hardware 64-bit architecture check failed for device to upgrade to the latest version of windows. When FALSE, indicates the check succeeded. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? Processor64BitCheckFailed { get; set; }
        /// <summary>When TRUE, indicates processor hardware core count check failed for device to upgrade to the latest version of windows. When FALSE, indicates the check succeeded. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? ProcessorCoreCountCheckFailed { get; set; }
        /// <summary>When TRUE, indicates processor hardware family check failed for device to upgrade to the latest version of windows. When FALSE, indicates the check succeeded. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? ProcessorFamilyCheckFailed { get; set; }
        /// <summary>When TRUE, indicates processor hardware speed check failed for device to upgrade to the latest version of windows. When FALSE, indicates the check succeeded. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? ProcessorSpeedCheckFailed { get; set; }
        /// <summary>When TRUE, indicates RAM hardware check failed for device to upgrade to the latest version of windows. When FALSE, indicates the check succeeded. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? RamCheckFailed { get; set; }
        /// <summary>When TRUE, indicates secure boot hardware check failed for device to upgrade to the latest version of windows. When FALSE, indicates the check succeeded. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? SecureBootCheckFailed { get; set; }
        /// <summary>The serial number of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber { get; set; }
#nullable restore
#else
        public string SerialNumber { get; set; }
#endif
        /// <summary>When TRUE, indicates storage hardware check failed for device to upgrade to the latest version of windows. When FALSE, indicates the check succeeded. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? StorageCheckFailed { get; set; }
        /// <summary>When TRUE, indicates the device is Tenant Attached. When FALSE, indicates it&apos;s not Tenant Attached. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? TenantAttached { get; set; }
        /// <summary>When TRUE, indicates Trusted Platform Module (TPM) hardware check failed for device to the latest version of upgrade to windows. When FALSE, indicates the check succeeded. Supports: $select, $OrderBy. Read-only.</summary>
        public bool? TpmCheckFailed { get; set; }
        /// <summary>Work From Anywhere windows device upgrade eligibility status.</summary>
        public OperatingSystemUpgradeEligibility? UpgradeEligibility { get; set; }
        /// <summary>Indicates per device windows score. Valid values 0 to 100. Value -1 means associated score is unavailable. Supports: $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? WindowsScore { get; set; }
        /// <summary>Indicates work from anywhere per device overall score. Valid values 0 to 100. Value -1 means associated score is unavailable. Supports: $select, $OrderBy. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? WorkFromAnywhereScore { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsWorkFromAnywhereDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsWorkFromAnywhereDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"autoPilotProfileAssigned", n => { AutoPilotProfileAssigned = n.GetBoolValue(); } },
                {"autoPilotRegistered", n => { AutoPilotRegistered = n.GetBoolValue(); } },
                {"azureAdDeviceId", n => { AzureAdDeviceId = n.GetStringValue(); } },
                {"azureAdJoinType", n => { AzureAdJoinType = n.GetStringValue(); } },
                {"azureAdRegistered", n => { AzureAdRegistered = n.GetBoolValue(); } },
                {"cloudIdentityScore", n => { CloudIdentityScore = n.GetDoubleValue(); } },
                {"cloudManagementScore", n => { CloudManagementScore = n.GetDoubleValue(); } },
                {"cloudProvisioningScore", n => { CloudProvisioningScore = n.GetDoubleValue(); } },
                {"compliancePolicySetToIntune", n => { CompliancePolicySetToIntune = n.GetBoolValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"isCloudManagedGatewayEnabled", n => { IsCloudManagedGatewayEnabled = n.GetBoolValue(); } },
                {"managedBy", n => { ManagedBy = n.GetStringValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"osCheckFailed", n => { OsCheckFailed = n.GetBoolValue(); } },
                {"osDescription", n => { OsDescription = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"otherWorkloadsSetToIntune", n => { OtherWorkloadsSetToIntune = n.GetBoolValue(); } },
                {"ownership", n => { Ownership = n.GetStringValue(); } },
                {"processor64BitCheckFailed", n => { Processor64BitCheckFailed = n.GetBoolValue(); } },
                {"processorCoreCountCheckFailed", n => { ProcessorCoreCountCheckFailed = n.GetBoolValue(); } },
                {"processorFamilyCheckFailed", n => { ProcessorFamilyCheckFailed = n.GetBoolValue(); } },
                {"processorSpeedCheckFailed", n => { ProcessorSpeedCheckFailed = n.GetBoolValue(); } },
                {"ramCheckFailed", n => { RamCheckFailed = n.GetBoolValue(); } },
                {"secureBootCheckFailed", n => { SecureBootCheckFailed = n.GetBoolValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"storageCheckFailed", n => { StorageCheckFailed = n.GetBoolValue(); } },
                {"tenantAttached", n => { TenantAttached = n.GetBoolValue(); } },
                {"tpmCheckFailed", n => { TpmCheckFailed = n.GetBoolValue(); } },
                {"upgradeEligibility", n => { UpgradeEligibility = n.GetEnumValue<OperatingSystemUpgradeEligibility>(); } },
                {"windowsScore", n => { WindowsScore = n.GetDoubleValue(); } },
                {"workFromAnywhereScore", n => { WorkFromAnywhereScore = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("autoPilotProfileAssigned", AutoPilotProfileAssigned);
            writer.WriteBoolValue("autoPilotRegistered", AutoPilotRegistered);
            writer.WriteStringValue("azureAdDeviceId", AzureAdDeviceId);
            writer.WriteStringValue("azureAdJoinType", AzureAdJoinType);
            writer.WriteBoolValue("azureAdRegistered", AzureAdRegistered);
            writer.WriteDoubleValue("cloudIdentityScore", CloudIdentityScore);
            writer.WriteDoubleValue("cloudManagementScore", CloudManagementScore);
            writer.WriteDoubleValue("cloudProvisioningScore", CloudProvisioningScore);
            writer.WriteBoolValue("compliancePolicySetToIntune", CompliancePolicySetToIntune);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteEnumValue<UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteBoolValue("isCloudManagedGatewayEnabled", IsCloudManagedGatewayEnabled);
            writer.WriteStringValue("managedBy", ManagedBy);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteBoolValue("osCheckFailed", OsCheckFailed);
            writer.WriteStringValue("osDescription", OsDescription);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteBoolValue("otherWorkloadsSetToIntune", OtherWorkloadsSetToIntune);
            writer.WriteStringValue("ownership", Ownership);
            writer.WriteBoolValue("processor64BitCheckFailed", Processor64BitCheckFailed);
            writer.WriteBoolValue("processorCoreCountCheckFailed", ProcessorCoreCountCheckFailed);
            writer.WriteBoolValue("processorFamilyCheckFailed", ProcessorFamilyCheckFailed);
            writer.WriteBoolValue("processorSpeedCheckFailed", ProcessorSpeedCheckFailed);
            writer.WriteBoolValue("ramCheckFailed", RamCheckFailed);
            writer.WriteBoolValue("secureBootCheckFailed", SecureBootCheckFailed);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteBoolValue("storageCheckFailed", StorageCheckFailed);
            writer.WriteBoolValue("tenantAttached", TenantAttached);
            writer.WriteBoolValue("tpmCheckFailed", TpmCheckFailed);
            writer.WriteEnumValue<OperatingSystemUpgradeEligibility>("upgradeEligibility", UpgradeEligibility);
            writer.WriteDoubleValue("windowsScore", WindowsScore);
            writer.WriteDoubleValue("workFromAnywhereScore", WorkFromAnywhereScore);
        }
    }
}
