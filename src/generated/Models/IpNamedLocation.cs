using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models {
    public class IpNamedLocation : NamedLocation, IParsable {
        /// <summary>List of IP address ranges in IPv4 CIDR format (e.g. 1.2.3.4/32) or any allowable IPv6 format from IETF RFC596. Required.</summary>
        public List<IpRange> IpRanges { get; set; }
        /// <summary>true if this location is explicitly trusted. Optional. Default value is false.</summary>
        public bool? IsTrusted { get; set; }
        /// <summary>
        /// Instantiates a new IpNamedLocation and sets the default values.
        /// </summary>
        public IpNamedLocation() : base() {
            OdataType = "#microsoft.graph.ipNamedLocation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IpNamedLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IpNamedLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"ipRanges", n => { IpRanges = n.GetCollectionOfObjectValues<IpRange>(IpRange.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isTrusted", n => { IsTrusted = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<IpRange>("ipRanges", IpRanges);
            writer.WriteBoolValue("isTrusted", IsTrusted);
        }
    }
}
