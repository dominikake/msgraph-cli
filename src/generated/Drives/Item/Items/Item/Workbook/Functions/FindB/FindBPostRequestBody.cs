using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Drives.Item.Items.Item.Workbook.Functions.FindB {
    public class FindBPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The findText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? FindText { get; set; }
#nullable restore
#else
        public Json FindText { get; set; }
#endif
        /// <summary>The startNum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? StartNum { get; set; }
#nullable restore
#else
        public Json StartNum { get; set; }
#endif
        /// <summary>The withinText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? WithinText { get; set; }
#nullable restore
#else
        public Json WithinText { get; set; }
#endif
        /// <summary>
        /// Instantiates a new findBPostRequestBody and sets the default values.
        /// </summary>
        public FindBPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FindBPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FindBPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"findText", n => { FindText = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"startNum", n => { StartNum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"withinText", n => { WithinText = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("findText", FindText);
            writer.WriteObjectValue<Json>("startNum", StartNum);
            writer.WriteObjectValue<Json>("withinText", WithinText);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
