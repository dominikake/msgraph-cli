using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Drives.Item.Items.Item.AssignSensitivityLabel {
    public class AssignSensitivityLabelPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The assignmentMethod property</summary>
        public SensitivityLabelAssignmentMethod? AssignmentMethod { get; set; }
        /// <summary>The justificationText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JustificationText { get; set; }
#nullable restore
#else
        public string JustificationText { get; set; }
#endif
        /// <summary>The sensitivityLabelId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SensitivityLabelId { get; set; }
#nullable restore
#else
        public string SensitivityLabelId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new assignSensitivityLabelPostRequestBody and sets the default values.
        /// </summary>
        public AssignSensitivityLabelPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AssignSensitivityLabelPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AssignSensitivityLabelPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignmentMethod", n => { AssignmentMethod = n.GetEnumValue<SensitivityLabelAssignmentMethod>(); } },
                {"justificationText", n => { JustificationText = n.GetStringValue(); } },
                {"sensitivityLabelId", n => { SensitivityLabelId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<SensitivityLabelAssignmentMethod>("assignmentMethod", AssignmentMethod);
            writer.WriteStringValue("justificationText", JustificationText);
            writer.WriteStringValue("sensitivityLabelId", SensitivityLabelId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
