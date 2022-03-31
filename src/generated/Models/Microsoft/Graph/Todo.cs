using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class Todo : Entity, IParsable {
        /// <summary>The task lists in the users mailbox.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.TodoTaskList> Lists { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.Todo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Todo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"lists", (o,n) => { (o as Todo).Lists = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TodoTaskList>(ApiSdk.Models.Microsoft.Graph.TodoTaskList.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.TodoTaskList>("lists", Lists);
        }
    }
}
