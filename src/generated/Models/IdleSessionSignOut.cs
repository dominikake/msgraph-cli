using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class IdleSessionSignOut : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether the idle session sign-out policy is enabled.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Number of seconds of inactivity after which a user is signed out.</summary>
        public long? SignOutAfterInSeconds { get; set; }
        /// <summary>Number of seconds of inactivity after which a user is notified that they&apos;ll be signed out.</summary>
        public long? WarnAfterInSeconds { get; set; }
        /// <summary>
        /// Instantiates a new idleSessionSignOut and sets the default values.
        /// </summary>
        public IdleSessionSignOut() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IdleSessionSignOut CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdleSessionSignOut();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"signOutAfterInSeconds", n => { SignOutAfterInSeconds = n.GetLongValue(); } },
                {"warnAfterInSeconds", n => { WarnAfterInSeconds = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("signOutAfterInSeconds", SignOutAfterInSeconds);
            writer.WriteLongValue("warnAfterInSeconds", WarnAfterInSeconds);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
