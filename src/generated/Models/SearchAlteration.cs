using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class SearchAlteration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Defines the altered highlighted query string with spelling correction. The annotation around the corrected segment is: /ue000, /ue001.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlteredHighlightedQueryString { get; set; }
#nullable restore
#else
        public string AlteredHighlightedQueryString { get; set; }
#endif
        /// <summary>Defines the altered query string with spelling correction.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlteredQueryString { get; set; }
#nullable restore
#else
        public string AlteredQueryString { get; set; }
#endif
        /// <summary>Represents changed segments related to an original user query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AlteredQueryToken>? AlteredQueryTokens { get; set; }
#nullable restore
#else
        public List<AlteredQueryToken> AlteredQueryTokens { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new searchAlteration and sets the default values.
        /// </summary>
        public SearchAlteration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SearchAlteration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchAlteration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alteredHighlightedQueryString", n => { AlteredHighlightedQueryString = n.GetStringValue(); } },
                {"alteredQueryString", n => { AlteredQueryString = n.GetStringValue(); } },
                {"alteredQueryTokens", n => { AlteredQueryTokens = n.GetCollectionOfObjectValues<AlteredQueryToken>(AlteredQueryToken.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("alteredHighlightedQueryString", AlteredHighlightedQueryString);
            writer.WriteStringValue("alteredQueryString", AlteredQueryString);
            writer.WriteCollectionOfObjectValues<AlteredQueryToken>("alteredQueryTokens", AlteredQueryTokens);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
