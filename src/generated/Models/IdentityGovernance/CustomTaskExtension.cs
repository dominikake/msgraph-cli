using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models.IdentityGovernance {
    public class CustomTaskExtension : CustomCalloutExtension, IParsable {
        /// <summary>The callback configuration for a custom task extension.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.CustomExtensionCallbackConfiguration? CallbackConfiguration { get; set; }
#nullable restore
#else
        public ApiSdk.Models.CustomExtensionCallbackConfiguration CallbackConfiguration { get; set; }
#endif
        /// <summary>The unique identifier of the Azure AD user that created the custom task extension.Supports $filter(eq, ne) and $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.User? CreatedBy { get; set; }
#nullable restore
#else
        public ApiSdk.Models.User CreatedBy { get; set; }
#endif
        /// <summary>When the custom task extension was created.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The unique identifier of the Azure AD user that modified the custom task extension last.Supports $filter(eq, ne) and $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.User? LastModifiedBy { get; set; }
#nullable restore
#else
        public ApiSdk.Models.User LastModifiedBy { get; set; }
#endif
        /// <summary>When the custom extension was last modified.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>
        /// Instantiates a new CustomTaskExtension and sets the default values.
        /// </summary>
        public CustomTaskExtension() : base() {
            OdataType = "#microsoft.graph.identityGovernance.customTaskExtension";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomTaskExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomTaskExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"callbackConfiguration", n => { CallbackConfiguration = n.GetObjectValue<ApiSdk.Models.CustomExtensionCallbackConfiguration>(ApiSdk.Models.CustomExtensionCallbackConfiguration.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<ApiSdk.Models.User>(ApiSdk.Models.User.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<ApiSdk.Models.User>(ApiSdk.Models.User.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.CustomExtensionCallbackConfiguration>("callbackConfiguration", CallbackConfiguration);
            writer.WriteObjectValue<ApiSdk.Models.User>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<ApiSdk.Models.User>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}
