using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class OnPremisesAccidentalDeletionPrevention : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Threshold value which triggers accidental deletion prevention. The threshold is either an absolute number of objects or a percentage number of objects.</summary>
        public int? AlertThreshold { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The status of the accidental deletion prevention feature. The possible values are: disabled, enabledForCount, enabledForPercentage, unknownFutureValue.</summary>
        public OnPremisesDirectorySynchronizationDeletionPreventionType? SynchronizationPreventionType { get; set; }
        /// <summary>
        /// Instantiates a new onPremisesAccidentalDeletionPrevention and sets the default values.
        /// </summary>
        public OnPremisesAccidentalDeletionPrevention() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OnPremisesAccidentalDeletionPrevention CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesAccidentalDeletionPrevention();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alertThreshold", n => { AlertThreshold = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"synchronizationPreventionType", n => { SynchronizationPreventionType = n.GetEnumValue<OnPremisesDirectorySynchronizationDeletionPreventionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("alertThreshold", AlertThreshold);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<OnPremisesDirectorySynchronizationDeletionPreventionType>("synchronizationPreventionType", SynchronizationPreventionType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
