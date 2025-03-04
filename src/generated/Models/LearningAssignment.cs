using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class LearningAssignment : LearningCourseActivity, IParsable {
        /// <summary>Assigned date for the course activity. Optional.</summary>
        public DateTimeOffset? AssignedDateTime { get; set; }
        /// <summary>The user ID of the assigner. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignerUserId { get; set; }
#nullable restore
#else
        public string AssignerUserId { get; set; }
#endif
        /// <summary>The assignmentType property</summary>
        public ApiSdk.Models.AssignmentType? AssignmentType { get; set; }
        /// <summary>Due date for the course activity. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeTimeZone? DueDateTime { get; set; }
#nullable restore
#else
        public DateTimeTimeZone DueDateTime { get; set; }
#endif
        /// <summary>Notes for the course activity. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? Notes { get; set; }
#nullable restore
#else
        public ItemBody Notes { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new LearningAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LearningAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedDateTime", n => { AssignedDateTime = n.GetDateTimeOffsetValue(); } },
                {"assignerUserId", n => { AssignerUserId = n.GetStringValue(); } },
                {"assignmentType", n => { AssignmentType = n.GetEnumValue<AssignmentType>(); } },
                {"dueDateTime", n => { DueDateTime = n.GetObjectValue<DateTimeTimeZone>(DateTimeTimeZone.CreateFromDiscriminatorValue); } },
                {"notes", n => { Notes = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("assignedDateTime", AssignedDateTime);
            writer.WriteStringValue("assignerUserId", AssignerUserId);
            writer.WriteEnumValue<AssignmentType>("assignmentType", AssignmentType);
            writer.WriteObjectValue<DateTimeTimeZone>("dueDateTime", DueDateTime);
            writer.WriteObjectValue<ItemBody>("notes", Notes);
        }
    }
}
