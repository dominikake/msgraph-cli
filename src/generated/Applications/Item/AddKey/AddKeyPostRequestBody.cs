using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Applications.Item.AddKey {
    public class AddKeyPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The keyCredential property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.KeyCredential? KeyCredential { get; set; }
#nullable restore
#else
        public ApiSdk.Models.KeyCredential KeyCredential { get; set; }
#endif
        /// <summary>The passwordCredential property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.PasswordCredential? PasswordCredential { get; set; }
#nullable restore
#else
        public ApiSdk.Models.PasswordCredential PasswordCredential { get; set; }
#endif
        /// <summary>The proof property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Proof { get; set; }
#nullable restore
#else
        public string Proof { get; set; }
#endif
        /// <summary>
        /// Instantiates a new addKeyPostRequestBody and sets the default values.
        /// </summary>
        public AddKeyPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AddKeyPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddKeyPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"keyCredential", n => { KeyCredential = n.GetObjectValue<ApiSdk.Models.KeyCredential>(ApiSdk.Models.KeyCredential.CreateFromDiscriminatorValue); } },
                {"passwordCredential", n => { PasswordCredential = n.GetObjectValue<ApiSdk.Models.PasswordCredential>(ApiSdk.Models.PasswordCredential.CreateFromDiscriminatorValue); } },
                {"proof", n => { Proof = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.KeyCredential>("keyCredential", KeyCredential);
            writer.WriteObjectValue<ApiSdk.Models.PasswordCredential>("passwordCredential", PasswordCredential);
            writer.WriteStringValue("proof", Proof);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
