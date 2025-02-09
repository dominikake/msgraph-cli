using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class Synchronization : Entity, IParsable {
        /// <summary>The jobs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SynchronizationJob>? Jobs { get; set; }
#nullable restore
#else
        public List<SynchronizationJob> Jobs { get; set; }
#endif
        /// <summary>The secrets property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SynchronizationSecretKeyStringValuePair>? Secrets { get; set; }
#nullable restore
#else
        public List<SynchronizationSecretKeyStringValuePair> Secrets { get; set; }
#endif
        /// <summary>The templates property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SynchronizationTemplate>? Templates { get; set; }
#nullable restore
#else
        public List<SynchronizationTemplate> Templates { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Synchronization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Synchronization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"jobs", n => { Jobs = n.GetCollectionOfObjectValues<SynchronizationJob>(SynchronizationJob.CreateFromDiscriminatorValue)?.ToList(); } },
                {"secrets", n => { Secrets = n.GetCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>(SynchronizationSecretKeyStringValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"templates", n => { Templates = n.GetCollectionOfObjectValues<SynchronizationTemplate>(SynchronizationTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<SynchronizationJob>("jobs", Jobs);
            writer.WriteCollectionOfObjectValues<SynchronizationSecretKeyStringValuePair>("secrets", Secrets);
            writer.WriteCollectionOfObjectValues<SynchronizationTemplate>("templates", Templates);
        }
    }
}
