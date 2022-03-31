using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class ResourceSpecificPermission : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Describes the level of access that the resource-specific permission represents.</summary>
        public string Description { get; set; }
        /// <summary>The display name for the resource-specific permission.</summary>
        public string DisplayName { get; set; }
        /// <summary>The unique identifier for the resource-specific application permission.</summary>
        public string Id { get; set; }
        /// <summary>Indicates whether the permission is enabled.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>The value of the permission.</summary>
        public string Value { get; set; }
        /// <summary>
        /// Instantiates a new resourceSpecificPermission and sets the default values.
        /// </summary>
        public ResourceSpecificPermission() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.ResourceSpecificPermission CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ResourceSpecificPermission();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"description", (o,n) => { (o as ResourceSpecificPermission).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ResourceSpecificPermission).DisplayName = n.GetStringValue(); } },
                {"id", (o,n) => { (o as ResourceSpecificPermission).Id = n.GetStringValue(); } },
                {"isEnabled", (o,n) => { (o as ResourceSpecificPermission).IsEnabled = n.GetBoolValue(); } },
                {"value", (o,n) => { (o as ResourceSpecificPermission).Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
