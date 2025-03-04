using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Users.Item.Presence.SetPresence {
    public class SetPresencePostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>The activity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Activity { get; set; }
#nullable restore
#else
        public string Activity { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The availability property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Availability { get; set; }
#nullable restore
#else
        public string Availability { get; set; }
#endif
        /// <summary>The expirationDuration property</summary>
        public TimeSpan? ExpirationDuration { get; set; }
        /// <summary>The sessionId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SessionId { get; set; }
#nullable restore
#else
        public string SessionId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new setPresencePostRequestBody and sets the default values.
        /// </summary>
        public SetPresencePostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SetPresencePostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SetPresencePostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"activity", n => { Activity = n.GetStringValue(); } },
                {"availability", n => { Availability = n.GetStringValue(); } },
                {"expirationDuration", n => { ExpirationDuration = n.GetTimeSpanValue(); } },
                {"sessionId", n => { SessionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activity", Activity);
            writer.WriteStringValue("availability", Availability);
            writer.WriteTimeSpanValue("expirationDuration", ExpirationDuration);
            writer.WriteStringValue("sessionId", SessionId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
