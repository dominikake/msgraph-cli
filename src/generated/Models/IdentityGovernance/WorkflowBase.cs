using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.IdentityGovernance {
    public class WorkflowBase : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The category property</summary>
        public LifecycleWorkflowCategory? Category { get; set; }
        /// <summary>The user who created the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.User? CreatedBy { get; set; }
#nullable restore
#else
        public ApiSdk.Models.User CreatedBy { get; set; }
#endif
        /// <summary>When a workflow was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>A string that describes the purpose of the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>A string to identify the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Defines when and for who the workflow will run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkflowExecutionConditions? ExecutionConditions { get; set; }
#nullable restore
#else
        public WorkflowExecutionConditions ExecutionConditions { get; set; }
#endif
        /// <summary>Whether the workflow is enabled or disabled. If this setting is true, the workflow can be run on demand or on schedule when isSchedulingEnabled is true.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>If true, the Lifecycle Workflow engine executes the workflow based on the schedule defined by tenant settings. Cannot be true for a disabled workflow (where isEnabled is false).</summary>
        public bool? IsSchedulingEnabled { get; set; }
        /// <summary>The unique identifier of the AAD identity that last modified the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.User? LastModifiedBy { get; set; }
#nullable restore
#else
        public ApiSdk.Models.User LastModifiedBy { get; set; }
#endif
        /// <summary>When the workflow was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The tasks in the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TaskObject>? Tasks { get; set; }
#nullable restore
#else
        public List<TaskObject> Tasks { get; set; }
#endif
        /// <summary>
        /// Instantiates a new workflowBase and sets the default values.
        /// </summary>
        public WorkflowBase() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.identityGovernance.workflow" => new Workflow(),
                "#microsoft.graph.identityGovernance.workflowVersion" => new WorkflowVersion(),
                _ => new WorkflowBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"category", n => { Category = n.GetEnumValue<LifecycleWorkflowCategory>(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<ApiSdk.Models.User>(ApiSdk.Models.User.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"executionConditions", n => { ExecutionConditions = n.GetObjectValue<WorkflowExecutionConditions>(WorkflowExecutionConditions.CreateFromDiscriminatorValue); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"isSchedulingEnabled", n => { IsSchedulingEnabled = n.GetBoolValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<ApiSdk.Models.User>(ApiSdk.Models.User.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<TaskObject>(TaskObject.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<LifecycleWorkflowCategory>("category", Category);
            writer.WriteObjectValue<ApiSdk.Models.User>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<WorkflowExecutionConditions>("executionConditions", ExecutionConditions);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteBoolValue("isSchedulingEnabled", IsSchedulingEnabled);
            writer.WriteObjectValue<ApiSdk.Models.User>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<TaskObject>("tasks", Tasks);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
