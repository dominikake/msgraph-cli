using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.IdentityGovernance {
    public class LifecycleWorkflowsContainer : Entity, IParsable {
        /// <summary>The customTaskExtension instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomTaskExtension>? CustomTaskExtensions { get; set; }
#nullable restore
#else
        public List<CustomTaskExtension> CustomTaskExtensions { get; set; }
#endif
        /// <summary>Deleted workflows in your lifecycle workflows instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.DeletedItemContainer? DeletedItems { get; set; }
#nullable restore
#else
        public ApiSdk.Models.DeletedItemContainer DeletedItems { get; set; }
#endif
        /// <summary>The settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LifecycleManagementSettings? Settings { get; set; }
#nullable restore
#else
        public LifecycleManagementSettings Settings { get; set; }
#endif
        /// <summary>The definition of tasks within the lifecycle workflows instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TaskDefinition>? TaskDefinitions { get; set; }
#nullable restore
#else
        public List<TaskDefinition> TaskDefinitions { get; set; }
#endif
        /// <summary>The workflows in the lifecycle workflows instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Workflow>? Workflows { get; set; }
#nullable restore
#else
        public List<Workflow> Workflows { get; set; }
#endif
        /// <summary>The workflow templates in the lifecycle workflow instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkflowTemplate>? WorkflowTemplates { get; set; }
#nullable restore
#else
        public List<WorkflowTemplate> WorkflowTemplates { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new LifecycleWorkflowsContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LifecycleWorkflowsContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customTaskExtensions", n => { CustomTaskExtensions = n.GetCollectionOfObjectValues<CustomTaskExtension>(CustomTaskExtension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deletedItems", n => { DeletedItems = n.GetObjectValue<ApiSdk.Models.DeletedItemContainer>(ApiSdk.Models.DeletedItemContainer.CreateFromDiscriminatorValue); } },
                {"settings", n => { Settings = n.GetObjectValue<LifecycleManagementSettings>(LifecycleManagementSettings.CreateFromDiscriminatorValue); } },
                {"taskDefinitions", n => { TaskDefinitions = n.GetCollectionOfObjectValues<TaskDefinition>(TaskDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"workflows", n => { Workflows = n.GetCollectionOfObjectValues<Workflow>(Workflow.CreateFromDiscriminatorValue)?.ToList(); } },
                {"workflowTemplates", n => { WorkflowTemplates = n.GetCollectionOfObjectValues<WorkflowTemplate>(WorkflowTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<CustomTaskExtension>("customTaskExtensions", CustomTaskExtensions);
            writer.WriteObjectValue<ApiSdk.Models.DeletedItemContainer>("deletedItems", DeletedItems);
            writer.WriteObjectValue<LifecycleManagementSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<TaskDefinition>("taskDefinitions", TaskDefinitions);
            writer.WriteCollectionOfObjectValues<Workflow>("workflows", Workflows);
            writer.WriteCollectionOfObjectValues<WorkflowTemplate>("workflowTemplates", WorkflowTemplates);
        }
    }
}
