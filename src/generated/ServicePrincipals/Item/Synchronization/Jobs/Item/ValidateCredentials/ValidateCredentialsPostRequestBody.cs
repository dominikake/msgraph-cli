using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.ServicePrincipals.Item.Synchronization.Jobs.Item.ValidateCredentials {
    public class ValidateCredentialsPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The applicationIdentifier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationIdentifier { get; set; }
#nullable restore
#else
        public string ApplicationIdentifier { get; set; }
#endif
        /// <summary>The credentials property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SynchronizationSecretKeyStringValuePair>? Credentials { get; set; }
#nullable restore
#else
        public List<SynchronizationSecretKeyStringValuePair> Credentials { get; set; }
#endif
        /// <summary>The templateId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TemplateId { get; set; }
#nullable restore
#else
        public string TemplateId { get; set; }
#endif
        /// <summary>The useSavedCredentials property</summary>
        public bool? UseSavedCredentials { get; set; }
        /// <summary>
        /// Instantiates a new validateCredentialsPostRequestBody and sets the default values.
        /// </summary>
        public ValidateCredentialsPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ValidateCredentialsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ValidateCredentialsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicationIdentifier", n => { ApplicationIdentifier = n.GetStringValue(); } },
                {"credentials", n => { Credentials = n.GetCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>(SynchronizationSecretKeyStringValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"templateId", n => { TemplateId = n.GetStringValue(); } },
                {"useSavedCredentials", n => { UseSavedCredentials = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("applicationIdentifier", ApplicationIdentifier);
            writer.WriteCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>("credentials", Credentials);
            writer.WriteStringValue("templateId", TemplateId);
            writer.WriteBoolValue("useSavedCredentials", UseSavedCredentials);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
