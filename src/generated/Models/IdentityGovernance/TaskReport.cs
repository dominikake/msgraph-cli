using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.IdentityGovernance {
    public class TaskReport : Entity, IParsable {
        /// <summary>The date time that the associated run completed. Value is null if the run has not completed.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
        /// <summary>The number of users in the run execution for which the associated task failed.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public int? FailedUsersCount { get; set; }
        /// <summary>The date and time that the task report was last updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>The processingStatus property</summary>
        public LifecycleWorkflowProcessingStatus? ProcessingStatus { get; set; }
        /// <summary>The unique identifier of the associated run.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RunId { get; set; }
#nullable restore
#else
        public string RunId { get; set; }
#endif
        /// <summary>The date time that the associated run started. Value is null if the run has not started.</summary>
        public DateTimeOffset? StartedDateTime { get; set; }
        /// <summary>The number of users in the run execution for which the associated task succeeded.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public int? SuccessfulUsersCount { get; set; }
        /// <summary>The taskDefinition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.IdentityGovernance.TaskDefinition? TaskDefinition { get; set; }
#nullable restore
#else
        public ApiSdk.Models.IdentityGovernance.TaskDefinition TaskDefinition { get; set; }
#endif
        /// <summary>The task property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.IdentityGovernance.TaskObject? TaskObject { get; set; }
#nullable restore
#else
        public ApiSdk.Models.IdentityGovernance.TaskObject TaskObject { get; set; }
#endif
        /// <summary>The related lifecycle workflow taskProcessingResults.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TaskProcessingResult>? TaskProcessingResults { get; set; }
#nullable restore
#else
        public List<TaskProcessingResult> TaskProcessingResults { get; set; }
#endif
        /// <summary>The total number of users in the run execution for which the associated task was scheduled to execute.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public int? TotalUsersCount { get; set; }
        /// <summary>The number of users in the run execution for which the associated task is queued, in progress, or canceled.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public int? UnprocessedUsersCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TaskReport CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TaskReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"failedUsersCount", n => { FailedUsersCount = n.GetIntValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"processingStatus", n => { ProcessingStatus = n.GetEnumValue<LifecycleWorkflowProcessingStatus>(); } },
                {"runId", n => { RunId = n.GetStringValue(); } },
                {"startedDateTime", n => { StartedDateTime = n.GetDateTimeOffsetValue(); } },
                {"successfulUsersCount", n => { SuccessfulUsersCount = n.GetIntValue(); } },
                {"taskDefinition", n => { TaskDefinition = n.GetObjectValue<ApiSdk.Models.IdentityGovernance.TaskDefinition>(ApiSdk.Models.IdentityGovernance.TaskDefinition.CreateFromDiscriminatorValue); } },
                {"task", n => { TaskObject = n.GetObjectValue<ApiSdk.Models.IdentityGovernance.TaskObject>(ApiSdk.Models.IdentityGovernance.TaskObject.CreateFromDiscriminatorValue); } },
                {"taskProcessingResults", n => { TaskProcessingResults = n.GetCollectionOfObjectValues<TaskProcessingResult>(TaskProcessingResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"totalUsersCount", n => { TotalUsersCount = n.GetIntValue(); } },
                {"unprocessedUsersCount", n => { UnprocessedUsersCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteIntValue("failedUsersCount", FailedUsersCount);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteEnumValue<LifecycleWorkflowProcessingStatus>("processingStatus", ProcessingStatus);
            writer.WriteStringValue("runId", RunId);
            writer.WriteDateTimeOffsetValue("startedDateTime", StartedDateTime);
            writer.WriteIntValue("successfulUsersCount", SuccessfulUsersCount);
            writer.WriteObjectValue<ApiSdk.Models.IdentityGovernance.TaskDefinition>("taskDefinition", TaskDefinition);
            writer.WriteObjectValue<ApiSdk.Models.IdentityGovernance.TaskObject>("task", TaskObject);
            writer.WriteCollectionOfObjectValues<TaskProcessingResult>("taskProcessingResults", TaskProcessingResults);
            writer.WriteIntValue("totalUsersCount", TotalUsersCount);
            writer.WriteIntValue("unprocessedUsersCount", UnprocessedUsersCount);
        }
    }
}
