using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.IdentityGovernance {
    public class RunSummary : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of failed workflow runs.</summary>
        public int? FailedRuns { get; set; }
        /// <summary>The number of failed tasks of a workflow.</summary>
        public int? FailedTasks { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The number of successful workflow runs.</summary>
        public int? SuccessfulRuns { get; set; }
        /// <summary>The total number of runs for a workflow.</summary>
        public int? TotalRuns { get; set; }
        /// <summary>The total number of tasks processed by a workflow.</summary>
        public int? TotalTasks { get; set; }
        /// <summary>The total number of users processed by a workflow.</summary>
        public int? TotalUsers { get; set; }
        /// <summary>
        /// Instantiates a new runSummary and sets the default values.
        /// </summary>
        public RunSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RunSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RunSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"failedRuns", n => { FailedRuns = n.GetIntValue(); } },
                {"failedTasks", n => { FailedTasks = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"successfulRuns", n => { SuccessfulRuns = n.GetIntValue(); } },
                {"totalRuns", n => { TotalRuns = n.GetIntValue(); } },
                {"totalTasks", n => { TotalTasks = n.GetIntValue(); } },
                {"totalUsers", n => { TotalUsers = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("failedRuns", FailedRuns);
            writer.WriteIntValue("failedTasks", FailedTasks);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("successfulRuns", SuccessfulRuns);
            writer.WriteIntValue("totalRuns", TotalRuns);
            writer.WriteIntValue("totalTasks", TotalTasks);
            writer.WriteIntValue("totalUsers", TotalUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
