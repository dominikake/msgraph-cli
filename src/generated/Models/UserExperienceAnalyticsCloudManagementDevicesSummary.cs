using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// The user experience work from anywhere Cloud management devices summary.
    /// </summary>
    public class UserExperienceAnalyticsCloudManagementDevicesSummary : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Total number of  co-managed devices. Read-only.</summary>
        public int? CoManagedDeviceCount { get; set; }
        /// <summary>The count of intune devices that are not autopilot registerd. Read-only.</summary>
        public int? IntuneDeviceCount { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Total count of tenant attach devices. Read-only.</summary>
        public int? TenantAttachDeviceCount { get; set; }
        /// <summary>
        /// Instantiates a new userExperienceAnalyticsCloudManagementDevicesSummary and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsCloudManagementDevicesSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserExperienceAnalyticsCloudManagementDevicesSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsCloudManagementDevicesSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"coManagedDeviceCount", n => { CoManagedDeviceCount = n.GetIntValue(); } },
                {"intuneDeviceCount", n => { IntuneDeviceCount = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"tenantAttachDeviceCount", n => { TenantAttachDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("coManagedDeviceCount", CoManagedDeviceCount);
            writer.WriteIntValue("intuneDeviceCount", IntuneDeviceCount);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("tenantAttachDeviceCount", TenantAttachDeviceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
