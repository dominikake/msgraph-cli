using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Functions.SeriesSum {
    public class SeriesSumPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The coefficients property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Coefficients { get; set; }
#nullable restore
#else
        public Json Coefficients { get; set; }
#endif
        /// <summary>The m property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? M { get; set; }
#nullable restore
#else
        public Json M { get; set; }
#endif
        /// <summary>The n property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? N { get; set; }
#nullable restore
#else
        public Json N { get; set; }
#endif
        /// <summary>The x property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? X { get; set; }
#nullable restore
#else
        public Json X { get; set; }
#endif
        /// <summary>
        /// Instantiates a new seriesSumPostRequestBody and sets the default values.
        /// </summary>
        public SeriesSumPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SeriesSumPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SeriesSumPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"coefficients", n => { Coefficients = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"m", n => { M = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"n", n => { N = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"x", n => { X = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("coefficients", Coefficients);
            writer.WriteObjectValue<Json>("m", M);
            writer.WriteObjectValue<Json>("n", N);
            writer.WriteObjectValue<Json>("x", X);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
