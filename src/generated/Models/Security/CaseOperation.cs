using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class CaseOperation : Entity, IParsable {
        /// <summary>The type of action the operation represents. Possible values are: addToReviewSet,applyTags,contentExport,convertToPdf,estimateStatistics, purgeData</summary>
        public CaseAction? Action { get; set; }
        /// <summary>The date and time the operation was completed.</summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
        /// <summary>The user that created the operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public ApiSdk.Models.IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>The date and time the operation was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The progress of the operation.</summary>
        public int? PercentProgress { get; set; }
        /// <summary>Contains success and failure-specific result information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ResultInfo? ResultInfo { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ResultInfo ResultInfo { get; set; }
#endif
        /// <summary>The status of the case operation. Possible values are: notStarted, submissionFailed, running, succeeded, partiallySucceeded, failed.</summary>
        public CaseOperationStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CaseOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.security.ediscoveryAddToReviewSetOperation" => new EdiscoveryAddToReviewSetOperation(),
                "#microsoft.graph.security.ediscoveryEstimateOperation" => new EdiscoveryEstimateOperation(),
                "#microsoft.graph.security.ediscoveryHoldOperation" => new EdiscoveryHoldOperation(),
                "#microsoft.graph.security.ediscoveryIndexOperation" => new EdiscoveryIndexOperation(),
                "#microsoft.graph.security.ediscoveryPurgeDataOperation" => new EdiscoveryPurgeDataOperation(),
                "#microsoft.graph.security.ediscoveryTagOperation" => new EdiscoveryTagOperation(),
                _ => new CaseOperation(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"action", n => { Action = n.GetEnumValue<CaseAction>(); } },
                {"completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<ApiSdk.Models.IdentitySet>(ApiSdk.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"percentProgress", n => { PercentProgress = n.GetIntValue(); } },
                {"resultInfo", n => { ResultInfo = n.GetObjectValue<ApiSdk.Models.ResultInfo>(ApiSdk.Models.ResultInfo.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<CaseOperationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<CaseAction>("action", Action);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteIntValue("percentProgress", PercentProgress);
            writer.WriteObjectValue<ApiSdk.Models.ResultInfo>("resultInfo", ResultInfo);
            writer.WriteEnumValue<CaseOperationStatus>("status", Status);
        }
    }
}
