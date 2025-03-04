using System.Runtime.Serialization;
using System;
namespace ApiSdk.Models {
    public enum ManagementAgentType {
        /// <summary>The device is managed by Exchange server.</summary>
        [EnumMember(Value = "eas")]
        Eas,
        /// <summary>The device is managed by Intune MDM.</summary>
        [EnumMember(Value = "mdm")]
        Mdm,
        /// <summary>The device is managed by both Exchange server and Intune MDM.</summary>
        [EnumMember(Value = "easMdm")]
        EasMdm,
        /// <summary>Intune client managed.</summary>
        [EnumMember(Value = "intuneClient")]
        IntuneClient,
        /// <summary>The device is EAS and Intune client dual managed.</summary>
        [EnumMember(Value = "easIntuneClient")]
        EasIntuneClient,
        /// <summary>The device is managed by Configuration Manager.</summary>
        [EnumMember(Value = "configurationManagerClient")]
        ConfigurationManagerClient,
        /// <summary>The device is managed by Configuration Manager and MDM.</summary>
        [EnumMember(Value = "configurationManagerClientMdm")]
        ConfigurationManagerClientMdm,
        /// <summary>The device is managed by Configuration Manager, MDM and Eas.</summary>
        [EnumMember(Value = "configurationManagerClientMdmEas")]
        ConfigurationManagerClientMdmEas,
        /// <summary>Unknown management agent type.</summary>
        [EnumMember(Value = "unknown")]
        Unknown,
        /// <summary>The device attributes are fetched from Jamf.</summary>
        [EnumMember(Value = "jamf")]
        Jamf,
        /// <summary>The device is managed by Google&apos;s CloudDPC.</summary>
        [EnumMember(Value = "googleCloudDevicePolicyController")]
        GoogleCloudDevicePolicyController,
        /// <summary>This device is managed by Microsoft 365 through Intune.</summary>
        [EnumMember(Value = "microsoft365ManagedMdm")]
        Microsoft365ManagedMdm,
        [EnumMember(Value = "msSense")]
        MsSense,
    }
}
