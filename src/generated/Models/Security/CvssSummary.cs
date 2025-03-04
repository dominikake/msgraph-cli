using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class CvssSummary : IAdditionalDataHolder, IParsable {
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
        /// <summary>The CVSS score about this vulnerability.</summary>
        public double? Score { get; set; }
        /// <summary>The CVSS severity rating for this vulnerability. The possible values are: none, low, medium, high, critical, unknownFutureValue.</summary>
        public VulnerabilitySeverity? Severity { get; set; }
        /// <summary>The CVSS vector string for this vulnerability.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VectorString { get; set; }
#nullable restore
#else
        public string VectorString { get; set; }
#endif
        /// <summary>
        /// Instantiates a new CvssSummary and sets the default values.
        /// </summary>
        public CvssSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CvssSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CvssSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"score", n => { Score = n.GetDoubleValue(); } },
                {"severity", n => { Severity = n.GetEnumValue<VulnerabilitySeverity>(); } },
                {"vectorString", n => { VectorString = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDoubleValue("score", Score);
            writer.WriteEnumValue<VulnerabilitySeverity>("severity", Severity);
            writer.WriteStringValue("vectorString", VectorString);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
