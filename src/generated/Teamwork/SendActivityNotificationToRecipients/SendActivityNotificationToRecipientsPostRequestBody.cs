using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Teamwork.SendActivityNotificationToRecipients {
    public class SendActivityNotificationToRecipientsPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>The activityType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivityType { get; set; }
#nullable restore
#else
        public string ActivityType { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The chainId property</summary>
        public long? ChainId { get; set; }
        /// <summary>The previewText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? PreviewText { get; set; }
#nullable restore
#else
        public ItemBody PreviewText { get; set; }
#endif
        /// <summary>The recipients property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamworkNotificationRecipient>? Recipients { get; set; }
#nullable restore
#else
        public List<TeamworkNotificationRecipient> Recipients { get; set; }
#endif
        /// <summary>The teamsAppId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamsAppId { get; set; }
#nullable restore
#else
        public string TeamsAppId { get; set; }
#endif
        /// <summary>The templateParameters property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.KeyValuePair>? TemplateParameters { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.KeyValuePair> TemplateParameters { get; set; }
#endif
        /// <summary>The topic property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkActivityTopic? Topic { get; set; }
#nullable restore
#else
        public TeamworkActivityTopic Topic { get; set; }
#endif
        /// <summary>
        /// Instantiates a new sendActivityNotificationToRecipientsPostRequestBody and sets the default values.
        /// </summary>
        public SendActivityNotificationToRecipientsPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SendActivityNotificationToRecipientsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SendActivityNotificationToRecipientsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"activityType", n => { ActivityType = n.GetStringValue(); } },
                {"chainId", n => { ChainId = n.GetLongValue(); } },
                {"previewText", n => { PreviewText = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"recipients", n => { Recipients = n.GetCollectionOfObjectValues<TeamworkNotificationRecipient>(TeamworkNotificationRecipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"teamsAppId", n => { TeamsAppId = n.GetStringValue(); } },
                {"templateParameters", n => { TemplateParameters = n.GetCollectionOfObjectValues<ApiSdk.Models.KeyValuePair>(ApiSdk.Models.KeyValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"topic", n => { Topic = n.GetObjectValue<TeamworkActivityTopic>(TeamworkActivityTopic.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("activityType", ActivityType);
            writer.WriteLongValue("chainId", ChainId);
            writer.WriteObjectValue<ItemBody>("previewText", PreviewText);
            writer.WriteCollectionOfObjectValues<TeamworkNotificationRecipient>("recipients", Recipients);
            writer.WriteStringValue("teamsAppId", TeamsAppId);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.KeyValuePair>("templateParameters", TemplateParameters);
            writer.WriteObjectValue<TeamworkActivityTopic>("topic", Topic);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
