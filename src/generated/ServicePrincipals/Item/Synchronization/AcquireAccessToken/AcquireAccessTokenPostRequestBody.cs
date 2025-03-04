using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.ServicePrincipals.Item.Synchronization.AcquireAccessToken {
    public class AcquireAccessTokenPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The credentials property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SynchronizationSecretKeyStringValuePair>? Credentials { get; set; }
#nullable restore
#else
        public List<SynchronizationSecretKeyStringValuePair> Credentials { get; set; }
#endif
        /// <summary>
        /// Instantiates a new acquireAccessTokenPostRequestBody and sets the default values.
        /// </summary>
        public AcquireAccessTokenPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AcquireAccessTokenPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AcquireAccessTokenPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"credentials", n => { Credentials = n.GetCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>(SynchronizationSecretKeyStringValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>("credentials", Credentials);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
