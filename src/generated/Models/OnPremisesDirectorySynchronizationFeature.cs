using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class OnPremisesDirectorySynchronizationFeature : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Used to block cloud object takeover via source anchor hard match if enabled.</summary>
        public bool? BlockCloudObjectTakeoverThroughHardMatchEnabled { get; set; }
        /// <summary>Use to block soft match for all objects if enabled for the  tenant. Customers are encouraged to enable this feature and keep it enabled until soft matching is required again for their tenancy. This flag should be enabled again after any soft matching has been completed and is no longer needed.</summary>
        public bool? BlockSoftMatchEnabled { get; set; }
        /// <summary>When true, persists the values of Mobile and OtherMobile in on-premises AD during sync cycles instead of values of MobilePhone or AlternateMobilePhones in Azure AD.</summary>
        public bool? BypassDirSyncOverridesEnabled { get; set; }
        /// <summary>Used to indicate that cloud password policy applies to users whose passwords are synchronized from on-premises.</summary>
        public bool? CloudPasswordPolicyForPasswordSyncedUsersEnabled { get; set; }
        /// <summary>Used to enable concurrent user credentials update in OrgId.</summary>
        public bool? ConcurrentCredentialUpdateEnabled { get; set; }
        /// <summary>Used to enable concurrent user creation in OrgId.</summary>
        public bool? ConcurrentOrgIdProvisioningEnabled { get; set; }
        /// <summary>Used to indicate that device write-back is enabled.</summary>
        public bool? DeviceWritebackEnabled { get; set; }
        /// <summary>Used to indicate that directory extensions are being synced from on-premises AD to Azure AD.</summary>
        public bool? DirectoryExtensionsEnabled { get; set; }
        /// <summary>Used to indicate that for a Microsoft Forefront Online Protection for Exchange (FOPE) migrated tenant, the conflicting proxy address should be migrated over.</summary>
        public bool? FopeConflictResolutionEnabled { get; set; }
        /// <summary>Used to enable object-level group writeback feature for additional group types.</summary>
        public bool? GroupWriteBackEnabled { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Used to indicate on-premise password synchronization is enabled.</summary>
        public bool? PasswordSyncEnabled { get; set; }
        /// <summary>Used to indicate that writeback of password resets from Azure AD to on-premises AD is enabled.</summary>
        public bool? PasswordWritebackEnabled { get; set; }
        /// <summary>Used to indicate that we should quarantine objects with conflicting proxy address.</summary>
        public bool? QuarantineUponProxyAddressesConflictEnabled { get; set; }
        /// <summary>Used to indicate that we should quarantine objects conflicting with duplicate userPrincipalName.</summary>
        public bool? QuarantineUponUpnConflictEnabled { get; set; }
        /// <summary>Used to indicate that we should soft match objects based on userPrincipalName.</summary>
        public bool? SoftMatchOnUpnEnabled { get; set; }
        /// <summary>Used to indicate that we should synchronize userPrincipalName objects for managed users with licenses.</summary>
        public bool? SynchronizeUpnForManagedUsersEnabled { get; set; }
        /// <summary>Used to indicate that Microsoft 365 Group write-back is enabled.</summary>
        public bool? UnifiedGroupWritebackEnabled { get; set; }
        /// <summary>Used to indicate that feature to force password change for a user on logon is enabled while synchronizing on-premise credentials.</summary>
        public bool? UserForcePasswordChangeOnLogonEnabled { get; set; }
        /// <summary>Used to indicate that user writeback is enabled.</summary>
        public bool? UserWritebackEnabled { get; set; }
        /// <summary>
        /// Instantiates a new OnPremisesDirectorySynchronizationFeature and sets the default values.
        /// </summary>
        public OnPremisesDirectorySynchronizationFeature() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OnPremisesDirectorySynchronizationFeature CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesDirectorySynchronizationFeature();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"blockCloudObjectTakeoverThroughHardMatchEnabled", n => { BlockCloudObjectTakeoverThroughHardMatchEnabled = n.GetBoolValue(); } },
                {"blockSoftMatchEnabled", n => { BlockSoftMatchEnabled = n.GetBoolValue(); } },
                {"bypassDirSyncOverridesEnabled", n => { BypassDirSyncOverridesEnabled = n.GetBoolValue(); } },
                {"cloudPasswordPolicyForPasswordSyncedUsersEnabled", n => { CloudPasswordPolicyForPasswordSyncedUsersEnabled = n.GetBoolValue(); } },
                {"concurrentCredentialUpdateEnabled", n => { ConcurrentCredentialUpdateEnabled = n.GetBoolValue(); } },
                {"concurrentOrgIdProvisioningEnabled", n => { ConcurrentOrgIdProvisioningEnabled = n.GetBoolValue(); } },
                {"deviceWritebackEnabled", n => { DeviceWritebackEnabled = n.GetBoolValue(); } },
                {"directoryExtensionsEnabled", n => { DirectoryExtensionsEnabled = n.GetBoolValue(); } },
                {"fopeConflictResolutionEnabled", n => { FopeConflictResolutionEnabled = n.GetBoolValue(); } },
                {"groupWriteBackEnabled", n => { GroupWriteBackEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"passwordSyncEnabled", n => { PasswordSyncEnabled = n.GetBoolValue(); } },
                {"passwordWritebackEnabled", n => { PasswordWritebackEnabled = n.GetBoolValue(); } },
                {"quarantineUponProxyAddressesConflictEnabled", n => { QuarantineUponProxyAddressesConflictEnabled = n.GetBoolValue(); } },
                {"quarantineUponUpnConflictEnabled", n => { QuarantineUponUpnConflictEnabled = n.GetBoolValue(); } },
                {"softMatchOnUpnEnabled", n => { SoftMatchOnUpnEnabled = n.GetBoolValue(); } },
                {"synchronizeUpnForManagedUsersEnabled", n => { SynchronizeUpnForManagedUsersEnabled = n.GetBoolValue(); } },
                {"unifiedGroupWritebackEnabled", n => { UnifiedGroupWritebackEnabled = n.GetBoolValue(); } },
                {"userForcePasswordChangeOnLogonEnabled", n => { UserForcePasswordChangeOnLogonEnabled = n.GetBoolValue(); } },
                {"userWritebackEnabled", n => { UserWritebackEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("blockCloudObjectTakeoverThroughHardMatchEnabled", BlockCloudObjectTakeoverThroughHardMatchEnabled);
            writer.WriteBoolValue("blockSoftMatchEnabled", BlockSoftMatchEnabled);
            writer.WriteBoolValue("bypassDirSyncOverridesEnabled", BypassDirSyncOverridesEnabled);
            writer.WriteBoolValue("cloudPasswordPolicyForPasswordSyncedUsersEnabled", CloudPasswordPolicyForPasswordSyncedUsersEnabled);
            writer.WriteBoolValue("concurrentCredentialUpdateEnabled", ConcurrentCredentialUpdateEnabled);
            writer.WriteBoolValue("concurrentOrgIdProvisioningEnabled", ConcurrentOrgIdProvisioningEnabled);
            writer.WriteBoolValue("deviceWritebackEnabled", DeviceWritebackEnabled);
            writer.WriteBoolValue("directoryExtensionsEnabled", DirectoryExtensionsEnabled);
            writer.WriteBoolValue("fopeConflictResolutionEnabled", FopeConflictResolutionEnabled);
            writer.WriteBoolValue("groupWriteBackEnabled", GroupWriteBackEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("passwordSyncEnabled", PasswordSyncEnabled);
            writer.WriteBoolValue("passwordWritebackEnabled", PasswordWritebackEnabled);
            writer.WriteBoolValue("quarantineUponProxyAddressesConflictEnabled", QuarantineUponProxyAddressesConflictEnabled);
            writer.WriteBoolValue("quarantineUponUpnConflictEnabled", QuarantineUponUpnConflictEnabled);
            writer.WriteBoolValue("softMatchOnUpnEnabled", SoftMatchOnUpnEnabled);
            writer.WriteBoolValue("synchronizeUpnForManagedUsersEnabled", SynchronizeUpnForManagedUsersEnabled);
            writer.WriteBoolValue("unifiedGroupWritebackEnabled", UnifiedGroupWritebackEnabled);
            writer.WriteBoolValue("userForcePasswordChangeOnLogonEnabled", UserForcePasswordChangeOnLogonEnabled);
            writer.WriteBoolValue("userWritebackEnabled", UserWritebackEnabled);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
