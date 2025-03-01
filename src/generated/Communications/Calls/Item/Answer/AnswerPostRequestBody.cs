using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Communications.Calls.Item.Answer {
    public class AnswerPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>The acceptedModalities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Modality?>? AcceptedModalities { get; set; }
#nullable restore
#else
        public List<Modality?> AcceptedModalities { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The callbackUri property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CallbackUri { get; set; }
#nullable restore
#else
        public string CallbackUri { get; set; }
#endif
        /// <summary>The callOptions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IncomingCallOptions? CallOptions { get; set; }
#nullable restore
#else
        public IncomingCallOptions CallOptions { get; set; }
#endif
        /// <summary>The mediaConfig property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.MediaConfig? MediaConfig { get; set; }
#nullable restore
#else
        public ApiSdk.Models.MediaConfig MediaConfig { get; set; }
#endif
        /// <summary>The participantCapacity property</summary>
        public int? ParticipantCapacity { get; set; }
        /// <summary>
        /// Instantiates a new answerPostRequestBody and sets the default values.
        /// </summary>
        public AnswerPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AnswerPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AnswerPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"acceptedModalities", n => { AcceptedModalities = n.GetCollectionOfEnumValues<Modality>()?.ToList(); } },
                {"callbackUri", n => { CallbackUri = n.GetStringValue(); } },
                {"callOptions", n => { CallOptions = n.GetObjectValue<IncomingCallOptions>(IncomingCallOptions.CreateFromDiscriminatorValue); } },
                {"mediaConfig", n => { MediaConfig = n.GetObjectValue<ApiSdk.Models.MediaConfig>(ApiSdk.Models.MediaConfig.CreateFromDiscriminatorValue); } },
                {"participantCapacity", n => { ParticipantCapacity = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<Modality>("acceptedModalities", AcceptedModalities);
            writer.WriteStringValue("callbackUri", CallbackUri);
            writer.WriteObjectValue<IncomingCallOptions>("callOptions", CallOptions);
            writer.WriteObjectValue<ApiSdk.Models.MediaConfig>("mediaConfig", MediaConfig);
            writer.WriteIntValue("participantCapacity", ParticipantCapacity);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
