using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    /// <summary>
    /// A singleton entity which is used to specify IE mode site list metadata
    /// </summary>
    public class BrowserSiteList : Entity, IParsable {
        /// <summary>The description of the site list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The name of the site list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The user who last modified the site list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LastModifiedBy { get; set; }
#nullable restore
#else
        public IdentitySet LastModifiedBy { get; set; }
#endif
        /// <summary>The date and time when the site list was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The user who published the site list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? PublishedBy { get; set; }
#nullable restore
#else
        public IdentitySet PublishedBy { get; set; }
#endif
        /// <summary>The date and time when the site list was published.</summary>
        public DateTimeOffset? PublishedDateTime { get; set; }
        /// <summary>The current revision of the site list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Revision { get; set; }
#nullable restore
#else
        public string Revision { get; set; }
#endif
        /// <summary>A collection of shared cookies defined for the site list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BrowserSharedCookie>? SharedCookies { get; set; }
#nullable restore
#else
        public List<BrowserSharedCookie> SharedCookies { get; set; }
#endif
        /// <summary>A collection of sites defined for the site list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BrowserSite>? Sites { get; set; }
#nullable restore
#else
        public List<BrowserSite> Sites { get; set; }
#endif
        /// <summary>The status property</summary>
        public BrowserSiteListStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BrowserSiteList CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BrowserSiteList();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"publishedBy", n => { PublishedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"publishedDateTime", n => { PublishedDateTime = n.GetDateTimeOffsetValue(); } },
                {"revision", n => { Revision = n.GetStringValue(); } },
                {"sharedCookies", n => { SharedCookies = n.GetCollectionOfObjectValues<BrowserSharedCookie>(BrowserSharedCookie.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sites", n => { Sites = n.GetCollectionOfObjectValues<BrowserSite>(BrowserSite.CreateFromDiscriminatorValue)?.ToList(); } },
                {"status", n => { Status = n.GetEnumValue<BrowserSiteListStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<IdentitySet>("publishedBy", PublishedBy);
            writer.WriteDateTimeOffsetValue("publishedDateTime", PublishedDateTime);
            writer.WriteStringValue("revision", Revision);
            writer.WriteCollectionOfObjectValues<BrowserSharedCookie>("sharedCookies", SharedCookies);
            writer.WriteCollectionOfObjectValues<BrowserSite>("sites", Sites);
            writer.WriteEnumValue<BrowserSiteListStatus>("status", Status);
        }
    }
}
