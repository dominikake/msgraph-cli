using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class AccessReviewInstanceDecisionItemAzureRoleResource : AccessReviewInstanceDecisionItemResource, IParsable {
        /// <summary>Details of the scope this role is associated with.</summary>
        public AccessReviewInstanceDecisionItemResource Scope { get; set; }
        /// <summary>
        /// Instantiates a new AccessReviewInstanceDecisionItemAzureRoleResource and sets the default values.
        /// </summary>
        public AccessReviewInstanceDecisionItemAzureRoleResource() : base() {
            OdataType = "#microsoft.graph.accessReviewInstanceDecisionItemAzureRoleResource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessReviewInstanceDecisionItemAzureRoleResource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewInstanceDecisionItemAzureRoleResource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"scope", n => { Scope = n.GetObjectValue<AccessReviewInstanceDecisionItemResource>(AccessReviewInstanceDecisionItemResource.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<AccessReviewInstanceDecisionItemResource>("scope", Scope);
        }
    }
}
