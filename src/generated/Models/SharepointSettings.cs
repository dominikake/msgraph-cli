using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class SharepointSettings : Entity, IParsable {
        /// <summary>Collection of trusted domain GUIDs for the OneDrive sync app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? AllowedDomainGuidsForSyncApp { get; set; }
#nullable restore
#else
        public List<Guid?> AllowedDomainGuidsForSyncApp { get; set; }
#endif
        /// <summary>Collection of managed paths available for site creation. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AvailableManagedPathsForSiteCreation { get; set; }
#nullable restore
#else
        public List<string> AvailableManagedPathsForSiteCreation { get; set; }
#endif
        /// <summary>The number of days for preserving a deleted user&apos;s OneDrive.</summary>
        public int? DeletedUserPersonalSiteRetentionPeriodInDays { get; set; }
        /// <summary>Collection of file extensions not uploaded by the OneDrive sync app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExcludedFileExtensionsForSyncApp { get; set; }
#nullable restore
#else
        public List<string> ExcludedFileExtensionsForSyncApp { get; set; }
#endif
        /// <summary>Specifies the idle session sign-out policies for the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.IdleSessionSignOut? IdleSessionSignOut { get; set; }
#nullable restore
#else
        public ApiSdk.Models.IdleSessionSignOut IdleSessionSignOut { get; set; }
#endif
        /// <summary>Specifies the image tagging option for the tenant. Possible values are: disabled, basic, enhanced.</summary>
        public ImageTaggingChoice? ImageTaggingOption { get; set; }
        /// <summary>Indicates whether comments are allowed on modern site pages in SharePoint.</summary>
        public bool? IsCommentingOnSitePagesEnabled { get; set; }
        /// <summary>Indicates whether push notifications are enabled for OneDrive events.</summary>
        public bool? IsFileActivityNotificationEnabled { get; set; }
        /// <summary>Indicates whether legacy authentication protocols are enabled for the tenant.</summary>
        public bool? IsLegacyAuthProtocolsEnabled { get; set; }
        /// <summary>Indicates whether if Fluid Framework is allowed on SharePoint sites.</summary>
        public bool? IsLoopEnabled { get; set; }
        /// <summary>Indicates whether files can be synced using the OneDrive sync app for Mac.</summary>
        public bool? IsMacSyncAppEnabled { get; set; }
        /// <summary>Indicates whether guests must sign in using the same account to which sharing invitations are sent.</summary>
        public bool? IsRequireAcceptingUserToMatchInvitedUserEnabled { get; set; }
        /// <summary>Indicates whether guests are allowed to reshare files, folders, and sites they don&apos;t own.</summary>
        public bool? IsResharingByExternalUsersEnabled { get; set; }
        /// <summary>Indicates whether mobile push notifications are enabled for SharePoint.</summary>
        public bool? IsSharePointMobileNotificationEnabled { get; set; }
        /// <summary>Indicates whether the newsfeed is allowed on the modern site pages in SharePoint.</summary>
        public bool? IsSharePointNewsfeedEnabled { get; set; }
        /// <summary>Indicates whether users are allowed to create sites.</summary>
        public bool? IsSiteCreationEnabled { get; set; }
        /// <summary>Indicates whether the UI commands for creating sites are shown.</summary>
        public bool? IsSiteCreationUIEnabled { get; set; }
        /// <summary>Indicates whether creating new modern pages is allowed on SharePoint sites.</summary>
        public bool? IsSitePagesCreationEnabled { get; set; }
        /// <summary>Indicates whether site storage space is automatically managed or if specific storage limits are set per site.</summary>
        public bool? IsSitesStorageLimitAutomatic { get; set; }
        /// <summary>Indicates whether the sync button in OneDrive is hidden.</summary>
        public bool? IsSyncButtonHiddenOnPersonalSite { get; set; }
        /// <summary>Indicates whether users are allowed to sync files only on PCs joined to specific domains.</summary>
        public bool? IsUnmanagedSyncAppForTenantRestricted { get; set; }
        /// <summary>The default OneDrive storage limit for all new and existing users who are assigned a qualifying license. Measured in megabytes (MB).</summary>
        public long? PersonalSiteDefaultStorageLimitInMB { get; set; }
        /// <summary>Collection of email domains that are allowed for sharing outside the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SharingAllowedDomainList { get; set; }
#nullable restore
#else
        public List<string> SharingAllowedDomainList { get; set; }
#endif
        /// <summary>Collection of email domains that are blocked for sharing outside the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SharingBlockedDomainList { get; set; }
#nullable restore
#else
        public List<string> SharingBlockedDomainList { get; set; }
#endif
        /// <summary>Sharing capability for the tenant. Possible values are: disabled, externalUserSharingOnly, externalUserAndGuestSharing, existingExternalUserSharingOnly.</summary>
        public SharingCapabilities? SharingCapability { get; set; }
        /// <summary>Specifies the external sharing mode for domains. Possible values are: none, allowList, blockList.</summary>
        public ApiSdk.Models.SharingDomainRestrictionMode? SharingDomainRestrictionMode { get; set; }
        /// <summary>The value of the team site managed path. This is the path under which new team sites will be created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SiteCreationDefaultManagedPath { get; set; }
#nullable restore
#else
        public string SiteCreationDefaultManagedPath { get; set; }
#endif
        /// <summary>The default storage quota for a new site upon creation. Measured in megabytes (MB).</summary>
        public int? SiteCreationDefaultStorageLimitInMB { get; set; }
        /// <summary>The default timezone of a tenant for newly created sites. For a list of possible values, see SPRegionalSettings.TimeZones property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantDefaultTimezone { get; set; }
#nullable restore
#else
        public string TenantDefaultTimezone { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SharepointSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharepointSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedDomainGuidsForSyncApp", n => { AllowedDomainGuidsForSyncApp = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
                {"availableManagedPathsForSiteCreation", n => { AvailableManagedPathsForSiteCreation = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"deletedUserPersonalSiteRetentionPeriodInDays", n => { DeletedUserPersonalSiteRetentionPeriodInDays = n.GetIntValue(); } },
                {"excludedFileExtensionsForSyncApp", n => { ExcludedFileExtensionsForSyncApp = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"idleSessionSignOut", n => { IdleSessionSignOut = n.GetObjectValue<ApiSdk.Models.IdleSessionSignOut>(ApiSdk.Models.IdleSessionSignOut.CreateFromDiscriminatorValue); } },
                {"imageTaggingOption", n => { ImageTaggingOption = n.GetEnumValue<ImageTaggingChoice>(); } },
                {"isCommentingOnSitePagesEnabled", n => { IsCommentingOnSitePagesEnabled = n.GetBoolValue(); } },
                {"isFileActivityNotificationEnabled", n => { IsFileActivityNotificationEnabled = n.GetBoolValue(); } },
                {"isLegacyAuthProtocolsEnabled", n => { IsLegacyAuthProtocolsEnabled = n.GetBoolValue(); } },
                {"isLoopEnabled", n => { IsLoopEnabled = n.GetBoolValue(); } },
                {"isMacSyncAppEnabled", n => { IsMacSyncAppEnabled = n.GetBoolValue(); } },
                {"isRequireAcceptingUserToMatchInvitedUserEnabled", n => { IsRequireAcceptingUserToMatchInvitedUserEnabled = n.GetBoolValue(); } },
                {"isResharingByExternalUsersEnabled", n => { IsResharingByExternalUsersEnabled = n.GetBoolValue(); } },
                {"isSharePointMobileNotificationEnabled", n => { IsSharePointMobileNotificationEnabled = n.GetBoolValue(); } },
                {"isSharePointNewsfeedEnabled", n => { IsSharePointNewsfeedEnabled = n.GetBoolValue(); } },
                {"isSiteCreationEnabled", n => { IsSiteCreationEnabled = n.GetBoolValue(); } },
                {"isSiteCreationUIEnabled", n => { IsSiteCreationUIEnabled = n.GetBoolValue(); } },
                {"isSitePagesCreationEnabled", n => { IsSitePagesCreationEnabled = n.GetBoolValue(); } },
                {"isSitesStorageLimitAutomatic", n => { IsSitesStorageLimitAutomatic = n.GetBoolValue(); } },
                {"isSyncButtonHiddenOnPersonalSite", n => { IsSyncButtonHiddenOnPersonalSite = n.GetBoolValue(); } },
                {"isUnmanagedSyncAppForTenantRestricted", n => { IsUnmanagedSyncAppForTenantRestricted = n.GetBoolValue(); } },
                {"personalSiteDefaultStorageLimitInMB", n => { PersonalSiteDefaultStorageLimitInMB = n.GetLongValue(); } },
                {"sharingAllowedDomainList", n => { SharingAllowedDomainList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"sharingBlockedDomainList", n => { SharingBlockedDomainList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"sharingCapability", n => { SharingCapability = n.GetEnumValue<SharingCapabilities>(); } },
                {"sharingDomainRestrictionMode", n => { SharingDomainRestrictionMode = n.GetEnumValue<SharingDomainRestrictionMode>(); } },
                {"siteCreationDefaultManagedPath", n => { SiteCreationDefaultManagedPath = n.GetStringValue(); } },
                {"siteCreationDefaultStorageLimitInMB", n => { SiteCreationDefaultStorageLimitInMB = n.GetIntValue(); } },
                {"tenantDefaultTimezone", n => { TenantDefaultTimezone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("allowedDomainGuidsForSyncApp", AllowedDomainGuidsForSyncApp);
            writer.WriteCollectionOfPrimitiveValues<string>("availableManagedPathsForSiteCreation", AvailableManagedPathsForSiteCreation);
            writer.WriteIntValue("deletedUserPersonalSiteRetentionPeriodInDays", DeletedUserPersonalSiteRetentionPeriodInDays);
            writer.WriteCollectionOfPrimitiveValues<string>("excludedFileExtensionsForSyncApp", ExcludedFileExtensionsForSyncApp);
            writer.WriteObjectValue<ApiSdk.Models.IdleSessionSignOut>("idleSessionSignOut", IdleSessionSignOut);
            writer.WriteEnumValue<ImageTaggingChoice>("imageTaggingOption", ImageTaggingOption);
            writer.WriteBoolValue("isCommentingOnSitePagesEnabled", IsCommentingOnSitePagesEnabled);
            writer.WriteBoolValue("isFileActivityNotificationEnabled", IsFileActivityNotificationEnabled);
            writer.WriteBoolValue("isLegacyAuthProtocolsEnabled", IsLegacyAuthProtocolsEnabled);
            writer.WriteBoolValue("isLoopEnabled", IsLoopEnabled);
            writer.WriteBoolValue("isMacSyncAppEnabled", IsMacSyncAppEnabled);
            writer.WriteBoolValue("isRequireAcceptingUserToMatchInvitedUserEnabled", IsRequireAcceptingUserToMatchInvitedUserEnabled);
            writer.WriteBoolValue("isResharingByExternalUsersEnabled", IsResharingByExternalUsersEnabled);
            writer.WriteBoolValue("isSharePointMobileNotificationEnabled", IsSharePointMobileNotificationEnabled);
            writer.WriteBoolValue("isSharePointNewsfeedEnabled", IsSharePointNewsfeedEnabled);
            writer.WriteBoolValue("isSiteCreationEnabled", IsSiteCreationEnabled);
            writer.WriteBoolValue("isSiteCreationUIEnabled", IsSiteCreationUIEnabled);
            writer.WriteBoolValue("isSitePagesCreationEnabled", IsSitePagesCreationEnabled);
            writer.WriteBoolValue("isSitesStorageLimitAutomatic", IsSitesStorageLimitAutomatic);
            writer.WriteBoolValue("isSyncButtonHiddenOnPersonalSite", IsSyncButtonHiddenOnPersonalSite);
            writer.WriteBoolValue("isUnmanagedSyncAppForTenantRestricted", IsUnmanagedSyncAppForTenantRestricted);
            writer.WriteLongValue("personalSiteDefaultStorageLimitInMB", PersonalSiteDefaultStorageLimitInMB);
            writer.WriteCollectionOfPrimitiveValues<string>("sharingAllowedDomainList", SharingAllowedDomainList);
            writer.WriteCollectionOfPrimitiveValues<string>("sharingBlockedDomainList", SharingBlockedDomainList);
            writer.WriteEnumValue<SharingCapabilities>("sharingCapability", SharingCapability);
            writer.WriteEnumValue<SharingDomainRestrictionMode>("sharingDomainRestrictionMode", SharingDomainRestrictionMode);
            writer.WriteStringValue("siteCreationDefaultManagedPath", SiteCreationDefaultManagedPath);
            writer.WriteIntValue("siteCreationDefaultStorageLimitInMB", SiteCreationDefaultStorageLimitInMB);
            writer.WriteStringValue("tenantDefaultTimezone", TenantDefaultTimezone);
        }
    }
}
