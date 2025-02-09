using ApiSdk.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Security.Cases.EdiscoveryCases.Item.ReviewSets.Item.MicrosoftGraphSecurityAddToReviewSet {
    public class AddToReviewSetPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The additionalDataOptions property</summary>
        public ApiSdk.Models.Security.AdditionalDataOptions? AdditionalDataOptions { get; set; }
        /// <summary>The search property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EdiscoverySearch? Search { get; set; }
#nullable restore
#else
        public EdiscoverySearch Search { get; set; }
#endif
        /// <summary>
        /// Instantiates a new addToReviewSetPostRequestBody and sets the default values.
        /// </summary>
        public AddToReviewSetPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AddToReviewSetPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddToReviewSetPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"additionalDataOptions", n => { AdditionalDataOptions = n.GetEnumValue<AdditionalDataOptions>(); } },
                {"search", n => { Search = n.GetObjectValue<EdiscoverySearch>(EdiscoverySearch.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AdditionalDataOptions>("additionalDataOptions", AdditionalDataOptions);
            writer.WriteObjectValue<EdiscoverySearch>("search", Search);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
