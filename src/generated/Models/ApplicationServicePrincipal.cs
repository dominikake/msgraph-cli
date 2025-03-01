using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ApplicationServicePrincipal : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The application property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Application? Application { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Application Application { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The servicePrincipal property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ServicePrincipal? ServicePrincipal { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ServicePrincipal ServicePrincipal { get; set; }
#endif
        /// <summary>
        /// Instantiates a new applicationServicePrincipal and sets the default values.
        /// </summary>
        public ApplicationServicePrincipal() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApplicationServicePrincipal CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplicationServicePrincipal();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"application", n => { Application = n.GetObjectValue<ApiSdk.Models.Application>(ApiSdk.Models.Application.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"servicePrincipal", n => { ServicePrincipal = n.GetObjectValue<ApiSdk.Models.ServicePrincipal>(ApiSdk.Models.ServicePrincipal.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.Application>("application", Application);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<ApiSdk.Models.ServicePrincipal>("servicePrincipal", ServicePrincipal);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
