using ApiSdk.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Groups.Item.Conversations.Item.Threads.Item.Posts.Item.InReplyTo.Attachments.CreateUploadSession {
    public class CreateUploadSessionPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The AttachmentItem property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AttachmentItem? AttachmentItem { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AttachmentItem AttachmentItem { get; set; }
#endif
        /// <summary>
        /// Instantiates a new createUploadSessionPostRequestBody and sets the default values.
        /// </summary>
        public CreateUploadSessionPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateUploadSessionPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateUploadSessionPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attachmentItem", n => { AttachmentItem = n.GetObjectValue<ApiSdk.Models.AttachmentItem>(ApiSdk.Models.AttachmentItem.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ApiSdk.Models.AttachmentItem>("attachmentItem", AttachmentItem);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
