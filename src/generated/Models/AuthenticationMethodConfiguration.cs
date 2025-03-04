using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class AuthenticationMethodConfiguration : Entity, IParsable {
        /// <summary>Groups of users that are excluded from a policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ExcludeTarget>? ExcludeTargets { get; set; }
#nullable restore
#else
        public List<ExcludeTarget> ExcludeTargets { get; set; }
#endif
        /// <summary>The state of the policy. Possible values are: enabled, disabled.</summary>
        public AuthenticationMethodState? State { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.emailAuthenticationMethodConfiguration" => new EmailAuthenticationMethodConfiguration(),
                "#microsoft.graph.fido2AuthenticationMethodConfiguration" => new Fido2AuthenticationMethodConfiguration(),
                "#microsoft.graph.microsoftAuthenticatorAuthenticationMethodConfiguration" => new MicrosoftAuthenticatorAuthenticationMethodConfiguration(),
                "#microsoft.graph.smsAuthenticationMethodConfiguration" => new SmsAuthenticationMethodConfiguration(),
                "#microsoft.graph.softwareOathAuthenticationMethodConfiguration" => new SoftwareOathAuthenticationMethodConfiguration(),
                "#microsoft.graph.temporaryAccessPassAuthenticationMethodConfiguration" => new TemporaryAccessPassAuthenticationMethodConfiguration(),
                "#microsoft.graph.voiceAuthenticationMethodConfiguration" => new VoiceAuthenticationMethodConfiguration(),
                "#microsoft.graph.x509CertificateAuthenticationMethodConfiguration" => new X509CertificateAuthenticationMethodConfiguration(),
                _ => new AuthenticationMethodConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"excludeTargets", n => { ExcludeTargets = n.GetCollectionOfObjectValues<ExcludeTarget>(ExcludeTarget.CreateFromDiscriminatorValue)?.ToList(); } },
                {"state", n => { State = n.GetEnumValue<AuthenticationMethodState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ExcludeTarget>("excludeTargets", ExcludeTargets);
            writer.WriteEnumValue<AuthenticationMethodState>("state", State);
        }
    }
}
