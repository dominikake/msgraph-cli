using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class TeleconferenceDeviceQuality : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A unique identifier for all  the participant calls in a conference or a unique identifier for two participant calls in P2P call. This needs to be copied over from Microsoft.Graph.Call.CallChainId.</summary>
        public Guid? CallChainId { get; set; }
        /// <summary>A geo-region where the service is deployed, such as ProdNoam.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloudServiceDeploymentEnvironment { get; set; }
#nullable restore
#else
        public string CloudServiceDeploymentEnvironment { get; set; }
#endif
        /// <summary>A unique deployment identifier assigned by Azure.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloudServiceDeploymentId { get; set; }
#nullable restore
#else
        public string CloudServiceDeploymentId { get; set; }
#endif
        /// <summary>The Azure deployed cloud service instance name, such as FrontEnd_IN_3.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloudServiceInstanceName { get; set; }
#nullable restore
#else
        public string CloudServiceInstanceName { get; set; }
#endif
        /// <summary>The Azure deployed cloud service name, such as contoso.cloudapp.net.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CloudServiceName { get; set; }
#nullable restore
#else
        public string CloudServiceName { get; set; }
#endif
        /// <summary>Any additional description, such as VTC Bldg 30/21.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceDescription { get; set; }
#nullable restore
#else
        public string DeviceDescription { get; set; }
#endif
        /// <summary>The user media agent name, such as Cisco SX80.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; set; }
#nullable restore
#else
        public string DeviceName { get; set; }
#endif
        /// <summary>A unique identifier for a specific media leg of a participant in a conference.  One participant can have multiple media leg identifiers if retargeting happens. CVI partner assigns this value.</summary>
        public Guid? MediaLegId { get; set; }
        /// <summary>The list of media qualities in a media session (call), such as audio quality, video quality, and/or screen sharing quality.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeleconferenceDeviceMediaQuality>? MediaQualityList { get; set; }
#nullable restore
#else
        public List<TeleconferenceDeviceMediaQuality> MediaQualityList { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>A unique identifier for a specific participant in a conference. The CVI partner needs to copy over Call.MyParticipantId to this property.</summary>
        public Guid? ParticipantId { get; set; }
        /// <summary>
        /// Instantiates a new TeleconferenceDeviceQuality and sets the default values.
        /// </summary>
        public TeleconferenceDeviceQuality() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeleconferenceDeviceQuality CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeleconferenceDeviceQuality();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"callChainId", n => { CallChainId = n.GetGuidValue(); } },
                {"cloudServiceDeploymentEnvironment", n => { CloudServiceDeploymentEnvironment = n.GetStringValue(); } },
                {"cloudServiceDeploymentId", n => { CloudServiceDeploymentId = n.GetStringValue(); } },
                {"cloudServiceInstanceName", n => { CloudServiceInstanceName = n.GetStringValue(); } },
                {"cloudServiceName", n => { CloudServiceName = n.GetStringValue(); } },
                {"deviceDescription", n => { DeviceDescription = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"mediaLegId", n => { MediaLegId = n.GetGuidValue(); } },
                {"mediaQualityList", n => { MediaQualityList = n.GetCollectionOfObjectValues<TeleconferenceDeviceMediaQuality>(TeleconferenceDeviceMediaQuality.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"participantId", n => { ParticipantId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("callChainId", CallChainId);
            writer.WriteStringValue("cloudServiceDeploymentEnvironment", CloudServiceDeploymentEnvironment);
            writer.WriteStringValue("cloudServiceDeploymentId", CloudServiceDeploymentId);
            writer.WriteStringValue("cloudServiceInstanceName", CloudServiceInstanceName);
            writer.WriteStringValue("cloudServiceName", CloudServiceName);
            writer.WriteStringValue("deviceDescription", DeviceDescription);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteGuidValue("mediaLegId", MediaLegId);
            writer.WriteCollectionOfObjectValues<TeleconferenceDeviceMediaQuality>("mediaQualityList", MediaQualityList);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteGuidValue("participantId", ParticipantId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
