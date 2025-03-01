using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class LearningProvider : Entity, IParsable {
        /// <summary>The display name that appears in Viva Learning. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Indicates whether a provider can ingest learning course activity records. The default value is false. Set to true to make learningCourseActivities available for this provider.</summary>
        public bool? IsCourseActivitySyncEnabled { get; set; }
        /// <summary>Learning catalog items for the provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LearningContent>? LearningContents { get; set; }
#nullable restore
#else
        public List<LearningContent> LearningContents { get; set; }
#endif
        /// <summary>The learningCourseActivities property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LearningCourseActivity>? LearningCourseActivities { get; set; }
#nullable restore
#else
        public List<LearningCourseActivity> LearningCourseActivities { get; set; }
#endif
        /// <summary>Authentication URL to access the courses for the provider. Optional.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LoginWebUrl { get; set; }
#nullable restore
#else
        public string LoginWebUrl { get; set; }
#endif
        /// <summary>The long logo URL for the dark mode that needs to be a publicly accessible image. This image would be saved to the blob storage of Viva Learning for rendering within the Viva Learning app. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LongLogoWebUrlForDarkTheme { get; set; }
#nullable restore
#else
        public string LongLogoWebUrlForDarkTheme { get; set; }
#endif
        /// <summary>The long logo URL for the light mode that needs to be a publicly accessible image. This image would be saved to the blob storage of Viva Learning for rendering within the Viva Learning app. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LongLogoWebUrlForLightTheme { get; set; }
#nullable restore
#else
        public string LongLogoWebUrlForLightTheme { get; set; }
#endif
        /// <summary>The square logo URL for the dark mode that needs to be a publicly accessible image. This image would be saved to the blob storage of Viva Learning for rendering within the Viva Learning app. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SquareLogoWebUrlForDarkTheme { get; set; }
#nullable restore
#else
        public string SquareLogoWebUrlForDarkTheme { get; set; }
#endif
        /// <summary>The square logo URL for the light mode that needs to be a publicly accessible image. This image would be saved to the blob storage of Viva Learning for rendering within the Viva Learning app. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SquareLogoWebUrlForLightTheme { get; set; }
#nullable restore
#else
        public string SquareLogoWebUrlForLightTheme { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new LearningProvider CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LearningProvider();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isCourseActivitySyncEnabled", n => { IsCourseActivitySyncEnabled = n.GetBoolValue(); } },
                {"learningContents", n => { LearningContents = n.GetCollectionOfObjectValues<LearningContent>(LearningContent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"learningCourseActivities", n => { LearningCourseActivities = n.GetCollectionOfObjectValues<LearningCourseActivity>(LearningCourseActivity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"loginWebUrl", n => { LoginWebUrl = n.GetStringValue(); } },
                {"longLogoWebUrlForDarkTheme", n => { LongLogoWebUrlForDarkTheme = n.GetStringValue(); } },
                {"longLogoWebUrlForLightTheme", n => { LongLogoWebUrlForLightTheme = n.GetStringValue(); } },
                {"squareLogoWebUrlForDarkTheme", n => { SquareLogoWebUrlForDarkTheme = n.GetStringValue(); } },
                {"squareLogoWebUrlForLightTheme", n => { SquareLogoWebUrlForLightTheme = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isCourseActivitySyncEnabled", IsCourseActivitySyncEnabled);
            writer.WriteCollectionOfObjectValues<LearningContent>("learningContents", LearningContents);
            writer.WriteCollectionOfObjectValues<LearningCourseActivity>("learningCourseActivities", LearningCourseActivities);
            writer.WriteStringValue("loginWebUrl", LoginWebUrl);
            writer.WriteStringValue("longLogoWebUrlForDarkTheme", LongLogoWebUrlForDarkTheme);
            writer.WriteStringValue("longLogoWebUrlForLightTheme", LongLogoWebUrlForLightTheme);
            writer.WriteStringValue("squareLogoWebUrlForDarkTheme", SquareLogoWebUrlForDarkTheme);
            writer.WriteStringValue("squareLogoWebUrlForLightTheme", SquareLogoWebUrlForLightTheme);
        }
    }
}
