using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.ExternalConnectors {
    public class PropertyRule : IAdditionalDataHolder, IParsable {
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
        /// <summary>The operation property</summary>
        public RuleOperation? Operation { get; set; }
        /// <summary>The property from the externalItem schema. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Property { get; set; }
#nullable restore
#else
        public string Property { get; set; }
#endif
        /// <summary>A collection with one or many strings. The specified string(s) will be matched with the specified property using the specified operation. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Values { get; set; }
#nullable restore
#else
        public List<string> Values { get; set; }
#endif
        /// <summary>The valuesJoinedBy property</summary>
        public BinaryOperator? ValuesJoinedBy { get; set; }
        /// <summary>
        /// Instantiates a new propertyRule and sets the default values.
        /// </summary>
        public PropertyRule() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PropertyRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PropertyRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operation", n => { Operation = n.GetEnumValue<RuleOperation>(); } },
                {"property", n => { Property = n.GetStringValue(); } },
                {"values", n => { Values = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"valuesJoinedBy", n => { ValuesJoinedBy = n.GetEnumValue<BinaryOperator>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<RuleOperation>("operation", Operation);
            writer.WriteStringValue("property", Property);
            writer.WriteCollectionOfPrimitiveValues<string>("values", Values);
            writer.WriteEnumValue<BinaryOperator>("valuesJoinedBy", ValuesJoinedBy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
