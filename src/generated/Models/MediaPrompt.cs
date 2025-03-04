using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class MediaPrompt : Prompt, IParsable {
        /// <summary>The mediaInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.MediaInfo? MediaInfo { get; set; }
#nullable restore
#else
        public ApiSdk.Models.MediaInfo MediaInfo { get; set; }
#endif
        /// <summary>
        /// Instantiates a new MediaPrompt and sets the default values.
        /// </summary>
        public MediaPrompt() : base() {
            OdataType = "#microsoft.graph.mediaPrompt";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MediaPrompt CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MediaPrompt();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"mediaInfo", n => { MediaInfo = n.GetObjectValue<ApiSdk.Models.MediaInfo>(ApiSdk.Models.MediaInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.MediaInfo>("mediaInfo", MediaInfo);
        }
    }
}
