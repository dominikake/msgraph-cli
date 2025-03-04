using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.Security {
    public class Security : Entity, IParsable {
        /// <summary>The alerts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.Alert>? Alerts { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.Alert> Alerts { get; set; }
#endif
        /// <summary>A collection of alerts in Microsoft 365 Defender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Alert>? Alerts_v2 { get; set; }
#nullable restore
#else
        public List<Alert> Alerts_v2 { get; set; }
#endif
        /// <summary>The attackSimulation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.AttackSimulationRoot? AttackSimulation { get; set; }
#nullable restore
#else
        public ApiSdk.Models.AttackSimulationRoot AttackSimulation { get; set; }
#endif
        /// <summary>The cases property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CasesRoot? Cases { get; set; }
#nullable restore
#else
        public CasesRoot Cases { get; set; }
#endif
        /// <summary>A collection of incidents in Microsoft 365 Defender, each of which is a set of correlated alerts and associated metadata that reflects the story of an attack.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Incident>? Incidents { get; set; }
#nullable restore
#else
        public List<Incident> Incidents { get; set; }
#endif
        /// <summary>The secureScoreControlProfiles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.SecureScoreControlProfile>? SecureScoreControlProfiles { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.SecureScoreControlProfile> SecureScoreControlProfiles { get; set; }
#endif
        /// <summary>The secureScores property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.SecureScore>? SecureScores { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.SecureScore> SecureScores { get; set; }
#endif
        /// <summary>The threatIntelligence property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.Security.ThreatIntelligence? ThreatIntelligence { get; set; }
#nullable restore
#else
        public ApiSdk.Models.Security.ThreatIntelligence ThreatIntelligence { get; set; }
#endif
        /// <summary>The triggers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TriggersRoot? Triggers { get; set; }
#nullable restore
#else
        public TriggersRoot Triggers { get; set; }
#endif
        /// <summary>The triggerTypes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TriggerTypesRoot? TriggerTypes { get; set; }
#nullable restore
#else
        public TriggerTypesRoot TriggerTypes { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Security CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Security();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alerts", n => { Alerts = n.GetCollectionOfObjectValues<ApiSdk.Models.Alert>(ApiSdk.Models.Alert.CreateFromDiscriminatorValue)?.ToList(); } },
                {"alerts_v2", n => { Alerts_v2 = n.GetCollectionOfObjectValues<Alert>(Alert.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attackSimulation", n => { AttackSimulation = n.GetObjectValue<ApiSdk.Models.AttackSimulationRoot>(ApiSdk.Models.AttackSimulationRoot.CreateFromDiscriminatorValue); } },
                {"cases", n => { Cases = n.GetObjectValue<CasesRoot>(CasesRoot.CreateFromDiscriminatorValue); } },
                {"incidents", n => { Incidents = n.GetCollectionOfObjectValues<Incident>(Incident.CreateFromDiscriminatorValue)?.ToList(); } },
                {"secureScoreControlProfiles", n => { SecureScoreControlProfiles = n.GetCollectionOfObjectValues<ApiSdk.Models.SecureScoreControlProfile>(ApiSdk.Models.SecureScoreControlProfile.CreateFromDiscriminatorValue)?.ToList(); } },
                {"secureScores", n => { SecureScores = n.GetCollectionOfObjectValues<ApiSdk.Models.SecureScore>(ApiSdk.Models.SecureScore.CreateFromDiscriminatorValue)?.ToList(); } },
                {"threatIntelligence", n => { ThreatIntelligence = n.GetObjectValue<ApiSdk.Models.Security.ThreatIntelligence>(ApiSdk.Models.Security.ThreatIntelligence.CreateFromDiscriminatorValue); } },
                {"triggers", n => { Triggers = n.GetObjectValue<TriggersRoot>(TriggersRoot.CreateFromDiscriminatorValue); } },
                {"triggerTypes", n => { TriggerTypes = n.GetObjectValue<TriggerTypesRoot>(TriggerTypesRoot.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Alert>("alerts", Alerts);
            writer.WriteCollectionOfObjectValues<Alert>("alerts_v2", Alerts_v2);
            writer.WriteObjectValue<ApiSdk.Models.AttackSimulationRoot>("attackSimulation", AttackSimulation);
            writer.WriteObjectValue<CasesRoot>("cases", Cases);
            writer.WriteCollectionOfObjectValues<Incident>("incidents", Incidents);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.SecureScoreControlProfile>("secureScoreControlProfiles", SecureScoreControlProfiles);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.SecureScore>("secureScores", SecureScores);
            writer.WriteObjectValue<ApiSdk.Models.Security.ThreatIntelligence>("threatIntelligence", ThreatIntelligence);
            writer.WriteObjectValue<TriggersRoot>("triggers", Triggers);
            writer.WriteObjectValue<TriggerTypesRoot>("triggerTypes", TriggerTypes);
        }
    }
}
