using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.IdentityGovernance {
    public class UserSummary : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of failed tasks for users in a user summary.</summary>
        public int? FailedTasks { get; set; }
        /// <summary>The number of failed users in a user summary.</summary>
        public int? FailedUsers { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The number of successful users in a user summary.</summary>
        public int? SuccessfulUsers { get; set; }
        /// <summary>The total tasks of users in a user summary.</summary>
        public int? TotalTasks { get; set; }
        /// <summary>The total number of users in a user summary</summary>
        public int? TotalUsers { get; set; }
        /// <summary>
        /// Instantiates a new userSummary and sets the default values.
        /// </summary>
        public UserSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"failedTasks", n => { FailedTasks = n.GetIntValue(); } },
                {"failedUsers", n => { FailedUsers = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"successfulUsers", n => { SuccessfulUsers = n.GetIntValue(); } },
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
            writer.WriteIntValue("failedTasks", FailedTasks);
            writer.WriteIntValue("failedUsers", FailedUsers);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("successfulUsers", SuccessfulUsers);
            writer.WriteIntValue("totalTasks", TotalTasks);
            writer.WriteIntValue("totalUsers", TotalUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
