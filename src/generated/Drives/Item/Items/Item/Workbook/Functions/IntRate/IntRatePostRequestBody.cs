using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Functions.IntRate {
    public class IntRatePostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The basis property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Basis { get; set; }
#nullable restore
#else
        public Json Basis { get; set; }
#endif
        /// <summary>The investment property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Investment { get; set; }
#nullable restore
#else
        public Json Investment { get; set; }
#endif
        /// <summary>The maturity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Maturity { get; set; }
#nullable restore
#else
        public Json Maturity { get; set; }
#endif
        /// <summary>The redemption property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Redemption { get; set; }
#nullable restore
#else
        public Json Redemption { get; set; }
#endif
        /// <summary>The settlement property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Settlement { get; set; }
#nullable restore
#else
        public Json Settlement { get; set; }
#endif
        /// <summary>
        /// Instantiates a new intRatePostRequestBody and sets the default values.
        /// </summary>
        public IntRatePostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IntRatePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IntRatePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"basis", n => { Basis = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"investment", n => { Investment = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"maturity", n => { Maturity = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"redemption", n => { Redemption = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"settlement", n => { Settlement = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("basis", Basis);
            writer.WriteObjectValue<Json>("investment", Investment);
            writer.WriteObjectValue<Json>("maturity", Maturity);
            writer.WriteObjectValue<Json>("redemption", Redemption);
            writer.WriteObjectValue<Json>("settlement", Settlement);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
