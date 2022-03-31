using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class PublicInnerError : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The error code.</summary>
        public string Code { get; set; }
        /// <summary>A collection of error details.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.PublicErrorDetail> Details { get; set; }
        /// <summary>The error message.</summary>
        public string Message { get; set; }
        /// <summary>The target of the error.</summary>
        public string Target { get; set; }
        /// <summary>
        /// Instantiates a new publicInnerError and sets the default values.
        /// </summary>
        public PublicInnerError() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ApiSdk.Models.Microsoft.Graph.PublicInnerError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PublicInnerError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"code", (o,n) => { (o as PublicInnerError).Code = n.GetStringValue(); } },
                {"details", (o,n) => { (o as PublicInnerError).Details = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PublicErrorDetail>(ApiSdk.Models.Microsoft.Graph.PublicErrorDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"message", (o,n) => { (o as PublicInnerError).Message = n.GetStringValue(); } },
                {"target", (o,n) => { (o as PublicInnerError).Target = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("code", Code);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.PublicErrorDetail>("details", Details);
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
