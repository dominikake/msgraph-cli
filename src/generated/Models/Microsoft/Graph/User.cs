using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace ApiSdk.Models.Microsoft.Graph {
    public class User : DirectoryObject, IParsable {
        /// <summary>A freeform text entry field for the user to describe themselves. Returned only on $select.</summary>
        public string AboutMe { get; set; }
        /// <summary>true if the account is enabled; otherwise, false. This property is required when a user is created. Returned only on $select. Supports $filter (eq, ne, not, and in).</summary>
        public bool? AccountEnabled { get; set; }
        /// <summary>The user's activities across devices. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.UserActivity> Activities { get; set; }
        /// <summary>Sets the age group of the user. Allowed values: null, Minor, NotAdult and Adult. Refer to the legal age group property definitions for further information. Returned only on $select. Supports $filter (eq, ne, not, and in).</summary>
        public string AgeGroup { get; set; }
        /// <summary>The user's terms of use acceptance statuses. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AgreementAcceptance> AgreementAcceptances { get; set; }
        /// <summary>Represents the app roles a user has been granted for an application. Supports $expand.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AppRoleAssignment> AppRoleAssignments { get; set; }
        /// <summary>The licenses that are assigned to the user, including inherited (group-based) licenses.  Not nullable. Returned only on $select. Supports $filter (eq and not).</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AssignedLicense> AssignedLicenses { get; set; }
        /// <summary>The plans that are assigned to the user. Read-only. Not nullable. Returned only on $select. Supports $filter (eq and not).</summary>
        public List<ApiSdk.Models.Microsoft.Graph.AssignedPlan> AssignedPlans { get; set; }
        /// <summary>The authentication methods that are supported for the user.</summary>
        public ApiSdk.Models.Microsoft.Graph.Authentication Authentication { get; set; }
        /// <summary>The birthday of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned only on $select.</summary>
        public DateTimeOffset? Birthday { get; set; }
        /// <summary>The telephone numbers for the user. NOTE: Although this is a string collection, only one number can be set for this property. Read-only for users synced from on-premises directory. Returned by default. Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> BusinessPhones { get; set; }
        /// <summary>The user's primary calendar. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Calendar Calendar { get; set; }
        /// <summary>The user's calendar groups. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.CalendarGroup> CalendarGroups { get; set; }
        /// <summary>The user's calendars. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Calendar> Calendars { get; set; }
        /// <summary>The calendar view for the calendar. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Event> CalendarView { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.Chat> Chats { get; set; }
        /// <summary>The city in which the user is located. Maximum length is 128 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string City { get; set; }
        /// <summary>The company name which the user is associated. This property can be useful for describing the company that an external user comes from. The maximum length is 64 characters.Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string CompanyName { get; set; }
        /// <summary>Sets whether consent has been obtained for minors. Allowed values: null, Granted, Denied and NotRequired. Refer to the legal age group property definitions for further information. Returned only on $select. Supports $filter (eq, ne, not, and in).</summary>
        public string ConsentProvidedForMinor { get; set; }
        /// <summary>The user's contacts folders. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ContactFolder> ContactFolders { get; set; }
        /// <summary>The user's contacts. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Contact> Contacts { get; set; }
        /// <summary>The country/region in which the user is located; for example, US or UK. Maximum length is 128 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string Country { get; set; }
        /// <summary>The created date of the user object. Read-only. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in).</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Directory objects that were created by the user. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DirectoryObject> CreatedObjects { get; set; }
        /// <summary>Indicates whether the user account was created through one of the following methods:  As a regular school or work account (null). As an external account (Invitation). As a local account for an Azure Active Directory B2C tenant (LocalAccount). Through self-service sign-up by an internal user using email verification (EmailVerified). Through self-service sign-up by an external user signing up through a link that is part of a user flow (SelfServiceSignUp). Read-only.Returned only on $select. Supports $filter (eq, ne, not, in).</summary>
        public string CreationType { get; set; }
        /// <summary>The name for the department in which the user works. Maximum length is 64 characters. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, and eq on null values).</summary>
        public string Department { get; set; }
        /// <summary>The limit on the maximum number of devices that the user is permitted to enroll. Allowed values are 5 or 1000.</summary>
        public int? DeviceEnrollmentLimit { get; set; }
        /// <summary>The list of troubleshooting events for this user.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DeviceManagementTroubleshootingEvent> DeviceManagementTroubleshootingEvents { get; set; }
        /// <summary>The users and contacts that report to the user. (The users and contacts that have their manager property set to this user.) Read-only. Nullable. Supports $expand.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DirectoryObject> DirectReports { get; set; }
        /// <summary>The name displayed in the address book for the user. This is usually the combination of the user's first name, middle initial and last name. This property is required when a user is created and it cannot be cleared during updates. Maximum length is 256 characters. Returned by default. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values), $orderBy, and $search.</summary>
        public string DisplayName { get; set; }
        /// <summary>The user's OneDrive. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Drive Drive { get; set; }
        /// <summary>A collection of drives available for this user. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Drive> Drives { get; set; }
        /// <summary>The date and time when the user was hired or will start work in case of a future hire. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in).</summary>
        public DateTimeOffset? EmployeeHireDate { get; set; }
        /// <summary>The employee identifier assigned to the user by the organization. The maximum length is 16 characters. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).</summary>
        public string EmployeeId { get; set; }
        /// <summary>Represents organization data (e.g. division and costCenter) associated with a user. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in).</summary>
        public ApiSdk.Models.Microsoft.Graph.EmployeeOrgData EmployeeOrgData { get; set; }
        /// <summary>Captures enterprise worker type. For example, Employee, Contractor, Consultant, or Vendor. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, startsWith).</summary>
        public string EmployeeType { get; set; }
        /// <summary>The user's events. Default is to show Events under the Default Calendar. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Event> Events { get; set; }
        /// <summary>The collection of open extensions defined for the user. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Extension> Extensions { get; set; }
        /// <summary>For an external user invited to the tenant using the invitation API, this property represents the invited user's invitation status. For invited users, the state can be PendingAcceptance or Accepted, or null for all other users. Returned only on $select. Supports $filter (eq, ne, not , in).</summary>
        public string ExternalUserState { get; set; }
        /// <summary>Shows the timestamp for the latest change to the externalUserState property. Returned only on $select. Supports $filter (eq, ne, not , in).</summary>
        public DateTimeOffset? ExternalUserStateChangeDateTime { get; set; }
        /// <summary>The fax number of the user. Returned only on $select. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).</summary>
        public string FaxNumber { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.Site> FollowedSites { get; set; }
        /// <summary>The given name (first name) of the user. Maximum length is 64 characters. Returned by default. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).</summary>
        public string GivenName { get; set; }
        /// <summary>The hire date of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned only on $select.  Note: This property is specific to SharePoint Online. We recommend using the native employeeHireDate property to set and update hire date values using Microsoft Graph APIs.</summary>
        public DateTimeOffset? HireDate { get; set; }
        /// <summary>Represents the identities that can be used to sign in to this user account. An identity can be provided by Microsoft (also known as a local account), by organizations, or by social identity providers such as Facebook, Google, and Microsoft, and tied to a user account. May contain multiple items with the same signInType value. Returned only on $select. Supports $filter (eq) including on null values, only where the signInType is not userPrincipalName.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ObjectIdentity> Identities { get; set; }
        /// <summary>The instant message voice over IP (VOIP) session initiation protocol (SIP) addresses for the user. Read-only. Returned only on $select. Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> ImAddresses { get; set; }
        /// <summary>Relevance classification of the user's messages based on explicit designations which override inferred relevance or importance.</summary>
        public ApiSdk.Models.Microsoft.Graph.InferenceClassification InferenceClassification { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public ApiSdk.Models.Microsoft.Graph.OfficeGraphInsights Insights { get; set; }
        /// <summary>A list for the user to describe their interests. Returned only on $select.</summary>
        public List<string> Interests { get; set; }
        /// <summary>Do not use – reserved for future use.</summary>
        public bool? IsResourceAccount { get; set; }
        /// <summary>The user's job title. Maximum length is 128 characters. Returned by default. Supports $filter (eq, ne, not , ge, le, in, startsWith, and eq on null values).</summary>
        public string JobTitle { get; set; }
        /// <summary>The Microsoft Teams teams that the user is a member of. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Team> JoinedTeams { get; set; }
        /// <summary>The time when this Azure AD user last changed their password or when their password was created, whichever date the latest action was performed. The date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned only on $select.</summary>
        public DateTimeOffset? LastPasswordChangeDateTime { get; set; }
        /// <summary>Used by enterprise applications to determine the legal age group of the user. This property is read-only and calculated based on ageGroup and consentProvidedForMinor properties. Allowed values: null, MinorWithOutParentalConsent, MinorWithParentalConsent, MinorNoParentalConsentRequired, NotAdult and Adult. Refer to the legal age group property definitions for further information. Returned only on $select.</summary>
        public string LegalAgeGroupClassification { get; set; }
        /// <summary>State of license assignments for this user. Read-only. Returned only on $select.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.LicenseAssignmentState> LicenseAssignmentStates { get; set; }
        /// <summary>A collection of this user's license details. Read-only.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.LicenseDetails> LicenseDetails { get; set; }
        /// <summary>The SMTP address for the user, for example, jeff@contoso.onmicrosoft.com.Changes to this property will also update the user's proxyAddresses collection to include the value as an SMTP address. For Azure AD B2C accounts, this property can be updated up to only ten times with unique SMTP addresses. This property cannot contain accent characters.Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, endsWith, and eq on null values).</summary>
        public string Mail { get; set; }
        /// <summary>Settings for the primary mailbox of the signed-in user. You can get or update settings for sending automatic replies to incoming messages, locale and time zone. Returned only on $select.</summary>
        public ApiSdk.Models.Microsoft.Graph.MailboxSettings MailboxSettings { get; set; }
        /// <summary>The user's mail folders. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.MailFolder> MailFolders { get; set; }
        /// <summary>The mail alias for the user. This property must be specified when a user is created. Maximum length is 64 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string MailNickname { get; set; }
        /// <summary>Zero or more managed app registrations that belong to the user.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ManagedAppRegistration> ManagedAppRegistrations { get; set; }
        /// <summary>The managed devices associated with the user.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ManagedDevice> ManagedDevices { get; set; }
        /// <summary>The user or contact that is this user's manager. Read-only. (HTTP Methods: GET, PUT, DELETE.). Supports $expand.</summary>
        public ApiSdk.Models.Microsoft.Graph.DirectoryObject Manager { get; set; }
        /// <summary>The groups and directory roles that the user is a member of. Read-only. Nullable. Supports $expand.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DirectoryObject> MemberOf { get; set; }
        /// <summary>The messages in a mailbox or folder. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Message> Messages { get; set; }
        /// <summary>The primary cellular telephone number for the user. Read-only for users synced from on-premises directory. Maximum length is 64 characters. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string MobilePhone { get; set; }
        /// <summary>The URL for the user's personal site. Returned only on $select.</summary>
        public string MySite { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.OAuth2PermissionGrant> Oauth2PermissionGrants { get; set; }
        /// <summary>The office location in the user's place of business. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string OfficeLocation { get; set; }
        /// <summary>Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.Onenote Onenote { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.OnlineMeeting> OnlineMeetings { get; set; }
        /// <summary>Contains the on-premises Active Directory distinguished name or DN. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select.</summary>
        public string OnPremisesDistinguishedName { get; set; }
        /// <summary>Contains the on-premises domainFQDN, also called dnsDomainName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select.</summary>
        public string OnPremisesDomainName { get; set; }
        /// <summary>Contains extensionAttributes1-15 for the user. The individual extension attributes are neither selectable nor filterable. For an onPremisesSyncEnabled user, the source of authority for this set of properties is the on-premises and is read-only. For a cloud-only user (where onPremisesSyncEnabled is false), these properties can be set during creation or update of a user object.  For a cloud-only user previously synced from on-premises Active Directory, these properties are read-only in Microsoft Graph but can be fully managed through the Exchange Admin Center or the Exchange Online V2 module in PowerShell. These extension attributes are also known as Exchange custom attributes 1-15.</summary>
        public ApiSdk.Models.Microsoft.Graph.OnPremisesExtensionAttributes OnPremisesExtensionAttributes { get; set; }
        /// <summary>This property is used to associate an on-premises Active Directory user account to their Azure AD user object. This property must be specified when creating a new user account in the Graph if you are using a federated domain for the user's userPrincipalName (UPN) property. NOTE: The $ and _ characters cannot be used when specifying this property. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in)..</summary>
        public string OnPremisesImmutableId { get; set; }
        /// <summary>Indicates the last time at which the object was synced with the on-premises directory; for example: 2013-02-16T03:04:54Z. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in).</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
        /// <summary>Errors when using Microsoft synchronization product during provisioning. Returned only on $select. Supports $filter (eq, not, ge, le).</summary>
        public List<ApiSdk.Models.Microsoft.Graph.OnPremisesProvisioningError> OnPremisesProvisioningErrors { get; set; }
        /// <summary>Contains the on-premises samAccountName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith).</summary>
        public string OnPremisesSamAccountName { get; set; }
        /// <summary>Contains the on-premises security identifier (SID) for the user that was synchronized from on-premises to the cloud. Read-only. Returned only on $select. Supports $filter (eq) on null values only.</summary>
        public string OnPremisesSecurityIdentifier { get; set; }
        /// <summary>true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only. Returned only on $select. Supports $filter (eq, ne, not, in, and eq on null values).</summary>
        public bool? OnPremisesSyncEnabled { get; set; }
        /// <summary>Contains the on-premises userPrincipalName synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect. Read-only. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith).</summary>
        public string OnPremisesUserPrincipalName { get; set; }
        /// <summary>A list of additional email addresses for the user; for example: ['bob@contoso.com', 'Robert@fabrikam.com']. NOTE: This property cannot contain accent characters. Returned only on $select. Supports $filter (eq, not, ge, le, in, startsWith).</summary>
        public List<string> OtherMails { get; set; }
        /// <summary>Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.OutlookUser Outlook { get; set; }
        /// <summary>Devices that are owned by the user. Read-only. Nullable. Supports $expand.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DirectoryObject> OwnedDevices { get; set; }
        /// <summary>Directory objects that are owned by the user. Read-only. Nullable. Supports $expand.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DirectoryObject> OwnedObjects { get; set; }
        /// <summary>Specifies password policies for the user. This value is an enumeration with one possible value being DisableStrongPassword, which allows weaker passwords than the default policy to be specified. DisablePasswordExpiration can also be specified. The two may be specified together; for example: DisablePasswordExpiration, DisableStrongPassword. Returned only on $select. For more information on the default password policies, see Azure AD pasword policies. Supports $filter (ne, not, and eq on null values).</summary>
        public string PasswordPolicies { get; set; }
        /// <summary>Specifies the password profile for the user. The profile contains the user’s password. This property is required when a user is created. The password in the profile must satisfy minimum requirements as specified by the passwordPolicies property. By default, a strong password is required. NOTE: For Azure B2C tenants, the forceChangePasswordNextSignIn property should be set to false and instead use custom policies and user flows to force password reset at first logon. See Force password reset at first logon.Returned only on $select. Supports $filter (eq, ne, not, in, and eq on null values).</summary>
        public ApiSdk.Models.Microsoft.Graph.PasswordProfile PasswordProfile { get; set; }
        /// <summary>A list for the user to enumerate their past projects. Returned only on $select.</summary>
        public List<string> PastProjects { get; set; }
        /// <summary>People that are relevant to the user. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.Person> People { get; set; }
        /// <summary>The user's profile photo. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.ProfilePhoto Photo { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ProfilePhoto> Photos { get; set; }
        /// <summary>Entry-point to the Planner resource that might exist for a user. Read-only.</summary>
        public ApiSdk.Models.Microsoft.Graph.PlannerUser Planner { get; set; }
        /// <summary>The postal code for the user's postal address. The postal code is specific to the user's country/region. In the United States of America, this attribute contains the ZIP code. Maximum length is 40 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string PostalCode { get; set; }
        /// <summary>The preferred language for the user. Should follow ISO 639-1 Code; for example en-US. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values)</summary>
        public string PreferredLanguage { get; set; }
        /// <summary>The preferred name for the user. Returned only on $select.</summary>
        public string PreferredName { get; set; }
        public ApiSdk.Models.Microsoft.Graph.Presence Presence { get; set; }
        /// <summary>The plans that are provisioned for the user. Read-only. Not nullable. Returned only on $select. Supports $filter (eq, not, ge, le).</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ProvisionedPlan> ProvisionedPlans { get; set; }
        /// <summary>For example: ['SMTP: bob@contoso.com', 'smtp: bob@sales.contoso.com']. Changes to the mail property will also update this collection to include the value as an SMTP address. For more information, see mail and proxyAddresses properties. The proxy address prefixed with SMTP (capitalized) is the primary proxy address while those prefixed with smtp are the secondary proxy addresses. For Azure AD B2C accounts, this property has a limit of ten unique addresses. Read-only in Microsoft Graph; you can update this property only through the Microsoft 365 admin center. Not nullable. Returned only on $select. Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> ProxyAddresses { get; set; }
        /// <summary>Devices that are registered for the user. Read-only. Nullable. Supports $expand.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.DirectoryObject> RegisteredDevices { get; set; }
        /// <summary>A list for the user to enumerate their responsibilities. Returned only on $select.</summary>
        public List<string> Responsibilities { get; set; }
        /// <summary>A list for the user to enumerate the schools they have attended. Returned only on $select.</summary>
        public List<string> Schools { get; set; }
        /// <summary>The scoped-role administrative unit memberships for this user. Read-only. Nullable.</summary>
        public List<ApiSdk.Models.Microsoft.Graph.ScopedRoleMembership> ScopedRoleMemberOf { get; set; }
        /// <summary>Read-only. Nullable.</summary>
        public ApiSdk.Models.Microsoft.Graph.UserSettings Settings { get; set; }
        /// <summary>true if the Outlook global address list should contain this user, otherwise false. If not set, this will be treated as true. For users invited through the invitation manager, this property will be set to false. Returned only on $select. Supports $filter (eq, ne, not, in).</summary>
        public bool? ShowInAddressList { get; set; }
        /// <summary>Any refresh tokens or sessions tokens (session cookies) issued before this time are invalid, and applications will get an error when using an invalid refresh or sessions token to acquire a delegated access token (to access APIs such as Microsoft Graph).  If this happens, the application will need to acquire a new refresh token by making a request to the authorize endpoint. Read-only. Use revokeSignInSessions to reset. Returned only on $select.</summary>
        public DateTimeOffset? SignInSessionsValidFromDateTime { get; set; }
        /// <summary>A list for the user to enumerate their skills. Returned only on $select.</summary>
        public List<string> Skills { get; set; }
        /// <summary>The state or province in the user's address. Maximum length is 128 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string State { get; set; }
        /// <summary>The street address of the user's place of business. Maximum length is 1024 characters. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string StreetAddress { get; set; }
        /// <summary>The user's surname (family name or last name). Maximum length is 64 characters. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string Surname { get; set; }
        /// <summary>A container for Microsoft Teams features available for the user. Read-only. Nullable.</summary>
        public ApiSdk.Models.Microsoft.Graph.UserTeamwork Teamwork { get; set; }
        /// <summary>Represents the To Do services available to a user.</summary>
        public ApiSdk.Models.Microsoft.Graph.Todo Todo { get; set; }
        public List<ApiSdk.Models.Microsoft.Graph.DirectoryObject> TransitiveMemberOf { get; set; }
        /// <summary>A two letter country code (ISO standard 3166). Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries.  Examples include: US, JP, and GB. Not nullable. Returned only on $select. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
        public string UsageLocation { get; set; }
        /// <summary>The user principal name (UPN) of the user. The UPN is an Internet-style login name for the user based on the Internet standard RFC 822. By convention, this should map to the user's email name. The general format is alias@domain, where domain must be present in the tenant's collection of verified domains. This property is required when a user is created. The verified domains for the tenant can be accessed from the verifiedDomains property of organization.NOTE: This property cannot contain accent characters. Only the following characters are allowed A - Z, a - z, 0 - 9, ' . - _ ! # ^ ~. For the complete list of allowed characters, see username policies. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, endsWith) and $orderBy.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>A string value that can be used to classify user types in your directory, such as Member and Guest. Returned only on $select. Supports $filter (eq, ne, not, in, and eq on null values). NOTE: For more information about the permissions for member and guest users, see What are the default user permissions in Azure Active Directory?</summary>
        public string UserType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ApiSdk.Models.Microsoft.Graph.User CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new User();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"aboutMe", (o,n) => { (o as User).AboutMe = n.GetStringValue(); } },
                {"accountEnabled", (o,n) => { (o as User).AccountEnabled = n.GetBoolValue(); } },
                {"activities", (o,n) => { (o as User).Activities = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.UserActivity>(ApiSdk.Models.Microsoft.Graph.UserActivity.CreateFromDiscriminatorValue).ToList(); } },
                {"ageGroup", (o,n) => { (o as User).AgeGroup = n.GetStringValue(); } },
                {"agreementAcceptances", (o,n) => { (o as User).AgreementAcceptances = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AgreementAcceptance>(ApiSdk.Models.Microsoft.Graph.AgreementAcceptance.CreateFromDiscriminatorValue).ToList(); } },
                {"appRoleAssignments", (o,n) => { (o as User).AppRoleAssignments = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AppRoleAssignment>(ApiSdk.Models.Microsoft.Graph.AppRoleAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"assignedLicenses", (o,n) => { (o as User).AssignedLicenses = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AssignedLicense>(ApiSdk.Models.Microsoft.Graph.AssignedLicense.CreateFromDiscriminatorValue).ToList(); } },
                {"assignedPlans", (o,n) => { (o as User).AssignedPlans = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AssignedPlan>(ApiSdk.Models.Microsoft.Graph.AssignedPlan.CreateFromDiscriminatorValue).ToList(); } },
                {"authentication", (o,n) => { (o as User).Authentication = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Authentication>(ApiSdk.Models.Microsoft.Graph.Authentication.CreateFromDiscriminatorValue); } },
                {"birthday", (o,n) => { (o as User).Birthday = n.GetDateTimeOffsetValue(); } },
                {"businessPhones", (o,n) => { (o as User).BusinessPhones = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"calendar", (o,n) => { (o as User).Calendar = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Calendar>(ApiSdk.Models.Microsoft.Graph.Calendar.CreateFromDiscriminatorValue); } },
                {"calendarGroups", (o,n) => { (o as User).CalendarGroups = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.CalendarGroup>(ApiSdk.Models.Microsoft.Graph.CalendarGroup.CreateFromDiscriminatorValue).ToList(); } },
                {"calendars", (o,n) => { (o as User).Calendars = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Calendar>(ApiSdk.Models.Microsoft.Graph.Calendar.CreateFromDiscriminatorValue).ToList(); } },
                {"calendarView", (o,n) => { (o as User).CalendarView = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Event>(ApiSdk.Models.Microsoft.Graph.Event.CreateFromDiscriminatorValue).ToList(); } },
                {"chats", (o,n) => { (o as User).Chats = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Chat>(ApiSdk.Models.Microsoft.Graph.Chat.CreateFromDiscriminatorValue).ToList(); } },
                {"city", (o,n) => { (o as User).City = n.GetStringValue(); } },
                {"companyName", (o,n) => { (o as User).CompanyName = n.GetStringValue(); } },
                {"consentProvidedForMinor", (o,n) => { (o as User).ConsentProvidedForMinor = n.GetStringValue(); } },
                {"contactFolders", (o,n) => { (o as User).ContactFolders = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ContactFolder>(ApiSdk.Models.Microsoft.Graph.ContactFolder.CreateFromDiscriminatorValue).ToList(); } },
                {"contacts", (o,n) => { (o as User).Contacts = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Contact>(ApiSdk.Models.Microsoft.Graph.Contact.CreateFromDiscriminatorValue).ToList(); } },
                {"country", (o,n) => { (o as User).Country = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as User).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdObjects", (o,n) => { (o as User).CreatedObjects = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryObject>(ApiSdk.Models.Microsoft.Graph.DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"creationType", (o,n) => { (o as User).CreationType = n.GetStringValue(); } },
                {"department", (o,n) => { (o as User).Department = n.GetStringValue(); } },
                {"deviceEnrollmentLimit", (o,n) => { (o as User).DeviceEnrollmentLimit = n.GetIntValue(); } },
                {"deviceManagementTroubleshootingEvents", (o,n) => { (o as User).DeviceManagementTroubleshootingEvents = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceManagementTroubleshootingEvent>(ApiSdk.Models.Microsoft.Graph.DeviceManagementTroubleshootingEvent.CreateFromDiscriminatorValue).ToList(); } },
                {"directReports", (o,n) => { (o as User).DirectReports = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryObject>(ApiSdk.Models.Microsoft.Graph.DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as User).DisplayName = n.GetStringValue(); } },
                {"drive", (o,n) => { (o as User).Drive = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Drive>(ApiSdk.Models.Microsoft.Graph.Drive.CreateFromDiscriminatorValue); } },
                {"drives", (o,n) => { (o as User).Drives = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Drive>(ApiSdk.Models.Microsoft.Graph.Drive.CreateFromDiscriminatorValue).ToList(); } },
                {"employeeHireDate", (o,n) => { (o as User).EmployeeHireDate = n.GetDateTimeOffsetValue(); } },
                {"employeeId", (o,n) => { (o as User).EmployeeId = n.GetStringValue(); } },
                {"employeeOrgData", (o,n) => { (o as User).EmployeeOrgData = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.EmployeeOrgData>(ApiSdk.Models.Microsoft.Graph.EmployeeOrgData.CreateFromDiscriminatorValue); } },
                {"employeeType", (o,n) => { (o as User).EmployeeType = n.GetStringValue(); } },
                {"events", (o,n) => { (o as User).Events = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Event>(ApiSdk.Models.Microsoft.Graph.Event.CreateFromDiscriminatorValue).ToList(); } },
                {"extensions", (o,n) => { (o as User).Extensions = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Extension>(ApiSdk.Models.Microsoft.Graph.Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"externalUserState", (o,n) => { (o as User).ExternalUserState = n.GetStringValue(); } },
                {"externalUserStateChangeDateTime", (o,n) => { (o as User).ExternalUserStateChangeDateTime = n.GetDateTimeOffsetValue(); } },
                {"faxNumber", (o,n) => { (o as User).FaxNumber = n.GetStringValue(); } },
                {"followedSites", (o,n) => { (o as User).FollowedSites = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Site>(ApiSdk.Models.Microsoft.Graph.Site.CreateFromDiscriminatorValue).ToList(); } },
                {"givenName", (o,n) => { (o as User).GivenName = n.GetStringValue(); } },
                {"hireDate", (o,n) => { (o as User).HireDate = n.GetDateTimeOffsetValue(); } },
                {"identities", (o,n) => { (o as User).Identities = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ObjectIdentity>(ApiSdk.Models.Microsoft.Graph.ObjectIdentity.CreateFromDiscriminatorValue).ToList(); } },
                {"imAddresses", (o,n) => { (o as User).ImAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"inferenceClassification", (o,n) => { (o as User).InferenceClassification = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.InferenceClassification>(ApiSdk.Models.Microsoft.Graph.InferenceClassification.CreateFromDiscriminatorValue); } },
                {"insights", (o,n) => { (o as User).Insights = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.OfficeGraphInsights>(ApiSdk.Models.Microsoft.Graph.OfficeGraphInsights.CreateFromDiscriminatorValue); } },
                {"interests", (o,n) => { (o as User).Interests = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isResourceAccount", (o,n) => { (o as User).IsResourceAccount = n.GetBoolValue(); } },
                {"jobTitle", (o,n) => { (o as User).JobTitle = n.GetStringValue(); } },
                {"joinedTeams", (o,n) => { (o as User).JoinedTeams = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Team>(ApiSdk.Models.Microsoft.Graph.Team.CreateFromDiscriminatorValue).ToList(); } },
                {"lastPasswordChangeDateTime", (o,n) => { (o as User).LastPasswordChangeDateTime = n.GetDateTimeOffsetValue(); } },
                {"legalAgeGroupClassification", (o,n) => { (o as User).LegalAgeGroupClassification = n.GetStringValue(); } },
                {"licenseAssignmentStates", (o,n) => { (o as User).LicenseAssignmentStates = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.LicenseAssignmentState>(ApiSdk.Models.Microsoft.Graph.LicenseAssignmentState.CreateFromDiscriminatorValue).ToList(); } },
                {"licenseDetails", (o,n) => { (o as User).LicenseDetails = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.LicenseDetails>(ApiSdk.Models.Microsoft.Graph.LicenseDetails.CreateFromDiscriminatorValue).ToList(); } },
                {"mail", (o,n) => { (o as User).Mail = n.GetStringValue(); } },
                {"mailboxSettings", (o,n) => { (o as User).MailboxSettings = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.MailboxSettings>(ApiSdk.Models.Microsoft.Graph.MailboxSettings.CreateFromDiscriminatorValue); } },
                {"mailFolders", (o,n) => { (o as User).MailFolders = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MailFolder>(ApiSdk.Models.Microsoft.Graph.MailFolder.CreateFromDiscriminatorValue).ToList(); } },
                {"mailNickname", (o,n) => { (o as User).MailNickname = n.GetStringValue(); } },
                {"managedAppRegistrations", (o,n) => { (o as User).ManagedAppRegistrations = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedAppRegistration>(ApiSdk.Models.Microsoft.Graph.ManagedAppRegistration.CreateFromDiscriminatorValue).ToList(); } },
                {"managedDevices", (o,n) => { (o as User).ManagedDevices = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedDevice>(ApiSdk.Models.Microsoft.Graph.ManagedDevice.CreateFromDiscriminatorValue).ToList(); } },
                {"manager", (o,n) => { (o as User).Manager = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.DirectoryObject>(ApiSdk.Models.Microsoft.Graph.DirectoryObject.CreateFromDiscriminatorValue); } },
                {"memberOf", (o,n) => { (o as User).MemberOf = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryObject>(ApiSdk.Models.Microsoft.Graph.DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"messages", (o,n) => { (o as User).Messages = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Message>(ApiSdk.Models.Microsoft.Graph.Message.CreateFromDiscriminatorValue).ToList(); } },
                {"mobilePhone", (o,n) => { (o as User).MobilePhone = n.GetStringValue(); } },
                {"mySite", (o,n) => { (o as User).MySite = n.GetStringValue(); } },
                {"oauth2PermissionGrants", (o,n) => { (o as User).Oauth2PermissionGrants = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OAuth2PermissionGrant>(ApiSdk.Models.Microsoft.Graph.OAuth2PermissionGrant.CreateFromDiscriminatorValue).ToList(); } },
                {"officeLocation", (o,n) => { (o as User).OfficeLocation = n.GetStringValue(); } },
                {"onenote", (o,n) => { (o as User).Onenote = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Onenote>(ApiSdk.Models.Microsoft.Graph.Onenote.CreateFromDiscriminatorValue); } },
                {"onlineMeetings", (o,n) => { (o as User).OnlineMeetings = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnlineMeeting>(ApiSdk.Models.Microsoft.Graph.OnlineMeeting.CreateFromDiscriminatorValue).ToList(); } },
                {"onPremisesDistinguishedName", (o,n) => { (o as User).OnPremisesDistinguishedName = n.GetStringValue(); } },
                {"onPremisesDomainName", (o,n) => { (o as User).OnPremisesDomainName = n.GetStringValue(); } },
                {"onPremisesExtensionAttributes", (o,n) => { (o as User).OnPremisesExtensionAttributes = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.OnPremisesExtensionAttributes>(ApiSdk.Models.Microsoft.Graph.OnPremisesExtensionAttributes.CreateFromDiscriminatorValue); } },
                {"onPremisesImmutableId", (o,n) => { (o as User).OnPremisesImmutableId = n.GetStringValue(); } },
                {"onPremisesLastSyncDateTime", (o,n) => { (o as User).OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesProvisioningErrors", (o,n) => { (o as User).OnPremisesProvisioningErrors = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnPremisesProvisioningError>(ApiSdk.Models.Microsoft.Graph.OnPremisesProvisioningError.CreateFromDiscriminatorValue).ToList(); } },
                {"onPremisesSamAccountName", (o,n) => { (o as User).OnPremisesSamAccountName = n.GetStringValue(); } },
                {"onPremisesSecurityIdentifier", (o,n) => { (o as User).OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                {"onPremisesSyncEnabled", (o,n) => { (o as User).OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"onPremisesUserPrincipalName", (o,n) => { (o as User).OnPremisesUserPrincipalName = n.GetStringValue(); } },
                {"otherMails", (o,n) => { (o as User).OtherMails = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"outlook", (o,n) => { (o as User).Outlook = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.OutlookUser>(ApiSdk.Models.Microsoft.Graph.OutlookUser.CreateFromDiscriminatorValue); } },
                {"ownedDevices", (o,n) => { (o as User).OwnedDevices = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryObject>(ApiSdk.Models.Microsoft.Graph.DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"ownedObjects", (o,n) => { (o as User).OwnedObjects = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryObject>(ApiSdk.Models.Microsoft.Graph.DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"passwordPolicies", (o,n) => { (o as User).PasswordPolicies = n.GetStringValue(); } },
                {"passwordProfile", (o,n) => { (o as User).PasswordProfile = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PasswordProfile>(ApiSdk.Models.Microsoft.Graph.PasswordProfile.CreateFromDiscriminatorValue); } },
                {"pastProjects", (o,n) => { (o as User).PastProjects = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"people", (o,n) => { (o as User).People = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Person>(ApiSdk.Models.Microsoft.Graph.Person.CreateFromDiscriminatorValue).ToList(); } },
                {"photo", (o,n) => { (o as User).Photo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.ProfilePhoto>(ApiSdk.Models.Microsoft.Graph.ProfilePhoto.CreateFromDiscriminatorValue); } },
                {"photos", (o,n) => { (o as User).Photos = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ProfilePhoto>(ApiSdk.Models.Microsoft.Graph.ProfilePhoto.CreateFromDiscriminatorValue).ToList(); } },
                {"planner", (o,n) => { (o as User).Planner = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.PlannerUser>(ApiSdk.Models.Microsoft.Graph.PlannerUser.CreateFromDiscriminatorValue); } },
                {"postalCode", (o,n) => { (o as User).PostalCode = n.GetStringValue(); } },
                {"preferredLanguage", (o,n) => { (o as User).PreferredLanguage = n.GetStringValue(); } },
                {"preferredName", (o,n) => { (o as User).PreferredName = n.GetStringValue(); } },
                {"presence", (o,n) => { (o as User).Presence = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Presence>(ApiSdk.Models.Microsoft.Graph.Presence.CreateFromDiscriminatorValue); } },
                {"provisionedPlans", (o,n) => { (o as User).ProvisionedPlans = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ProvisionedPlan>(ApiSdk.Models.Microsoft.Graph.ProvisionedPlan.CreateFromDiscriminatorValue).ToList(); } },
                {"proxyAddresses", (o,n) => { (o as User).ProxyAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"registeredDevices", (o,n) => { (o as User).RegisteredDevices = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryObject>(ApiSdk.Models.Microsoft.Graph.DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"responsibilities", (o,n) => { (o as User).Responsibilities = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"schools", (o,n) => { (o as User).Schools = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"scopedRoleMemberOf", (o,n) => { (o as User).ScopedRoleMemberOf = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ScopedRoleMembership>(ApiSdk.Models.Microsoft.Graph.ScopedRoleMembership.CreateFromDiscriminatorValue).ToList(); } },
                {"settings", (o,n) => { (o as User).Settings = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.UserSettings>(ApiSdk.Models.Microsoft.Graph.UserSettings.CreateFromDiscriminatorValue); } },
                {"showInAddressList", (o,n) => { (o as User).ShowInAddressList = n.GetBoolValue(); } },
                {"signInSessionsValidFromDateTime", (o,n) => { (o as User).SignInSessionsValidFromDateTime = n.GetDateTimeOffsetValue(); } },
                {"skills", (o,n) => { (o as User).Skills = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"state", (o,n) => { (o as User).State = n.GetStringValue(); } },
                {"streetAddress", (o,n) => { (o as User).StreetAddress = n.GetStringValue(); } },
                {"surname", (o,n) => { (o as User).Surname = n.GetStringValue(); } },
                {"teamwork", (o,n) => { (o as User).Teamwork = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.UserTeamwork>(ApiSdk.Models.Microsoft.Graph.UserTeamwork.CreateFromDiscriminatorValue); } },
                {"todo", (o,n) => { (o as User).Todo = n.GetObjectValue<ApiSdk.Models.Microsoft.Graph.Todo>(ApiSdk.Models.Microsoft.Graph.Todo.CreateFromDiscriminatorValue); } },
                {"transitiveMemberOf", (o,n) => { (o as User).TransitiveMemberOf = n.GetCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryObject>(ApiSdk.Models.Microsoft.Graph.DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"usageLocation", (o,n) => { (o as User).UsageLocation = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as User).UserPrincipalName = n.GetStringValue(); } },
                {"userType", (o,n) => { (o as User).UserType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("aboutMe", AboutMe);
            writer.WriteBoolValue("accountEnabled", AccountEnabled);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.UserActivity>("activities", Activities);
            writer.WriteStringValue("ageGroup", AgeGroup);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AgreementAcceptance>("agreementAcceptances", AgreementAcceptances);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AppRoleAssignment>("appRoleAssignments", AppRoleAssignments);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AssignedLicense>("assignedLicenses", AssignedLicenses);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.AssignedPlan>("assignedPlans", AssignedPlans);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Authentication>("authentication", Authentication);
            writer.WriteDateTimeOffsetValue("birthday", Birthday);
            writer.WriteCollectionOfPrimitiveValues<string>("businessPhones", BusinessPhones);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Calendar>("calendar", Calendar);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.CalendarGroup>("calendarGroups", CalendarGroups);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Calendar>("calendars", Calendars);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Event>("calendarView", CalendarView);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Chat>("chats", Chats);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("consentProvidedForMinor", ConsentProvidedForMinor);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ContactFolder>("contactFolders", ContactFolders);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Contact>("contacts", Contacts);
            writer.WriteStringValue("country", Country);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryObject>("createdObjects", CreatedObjects);
            writer.WriteStringValue("creationType", CreationType);
            writer.WriteStringValue("department", Department);
            writer.WriteIntValue("deviceEnrollmentLimit", DeviceEnrollmentLimit);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DeviceManagementTroubleshootingEvent>("deviceManagementTroubleshootingEvents", DeviceManagementTroubleshootingEvents);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryObject>("directReports", DirectReports);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Drive>("drives", Drives);
            writer.WriteDateTimeOffsetValue("employeeHireDate", EmployeeHireDate);
            writer.WriteStringValue("employeeId", EmployeeId);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.EmployeeOrgData>("employeeOrgData", EmployeeOrgData);
            writer.WriteStringValue("employeeType", EmployeeType);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Event>("events", Events);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Extension>("extensions", Extensions);
            writer.WriteStringValue("externalUserState", ExternalUserState);
            writer.WriteDateTimeOffsetValue("externalUserStateChangeDateTime", ExternalUserStateChangeDateTime);
            writer.WriteStringValue("faxNumber", FaxNumber);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Site>("followedSites", FollowedSites);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteDateTimeOffsetValue("hireDate", HireDate);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ObjectIdentity>("identities", Identities);
            writer.WriteCollectionOfPrimitiveValues<string>("imAddresses", ImAddresses);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.InferenceClassification>("inferenceClassification", InferenceClassification);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.OfficeGraphInsights>("insights", Insights);
            writer.WriteCollectionOfPrimitiveValues<string>("interests", Interests);
            writer.WriteBoolValue("isResourceAccount", IsResourceAccount);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Team>("joinedTeams", JoinedTeams);
            writer.WriteDateTimeOffsetValue("lastPasswordChangeDateTime", LastPasswordChangeDateTime);
            writer.WriteStringValue("legalAgeGroupClassification", LegalAgeGroupClassification);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.LicenseAssignmentState>("licenseAssignmentStates", LicenseAssignmentStates);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.LicenseDetails>("licenseDetails", LicenseDetails);
            writer.WriteStringValue("mail", Mail);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.MailboxSettings>("mailboxSettings", MailboxSettings);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.MailFolder>("mailFolders", MailFolders);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedAppRegistration>("managedAppRegistrations", ManagedAppRegistrations);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ManagedDevice>("managedDevices", ManagedDevices);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.DirectoryObject>("manager", Manager);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryObject>("memberOf", MemberOf);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Message>("messages", Messages);
            writer.WriteStringValue("mobilePhone", MobilePhone);
            writer.WriteStringValue("mySite", MySite);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OAuth2PermissionGrant>("oauth2PermissionGrants", Oauth2PermissionGrants);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Onenote>("onenote", Onenote);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnlineMeeting>("onlineMeetings", OnlineMeetings);
            writer.WriteStringValue("onPremisesDistinguishedName", OnPremisesDistinguishedName);
            writer.WriteStringValue("onPremisesDomainName", OnPremisesDomainName);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.OnPremisesExtensionAttributes>("onPremisesExtensionAttributes", OnPremisesExtensionAttributes);
            writer.WriteStringValue("onPremisesImmutableId", OnPremisesImmutableId);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.OnPremisesProvisioningError>("onPremisesProvisioningErrors", OnPremisesProvisioningErrors);
            writer.WriteStringValue("onPremisesSamAccountName", OnPremisesSamAccountName);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteStringValue("onPremisesUserPrincipalName", OnPremisesUserPrincipalName);
            writer.WriteCollectionOfPrimitiveValues<string>("otherMails", OtherMails);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.OutlookUser>("outlook", Outlook);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryObject>("ownedDevices", OwnedDevices);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryObject>("ownedObjects", OwnedObjects);
            writer.WriteStringValue("passwordPolicies", PasswordPolicies);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PasswordProfile>("passwordProfile", PasswordProfile);
            writer.WriteCollectionOfPrimitiveValues<string>("pastProjects", PastProjects);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.Person>("people", People);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.ProfilePhoto>("photo", Photo);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ProfilePhoto>("photos", Photos);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.PlannerUser>("planner", Planner);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("preferredLanguage", PreferredLanguage);
            writer.WriteStringValue("preferredName", PreferredName);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Presence>("presence", Presence);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ProvisionedPlan>("provisionedPlans", ProvisionedPlans);
            writer.WriteCollectionOfPrimitiveValues<string>("proxyAddresses", ProxyAddresses);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryObject>("registeredDevices", RegisteredDevices);
            writer.WriteCollectionOfPrimitiveValues<string>("responsibilities", Responsibilities);
            writer.WriteCollectionOfPrimitiveValues<string>("schools", Schools);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.ScopedRoleMembership>("scopedRoleMemberOf", ScopedRoleMemberOf);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.UserSettings>("settings", Settings);
            writer.WriteBoolValue("showInAddressList", ShowInAddressList);
            writer.WriteDateTimeOffsetValue("signInSessionsValidFromDateTime", SignInSessionsValidFromDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("skills", Skills);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("streetAddress", StreetAddress);
            writer.WriteStringValue("surname", Surname);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.UserTeamwork>("teamwork", Teamwork);
            writer.WriteObjectValue<ApiSdk.Models.Microsoft.Graph.Todo>("todo", Todo);
            writer.WriteCollectionOfObjectValues<ApiSdk.Models.Microsoft.Graph.DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
            writer.WriteStringValue("usageLocation", UsageLocation);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("userType", UserType);
        }
    }
}
