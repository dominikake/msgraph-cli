using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class SynchronizationProgress : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The completedUnits property</summary>
        public long? CompletedUnits { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The progressObservationDateTime property</summary>
        public DateTimeOffset? ProgressObservationDateTime { get; set; }
        /// <summary>The totalUnits property</summary>
        public long? TotalUnits { get; set; }
        /// <summary>The units property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Units { get; set; }
#nullable restore
#else
        public string Units { get; set; }
#endif
        /// <summary>
        /// Instantiates a new synchronizationProgress and sets the default values.
        /// </summary>
        public SynchronizationProgress() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SynchronizationProgress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationProgress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"completedUnits", n => { CompletedUnits = n.GetLongValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"progressObservationDateTime", n => { ProgressObservationDateTime = n.GetDateTimeOffsetValue(); } },
                {"totalUnits", n => { TotalUnits = n.GetLongValue(); } },
                {"units", n => { Units = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("completedUnits", CompletedUnits);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("progressObservationDateTime", ProgressObservationDateTime);
            writer.WriteLongValue("totalUnits", TotalUnits);
            writer.WriteStringValue("units", Units);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
