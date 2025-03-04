using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.DirectoryRoles.ValidateProperties {
    public class ValidatePropertiesPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The entityType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EntityType { get; set; }
#nullable restore
#else
        public string EntityType { get; set; }
#endif
        /// <summary>The mailNickname property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MailNickname { get; set; }
#nullable restore
#else
        public string MailNickname { get; set; }
#endif
        /// <summary>The onBehalfOfUserId property</summary>
        public Guid? OnBehalfOfUserId { get; set; }
        /// <summary>
        /// Instantiates a new validatePropertiesPostRequestBody and sets the default values.
        /// </summary>
        public ValidatePropertiesPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ValidatePropertiesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ValidatePropertiesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"entityType", n => { EntityType = n.GetStringValue(); } },
                {"mailNickname", n => { MailNickname = n.GetStringValue(); } },
                {"onBehalfOfUserId", n => { OnBehalfOfUserId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("entityType", EntityType);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteGuidValue("onBehalfOfUserId", OnBehalfOfUserId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
