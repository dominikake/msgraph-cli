using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ParseExpressionResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The error property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PublicError? Error { get; set; }
#nullable restore
#else
        public PublicError Error { get; set; }
#endif
        /// <summary>The evaluationResult property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EvaluationResult { get; set; }
#nullable restore
#else
        public List<string> EvaluationResult { get; set; }
#endif
        /// <summary>The evaluationSucceeded property</summary>
        public bool? EvaluationSucceeded { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The parsedExpression property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AttributeMappingSource? ParsedExpression { get; set; }
#nullable restore
#else
        public AttributeMappingSource ParsedExpression { get; set; }
#endif
        /// <summary>The parsingSucceeded property</summary>
        public bool? ParsingSucceeded { get; set; }
        /// <summary>
        /// Instantiates a new parseExpressionResponse and sets the default values.
        /// </summary>
        public ParseExpressionResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ParseExpressionResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ParseExpressionResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"error", n => { Error = n.GetObjectValue<PublicError>(PublicError.CreateFromDiscriminatorValue); } },
                {"evaluationResult", n => { EvaluationResult = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"evaluationSucceeded", n => { EvaluationSucceeded = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"parsedExpression", n => { ParsedExpression = n.GetObjectValue<AttributeMappingSource>(AttributeMappingSource.CreateFromDiscriminatorValue); } },
                {"parsingSucceeded", n => { ParsingSucceeded = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PublicError>("error", Error);
            writer.WriteCollectionOfPrimitiveValues<string>("evaluationResult", EvaluationResult);
            writer.WriteBoolValue("evaluationSucceeded", EvaluationSucceeded);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<AttributeMappingSource>("parsedExpression", ParsedExpression);
            writer.WriteBoolValue("parsingSucceeded", ParsingSucceeded);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
