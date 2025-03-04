using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class SmsAuthenticationMethodConfiguration : AuthenticationMethodConfiguration, IParsable {
        /// <summary>A collection of groups that are enabled to use the authentication method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SmsAuthenticationMethodTarget>? IncludeTargets { get; set; }
#nullable restore
#else
        public List<SmsAuthenticationMethodTarget> IncludeTargets { get; set; }
#endif
        /// <summary>
        /// Instantiates a new SmsAuthenticationMethodConfiguration and sets the default values.
        /// </summary>
        public SmsAuthenticationMethodConfiguration() : base() {
            OdataType = "#microsoft.graph.smsAuthenticationMethodConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SmsAuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SmsAuthenticationMethodConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<SmsAuthenticationMethodTarget>(SmsAuthenticationMethodTarget.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<SmsAuthenticationMethodTarget>("includeTargets", IncludeTargets);
        }
    }
}
