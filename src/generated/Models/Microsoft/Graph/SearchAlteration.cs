using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class SearchAlteration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Defines the altered highlighted query string with spelling correction. The annotation around the corrected segment is: /ue000, /ue001.</summary>
        public string AlteredHighlightedQueryString { get; set; }
        /// <summary>Defines the altered query string with spelling correction.</summary>
        public string AlteredQueryString { get; set; }
        /// <summary>Represents changed segments related to an original user query.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AlteredQueryToken> AlteredQueryTokens { get; set; }
        /// <summary>
        /// Instantiates a new searchAlteration and sets the default values.
        /// </summary>
        public SearchAlteration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.SearchAlteration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchAlteration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"alteredHighlightedQueryString", (o,n) => { (o as SearchAlteration).AlteredHighlightedQueryString = n.GetStringValue(); } },
                {"alteredQueryString", (o,n) => { (o as SearchAlteration).AlteredQueryString = n.GetStringValue(); } },
                {"alteredQueryTokens", (o,n) => { (o as SearchAlteration).AlteredQueryTokens = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AlteredQueryToken>(ApiSdk.Models.Microsoft.Graph.AlteredQueryToken.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("alteredHighlightedQueryString", AlteredHighlightedQueryString);
            writer.WriteStringValue("alteredQueryString", AlteredQueryString);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AlteredQueryToken>("alteredQueryTokens", AlteredQueryTokens);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
