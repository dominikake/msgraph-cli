using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// The user experience analytics device scores entity consolidates the various Endpoint Analytics scores.
    /// </summary>
    public class UserExperienceAnalyticsDeviceScores : Entity, IParsable {
        /// <summary>Indicates a score calculated from application health data to indicate when a device is having problems running one or more applications. Valid values range from 0-100. Value -1 means associated score is unavailable. A higher score indicates a healthier device. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? AppReliabilityScore { get; set; }
        /// <summary>Indicates a calulated score indicating the health of the device&apos;s battery. Valid values range from 0-100. Value -1 means associated score is unavailable. A higher score indicates a healthier device. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? BatteryHealthScore { get; set; }
        /// <summary>The name of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; set; }
#nullable restore
#else
        public string DeviceName { get; set; }
#endif
        /// <summary>Indicates a weighted average of the various scores. Valid values range from 0-100. Value -1 means associated score is unavailable. A higher score indicates a healthier device. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? EndpointAnalyticsScore { get; set; }
        /// <summary>The healthStatus property</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
        /// <summary>The manufacturer name of the device. Examples: Microsoft Corporation, HP, Lenovo. Supports: $select, $OrderBy. Read-only.</summary>
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
        /// <summary>Indicates a weighted average of boot score and logon score used for measuring startup performance. Valid values range from 0-100. Value -1 means associated score is unavailable. A higher score indicates a healthier device. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? StartupPerformanceScore { get; set; }
        /// <summary>Indicates a weighted score of the work from anywhere on a device level. Valid values range from 0-100. Value -1 means associated score is unavailable. A higher score indicates a healthier device. Read-only. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? WorkFromAnywhereScore { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsDeviceScores CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsDeviceScores();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appReliabilityScore", n => { AppReliabilityScore = n.GetDoubleValue(); } },
                {"batteryHealthScore", n => { BatteryHealthScore = n.GetDoubleValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"endpointAnalyticsScore", n => { EndpointAnalyticsScore = n.GetDoubleValue(); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"startupPerformanceScore", n => { StartupPerformanceScore = n.GetDoubleValue(); } },
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
            writer.WriteDoubleValue("appReliabilityScore", AppReliabilityScore);
            writer.WriteDoubleValue("batteryHealthScore", BatteryHealthScore);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteDoubleValue("endpointAnalyticsScore", EndpointAnalyticsScore);
            writer.WriteEnumValue<UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteDoubleValue("startupPerformanceScore", StartupPerformanceScore);
            writer.WriteDoubleValue("workFromAnywhereScore", WorkFromAnywhereScore);
        }
    }
}
