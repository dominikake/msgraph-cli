using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class UpdateAllowedCombinationsResult : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Information about why the updateAllowedCombinations action was successful or failed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalInformation { get; set; }
#nullable restore
#else
        public string AdditionalInformation { get; set; }
#endif
        /// <summary>References to existing Conditional Access policies that use this authentication strength.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ConditionalAccessReferences { get; set; }
#nullable restore
#else
        public List<string> ConditionalAccessReferences { get; set; }
#endif
        /// <summary>The list of current authentication method combinations allowed by the authentication strength.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationMethodModes?>? CurrentCombinations { get; set; }
#nullable restore
#else
        public List<AuthenticationMethodModes?> CurrentCombinations { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The list of former authentication method combinations allowed by the authentication strength before they were updated through the updateAllowedCombinations action.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationMethodModes?>? PreviousCombinations { get; set; }
#nullable restore
#else
        public List<AuthenticationMethodModes?> PreviousCombinations { get; set; }
#endif
        /// <summary>
        /// Instantiates a new updateAllowedCombinationsResult and sets the default values.
        /// </summary>
        public UpdateAllowedCombinationsResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UpdateAllowedCombinationsResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateAllowedCombinationsResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"additionalInformation", n => { AdditionalInformation = n.GetStringValue(); } },
                {"conditionalAccessReferences", n => { ConditionalAccessReferences = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"currentCombinations", n => { CurrentCombinations = n.GetCollectionOfEnumValues<AuthenticationMethodModes>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"previousCombinations", n => { PreviousCombinations = n.GetCollectionOfEnumValues<AuthenticationMethodModes>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("additionalInformation", AdditionalInformation);
            writer.WriteCollectionOfPrimitiveValues<string>("conditionalAccessReferences", ConditionalAccessReferences);
            writer.WriteCollectionOfEnumValues<AuthenticationMethodModes>("currentCombinations", CurrentCombinations);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfEnumValues<AuthenticationMethodModes>("previousCombinations", PreviousCombinations);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
