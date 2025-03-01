using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Functions.HypGeom_Dist {
    public class HypGeom_DistPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cumulative property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Cumulative { get; set; }
#nullable restore
#else
        public Json Cumulative { get; set; }
#endif
        /// <summary>The numberPop property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? NumberPop { get; set; }
#nullable restore
#else
        public Json NumberPop { get; set; }
#endif
        /// <summary>The numberSample property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? NumberSample { get; set; }
#nullable restore
#else
        public Json NumberSample { get; set; }
#endif
        /// <summary>The populationS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? PopulationS { get; set; }
#nullable restore
#else
        public Json PopulationS { get; set; }
#endif
        /// <summary>The sampleS property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? SampleS { get; set; }
#nullable restore
#else
        public Json SampleS { get; set; }
#endif
        /// <summary>
        /// Instantiates a new hypGeom_DistPostRequestBody and sets the default values.
        /// </summary>
        public HypGeom_DistPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static HypGeom_DistPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new HypGeom_DistPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cumulative", n => { Cumulative = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"numberPop", n => { NumberPop = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"numberSample", n => { NumberSample = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"populationS", n => { PopulationS = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"sampleS", n => { SampleS = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("cumulative", Cumulative);
            writer.WriteObjectValue<Json>("numberPop", NumberPop);
            writer.WriteObjectValue<Json>("numberSample", NumberSample);
            writer.WriteObjectValue<Json>("populationS", PopulationS);
            writer.WriteObjectValue<Json>("sampleS", SampleS);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
