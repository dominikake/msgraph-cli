using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class DeviceManagement : Entity, IParsable {
        /// <summary>Apple push notification certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ApplePushNotificationCertificate? ApplePushNotificationCertificate { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ApplePushNotificationCertificate ApplePushNotificationCertificate { get; set; }
#endif
        /// <summary>The Audit Events</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuditEvent>? AuditEvents { get; set; }
#nullable restore
#else
        public List<AuditEvent> AuditEvents { get; set; }
#endif
        /// <summary>The list of Compliance Management Partners configured by the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ComplianceManagementPartner>? ComplianceManagementPartners { get; set; }
#nullable restore
#else
        public List<ComplianceManagementPartner> ComplianceManagementPartners { get; set; }
#endif
        /// <summary>The Exchange on premises conditional access settings. On premises conditional access will require devices to be both enrolled and compliant for mail access</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OnPremisesConditionalAccessSettings? ConditionalAccessSettings { get; set; }
#nullable restore
#else
        public OnPremisesConditionalAccessSettings ConditionalAccessSettings { get; set; }
#endif
        /// <summary>The list of detected apps associated with a device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DetectedApp>? DetectedApps { get; set; }
#nullable restore
#else
        public List<DetectedApp> DetectedApps { get; set; }
#endif
        /// <summary>The list of device categories with the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceCategory>? DeviceCategories { get; set; }
#nullable restore
#else
        public List<DeviceCategory> DeviceCategories { get; set; }
#endif
        /// <summary>The device compliance policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceCompliancePolicy>? DeviceCompliancePolicies { get; set; }
#nullable restore
#else
        public List<DeviceCompliancePolicy> DeviceCompliancePolicies { get; set; }
#endif
        /// <summary>The device compliance state summary for this account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.DeviceCompliancePolicyDeviceStateSummary? DeviceCompliancePolicyDeviceStateSummary { get; set; }
#nullable restore
#else
        public ApiSdk.Models.DeviceCompliancePolicyDeviceStateSummary DeviceCompliancePolicyDeviceStateSummary { get; set; }
#endif
        /// <summary>The summary states of compliance policy settings for this account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceCompliancePolicySettingStateSummary>? DeviceCompliancePolicySettingStateSummaries { get; set; }
#nullable restore
#else
        public List<DeviceCompliancePolicySettingStateSummary> DeviceCompliancePolicySettingStateSummaries { get; set; }
#endif
        /// <summary>The device configuration device state summary for this account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceConfigurationDeviceStateSummary? DeviceConfigurationDeviceStateSummaries { get; set; }
#nullable restore
#else
        public DeviceConfigurationDeviceStateSummary DeviceConfigurationDeviceStateSummaries { get; set; }
#endif
        /// <summary>The device configurations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceConfiguration>? DeviceConfigurations { get; set; }
#nullable restore
#else
        public List<DeviceConfiguration> DeviceConfigurations { get; set; }
#endif
        /// <summary>The list of device enrollment configurations</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceEnrollmentConfiguration>? DeviceEnrollmentConfigurations { get; set; }
#nullable restore
#else
        public List<DeviceEnrollmentConfiguration> DeviceEnrollmentConfigurations { get; set; }
#endif
        /// <summary>The list of Device Management Partners configured by the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementPartner>? DeviceManagementPartners { get; set; }
#nullable restore
#else
        public List<DeviceManagementPartner> DeviceManagementPartners { get; set; }
#endif
        /// <summary>Device protection overview.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.DeviceProtectionOverview? DeviceProtectionOverview { get; set; }
#nullable restore
#else
        public ApiSdk.Models.DeviceProtectionOverview DeviceProtectionOverview { get; set; }
#endif
        /// <summary>The list of Exchange Connectors configured by the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementExchangeConnector>? ExchangeConnectors { get; set; }
#nullable restore
#else
        public List<DeviceManagementExchangeConnector> ExchangeConnectors { get; set; }
#endif
        /// <summary>Collection of imported Windows autopilot devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ImportedWindowsAutopilotDeviceIdentity>? ImportedWindowsAutopilotDeviceIdentities { get; set; }
#nullable restore
#else
        public List<ImportedWindowsAutopilotDeviceIdentity> ImportedWindowsAutopilotDeviceIdentities { get; set; }
#endif
        /// <summary>Intune Account Id for given tenant</summary>
        public Guid? IntuneAccountId { get; set; }
        /// <summary>intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.IntuneBrand? IntuneBrand { get; set; }
#nullable restore
#else
        public ApiSdk.Models.IntuneBrand IntuneBrand { get; set; }
#endif
        /// <summary>The IOS software update installation statuses for this account.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IosUpdateDeviceStatus>? IosUpdateStatuses { get; set; }
#nullable restore
#else
        public List<IosUpdateDeviceStatus> IosUpdateStatuses { get; set; }
#endif
        /// <summary>Device overview</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.ManagedDeviceOverview? ManagedDeviceOverview { get; set; }
#nullable restore
#else
        public ApiSdk.Models.ManagedDeviceOverview ManagedDeviceOverview { get; set; }
#endif
        /// <summary>The list of managed devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedDevice>? ManagedDevices { get; set; }
#nullable restore
#else
        public List<ManagedDevice> ManagedDevices { get; set; }
#endif
        /// <summary>The collection property of MobileAppTroubleshootingEvent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MobileAppTroubleshootingEvent>? MobileAppTroubleshootingEvents { get; set; }
#nullable restore
#else
        public List<MobileAppTroubleshootingEvent> MobileAppTroubleshootingEvents { get; set; }
#endif
        /// <summary>The list of Mobile threat Defense connectors configured by the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MobileThreatDefenseConnector>? MobileThreatDefenseConnectors { get; set; }
#nullable restore
#else
        public List<MobileThreatDefenseConnector> MobileThreatDefenseConnectors { get; set; }
#endif
        /// <summary>The Notification Message Templates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<NotificationMessageTemplate>? NotificationMessageTemplates { get; set; }
#nullable restore
#else
        public List<NotificationMessageTemplate> NotificationMessageTemplates { get; set; }
#endif
        /// <summary>The remote assist partners.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RemoteAssistancePartner>? RemoteAssistancePartners { get; set; }
#nullable restore
#else
        public List<RemoteAssistancePartner> RemoteAssistancePartners { get; set; }
#endif
        /// <summary>Reports singleton</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementReports? Reports { get; set; }
#nullable restore
#else
        public DeviceManagementReports Reports { get; set; }
#endif
        /// <summary>The Resource Operations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ResourceOperation>? ResourceOperations { get; set; }
#nullable restore
#else
        public List<ResourceOperation> ResourceOperations { get; set; }
#endif
        /// <summary>The Role Assignments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceAndAppManagementRoleAssignment>? RoleAssignments { get; set; }
#nullable restore
#else
        public List<DeviceAndAppManagementRoleAssignment> RoleAssignments { get; set; }
#endif
        /// <summary>The Role Definitions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RoleDefinition>? RoleDefinitions { get; set; }
#nullable restore
#else
        public List<RoleDefinition> RoleDefinitions { get; set; }
#endif
        /// <summary>Account level settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceManagementSettings? Settings { get; set; }
#nullable restore
#else
        public DeviceManagementSettings Settings { get; set; }
#endif
        /// <summary>The software update status summary.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.SoftwareUpdateStatusSummary? SoftwareUpdateStatusSummary { get; set; }
#nullable restore
#else
        public ApiSdk.Models.SoftwareUpdateStatusSummary SoftwareUpdateStatusSummary { get; set; }
#endif
        /// <summary>Tenant mobile device management subscription state.</summary>
        public DeviceManagementSubscriptionState? SubscriptionState { get; set; }
        /// <summary>The telecom expense management partners.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TelecomExpenseManagementPartner>? TelecomExpenseManagementPartners { get; set; }
#nullable restore
#else
        public List<TelecomExpenseManagementPartner> TelecomExpenseManagementPartners { get; set; }
#endif
        /// <summary>The terms and conditions associated with device management of the company.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.TermsAndConditions>? TermsAndConditions { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.TermsAndConditions> TermsAndConditions { get; set; }
#endif
        /// <summary>The list of troubleshooting events for the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceManagementTroubleshootingEvent>? TroubleshootingEvents { get; set; }
#nullable restore
#else
        public List<DeviceManagementTroubleshootingEvent> TroubleshootingEvents { get; set; }
#endif
        /// <summary>User experience analytics appHealth Application Performance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.UserExperienceAnalyticsAppHealthApplicationPerformance>? UserExperienceAnalyticsAppHealthApplicationPerformance { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.UserExperienceAnalyticsAppHealthApplicationPerformance> UserExperienceAnalyticsAppHealthApplicationPerformance { get; set; }
#endif
        /// <summary>User experience analytics appHealth Application Performance by App Version details</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>? UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails { get; set; }
#nullable restore
#else
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails> UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails { get; set; }
#endif
        /// <summary>User experience analytics appHealth Application Performance by App Version Device Id</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>? UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId { get; set; }
#nullable restore
#else
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId> UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId { get; set; }
#endif
        /// <summary>User experience analytics appHealth Application Performance by OS Version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>? UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion { get; set; }
#nullable restore
#else
        public List<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion> UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion { get; set; }
#endif
        /// <summary>User experience analytics appHealth Model Performance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance>? UserExperienceAnalyticsAppHealthDeviceModelPerformance { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance> UserExperienceAnalyticsAppHealthDeviceModelPerformance { get; set; }
#endif
        /// <summary>User experience analytics appHealth Device Performance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.UserExperienceAnalyticsAppHealthDevicePerformance>? UserExperienceAnalyticsAppHealthDevicePerformance { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.UserExperienceAnalyticsAppHealthDevicePerformance> UserExperienceAnalyticsAppHealthDevicePerformance { get; set; }
#endif
        /// <summary>User experience analytics device performance details</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails>? UserExperienceAnalyticsAppHealthDevicePerformanceDetails { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails> UserExperienceAnalyticsAppHealthDevicePerformanceDetails { get; set; }
#endif
        /// <summary>User experience analytics appHealth OS version Performance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance>? UserExperienceAnalyticsAppHealthOSVersionPerformance { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance> UserExperienceAnalyticsAppHealthOSVersionPerformance { get; set; }
#endif
        /// <summary>User experience analytics appHealth overview</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserExperienceAnalyticsCategory? UserExperienceAnalyticsAppHealthOverview { get; set; }
#nullable restore
#else
        public UserExperienceAnalyticsCategory UserExperienceAnalyticsAppHealthOverview { get; set; }
#endif
        /// <summary>User experience analytics baselines</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsBaseline>? UserExperienceAnalyticsBaselines { get; set; }
#nullable restore
#else
        public List<UserExperienceAnalyticsBaseline> UserExperienceAnalyticsBaselines { get; set; }
#endif
        /// <summary>User experience analytics categories</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsCategory>? UserExperienceAnalyticsCategories { get; set; }
#nullable restore
#else
        public List<UserExperienceAnalyticsCategory> UserExperienceAnalyticsCategories { get; set; }
#endif
        /// <summary>User experience analytics device performance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.UserExperienceAnalyticsDevicePerformance>? UserExperienceAnalyticsDevicePerformance { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.UserExperienceAnalyticsDevicePerformance> UserExperienceAnalyticsDevicePerformance { get; set; }
#endif
        /// <summary>User experience analytics device scores</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.UserExperienceAnalyticsDeviceScores>? UserExperienceAnalyticsDeviceScores { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.UserExperienceAnalyticsDeviceScores> UserExperienceAnalyticsDeviceScores { get; set; }
#endif
        /// <summary>User experience analytics device Startup History</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.UserExperienceAnalyticsDeviceStartupHistory>? UserExperienceAnalyticsDeviceStartupHistory { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.UserExperienceAnalyticsDeviceStartupHistory> UserExperienceAnalyticsDeviceStartupHistory { get; set; }
#endif
        /// <summary>User experience analytics device Startup Processes</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsDeviceStartupProcess>? UserExperienceAnalyticsDeviceStartupProcesses { get; set; }
#nullable restore
#else
        public List<UserExperienceAnalyticsDeviceStartupProcess> UserExperienceAnalyticsDeviceStartupProcesses { get; set; }
#endif
        /// <summary>User experience analytics metric history</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.UserExperienceAnalyticsMetricHistory>? UserExperienceAnalyticsMetricHistory { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.UserExperienceAnalyticsMetricHistory> UserExperienceAnalyticsMetricHistory { get; set; }
#endif
        /// <summary>User experience analytics model scores</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.UserExperienceAnalyticsModelScores>? UserExperienceAnalyticsModelScores { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.UserExperienceAnalyticsModelScores> UserExperienceAnalyticsModelScores { get; set; }
#endif
        /// <summary>User experience analytics overview</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.UserExperienceAnalyticsOverview? UserExperienceAnalyticsOverview { get; set; }
#nullable restore
#else
        public ApiSdk.Models.UserExperienceAnalyticsOverview UserExperienceAnalyticsOverview { get; set; }
#endif
        /// <summary>User experience analytics device Startup Score History</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.UserExperienceAnalyticsScoreHistory>? UserExperienceAnalyticsScoreHistory { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.UserExperienceAnalyticsScoreHistory> UserExperienceAnalyticsScoreHistory { get; set; }
#endif
        /// <summary>User experience analytics device settings</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.UserExperienceAnalyticsSettings? UserExperienceAnalyticsSettings { get; set; }
#nullable restore
#else
        public ApiSdk.Models.UserExperienceAnalyticsSettings UserExperienceAnalyticsSettings { get; set; }
#endif
        /// <summary>User experience analytics work from anywhere hardware readiness metrics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric? UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric { get; set; }
#nullable restore
#else
        public ApiSdk.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric { get; set; }
#endif
        /// <summary>User experience analytics work from anywhere metrics.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserExperienceAnalyticsWorkFromAnywhereMetric>? UserExperienceAnalyticsWorkFromAnywhereMetrics { get; set; }
#nullable restore
#else
        public List<UserExperienceAnalyticsWorkFromAnywhereMetric> UserExperienceAnalyticsWorkFromAnywhereMetrics { get; set; }
#endif
        /// <summary>The user experience analytics work from anywhere model performance</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance>? UserExperienceAnalyticsWorkFromAnywhereModelPerformance { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance> UserExperienceAnalyticsWorkFromAnywhereModelPerformance { get; set; }
#endif
        /// <summary>The Windows autopilot device identities contained collection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsAutopilotDeviceIdentity>? WindowsAutopilotDeviceIdentities { get; set; }
#nullable restore
#else
        public List<WindowsAutopilotDeviceIdentity> WindowsAutopilotDeviceIdentities { get; set; }
#endif
        /// <summary>The windows information protection app learning summaries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionAppLearningSummary>? WindowsInformationProtectionAppLearningSummaries { get; set; }
#nullable restore
#else
        public List<WindowsInformationProtectionAppLearningSummary> WindowsInformationProtectionAppLearningSummaries { get; set; }
#endif
        /// <summary>The windows information protection network learning summaries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionNetworkLearningSummary>? WindowsInformationProtectionNetworkLearningSummaries { get; set; }
#nullable restore
#else
        public List<WindowsInformationProtectionNetworkLearningSummary> WindowsInformationProtectionNetworkLearningSummaries { get; set; }
#endif
        /// <summary>The list of affected malware in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ApiSdk.Models.WindowsMalwareInformation>? WindowsMalwareInformation { get; set; }
#nullable restore
#else
        public List<ApiSdk.Models.WindowsMalwareInformation> WindowsMalwareInformation { get; set; }
#endif
        /// <summary>Malware overview for windows devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.WindowsMalwareOverview? WindowsMalwareOverview { get; set; }
#nullable restore
#else
        public ApiSdk.Models.WindowsMalwareOverview WindowsMalwareOverview { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applePushNotificationCertificate", n => { ApplePushNotificationCertificate = n.GetObjectValue<ApiSdk.Models.ApplePushNotificationCertificate>(ApiSdk.Models.ApplePushNotificationCertificate.CreateFromDiscriminatorValue); } },
                {"auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<AuditEvent>(AuditEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"complianceManagementPartners", n => { ComplianceManagementPartners = n.GetCollectionOfObjectValues<ComplianceManagementPartner>(ComplianceManagementPartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conditionalAccessSettings", n => { ConditionalAccessSettings = n.GetObjectValue<OnPremisesConditionalAccessSettings>(OnPremisesConditionalAccessSettings.CreateFromDiscriminatorValue); } },
                {"detectedApps", n => { DetectedApps = n.GetCollectionOfObjectValues<DetectedApp>(DetectedApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCategories", n => { DeviceCategories = n.GetCollectionOfObjectValues<DeviceCategory>(DeviceCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCompliancePolicies", n => { DeviceCompliancePolicies = n.GetCollectionOfObjectValues<DeviceCompliancePolicy>(DeviceCompliancePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCompliancePolicyDeviceStateSummary", n => { DeviceCompliancePolicyDeviceStateSummary = n.GetObjectValue<ApiSdk.Models.DeviceCompliancePolicyDeviceStateSummary>(ApiSdk.Models.DeviceCompliancePolicyDeviceStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceCompliancePolicySettingStateSummaries", n => { DeviceCompliancePolicySettingStateSummaries = n.GetCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>(DeviceCompliancePolicySettingStateSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceConfigurationDeviceStateSummaries", n => { DeviceConfigurationDeviceStateSummaries = n.GetObjectValue<DeviceConfigurationDeviceStateSummary>(DeviceConfigurationDeviceStateSummary.CreateFromDiscriminatorValue); } },
                {"deviceConfigurations", n => { DeviceConfigurations = n.GetCollectionOfObjectValues<DeviceConfiguration>(DeviceConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceEnrollmentConfigurations", n => { DeviceEnrollmentConfigurations = n.GetCollectionOfObjectValues<DeviceEnrollmentConfiguration>(DeviceEnrollmentConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceManagementPartners", n => { DeviceManagementPartners = n.GetCollectionOfObjectValues<DeviceManagementPartner>(DeviceManagementPartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceProtectionOverview", n => { DeviceProtectionOverview = n.GetObjectValue<ApiSdk.Models.DeviceProtectionOverview>(ApiSdk.Models.DeviceProtectionOverview.CreateFromDiscriminatorValue); } },
                {"exchangeConnectors", n => { ExchangeConnectors = n.GetCollectionOfObjectValues<DeviceManagementExchangeConnector>(DeviceManagementExchangeConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"importedWindowsAutopilotDeviceIdentities", n => { ImportedWindowsAutopilotDeviceIdentities = n.GetCollectionOfObjectValues<ImportedWindowsAutopilotDeviceIdentity>(ImportedWindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"intuneAccountId", n => { IntuneAccountId = n.GetGuidValue(); } },
                {"intuneBrand", n => { IntuneBrand = n.GetObjectValue<ApiSdk.Models.IntuneBrand>(ApiSdk.Models.IntuneBrand.CreateFromDiscriminatorValue); } },
                {"iosUpdateStatuses", n => { IosUpdateStatuses = n.GetCollectionOfObjectValues<IosUpdateDeviceStatus>(IosUpdateDeviceStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedDeviceOverview", n => { ManagedDeviceOverview = n.GetObjectValue<ApiSdk.Models.ManagedDeviceOverview>(ApiSdk.Models.ManagedDeviceOverview.CreateFromDiscriminatorValue); } },
                {"managedDevices", n => { ManagedDevices = n.GetCollectionOfObjectValues<ManagedDevice>(ManagedDevice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mobileAppTroubleshootingEvents", n => { MobileAppTroubleshootingEvents = n.GetCollectionOfObjectValues<MobileAppTroubleshootingEvent>(MobileAppTroubleshootingEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mobileThreatDefenseConnectors", n => { MobileThreatDefenseConnectors = n.GetCollectionOfObjectValues<MobileThreatDefenseConnector>(MobileThreatDefenseConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"notificationMessageTemplates", n => { NotificationMessageTemplates = n.GetCollectionOfObjectValues<NotificationMessageTemplate>(NotificationMessageTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"remoteAssistancePartners", n => { RemoteAssistancePartners = n.GetCollectionOfObjectValues<RemoteAssistancePartner>(RemoteAssistancePartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"reports", n => { Reports = n.GetObjectValue<DeviceManagementReports>(DeviceManagementReports.CreateFromDiscriminatorValue); } },
                {"resourceOperations", n => { ResourceOperations = n.GetCollectionOfObjectValues<ResourceOperation>(ResourceOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<DeviceAndAppManagementRoleAssignment>(DeviceAndAppManagementRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<RoleDefinition>(RoleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<DeviceManagementSettings>(DeviceManagementSettings.CreateFromDiscriminatorValue); } },
                {"softwareUpdateStatusSummary", n => { SoftwareUpdateStatusSummary = n.GetObjectValue<ApiSdk.Models.SoftwareUpdateStatusSummary>(ApiSdk.Models.SoftwareUpdateStatusSummary.CreateFromDiscriminatorValue); } },
                {"subscriptionState", n => { SubscriptionState = n.GetEnumValue<DeviceManagementSubscriptionState>(); } },
                {"telecomExpenseManagementPartners", n => { TelecomExpenseManagementPartners = n.GetCollectionOfObjectValues<TelecomExpenseManagementPartner>(TelecomExpenseManagementPartner.CreateFromDiscriminatorValue)?.ToList(); } },
                {"termsAndConditions", n => { TermsAndConditions = n.GetCollectionOfObjectValues<ApiSdk.Models.TermsAndConditions>(ApiSdk.Models.TermsAndConditions.CreateFromDiscriminatorValue)?.ToList(); } },
                {"troubleshootingEvents", n => { TroubleshootingEvents = n.GetCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>(DeviceManagementTroubleshootingEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformance", n => { UserExperienceAnalyticsAppHealthApplicationPerformance = n.GetCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsAppHealthApplicationPerformance>(ApiSdk.Models.UserExperienceAnalyticsAppHealthApplicationPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails", n => { UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId", n => { UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>(UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion", n => { UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion = n.GetCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>(UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthDeviceModelPerformance", n => { UserExperienceAnalyticsAppHealthDeviceModelPerformance = n.GetCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance>(ApiSdk.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthDevicePerformance", n => { UserExperienceAnalyticsAppHealthDevicePerformance = n.GetCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsAppHealthDevicePerformance>(ApiSdk.Models.UserExperienceAnalyticsAppHealthDevicePerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthDevicePerformanceDetails", n => { UserExperienceAnalyticsAppHealthDevicePerformanceDetails = n.GetCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails>(ApiSdk.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthOSVersionPerformance", n => { UserExperienceAnalyticsAppHealthOSVersionPerformance = n.GetCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance>(ApiSdk.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsAppHealthOverview", n => { UserExperienceAnalyticsAppHealthOverview = n.GetObjectValue<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsBaselines", n => { UserExperienceAnalyticsBaselines = n.GetCollectionOfObjectValues<UserExperienceAnalyticsBaseline>(UserExperienceAnalyticsBaseline.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsCategories", n => { UserExperienceAnalyticsCategories = n.GetCollectionOfObjectValues<UserExperienceAnalyticsCategory>(UserExperienceAnalyticsCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDevicePerformance", n => { UserExperienceAnalyticsDevicePerformance = n.GetCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsDevicePerformance>(ApiSdk.Models.UserExperienceAnalyticsDevicePerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDeviceScores", n => { UserExperienceAnalyticsDeviceScores = n.GetCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsDeviceScores>(ApiSdk.Models.UserExperienceAnalyticsDeviceScores.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDeviceStartupHistory", n => { UserExperienceAnalyticsDeviceStartupHistory = n.GetCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsDeviceStartupHistory>(ApiSdk.Models.UserExperienceAnalyticsDeviceStartupHistory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsDeviceStartupProcesses", n => { UserExperienceAnalyticsDeviceStartupProcesses = n.GetCollectionOfObjectValues<UserExperienceAnalyticsDeviceStartupProcess>(UserExperienceAnalyticsDeviceStartupProcess.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsMetricHistory", n => { UserExperienceAnalyticsMetricHistory = n.GetCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsMetricHistory>(ApiSdk.Models.UserExperienceAnalyticsMetricHistory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsModelScores", n => { UserExperienceAnalyticsModelScores = n.GetCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsModelScores>(ApiSdk.Models.UserExperienceAnalyticsModelScores.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsOverview", n => { UserExperienceAnalyticsOverview = n.GetObjectValue<ApiSdk.Models.UserExperienceAnalyticsOverview>(ApiSdk.Models.UserExperienceAnalyticsOverview.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsScoreHistory", n => { UserExperienceAnalyticsScoreHistory = n.GetCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsScoreHistory>(ApiSdk.Models.UserExperienceAnalyticsScoreHistory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsSettings", n => { UserExperienceAnalyticsSettings = n.GetObjectValue<ApiSdk.Models.UserExperienceAnalyticsSettings>(ApiSdk.Models.UserExperienceAnalyticsSettings.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric", n => { UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric = n.GetObjectValue<ApiSdk.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric>(ApiSdk.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric.CreateFromDiscriminatorValue); } },
                {"userExperienceAnalyticsWorkFromAnywhereMetrics", n => { UserExperienceAnalyticsWorkFromAnywhereMetrics = n.GetCollectionOfObjectValues<UserExperienceAnalyticsWorkFromAnywhereMetric>(UserExperienceAnalyticsWorkFromAnywhereMetric.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userExperienceAnalyticsWorkFromAnywhereModelPerformance", n => { UserExperienceAnalyticsWorkFromAnywhereModelPerformance = n.GetCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance>(ApiSdk.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsAutopilotDeviceIdentities", n => { WindowsAutopilotDeviceIdentities = n.GetCollectionOfObjectValues<WindowsAutopilotDeviceIdentity>(WindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsInformationProtectionAppLearningSummaries", n => { WindowsInformationProtectionAppLearningSummaries = n.GetCollectionOfObjectValues<WindowsInformationProtectionAppLearningSummary>(WindowsInformationProtectionAppLearningSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsInformationProtectionNetworkLearningSummaries", n => { WindowsInformationProtectionNetworkLearningSummaries = n.GetCollectionOfObjectValues<WindowsInformationProtectionNetworkLearningSummary>(WindowsInformationProtectionNetworkLearningSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsMalwareInformation", n => { WindowsMalwareInformation = n.GetCollectionOfObjectValues<ApiSdk.Models.WindowsMalwareInformation>(ApiSdk.Models.WindowsMalwareInformation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsMalwareOverview", n => { WindowsMalwareOverview = n.GetObjectValue<ApiSdk.Models.WindowsMalwareOverview>(ApiSdk.Models.WindowsMalwareOverview.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiSdk.Models.ApplePushNotificationCertificate>("applePushNotificationCertificate", ApplePushNotificationCertificate);
            writer.WriteCollectionOfObjectValues<AuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<ComplianceManagementPartner>("complianceManagementPartners", ComplianceManagementPartners);
            writer.WriteObjectValue<OnPremisesConditionalAccessSettings>("conditionalAccessSettings", ConditionalAccessSettings);
            writer.WriteCollectionOfObjectValues<DetectedApp>("detectedApps", DetectedApps);
            writer.WriteCollectionOfObjectValues<DeviceCategory>("deviceCategories", DeviceCategories);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicy>("deviceCompliancePolicies", DeviceCompliancePolicies);
            writer.WriteObjectValue<ApiSdk.Models.DeviceCompliancePolicyDeviceStateSummary>("deviceCompliancePolicyDeviceStateSummary", DeviceCompliancePolicyDeviceStateSummary);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicySettingStateSummary>("deviceCompliancePolicySettingStateSummaries", DeviceCompliancePolicySettingStateSummaries);
            writer.WriteObjectValue<DeviceConfigurationDeviceStateSummary>("deviceConfigurationDeviceStateSummaries", DeviceConfigurationDeviceStateSummaries);
            writer.WriteCollectionOfObjectValues<DeviceConfiguration>("deviceConfigurations", DeviceConfigurations);
            writer.WriteCollectionOfObjectValues<DeviceEnrollmentConfiguration>("deviceEnrollmentConfigurations", DeviceEnrollmentConfigurations);
            writer.WriteCollectionOfObjectValues<DeviceManagementPartner>("deviceManagementPartners", DeviceManagementPartners);
            writer.WriteObjectValue<ApiSdk.Models.DeviceProtectionOverview>("deviceProtectionOverview", DeviceProtectionOverview);
            writer.WriteCollectionOfObjectValues<DeviceManagementExchangeConnector>("exchangeConnectors", ExchangeConnectors);
            writer.WriteCollectionOfObjectValues<ImportedWindowsAutopilotDeviceIdentity>("importedWindowsAutopilotDeviceIdentities", ImportedWindowsAutopilotDeviceIdentities);
            writer.WriteGuidValue("intuneAccountId", IntuneAccountId);
            writer.WriteObjectValue<ApiSdk.Models.IntuneBrand>("intuneBrand", IntuneBrand);
            writer.WriteCollectionOfObjectValues<IosUpdateDeviceStatus>("iosUpdateStatuses", IosUpdateStatuses);
            writer.WriteObjectValue<ApiSdk.Models.ManagedDeviceOverview>("managedDeviceOverview", ManagedDeviceOverview);
            writer.WriteCollectionOfObjectValues<ManagedDevice>("managedDevices", ManagedDevices);
            writer.WriteCollectionOfObjectValues<MobileAppTroubleshootingEvent>("mobileAppTroubleshootingEvents", MobileAppTroubleshootingEvents);
            writer.WriteCollectionOfObjectValues<MobileThreatDefenseConnector>("mobileThreatDefenseConnectors", MobileThreatDefenseConnectors);
            writer.WriteCollectionOfObjectValues<NotificationMessageTemplate>("notificationMessageTemplates", NotificationMessageTemplates);
            writer.WriteCollectionOfObjectValues<RemoteAssistancePartner>("remoteAssistancePartners", RemoteAssistancePartners);
            writer.WriteObjectValue<DeviceManagementReports>("reports", Reports);
            writer.WriteCollectionOfObjectValues<ResourceOperation>("resourceOperations", ResourceOperations);
            writer.WriteCollectionOfObjectValues<DeviceAndAppManagementRoleAssignment>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<RoleDefinition>("roleDefinitions", RoleDefinitions);
            writer.WriteObjectValue<DeviceManagementSettings>("settings", Settings);
            writer.WriteObjectValue<ApiSdk.Models.SoftwareUpdateStatusSummary>("softwareUpdateStatusSummary", SoftwareUpdateStatusSummary);
            writer.WriteEnumValue<DeviceManagementSubscriptionState>("subscriptionState", SubscriptionState);
            writer.WriteCollectionOfObjectValues<TelecomExpenseManagementPartner>("telecomExpenseManagementPartners", TelecomExpenseManagementPartners);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.TermsAndConditions>("termsAndConditions", TermsAndConditions);
            writer.WriteCollectionOfObjectValues<DeviceManagementTroubleshootingEvent>("troubleshootingEvents", TroubleshootingEvents);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsAppHealthApplicationPerformance>("userExperienceAnalyticsAppHealthApplicationPerformance", UserExperienceAnalyticsAppHealthApplicationPerformance);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDetails>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails", UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDetails);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByAppVersionDeviceId>("userExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId", UserExperienceAnalyticsAppHealthApplicationPerformanceByAppVersionDeviceId);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsAppHealthAppPerformanceByOSVersion>("userExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion", UserExperienceAnalyticsAppHealthApplicationPerformanceByOSVersion);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsAppHealthDeviceModelPerformance>("userExperienceAnalyticsAppHealthDeviceModelPerformance", UserExperienceAnalyticsAppHealthDeviceModelPerformance);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsAppHealthDevicePerformance>("userExperienceAnalyticsAppHealthDevicePerformance", UserExperienceAnalyticsAppHealthDevicePerformance);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsAppHealthDevicePerformanceDetails>("userExperienceAnalyticsAppHealthDevicePerformanceDetails", UserExperienceAnalyticsAppHealthDevicePerformanceDetails);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsAppHealthOSVersionPerformance>("userExperienceAnalyticsAppHealthOSVersionPerformance", UserExperienceAnalyticsAppHealthOSVersionPerformance);
            writer.WriteObjectValue<UserExperienceAnalyticsCategory>("userExperienceAnalyticsAppHealthOverview", UserExperienceAnalyticsAppHealthOverview);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsBaseline>("userExperienceAnalyticsBaselines", UserExperienceAnalyticsBaselines);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsCategory>("userExperienceAnalyticsCategories", UserExperienceAnalyticsCategories);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsDevicePerformance>("userExperienceAnalyticsDevicePerformance", UserExperienceAnalyticsDevicePerformance);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsDeviceScores>("userExperienceAnalyticsDeviceScores", UserExperienceAnalyticsDeviceScores);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsDeviceStartupHistory>("userExperienceAnalyticsDeviceStartupHistory", UserExperienceAnalyticsDeviceStartupHistory);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsDeviceStartupProcess>("userExperienceAnalyticsDeviceStartupProcesses", UserExperienceAnalyticsDeviceStartupProcesses);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsMetricHistory>("userExperienceAnalyticsMetricHistory", UserExperienceAnalyticsMetricHistory);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsModelScores>("userExperienceAnalyticsModelScores", UserExperienceAnalyticsModelScores);
            writer.WriteObjectValue<ApiSdk.Models.UserExperienceAnalyticsOverview>("userExperienceAnalyticsOverview", UserExperienceAnalyticsOverview);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsScoreHistory>("userExperienceAnalyticsScoreHistory", UserExperienceAnalyticsScoreHistory);
            writer.WriteObjectValue<ApiSdk.Models.UserExperienceAnalyticsSettings>("userExperienceAnalyticsSettings", UserExperienceAnalyticsSettings);
            writer.WriteObjectValue<ApiSdk.Models.UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric>("userExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric", UserExperienceAnalyticsWorkFromAnywhereHardwareReadinessMetric);
            writer.WriteCollectionOfObjectValues<UserExperienceAnalyticsWorkFromAnywhereMetric>("userExperienceAnalyticsWorkFromAnywhereMetrics", UserExperienceAnalyticsWorkFromAnywhereMetrics);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.UserExperienceAnalyticsWorkFromAnywhereModelPerformance>("userExperienceAnalyticsWorkFromAnywhereModelPerformance", UserExperienceAnalyticsWorkFromAnywhereModelPerformance);
            writer.WriteCollectionOfObjectValues<WindowsAutopilotDeviceIdentity>("windowsAutopilotDeviceIdentities", WindowsAutopilotDeviceIdentities);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionAppLearningSummary>("windowsInformationProtectionAppLearningSummaries", WindowsInformationProtectionAppLearningSummaries);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionNetworkLearningSummary>("windowsInformationProtectionNetworkLearningSummaries", WindowsInformationProtectionNetworkLearningSummaries);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.WindowsMalwareInformation>("windowsMalwareInformation", WindowsMalwareInformation);
            writer.WriteObjectValue<ApiSdk.Models.WindowsMalwareOverview>("windowsMalwareOverview", WindowsMalwareOverview);
        }
    }
}
