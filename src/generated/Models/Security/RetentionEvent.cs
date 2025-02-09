using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class RetentionEvent : Entity, IParsable {
        /// <summary>The user who created the retentionEvent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public ApiSdk.Models.IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>The date time when the retentionEvent was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Optional information about the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Name of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The eventPropagationResults property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EventPropagationResult>? EventPropagationResults { get; set; }
#nullable restore
#else
        public List<EventPropagationResult> EventPropagationResults { get; set; }
#endif
        /// <summary>Represents the workload (SharePoint Online, OneDrive for Business, Exchange Online) and identification information associated with a retention event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EventQuery>? EventQueries { get; set; }
#nullable restore
#else
        public List<EventQuery> EventQueries { get; set; }
#endif
        /// <summary>The eventStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RetentionEventStatus? EventStatus { get; set; }
#nullable restore
#else
        public RetentionEventStatus EventStatus { get; set; }
#endif
        /// <summary>Optional time when the event should be triggered.</summary>
        public DateTimeOffset? EventTriggerDateTime { get; set; }
        /// <summary>The user who last modified the retentionEvent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.IdentitySet? LastModifiedBy { get; set; }
#nullable restore
#else
        public ApiSdk.Models.IdentitySet LastModifiedBy { get; set; }
#endif
        /// <summary>The latest date time when the retentionEvent was modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Last time the status of the event was updated.</summary>
        public DateTimeOffset? LastStatusUpdateDateTime { get; set; }
        /// <summary>Specifies the event that will start the retention period for labels that use this event type when an event is created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Security.RetentionEventType? RetentionEventType { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Security.RetentionEventType RetentionEventType { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RetentionEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RetentionEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdBy", n => { CreatedBy = n.GetObjectValue<ApiSdk.Models.IdentitySet>(ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"eventPropagationResults", n => { EventPropagationResults = n.GetCollectionOfObjectValues<EventPropagationResult>(EventPropagationResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"eventQueries", n => { EventQueries = n.GetCollectionOfObjectValues<EventQuery>(EventQuery.CreateFromDiscriminatorValue)?.ToList(); } },
                {"eventStatus", n => { EventStatus = n.GetObjectValue<RetentionEventStatus>(RetentionEventStatus.CreateFromDiscriminatorValue); } },
                {"eventTriggerDateTime", n => { EventTriggerDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<ApiSdk.Models.IdentitySet>(ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastStatusUpdateDateTime", n => { LastStatusUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"retentionEventType", n => { RetentionEventType = n.GetObjectValue<ApiSdk.Models.Security.RetentionEventType>(ApiSdk.Models.Security.RetentionEventType.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<EventPropagationResult>("eventPropagationResults", EventPropagationResults);
            writer.WriteCollectionOfObjectValues<EventQuery>("eventQueries", EventQueries);
            writer.WriteObjectValue<RetentionEventStatus>("eventStatus", EventStatus);
            writer.WriteDateTimeOffsetValue("eventTriggerDateTime", EventTriggerDateTime);
            writer.WriteObjectValue<ApiSdk.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDateTimeOffsetValue("lastStatusUpdateDateTime", LastStatusUpdateDateTime);
            writer.WriteObjectValue<ApiSdk.Models.Security.RetentionEventType>("retentionEventType", RetentionEventType);
        }
    }
}
