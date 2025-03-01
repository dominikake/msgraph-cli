using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.Reports.AuthenticationMethods;
using ApiSdk.Reports.DailyPrintUsageByPrinter;
using ApiSdk.Reports.DailyPrintUsageByUser;
using ApiSdk.Reports.DeviceConfigurationDeviceActivity;
using ApiSdk.Reports.DeviceConfigurationUserActivity;
using ApiSdk.Reports.GetEmailActivityCountsWithPeriod;
using ApiSdk.Reports.GetEmailActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetEmailActivityUserDetailWithDate;
using ApiSdk.Reports.GetEmailActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetEmailAppUsageAppsUserCountsWithPeriod;
using ApiSdk.Reports.GetEmailAppUsageUserCountsWithPeriod;
using ApiSdk.Reports.GetEmailAppUsageUserDetailWithDate;
using ApiSdk.Reports.GetEmailAppUsageUserDetailWithPeriod;
using ApiSdk.Reports.GetEmailAppUsageVersionsUserCountsWithPeriod;
using ApiSdk.Reports.GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTime;
using ApiSdk.Reports.GetM365AppPlatformUserCountsWithPeriod;
using ApiSdk.Reports.GetM365AppUserCountsWithPeriod;
using ApiSdk.Reports.GetM365AppUserDetailWithDate;
using ApiSdk.Reports.GetM365AppUserDetailWithPeriod;
using ApiSdk.Reports.GetMailboxUsageDetailWithPeriod;
using ApiSdk.Reports.GetMailboxUsageMailboxCountsWithPeriod;
using ApiSdk.Reports.GetMailboxUsageQuotaStatusMailboxCountsWithPeriod;
using ApiSdk.Reports.GetMailboxUsageStorageWithPeriod;
using ApiSdk.Reports.GetOffice365ActivationCounts;
using ApiSdk.Reports.GetOffice365ActivationsUserCounts;
using ApiSdk.Reports.GetOffice365ActivationsUserDetail;
using ApiSdk.Reports.GetOffice365ActiveUserCountsWithPeriod;
using ApiSdk.Reports.GetOffice365ActiveUserDetailWithDate;
using ApiSdk.Reports.GetOffice365ActiveUserDetailWithPeriod;
using ApiSdk.Reports.GetOffice365GroupsActivityCountsWithPeriod;
using ApiSdk.Reports.GetOffice365GroupsActivityDetailWithDate;
using ApiSdk.Reports.GetOffice365GroupsActivityDetailWithPeriod;
using ApiSdk.Reports.GetOffice365GroupsActivityFileCountsWithPeriod;
using ApiSdk.Reports.GetOffice365GroupsActivityGroupCountsWithPeriod;
using ApiSdk.Reports.GetOffice365GroupsActivityStorageWithPeriod;
using ApiSdk.Reports.GetOffice365ServicesUserCountsWithPeriod;
using ApiSdk.Reports.GetOneDriveActivityFileCountsWithPeriod;
using ApiSdk.Reports.GetOneDriveActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetOneDriveActivityUserDetailWithDate;
using ApiSdk.Reports.GetOneDriveActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetOneDriveUsageAccountCountsWithPeriod;
using ApiSdk.Reports.GetOneDriveUsageAccountDetailWithDate;
using ApiSdk.Reports.GetOneDriveUsageAccountDetailWithPeriod;
using ApiSdk.Reports.GetOneDriveUsageFileCountsWithPeriod;
using ApiSdk.Reports.GetOneDriveUsageStorageWithPeriod;
using ApiSdk.Reports.GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTime;
using ApiSdk.Reports.GetSharePointActivityFileCountsWithPeriod;
using ApiSdk.Reports.GetSharePointActivityPagesWithPeriod;
using ApiSdk.Reports.GetSharePointActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetSharePointActivityUserDetailWithDate;
using ApiSdk.Reports.GetSharePointActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetSharePointSiteUsageDetailWithDate;
using ApiSdk.Reports.GetSharePointSiteUsageDetailWithPeriod;
using ApiSdk.Reports.GetSharePointSiteUsageFileCountsWithPeriod;
using ApiSdk.Reports.GetSharePointSiteUsagePagesWithPeriod;
using ApiSdk.Reports.GetSharePointSiteUsageSiteCountsWithPeriod;
using ApiSdk.Reports.GetSharePointSiteUsageStorageWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessActivityCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessActivityUserDetailWithDate;
using ApiSdk.Reports.GetSkypeForBusinessActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessDeviceUsageUserCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessDeviceUsageUserDetailWithDate;
using ApiSdk.Reports.GetSkypeForBusinessDeviceUsageUserDetailWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessOrganizerActivityCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessOrganizerActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessParticipantActivityCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessParticipantActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessPeerToPeerActivityCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriod;
using ApiSdk.Reports.GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetTeamsDeviceUsageDistributionUserCountsWithPeriod;
using ApiSdk.Reports.GetTeamsDeviceUsageUserCountsWithPeriod;
using ApiSdk.Reports.GetTeamsDeviceUsageUserDetailWithDate;
using ApiSdk.Reports.GetTeamsDeviceUsageUserDetailWithPeriod;
using ApiSdk.Reports.GetTeamsTeamActivityCountsWithPeriod;
using ApiSdk.Reports.GetTeamsTeamActivityDetailWithDate;
using ApiSdk.Reports.GetTeamsTeamActivityDetailWithPeriod;
using ApiSdk.Reports.GetTeamsTeamActivityDistributionCountsWithPeriod;
using ApiSdk.Reports.GetTeamsTeamCountsWithPeriod;
using ApiSdk.Reports.GetTeamsUserActivityCountsWithPeriod;
using ApiSdk.Reports.GetTeamsUserActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetTeamsUserActivityUserDetailWithDate;
using ApiSdk.Reports.GetTeamsUserActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTime;
using ApiSdk.Reports.GetYammerActivityCountsWithPeriod;
using ApiSdk.Reports.GetYammerActivityUserCountsWithPeriod;
using ApiSdk.Reports.GetYammerActivityUserDetailWithDate;
using ApiSdk.Reports.GetYammerActivityUserDetailWithPeriod;
using ApiSdk.Reports.GetYammerDeviceUsageDistributionUserCountsWithPeriod;
using ApiSdk.Reports.GetYammerDeviceUsageUserCountsWithPeriod;
using ApiSdk.Reports.GetYammerDeviceUsageUserDetailWithDate;
using ApiSdk.Reports.GetYammerDeviceUsageUserDetailWithPeriod;
using ApiSdk.Reports.GetYammerGroupsActivityCountsWithPeriod;
using ApiSdk.Reports.GetYammerGroupsActivityDetailWithDate;
using ApiSdk.Reports.GetYammerGroupsActivityDetailWithPeriod;
using ApiSdk.Reports.GetYammerGroupsActivityGroupCountsWithPeriod;
using ApiSdk.Reports.ManagedDeviceEnrollmentFailureDetails;
using ApiSdk.Reports.ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipToken;
using ApiSdk.Reports.ManagedDeviceEnrollmentTopFailures;
using ApiSdk.Reports.ManagedDeviceEnrollmentTopFailuresWithPeriod;
using ApiSdk.Reports.MonthlyPrintUsageByPrinter;
using ApiSdk.Reports.MonthlyPrintUsageByUser;
using ApiSdk.Reports.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace ApiSdk.Reports {
    /// <summary>
    /// Provides operations to manage the reportRoot singleton.
    /// </summary>
    public class ReportsRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the authenticationMethods property of the microsoft.graph.reportRoot entity.
        /// </summary>
        public Command BuildAuthenticationMethodsNavCommand() {
            var command = new Command("authentication-methods");
            command.Description = "Provides operations to manage the authenticationMethods property of the microsoft.graph.reportRoot entity.";
            var builder = new AuthenticationMethodsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildUserRegistrationDetailsNavCommand());
            nonExecCommands.Add(builder.BuildUsersRegisteredByFeatureNavCommand());
            nonExecCommands.Add(builder.BuildUsersRegisteredByFeatureWithIncludedUserTypesWithIncludedUserRolesRbCommand());
            nonExecCommands.Add(builder.BuildUsersRegisteredByMethodNavCommand());
            nonExecCommands.Add(builder.BuildUsersRegisteredByMethodWithIncludedUserTypesWithIncludedUserRolesRbCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the dailyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.
        /// </summary>
        public Command BuildDailyPrintUsageByPrinterNavCommand() {
            var command = new Command("daily-print-usage-by-printer");
            command.Description = "Provides operations to manage the dailyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.";
            var builder = new DailyPrintUsageByPrinterRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the dailyPrintUsageByUser property of the microsoft.graph.reportRoot entity.
        /// </summary>
        public Command BuildDailyPrintUsageByUserNavCommand() {
            var command = new Command("daily-print-usage-by-user");
            command.Description = "Provides operations to manage the dailyPrintUsageByUser property of the microsoft.graph.reportRoot entity.";
            var builder = new DailyPrintUsageByUserRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the deviceConfigurationDeviceActivity method.
        /// </summary>
        public Command BuildDeviceConfigurationDeviceActivityNavCommand() {
            var command = new Command("device-configuration-device-activity");
            command.Description = "Provides operations to call the deviceConfigurationDeviceActivity method.";
            var builder = new DeviceConfigurationDeviceActivityRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the deviceConfigurationUserActivity method.
        /// </summary>
        public Command BuildDeviceConfigurationUserActivityNavCommand() {
            var command = new Command("device-configuration-user-activity");
            command.Description = "Provides operations to call the deviceConfigurationUserActivity method.";
            var builder = new DeviceConfigurationUserActivityRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Read properties and relationships of the reportRoot object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/intune-deviceconfig-reportroot-get?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Read properties and relationships of the reportRoot object.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/intune-deviceconfig-reportroot-get?view=graph-rest-1.0";
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
            var expandOption = new Option<string[]>("--expand", description: "Expand related entities") {
                Arity = ArgumentArity.ZeroOrMore
            };
            expandOption.IsRequired = false;
            command.AddOption(expandOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var jsonNoIndentOption = new Option<bool>("--json-no-indent", r => {
                if (bool.TryParse(r.Tokens.Select(t => t.Value).LastOrDefault(), out var value)) {
                    return value;
                }
                return true;
            }, description: "Disable indentation for the JSON output formatter.");
            command.AddOption(jsonNoIndentOption);
            command.SetHandler(async (invocationContext) => {
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityCounts method.
        /// </summary>
        public Command BuildGetEmailActivityCountsWithPeriodRbCommand() {
            var command = new Command("get-email-activity-counts-with-period");
            command.Description = "Provides operations to call the getEmailActivityCounts method.";
            var builder = new GetEmailActivityCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityUserCounts method.
        /// </summary>
        public Command BuildGetEmailActivityUserCountsWithPeriodRbCommand() {
            var command = new Command("get-email-activity-user-counts-with-period");
            command.Description = "Provides operations to call the getEmailActivityUserCounts method.";
            var builder = new GetEmailActivityUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityUserDetail method.
        /// </summary>
        public Command BuildGetEmailActivityUserDetailWithDateRbCommand() {
            var command = new Command("get-email-activity-user-detail-with-date");
            command.Description = "Provides operations to call the getEmailActivityUserDetail method.";
            var builder = new GetEmailActivityUserDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getEmailActivityUserDetail method.
        /// </summary>
        public Command BuildGetEmailActivityUserDetailWithPeriodRbCommand() {
            var command = new Command("get-email-activity-user-detail-with-period");
            command.Description = "Provides operations to call the getEmailActivityUserDetail method.";
            var builder = new GetEmailActivityUserDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageAppsUserCounts method.
        /// </summary>
        public Command BuildGetEmailAppUsageAppsUserCountsWithPeriodRbCommand() {
            var command = new Command("get-email-app-usage-apps-user-counts-with-period");
            command.Description = "Provides operations to call the getEmailAppUsageAppsUserCounts method.";
            var builder = new GetEmailAppUsageAppsUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageUserCounts method.
        /// </summary>
        public Command BuildGetEmailAppUsageUserCountsWithPeriodRbCommand() {
            var command = new Command("get-email-app-usage-user-counts-with-period");
            command.Description = "Provides operations to call the getEmailAppUsageUserCounts method.";
            var builder = new GetEmailAppUsageUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageUserDetail method.
        /// </summary>
        public Command BuildGetEmailAppUsageUserDetailWithDateRbCommand() {
            var command = new Command("get-email-app-usage-user-detail-with-date");
            command.Description = "Provides operations to call the getEmailAppUsageUserDetail method.";
            var builder = new GetEmailAppUsageUserDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageUserDetail method.
        /// </summary>
        public Command BuildGetEmailAppUsageUserDetailWithPeriodRbCommand() {
            var command = new Command("get-email-app-usage-user-detail-with-period");
            command.Description = "Provides operations to call the getEmailAppUsageUserDetail method.";
            var builder = new GetEmailAppUsageUserDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getEmailAppUsageVersionsUserCounts method.
        /// </summary>
        public Command BuildGetEmailAppUsageVersionsUserCountsWithPeriodRbCommand() {
            var command = new Command("get-email-app-usage-versions-user-counts-with-period");
            command.Description = "Provides operations to call the getEmailAppUsageVersionsUserCounts method.";
            var builder = new GetEmailAppUsageVersionsUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getGroupArchivedPrintJobs method.
        /// </summary>
        public Command BuildGetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRbCommand() {
            var command = new Command("get-group-archived-print-jobs-with-group-id-with-start-date-time-with-end-date-time");
            command.Description = "Provides operations to call the getGroupArchivedPrintJobs method.";
            var builder = new GetGroupArchivedPrintJobsWithGroupIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getM365AppPlatformUserCounts method.
        /// </summary>
        public Command BuildGetM365AppPlatformUserCountsWithPeriodRbCommand() {
            var command = new Command("get-m365-app-platform-user-counts-with-period");
            command.Description = "Provides operations to call the getM365AppPlatformUserCounts method.";
            var builder = new GetM365AppPlatformUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getM365AppUserCounts method.
        /// </summary>
        public Command BuildGetM365AppUserCountsWithPeriodRbCommand() {
            var command = new Command("get-m365-app-user-counts-with-period");
            command.Description = "Provides operations to call the getM365AppUserCounts method.";
            var builder = new GetM365AppUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getM365AppUserDetail method.
        /// </summary>
        public Command BuildGetM365AppUserDetailWithDateRbCommand() {
            var command = new Command("get-m365-app-user-detail-with-date");
            command.Description = "Provides operations to call the getM365AppUserDetail method.";
            var builder = new GetM365AppUserDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getM365AppUserDetail method.
        /// </summary>
        public Command BuildGetM365AppUserDetailWithPeriodRbCommand() {
            var command = new Command("get-m365-app-user-detail-with-period");
            command.Description = "Provides operations to call the getM365AppUserDetail method.";
            var builder = new GetM365AppUserDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageDetail method.
        /// </summary>
        public Command BuildGetMailboxUsageDetailWithPeriodRbCommand() {
            var command = new Command("get-mailbox-usage-detail-with-period");
            command.Description = "Provides operations to call the getMailboxUsageDetail method.";
            var builder = new GetMailboxUsageDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageMailboxCounts method.
        /// </summary>
        public Command BuildGetMailboxUsageMailboxCountsWithPeriodRbCommand() {
            var command = new Command("get-mailbox-usage-mailbox-counts-with-period");
            command.Description = "Provides operations to call the getMailboxUsageMailboxCounts method.";
            var builder = new GetMailboxUsageMailboxCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageQuotaStatusMailboxCounts method.
        /// </summary>
        public Command BuildGetMailboxUsageQuotaStatusMailboxCountsWithPeriodRbCommand() {
            var command = new Command("get-mailbox-usage-quota-status-mailbox-counts-with-period");
            command.Description = "Provides operations to call the getMailboxUsageQuotaStatusMailboxCounts method.";
            var builder = new GetMailboxUsageQuotaStatusMailboxCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getMailboxUsageStorage method.
        /// </summary>
        public Command BuildGetMailboxUsageStorageWithPeriodRbCommand() {
            var command = new Command("get-mailbox-usage-storage-with-period");
            command.Description = "Provides operations to call the getMailboxUsageStorage method.";
            var builder = new GetMailboxUsageStorageWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActivationCounts method.
        /// </summary>
        public Command BuildGetOffice365ActivationCountsNavCommand() {
            var command = new Command("get-office365-activation-counts");
            command.Description = "Provides operations to call the getOffice365ActivationCounts method.";
            var builder = new GetOffice365ActivationCountsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActivationsUserCounts method.
        /// </summary>
        public Command BuildGetOffice365ActivationsUserCountsNavCommand() {
            var command = new Command("get-office365-activations-user-counts");
            command.Description = "Provides operations to call the getOffice365ActivationsUserCounts method.";
            var builder = new GetOffice365ActivationsUserCountsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActivationsUserDetail method.
        /// </summary>
        public Command BuildGetOffice365ActivationsUserDetailNavCommand() {
            var command = new Command("get-office365-activations-user-detail");
            command.Description = "Provides operations to call the getOffice365ActivationsUserDetail method.";
            var builder = new GetOffice365ActivationsUserDetailRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActiveUserCounts method.
        /// </summary>
        public Command BuildGetOffice365ActiveUserCountsWithPeriodRbCommand() {
            var command = new Command("get-office365-active-user-counts-with-period");
            command.Description = "Provides operations to call the getOffice365ActiveUserCounts method.";
            var builder = new GetOffice365ActiveUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActiveUserDetail method.
        /// </summary>
        public Command BuildGetOffice365ActiveUserDetailWithDateRbCommand() {
            var command = new Command("get-office365-active-user-detail-with-date");
            command.Description = "Provides operations to call the getOffice365ActiveUserDetail method.";
            var builder = new GetOffice365ActiveUserDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365ActiveUserDetail method.
        /// </summary>
        public Command BuildGetOffice365ActiveUserDetailWithPeriodRbCommand() {
            var command = new Command("get-office365-active-user-detail-with-period");
            command.Description = "Provides operations to call the getOffice365ActiveUserDetail method.";
            var builder = new GetOffice365ActiveUserDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityCounts method.
        /// </summary>
        public Command BuildGetOffice365GroupsActivityCountsWithPeriodRbCommand() {
            var command = new Command("get-office365-groups-activity-counts-with-period");
            command.Description = "Provides operations to call the getOffice365GroupsActivityCounts method.";
            var builder = new GetOffice365GroupsActivityCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityDetail method.
        /// </summary>
        public Command BuildGetOffice365GroupsActivityDetailWithDateRbCommand() {
            var command = new Command("get-office365-groups-activity-detail-with-date");
            command.Description = "Provides operations to call the getOffice365GroupsActivityDetail method.";
            var builder = new GetOffice365GroupsActivityDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityDetail method.
        /// </summary>
        public Command BuildGetOffice365GroupsActivityDetailWithPeriodRbCommand() {
            var command = new Command("get-office365-groups-activity-detail-with-period");
            command.Description = "Provides operations to call the getOffice365GroupsActivityDetail method.";
            var builder = new GetOffice365GroupsActivityDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityFileCounts method.
        /// </summary>
        public Command BuildGetOffice365GroupsActivityFileCountsWithPeriodRbCommand() {
            var command = new Command("get-office365-groups-activity-file-counts-with-period");
            command.Description = "Provides operations to call the getOffice365GroupsActivityFileCounts method.";
            var builder = new GetOffice365GroupsActivityFileCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityGroupCounts method.
        /// </summary>
        public Command BuildGetOffice365GroupsActivityGroupCountsWithPeriodRbCommand() {
            var command = new Command("get-office365-groups-activity-group-counts-with-period");
            command.Description = "Provides operations to call the getOffice365GroupsActivityGroupCounts method.";
            var builder = new GetOffice365GroupsActivityGroupCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365GroupsActivityStorage method.
        /// </summary>
        public Command BuildGetOffice365GroupsActivityStorageWithPeriodRbCommand() {
            var command = new Command("get-office365-groups-activity-storage-with-period");
            command.Description = "Provides operations to call the getOffice365GroupsActivityStorage method.";
            var builder = new GetOffice365GroupsActivityStorageWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOffice365ServicesUserCounts method.
        /// </summary>
        public Command BuildGetOffice365ServicesUserCountsWithPeriodRbCommand() {
            var command = new Command("get-office365-services-user-counts-with-period");
            command.Description = "Provides operations to call the getOffice365ServicesUserCounts method.";
            var builder = new GetOffice365ServicesUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityFileCounts method.
        /// </summary>
        public Command BuildGetOneDriveActivityFileCountsWithPeriodRbCommand() {
            var command = new Command("get-one-drive-activity-file-counts-with-period");
            command.Description = "Provides operations to call the getOneDriveActivityFileCounts method.";
            var builder = new GetOneDriveActivityFileCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityUserCounts method.
        /// </summary>
        public Command BuildGetOneDriveActivityUserCountsWithPeriodRbCommand() {
            var command = new Command("get-one-drive-activity-user-counts-with-period");
            command.Description = "Provides operations to call the getOneDriveActivityUserCounts method.";
            var builder = new GetOneDriveActivityUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityUserDetail method.
        /// </summary>
        public Command BuildGetOneDriveActivityUserDetailWithDateRbCommand() {
            var command = new Command("get-one-drive-activity-user-detail-with-date");
            command.Description = "Provides operations to call the getOneDriveActivityUserDetail method.";
            var builder = new GetOneDriveActivityUserDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOneDriveActivityUserDetail method.
        /// </summary>
        public Command BuildGetOneDriveActivityUserDetailWithPeriodRbCommand() {
            var command = new Command("get-one-drive-activity-user-detail-with-period");
            command.Description = "Provides operations to call the getOneDriveActivityUserDetail method.";
            var builder = new GetOneDriveActivityUserDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageAccountCounts method.
        /// </summary>
        public Command BuildGetOneDriveUsageAccountCountsWithPeriodRbCommand() {
            var command = new Command("get-one-drive-usage-account-counts-with-period");
            command.Description = "Provides operations to call the getOneDriveUsageAccountCounts method.";
            var builder = new GetOneDriveUsageAccountCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageAccountDetail method.
        /// </summary>
        public Command BuildGetOneDriveUsageAccountDetailWithDateRbCommand() {
            var command = new Command("get-one-drive-usage-account-detail-with-date");
            command.Description = "Provides operations to call the getOneDriveUsageAccountDetail method.";
            var builder = new GetOneDriveUsageAccountDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageAccountDetail method.
        /// </summary>
        public Command BuildGetOneDriveUsageAccountDetailWithPeriodRbCommand() {
            var command = new Command("get-one-drive-usage-account-detail-with-period");
            command.Description = "Provides operations to call the getOneDriveUsageAccountDetail method.";
            var builder = new GetOneDriveUsageAccountDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageFileCounts method.
        /// </summary>
        public Command BuildGetOneDriveUsageFileCountsWithPeriodRbCommand() {
            var command = new Command("get-one-drive-usage-file-counts-with-period");
            command.Description = "Provides operations to call the getOneDriveUsageFileCounts method.";
            var builder = new GetOneDriveUsageFileCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getOneDriveUsageStorage method.
        /// </summary>
        public Command BuildGetOneDriveUsageStorageWithPeriodRbCommand() {
            var command = new Command("get-one-drive-usage-storage-with-period");
            command.Description = "Provides operations to call the getOneDriveUsageStorage method.";
            var builder = new GetOneDriveUsageStorageWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getPrinterArchivedPrintJobs method.
        /// </summary>
        public Command BuildGetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRbCommand() {
            var command = new Command("get-printer-archived-print-jobs-with-printer-id-with-start-date-time-with-end-date-time");
            command.Description = "Provides operations to call the getPrinterArchivedPrintJobs method.";
            var builder = new GetPrinterArchivedPrintJobsWithPrinterIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityFileCounts method.
        /// </summary>
        public Command BuildGetSharePointActivityFileCountsWithPeriodRbCommand() {
            var command = new Command("get-share-point-activity-file-counts-with-period");
            command.Description = "Provides operations to call the getSharePointActivityFileCounts method.";
            var builder = new GetSharePointActivityFileCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityPages method.
        /// </summary>
        public Command BuildGetSharePointActivityPagesWithPeriodRbCommand() {
            var command = new Command("get-share-point-activity-pages-with-period");
            command.Description = "Provides operations to call the getSharePointActivityPages method.";
            var builder = new GetSharePointActivityPagesWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityUserCounts method.
        /// </summary>
        public Command BuildGetSharePointActivityUserCountsWithPeriodRbCommand() {
            var command = new Command("get-share-point-activity-user-counts-with-period");
            command.Description = "Provides operations to call the getSharePointActivityUserCounts method.";
            var builder = new GetSharePointActivityUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityUserDetail method.
        /// </summary>
        public Command BuildGetSharePointActivityUserDetailWithDateRbCommand() {
            var command = new Command("get-share-point-activity-user-detail-with-date");
            command.Description = "Provides operations to call the getSharePointActivityUserDetail method.";
            var builder = new GetSharePointActivityUserDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSharePointActivityUserDetail method.
        /// </summary>
        public Command BuildGetSharePointActivityUserDetailWithPeriodRbCommand() {
            var command = new Command("get-share-point-activity-user-detail-with-period");
            command.Description = "Provides operations to call the getSharePointActivityUserDetail method.";
            var builder = new GetSharePointActivityUserDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageDetail method.
        /// </summary>
        public Command BuildGetSharePointSiteUsageDetailWithDateRbCommand() {
            var command = new Command("get-share-point-site-usage-detail-with-date");
            command.Description = "Provides operations to call the getSharePointSiteUsageDetail method.";
            var builder = new GetSharePointSiteUsageDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageDetail method.
        /// </summary>
        public Command BuildGetSharePointSiteUsageDetailWithPeriodRbCommand() {
            var command = new Command("get-share-point-site-usage-detail-with-period");
            command.Description = "Provides operations to call the getSharePointSiteUsageDetail method.";
            var builder = new GetSharePointSiteUsageDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageFileCounts method.
        /// </summary>
        public Command BuildGetSharePointSiteUsageFileCountsWithPeriodRbCommand() {
            var command = new Command("get-share-point-site-usage-file-counts-with-period");
            command.Description = "Provides operations to call the getSharePointSiteUsageFileCounts method.";
            var builder = new GetSharePointSiteUsageFileCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsagePages method.
        /// </summary>
        public Command BuildGetSharePointSiteUsagePagesWithPeriodRbCommand() {
            var command = new Command("get-share-point-site-usage-pages-with-period");
            command.Description = "Provides operations to call the getSharePointSiteUsagePages method.";
            var builder = new GetSharePointSiteUsagePagesWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageSiteCounts method.
        /// </summary>
        public Command BuildGetSharePointSiteUsageSiteCountsWithPeriodRbCommand() {
            var command = new Command("get-share-point-site-usage-site-counts-with-period");
            command.Description = "Provides operations to call the getSharePointSiteUsageSiteCounts method.";
            var builder = new GetSharePointSiteUsageSiteCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSharePointSiteUsageStorage method.
        /// </summary>
        public Command BuildGetSharePointSiteUsageStorageWithPeriodRbCommand() {
            var command = new Command("get-share-point-site-usage-storage-with-period");
            command.Description = "Provides operations to call the getSharePointSiteUsageStorage method.";
            var builder = new GetSharePointSiteUsageStorageWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityCounts method.
        /// </summary>
        public Command BuildGetSkypeForBusinessActivityCountsWithPeriodRbCommand() {
            var command = new Command("get-skype-for-business-activity-counts-with-period");
            command.Description = "Provides operations to call the getSkypeForBusinessActivityCounts method.";
            var builder = new GetSkypeForBusinessActivityCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityUserCounts method.
        /// </summary>
        public Command BuildGetSkypeForBusinessActivityUserCountsWithPeriodRbCommand() {
            var command = new Command("get-skype-for-business-activity-user-counts-with-period");
            command.Description = "Provides operations to call the getSkypeForBusinessActivityUserCounts method.";
            var builder = new GetSkypeForBusinessActivityUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityUserDetail method.
        /// </summary>
        public Command BuildGetSkypeForBusinessActivityUserDetailWithDateRbCommand() {
            var command = new Command("get-skype-for-business-activity-user-detail-with-date");
            command.Description = "Provides operations to call the getSkypeForBusinessActivityUserDetail method.";
            var builder = new GetSkypeForBusinessActivityUserDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessActivityUserDetail method.
        /// </summary>
        public Command BuildGetSkypeForBusinessActivityUserDetailWithPeriodRbCommand() {
            var command = new Command("get-skype-for-business-activity-user-detail-with-period");
            command.Description = "Provides operations to call the getSkypeForBusinessActivityUserDetail method.";
            var builder = new GetSkypeForBusinessActivityUserDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageDistributionUserCounts method.
        /// </summary>
        public Command BuildGetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRbCommand() {
            var command = new Command("get-skype-for-business-device-usage-distribution-user-counts-with-period");
            command.Description = "Provides operations to call the getSkypeForBusinessDeviceUsageDistributionUserCounts method.";
            var builder = new GetSkypeForBusinessDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageUserCounts method.
        /// </summary>
        public Command BuildGetSkypeForBusinessDeviceUsageUserCountsWithPeriodRbCommand() {
            var command = new Command("get-skype-for-business-device-usage-user-counts-with-period");
            command.Description = "Provides operations to call the getSkypeForBusinessDeviceUsageUserCounts method.";
            var builder = new GetSkypeForBusinessDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageUserDetail method.
        /// </summary>
        public Command BuildGetSkypeForBusinessDeviceUsageUserDetailWithDateRbCommand() {
            var command = new Command("get-skype-for-business-device-usage-user-detail-with-date");
            command.Description = "Provides operations to call the getSkypeForBusinessDeviceUsageUserDetail method.";
            var builder = new GetSkypeForBusinessDeviceUsageUserDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessDeviceUsageUserDetail method.
        /// </summary>
        public Command BuildGetSkypeForBusinessDeviceUsageUserDetailWithPeriodRbCommand() {
            var command = new Command("get-skype-for-business-device-usage-user-detail-with-period");
            command.Description = "Provides operations to call the getSkypeForBusinessDeviceUsageUserDetail method.";
            var builder = new GetSkypeForBusinessDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessOrganizerActivityCounts method.
        /// </summary>
        public Command BuildGetSkypeForBusinessOrganizerActivityCountsWithPeriodRbCommand() {
            var command = new Command("get-skype-for-business-organizer-activity-counts-with-period");
            command.Description = "Provides operations to call the getSkypeForBusinessOrganizerActivityCounts method.";
            var builder = new GetSkypeForBusinessOrganizerActivityCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessOrganizerActivityMinuteCounts method.
        /// </summary>
        public Command BuildGetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRbCommand() {
            var command = new Command("get-skype-for-business-organizer-activity-minute-counts-with-period");
            command.Description = "Provides operations to call the getSkypeForBusinessOrganizerActivityMinuteCounts method.";
            var builder = new GetSkypeForBusinessOrganizerActivityMinuteCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessOrganizerActivityUserCounts method.
        /// </summary>
        public Command BuildGetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRbCommand() {
            var command = new Command("get-skype-for-business-organizer-activity-user-counts-with-period");
            command.Description = "Provides operations to call the getSkypeForBusinessOrganizerActivityUserCounts method.";
            var builder = new GetSkypeForBusinessOrganizerActivityUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessParticipantActivityCounts method.
        /// </summary>
        public Command BuildGetSkypeForBusinessParticipantActivityCountsWithPeriodRbCommand() {
            var command = new Command("get-skype-for-business-participant-activity-counts-with-period");
            command.Description = "Provides operations to call the getSkypeForBusinessParticipantActivityCounts method.";
            var builder = new GetSkypeForBusinessParticipantActivityCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessParticipantActivityMinuteCounts method.
        /// </summary>
        public Command BuildGetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRbCommand() {
            var command = new Command("get-skype-for-business-participant-activity-minute-counts-with-period");
            command.Description = "Provides operations to call the getSkypeForBusinessParticipantActivityMinuteCounts method.";
            var builder = new GetSkypeForBusinessParticipantActivityMinuteCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessParticipantActivityUserCounts method.
        /// </summary>
        public Command BuildGetSkypeForBusinessParticipantActivityUserCountsWithPeriodRbCommand() {
            var command = new Command("get-skype-for-business-participant-activity-user-counts-with-period");
            command.Description = "Provides operations to call the getSkypeForBusinessParticipantActivityUserCounts method.";
            var builder = new GetSkypeForBusinessParticipantActivityUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessPeerToPeerActivityCounts method.
        /// </summary>
        public Command BuildGetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRbCommand() {
            var command = new Command("get-skype-for-business-peer-to-peer-activity-counts-with-period");
            command.Description = "Provides operations to call the getSkypeForBusinessPeerToPeerActivityCounts method.";
            var builder = new GetSkypeForBusinessPeerToPeerActivityCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessPeerToPeerActivityMinuteCounts method.
        /// </summary>
        public Command BuildGetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRbCommand() {
            var command = new Command("get-skype-for-business-peer-to-peer-activity-minute-counts-with-period");
            command.Description = "Provides operations to call the getSkypeForBusinessPeerToPeerActivityMinuteCounts method.";
            var builder = new GetSkypeForBusinessPeerToPeerActivityMinuteCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getSkypeForBusinessPeerToPeerActivityUserCounts method.
        /// </summary>
        public Command BuildGetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRbCommand() {
            var command = new Command("get-skype-for-business-peer-to-peer-activity-user-counts-with-period");
            command.Description = "Provides operations to call the getSkypeForBusinessPeerToPeerActivityUserCounts method.";
            var builder = new GetSkypeForBusinessPeerToPeerActivityUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageDistributionUserCounts method.
        /// </summary>
        public Command BuildGetTeamsDeviceUsageDistributionUserCountsWithPeriodRbCommand() {
            var command = new Command("get-teams-device-usage-distribution-user-counts-with-period");
            command.Description = "Provides operations to call the getTeamsDeviceUsageDistributionUserCounts method.";
            var builder = new GetTeamsDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageUserCounts method.
        /// </summary>
        public Command BuildGetTeamsDeviceUsageUserCountsWithPeriodRbCommand() {
            var command = new Command("get-teams-device-usage-user-counts-with-period");
            command.Description = "Provides operations to call the getTeamsDeviceUsageUserCounts method.";
            var builder = new GetTeamsDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageUserDetail method.
        /// </summary>
        public Command BuildGetTeamsDeviceUsageUserDetailWithDateRbCommand() {
            var command = new Command("get-teams-device-usage-user-detail-with-date");
            command.Description = "Provides operations to call the getTeamsDeviceUsageUserDetail method.";
            var builder = new GetTeamsDeviceUsageUserDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getTeamsDeviceUsageUserDetail method.
        /// </summary>
        public Command BuildGetTeamsDeviceUsageUserDetailWithPeriodRbCommand() {
            var command = new Command("get-teams-device-usage-user-detail-with-period");
            command.Description = "Provides operations to call the getTeamsDeviceUsageUserDetail method.";
            var builder = new GetTeamsDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getTeamsTeamActivityCounts method.
        /// </summary>
        public Command BuildGetTeamsTeamActivityCountsWithPeriodRbCommand() {
            var command = new Command("get-teams-team-activity-counts-with-period");
            command.Description = "Provides operations to call the getTeamsTeamActivityCounts method.";
            var builder = new GetTeamsTeamActivityCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getTeamsTeamActivityDetail method.
        /// </summary>
        public Command BuildGetTeamsTeamActivityDetailWithDateRbCommand() {
            var command = new Command("get-teams-team-activity-detail-with-date");
            command.Description = "Provides operations to call the getTeamsTeamActivityDetail method.";
            var builder = new GetTeamsTeamActivityDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getTeamsTeamActivityDetail method.
        /// </summary>
        public Command BuildGetTeamsTeamActivityDetailWithPeriodRbCommand() {
            var command = new Command("get-teams-team-activity-detail-with-period");
            command.Description = "Provides operations to call the getTeamsTeamActivityDetail method.";
            var builder = new GetTeamsTeamActivityDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getTeamsTeamActivityDistributionCounts method.
        /// </summary>
        public Command BuildGetTeamsTeamActivityDistributionCountsWithPeriodRbCommand() {
            var command = new Command("get-teams-team-activity-distribution-counts-with-period");
            command.Description = "Provides operations to call the getTeamsTeamActivityDistributionCounts method.";
            var builder = new GetTeamsTeamActivityDistributionCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getTeamsTeamCounts method.
        /// </summary>
        public Command BuildGetTeamsTeamCountsWithPeriodRbCommand() {
            var command = new Command("get-teams-team-counts-with-period");
            command.Description = "Provides operations to call the getTeamsTeamCounts method.";
            var builder = new GetTeamsTeamCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityCounts method.
        /// </summary>
        public Command BuildGetTeamsUserActivityCountsWithPeriodRbCommand() {
            var command = new Command("get-teams-user-activity-counts-with-period");
            command.Description = "Provides operations to call the getTeamsUserActivityCounts method.";
            var builder = new GetTeamsUserActivityCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityUserCounts method.
        /// </summary>
        public Command BuildGetTeamsUserActivityUserCountsWithPeriodRbCommand() {
            var command = new Command("get-teams-user-activity-user-counts-with-period");
            command.Description = "Provides operations to call the getTeamsUserActivityUserCounts method.";
            var builder = new GetTeamsUserActivityUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityUserDetail method.
        /// </summary>
        public Command BuildGetTeamsUserActivityUserDetailWithDateRbCommand() {
            var command = new Command("get-teams-user-activity-user-detail-with-date");
            command.Description = "Provides operations to call the getTeamsUserActivityUserDetail method.";
            var builder = new GetTeamsUserActivityUserDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getTeamsUserActivityUserDetail method.
        /// </summary>
        public Command BuildGetTeamsUserActivityUserDetailWithPeriodRbCommand() {
            var command = new Command("get-teams-user-activity-user-detail-with-period");
            command.Description = "Provides operations to call the getTeamsUserActivityUserDetail method.";
            var builder = new GetTeamsUserActivityUserDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getUserArchivedPrintJobs method.
        /// </summary>
        public Command BuildGetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTimeRbCommand() {
            var command = new Command("get-user-archived-print-jobs-with-user-id-with-start-date-time-with-end-date-time");
            command.Description = "Provides operations to call the getUserArchivedPrintJobs method.";
            var builder = new GetUserArchivedPrintJobsWithUserIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityCounts method.
        /// </summary>
        public Command BuildGetYammerActivityCountsWithPeriodRbCommand() {
            var command = new Command("get-yammer-activity-counts-with-period");
            command.Description = "Provides operations to call the getYammerActivityCounts method.";
            var builder = new GetYammerActivityCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityUserCounts method.
        /// </summary>
        public Command BuildGetYammerActivityUserCountsWithPeriodRbCommand() {
            var command = new Command("get-yammer-activity-user-counts-with-period");
            command.Description = "Provides operations to call the getYammerActivityUserCounts method.";
            var builder = new GetYammerActivityUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityUserDetail method.
        /// </summary>
        public Command BuildGetYammerActivityUserDetailWithDateRbCommand() {
            var command = new Command("get-yammer-activity-user-detail-with-date");
            command.Description = "Provides operations to call the getYammerActivityUserDetail method.";
            var builder = new GetYammerActivityUserDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getYammerActivityUserDetail method.
        /// </summary>
        public Command BuildGetYammerActivityUserDetailWithPeriodRbCommand() {
            var command = new Command("get-yammer-activity-user-detail-with-period");
            command.Description = "Provides operations to call the getYammerActivityUserDetail method.";
            var builder = new GetYammerActivityUserDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageDistributionUserCounts method.
        /// </summary>
        public Command BuildGetYammerDeviceUsageDistributionUserCountsWithPeriodRbCommand() {
            var command = new Command("get-yammer-device-usage-distribution-user-counts-with-period");
            command.Description = "Provides operations to call the getYammerDeviceUsageDistributionUserCounts method.";
            var builder = new GetYammerDeviceUsageDistributionUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageUserCounts method.
        /// </summary>
        public Command BuildGetYammerDeviceUsageUserCountsWithPeriodRbCommand() {
            var command = new Command("get-yammer-device-usage-user-counts-with-period");
            command.Description = "Provides operations to call the getYammerDeviceUsageUserCounts method.";
            var builder = new GetYammerDeviceUsageUserCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageUserDetail method.
        /// </summary>
        public Command BuildGetYammerDeviceUsageUserDetailWithDateRbCommand() {
            var command = new Command("get-yammer-device-usage-user-detail-with-date");
            command.Description = "Provides operations to call the getYammerDeviceUsageUserDetail method.";
            var builder = new GetYammerDeviceUsageUserDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getYammerDeviceUsageUserDetail method.
        /// </summary>
        public Command BuildGetYammerDeviceUsageUserDetailWithPeriodRbCommand() {
            var command = new Command("get-yammer-device-usage-user-detail-with-period");
            command.Description = "Provides operations to call the getYammerDeviceUsageUserDetail method.";
            var builder = new GetYammerDeviceUsageUserDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityCounts method.
        /// </summary>
        public Command BuildGetYammerGroupsActivityCountsWithPeriodRbCommand() {
            var command = new Command("get-yammer-groups-activity-counts-with-period");
            command.Description = "Provides operations to call the getYammerGroupsActivityCounts method.";
            var builder = new GetYammerGroupsActivityCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityDetail method.
        /// </summary>
        public Command BuildGetYammerGroupsActivityDetailWithDateRbCommand() {
            var command = new Command("get-yammer-groups-activity-detail-with-date");
            command.Description = "Provides operations to call the getYammerGroupsActivityDetail method.";
            var builder = new GetYammerGroupsActivityDetailWithDateRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityDetail method.
        /// </summary>
        public Command BuildGetYammerGroupsActivityDetailWithPeriodRbCommand() {
            var command = new Command("get-yammer-groups-activity-detail-with-period");
            command.Description = "Provides operations to call the getYammerGroupsActivityDetail method.";
            var builder = new GetYammerGroupsActivityDetailWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getYammerGroupsActivityGroupCounts method.
        /// </summary>
        public Command BuildGetYammerGroupsActivityGroupCountsWithPeriodRbCommand() {
            var command = new Command("get-yammer-groups-activity-group-counts-with-period");
            command.Description = "Provides operations to call the getYammerGroupsActivityGroupCounts method.";
            var builder = new GetYammerGroupsActivityGroupCountsWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentFailureDetails method.
        /// </summary>
        public Command BuildManagedDeviceEnrollmentFailureDetailsNavCommand() {
            var command = new Command("managed-device-enrollment-failure-details");
            command.Description = "Provides operations to call the managedDeviceEnrollmentFailureDetails method.";
            var builder = new ManagedDeviceEnrollmentFailureDetailsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentFailureDetails method.
        /// </summary>
        public Command BuildManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRbCommand() {
            var command = new Command("managed-device-enrollment-failure-details-with-skip-with-top-with-filter-with-skip-token");
            command.Description = "Provides operations to call the managedDeviceEnrollmentFailureDetails method.";
            var builder = new ManagedDeviceEnrollmentFailureDetailsWithSkipWithTopWithFilterWithSkipTokenRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentTopFailures method.
        /// </summary>
        public Command BuildManagedDeviceEnrollmentTopFailuresNavCommand() {
            var command = new Command("managed-device-enrollment-top-failures");
            command.Description = "Provides operations to call the managedDeviceEnrollmentTopFailures method.";
            var builder = new ManagedDeviceEnrollmentTopFailuresRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the managedDeviceEnrollmentTopFailures method.
        /// </summary>
        public Command BuildManagedDeviceEnrollmentTopFailuresWithPeriodRbCommand() {
            var command = new Command("managed-device-enrollment-top-failures-with-period");
            command.Description = "Provides operations to call the managedDeviceEnrollmentTopFailures method.";
            var builder = new ManagedDeviceEnrollmentTopFailuresWithPeriodRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the monthlyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.
        /// </summary>
        public Command BuildMonthlyPrintUsageByPrinterNavCommand() {
            var command = new Command("monthly-print-usage-by-printer");
            command.Description = "Provides operations to manage the monthlyPrintUsageByPrinter property of the microsoft.graph.reportRoot entity.";
            var builder = new MonthlyPrintUsageByPrinterRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the monthlyPrintUsageByUser property of the microsoft.graph.reportRoot entity.
        /// </summary>
        public Command BuildMonthlyPrintUsageByUserNavCommand() {
            var command = new Command("monthly-print-usage-by-user");
            command.Description = "Provides operations to manage the monthlyPrintUsageByUser property of the microsoft.graph.reportRoot entity.";
            var builder = new MonthlyPrintUsageByUserRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            execCommands.Add(builder.BuildListCommand());
            var cmds = builder.BuildCommand();
            execCommands.AddRange(cmds.Item1);
            nonExecCommands.AddRange(cmds.Item2);
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands.OrderBy(static c => c.Name, StringComparer.Ordinal))
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Update the properties of a reportRoot object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/intune-deviceconfig-reportroot-update?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the properties of a reportRoot object.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/intune-deviceconfig-reportroot-update?view=graph-rest-1.0";
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            var outputOption = new Option<FormatterType>("--output", () => FormatterType.JSON){
                IsRequired = true
            };
            command.AddOption(outputOption);
            var queryOption = new Option<string>("--query");
            command.AddOption(queryOption);
            var jsonNoIndentOption = new Option<bool>("--json-no-indent", r => {
                if (bool.TryParse(r.Tokens.Select(t => t.Value).LastOrDefault(), out var value)) {
                    return value;
                }
                return true;
            }, description: "Disable indentation for the JSON output formatter.");
            command.AddOption(jsonNoIndentOption);
            command.SetHandler(async (invocationContext) => {
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ReportRoot>(ReportRoot.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the security property of the microsoft.graph.reportRoot entity.
        /// </summary>
        public Command BuildSecurityNavCommand() {
            var command = new Command("security");
            command.Description = "Provides operations to manage the security property of the microsoft.graph.reportRoot entity.";
            var builder = new SecurityRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            nonExecCommands.Add(builder.BuildGetAttackSimulationRepeatOffendersNavCommand());
            nonExecCommands.Add(builder.BuildGetAttackSimulationSimulationUserCoverageNavCommand());
            nonExecCommands.Add(builder.BuildGetAttackSimulationTrainingUserCoverageNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new ReportsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ReportsRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/reports{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Read properties and relationships of the reportRoot object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ReportsRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<ReportsRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<ReportsRequestBuilderGetQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of a reportRoot object.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ReportRoot body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ReportRoot body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<DefaultQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Read properties and relationships of the reportRoot object.
        /// </summary>
        public class ReportsRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
        }
    }
}
