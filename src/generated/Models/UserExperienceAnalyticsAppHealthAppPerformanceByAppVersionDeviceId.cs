using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// The user experience analytics application performance entity contains application performance by application version device id.
    /// </summary>
    public class UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId : Entity, IParsable {
        /// <summary>The number of crashes for the app. Valid values -2147483648 to 2147483647</summary>
        public int? AppCrashCount { get; set; }
        /// <summary>The friendly name of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppDisplayName { get; set; }
#nullable restore
#else
        public string AppDisplayName { get; set; }
#endif
        /// <summary>The name of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppName { get; set; }
#nullable restore
#else
        public string AppName { get; set; }
#endif
        /// <summary>The publisher of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppPublisher { get; set; }
#nullable restore
#else
        public string AppPublisher { get; set; }
#endif
        /// <summary>The version of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppVersion { get; set; }
#nullable restore
#else
        public string AppVersion { get; set; }
#endif
        /// <summary>The name of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceDisplayName { get; set; }
#nullable restore
#else
        public string DeviceDisplayName { get; set; }
#endif
        /// <summary>The Intune device id of the device. Supports: $select, $OrderBy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>The date and time when the statistics were last computed. The value cannot be modified and is automatically populated when the statistics are computed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2022 would look like this: &apos;2022-01-01T00:00:00Z&apos;. Returned by default. Read-only.</summary>
        public DateTimeOffset? ProcessedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appCrashCount", n => { AppCrashCount = n.GetIntValue(); } },
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appName", n => { AppName = n.GetStringValue(); } },
                {"appPublisher", n => { AppPublisher = n.GetStringValue(); } },
                {"appVersion", n => { AppVersion = n.GetStringValue(); } },
                {"deviceDisplayName", n => { DeviceDisplayName = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"processedDateTime", n => { ProcessedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("appCrashCount", AppCrashCount);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appName", AppName);
            writer.WriteStringValue("appPublisher", AppPublisher);
            writer.WriteStringValue("appVersion", AppVersion);
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteDateTimeOffsetValue("processedDateTime", ProcessedDateTime);
        }
    }
}
