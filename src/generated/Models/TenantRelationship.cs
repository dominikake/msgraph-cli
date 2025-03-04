using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class TenantRelationship : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The customer who has a delegated admin relationship with a Microsoft partner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DelegatedAdminCustomer>? DelegatedAdminCustomers { get; set; }
#nullable restore
#else
        public List<DelegatedAdminCustomer> DelegatedAdminCustomers { get; set; }
#endif
        /// <summary>The details of the delegated administrative privileges that a Microsoft partner has in a customer tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DelegatedAdminRelationship>? DelegatedAdminRelationships { get; set; }
#nullable restore
#else
        public List<DelegatedAdminRelationship> DelegatedAdminRelationships { get; set; }
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
        /// Instantiates a new TenantRelationship and sets the default values.
        /// </summary>
        public TenantRelationship() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TenantRelationship CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantRelationship();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"delegatedAdminCustomers", n => { DelegatedAdminCustomers = n.GetCollectionOfObjectValues<DelegatedAdminCustomer>(DelegatedAdminCustomer.CreateFromDiscriminatorValue)?.ToList(); } },
                {"delegatedAdminRelationships", n => { DelegatedAdminRelationships = n.GetCollectionOfObjectValues<DelegatedAdminRelationship>(DelegatedAdminRelationship.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DelegatedAdminCustomer>("delegatedAdminCustomers", DelegatedAdminCustomers);
            writer.WriteCollectionOfObjectValues<DelegatedAdminRelationship>("delegatedAdminRelationships", DelegatedAdminRelationships);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
