using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class UserRegistrationFeatureSummary : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The totalUserCount property</summary>
        public long? TotalUserCount { get; set; }
        /// <summary>The userRegistrationFeatureCounts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserRegistrationFeatureCount>? UserRegistrationFeatureCounts { get; set; }
#nullable restore
#else
        public List<UserRegistrationFeatureCount> UserRegistrationFeatureCounts { get; set; }
#endif
        /// <summary>The userRoles property</summary>
        public IncludedUserRoles? UserRoles { get; set; }
        /// <summary>The userTypes property</summary>
        public IncludedUserTypes? UserTypes { get; set; }
        /// <summary>
        /// Instantiates a new UserRegistrationFeatureSummary and sets the default values.
        /// </summary>
        public UserRegistrationFeatureSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserRegistrationFeatureSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserRegistrationFeatureSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"totalUserCount", n => { TotalUserCount = n.GetLongValue(); } },
                {"userRegistrationFeatureCounts", n => { UserRegistrationFeatureCounts = n.GetCollectionOfObjectValues<UserRegistrationFeatureCount>(UserRegistrationFeatureCount.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userRoles", n => { UserRoles = n.GetEnumValue<IncludedUserRoles>(); } },
                {"userTypes", n => { UserTypes = n.GetEnumValue<IncludedUserTypes>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("totalUserCount", TotalUserCount);
            writer.WriteCollectionOfObjectValues<UserRegistrationFeatureCount>("userRegistrationFeatureCounts", UserRegistrationFeatureCounts);
            writer.WriteEnumValue<IncludedUserRoles>("userRoles", UserRoles);
            writer.WriteEnumValue<IncludedUserTypes>("userTypes", UserTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
