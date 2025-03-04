using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class SearchResponse : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A collection of search results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SearchHitsContainer>? HitsContainers { get; set; }
#nullable restore
#else
        public List<SearchHitsContainer> HitsContainers { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Provides information related to spelling corrections in the alteration response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AlterationResponse? QueryAlterationResponse { get; set; }
#nullable restore
#else
        public AlterationResponse QueryAlterationResponse { get; set; }
#endif
        /// <summary>A dictionary of resultTemplateIds and associated values, which include the name and JSON schema of the result templates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ResultTemplateDictionary? ResultTemplates { get; set; }
#nullable restore
#else
        public ResultTemplateDictionary ResultTemplates { get; set; }
#endif
        /// <summary>Contains the search terms sent in the initial search query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SearchTerms { get; set; }
#nullable restore
#else
        public List<string> SearchTerms { get; set; }
#endif
        /// <summary>
        /// Instantiates a new SearchResponse and sets the default values.
        /// </summary>
        public SearchResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SearchResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hitsContainers", n => { HitsContainers = n.GetCollectionOfObjectValues<SearchHitsContainer>(SearchHitsContainer.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"queryAlterationResponse", n => { QueryAlterationResponse = n.GetObjectValue<AlterationResponse>(AlterationResponse.CreateFromDiscriminatorValue); } },
                {"resultTemplates", n => { ResultTemplates = n.GetObjectValue<ResultTemplateDictionary>(ResultTemplateDictionary.CreateFromDiscriminatorValue); } },
                {"searchTerms", n => { SearchTerms = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SearchHitsContainer>("hitsContainers", HitsContainers);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<AlterationResponse>("queryAlterationResponse", QueryAlterationResponse);
            writer.WriteObjectValue<ResultTemplateDictionary>("resultTemplates", ResultTemplates);
            writer.WriteCollectionOfPrimitiveValues<string>("searchTerms", SearchTerms);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
