using ApiSdk.Models.IdentityGovernance;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class CustomCalloutExtension : Entity, IParsable {
        /// <summary>Configuration for securing the API call to the logic app. For example, using OAuth client credentials flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomExtensionAuthenticationConfiguration? AuthenticationConfiguration { get; set; }
#nullable restore
#else
        public CustomExtensionAuthenticationConfiguration AuthenticationConfiguration { get; set; }
#endif
        /// <summary>HTTP connection settings that define how long Azure AD can wait for a connection to a logic app, how many times you can retry a timed-out connection and the exception scenarios when retries are allowed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomExtensionClientConfiguration? ClientConfiguration { get; set; }
#nullable restore
#else
        public CustomExtensionClientConfiguration ClientConfiguration { get; set; }
#endif
        /// <summary>Description for the customCalloutExtension object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Display name for the customCalloutExtension object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The type and details for configuring the endpoint to call the logic app&apos;s workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomExtensionEndpointConfiguration? EndpointConfiguration { get; set; }
#nullable restore
#else
        public CustomExtensionEndpointConfiguration EndpointConfiguration { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomCalloutExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.identityGovernance.customTaskExtension" => new CustomTaskExtension(),
                _ => new CustomCalloutExtension(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationConfiguration", n => { AuthenticationConfiguration = n.GetObjectValue<CustomExtensionAuthenticationConfiguration>(CustomExtensionAuthenticationConfiguration.CreateFromDiscriminatorValue); } },
                {"clientConfiguration", n => { ClientConfiguration = n.GetObjectValue<CustomExtensionClientConfiguration>(CustomExtensionClientConfiguration.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"endpointConfiguration", n => { EndpointConfiguration = n.GetObjectValue<CustomExtensionEndpointConfiguration>(CustomExtensionEndpointConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<CustomExtensionAuthenticationConfiguration>("authenticationConfiguration", AuthenticationConfiguration);
            writer.WriteObjectValue<CustomExtensionClientConfiguration>("clientConfiguration", ClientConfiguration);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<CustomExtensionEndpointConfiguration>("endpointConfiguration", EndpointConfiguration);
        }
    }
}
