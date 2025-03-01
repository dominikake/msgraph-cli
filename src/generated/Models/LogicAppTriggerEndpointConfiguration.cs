using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class LogicAppTriggerEndpointConfiguration : CustomExtensionEndpointConfiguration, IParsable {
        /// <summary>The name of the logic app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LogicAppWorkflowName { get; set; }
#nullable restore
#else
        public string LogicAppWorkflowName { get; set; }
#endif
        /// <summary>The Azure resource group name for the logic app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceGroupName { get; set; }
#nullable restore
#else
        public string ResourceGroupName { get; set; }
#endif
        /// <summary>Identifier of the Azure subscription for the logic app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionId { get; set; }
#nullable restore
#else
        public string SubscriptionId { get; set; }
#endif
        /// <summary>The URL to the logic app endpoint that will be triggered. Only required for app-only token scenarios where app is creating a customCalloutExtension without a signed-in user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new LogicAppTriggerEndpointConfiguration and sets the default values.
        /// </summary>
        public LogicAppTriggerEndpointConfiguration() : base() {
            OdataType = "#microsoft.graph.logicAppTriggerEndpointConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new LogicAppTriggerEndpointConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LogicAppTriggerEndpointConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"logicAppWorkflowName", n => { LogicAppWorkflowName = n.GetStringValue(); } },
                {"resourceGroupName", n => { ResourceGroupName = n.GetStringValue(); } },
                {"subscriptionId", n => { SubscriptionId = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("logicAppWorkflowName", LogicAppWorkflowName);
            writer.WriteStringValue("resourceGroupName", ResourceGroupName);
            writer.WriteStringValue("subscriptionId", SubscriptionId);
            writer.WriteStringValue("url", Url);
        }
    }
}
