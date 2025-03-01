using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class AppLogCollectionDownloadDetails : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The appLogDecryptionAlgorithm property</summary>
        public ApiSdk.Models.AppLogDecryptionAlgorithm? AppLogDecryptionAlgorithm { get; set; }
        /// <summary>Decryption key that used to decrypt the log.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DecryptionKey { get; set; }
#nullable restore
#else
        public string DecryptionKey { get; set; }
#endif
        /// <summary>Download SAS (Shared Access Signature) Url for completed app log request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DownloadUrl { get; set; }
#nullable restore
#else
        public string DownloadUrl { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new appLogCollectionDownloadDetails and sets the default values.
        /// </summary>
        public AppLogCollectionDownloadDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AppLogCollectionDownloadDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppLogCollectionDownloadDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"appLogDecryptionAlgorithm", n => { AppLogDecryptionAlgorithm = n.GetEnumValue<AppLogDecryptionAlgorithm>(); } },
                {"decryptionKey", n => { DecryptionKey = n.GetStringValue(); } },
                {"downloadUrl", n => { DownloadUrl = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AppLogDecryptionAlgorithm>("appLogDecryptionAlgorithm", AppLogDecryptionAlgorithm);
            writer.WriteStringValue("decryptionKey", DecryptionKey);
            writer.WriteStringValue("downloadUrl", DownloadUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
