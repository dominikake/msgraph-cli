using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class FilterClause : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The operatorName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatorName { get; set; }
#nullable restore
#else
        public string OperatorName { get; set; }
#endif
        /// <summary>The sourceOperandName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceOperandName { get; set; }
#nullable restore
#else
        public string SourceOperandName { get; set; }
#endif
        /// <summary>The targetOperand property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FilterOperand? TargetOperand { get; set; }
#nullable restore
#else
        public FilterOperand TargetOperand { get; set; }
#endif
        /// <summary>
        /// Instantiates a new filterClause and sets the default values.
        /// </summary>
        public FilterClause() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FilterClause CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FilterClause();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operatorName", n => { OperatorName = n.GetStringValue(); } },
                {"sourceOperandName", n => { SourceOperandName = n.GetStringValue(); } },
                {"targetOperand", n => { TargetOperand = n.GetObjectValue<FilterOperand>(FilterOperand.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("operatorName", OperatorName);
            writer.WriteStringValue("sourceOperandName", SourceOperandName);
            writer.WriteObjectValue<FilterOperand>("targetOperand", TargetOperand);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
