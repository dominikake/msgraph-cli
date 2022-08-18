using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class WindowsInformationProtectionAppLearningSummaryCollectionResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataNextLink property</summary>
        public string OdataNextLink { get; set; }
        /// <summary>The value property</summary>
        public List<WindowsInformationProtectionAppLearningSummary> Value { get; set; }
        /// <summary>
        /// Instantiates a new WindowsInformationProtectionAppLearningSummaryCollectionResponse and sets the default values.
        /// </summary>
        public WindowsInformationProtectionAppLearningSummaryCollectionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WindowsInformationProtectionAppLearningSummaryCollectionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionAppLearningSummaryCollectionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.nextLink", n => { OdataNextLink = n.GetStringValue(); } },
                {"value", n => { Value = n.GetCollectionOfObjectValues<WindowsInformationProtectionAppLearningSummary>(WindowsInformationProtectionAppLearningSummary.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", OdataNextLink);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionAppLearningSummary>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
