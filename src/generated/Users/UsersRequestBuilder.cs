using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.Users.Count;
using ApiSdk.Users.Delta;
using ApiSdk.Users.GetAvailableExtensionProperties;
using ApiSdk.Users.GetByIds;
using ApiSdk.Users.Item;
using ApiSdk.Users.ValidateProperties;
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
namespace ApiSdk.Users {
    /// <summary>
    /// Provides operations to manage the collection of user entities.
    /// </summary>
    public class UsersRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the collection of user entities.
        /// </summary>
        public Tuple<List<Command>, List<Command>> BuildCommand() {
            var executables = new List<Command>();
            var commands = new List<Command>();
            var builder = new UserItemRequestBuilder(PathParameters);
            commands.Add(builder.BuildActivitiesNavCommand());
            commands.Add(builder.BuildAgreementAcceptancesNavCommand());
            commands.Add(builder.BuildAppRoleAssignmentsNavCommand());
            commands.Add(builder.BuildAssignLicenseNavCommand());
            commands.Add(builder.BuildAuthenticationNavCommand());
            commands.Add(builder.BuildCalendarGroupsNavCommand());
            commands.Add(builder.BuildCalendarNavCommand());
            commands.Add(builder.BuildCalendarsNavCommand());
            commands.Add(builder.BuildCalendarViewNavCommand());
            commands.Add(builder.BuildChangePasswordNavCommand());
            commands.Add(builder.BuildChatsNavCommand());
            commands.Add(builder.BuildCheckMemberGroupsNavCommand());
            commands.Add(builder.BuildCheckMemberObjectsNavCommand());
            commands.Add(builder.BuildContactFoldersNavCommand());
            commands.Add(builder.BuildContactsNavCommand());
            commands.Add(builder.BuildCreatedObjectsNavCommand());
            executables.Add(builder.BuildDeleteCommand());
            commands.Add(builder.BuildDeviceManagementTroubleshootingEventsNavCommand());
            commands.Add(builder.BuildDirectReportsNavCommand());
            commands.Add(builder.BuildDriveNavCommand());
            commands.Add(builder.BuildDrivesNavCommand());
            commands.Add(builder.BuildEmployeeExperienceNavCommand());
            commands.Add(builder.BuildEventsNavCommand());
            commands.Add(builder.BuildExportDeviceAndAppManagementDataNavCommand());
            commands.Add(builder.BuildExportDeviceAndAppManagementDataWithSkipWithTopRbCommand());
            commands.Add(builder.BuildExportPersonalDataNavCommand());
            commands.Add(builder.BuildExtensionsNavCommand());
            commands.Add(builder.BuildFindMeetingTimesNavCommand());
            commands.Add(builder.BuildFollowedSitesNavCommand());
            executables.Add(builder.BuildGetCommand());
            commands.Add(builder.BuildGetMailTipsNavCommand());
            commands.Add(builder.BuildGetManagedAppDiagnosticStatusesNavCommand());
            commands.Add(builder.BuildGetManagedAppPoliciesNavCommand());
            commands.Add(builder.BuildGetManagedDevicesWithAppFailuresNavCommand());
            commands.Add(builder.BuildGetMemberGroupsNavCommand());
            commands.Add(builder.BuildGetMemberObjectsNavCommand());
            commands.Add(builder.BuildInferenceClassificationNavCommand());
            commands.Add(builder.BuildInsightsNavCommand());
            commands.Add(builder.BuildJoinedTeamsNavCommand());
            commands.Add(builder.BuildLicenseDetailsNavCommand());
            commands.Add(builder.BuildMailboxSettingsNavCommand());
            commands.Add(builder.BuildMailFoldersNavCommand());
            commands.Add(builder.BuildManagedAppRegistrationsNavCommand());
            commands.Add(builder.BuildManagedDevicesNavCommand());
            commands.Add(builder.BuildManagerNavCommand());
            commands.Add(builder.BuildMemberOfNavCommand());
            commands.Add(builder.BuildMessagesNavCommand());
            commands.Add(builder.BuildOauth2PermissionGrantsNavCommand());
            commands.Add(builder.BuildOnenoteNavCommand());
            commands.Add(builder.BuildOnlineMeetingsNavCommand());
            commands.Add(builder.BuildOutlookNavCommand());
            commands.Add(builder.BuildOwnedDevicesNavCommand());
            commands.Add(builder.BuildOwnedObjectsNavCommand());
            executables.Add(builder.BuildPatchCommand());
            commands.Add(builder.BuildPeopleNavCommand());
            commands.Add(builder.BuildPhotoNavCommand());
            commands.Add(builder.BuildPhotosNavCommand());
            commands.Add(builder.BuildPlannerNavCommand());
            commands.Add(builder.BuildPresenceNavCommand());
            commands.Add(builder.BuildRegisteredDevicesNavCommand());
            commands.Add(builder.BuildReminderViewWithStartDateTimeWithEndDateTimeRbCommand());
            commands.Add(builder.BuildRemoveAllDevicesFromManagementNavCommand());
            commands.Add(builder.BuildReprocessLicenseAssignmentNavCommand());
            commands.Add(builder.BuildRestoreNavCommand());
            commands.Add(builder.BuildRevokeSignInSessionsNavCommand());
            commands.Add(builder.BuildScopedRoleMemberOfNavCommand());
            commands.Add(builder.BuildSendMailNavCommand());
            commands.Add(builder.BuildSettingsNavCommand());
            commands.Add(builder.BuildTeamworkNavCommand());
            commands.Add(builder.BuildTodoNavCommand());
            commands.Add(builder.BuildTransitiveMemberOfNavCommand());
            commands.Add(builder.BuildTranslateExchangeIdsNavCommand());
            commands.Add(builder.BuildWipeManagedAppRegistrationsByDeviceTagNavCommand());
            return new(executables, commands);
        }
        /// <summary>
        /// Provides operations to count the resources in the collection.
        /// </summary>
        public Command BuildCountNavCommand() {
            var command = new Command("count");
            command.Description = "Provides operations to count the resources in the collection.";
            var builder = new CountRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Create a new user object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/intune-onboarding-user-create?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildCreateCommand() {
            var command = new Command("create");
            command.Description = "Create a new user object.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/intune-onboarding-user-create?view=graph-rest-1.0";
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
                var model = parseNode.GetObjectValue<ApiSdk.Models.User>(ApiSdk.Models.User.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPostRequestInformation(model, q => {
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
        /// Provides operations to call the delta method.
        /// </summary>
        public Command BuildDeltaNavCommand() {
            var command = new Command("delta");
            command.Description = "Provides operations to call the delta method.";
            var builder = new DeltaRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getAvailableExtensionProperties method.
        /// </summary>
        public Command BuildGetAvailableExtensionPropertiesNavCommand() {
            var command = new Command("get-available-extension-properties");
            command.Description = "Provides operations to call the getAvailableExtensionProperties method.";
            var builder = new GetAvailableExtensionPropertiesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the getByIds method.
        /// </summary>
        public Command BuildGetByIdsNavCommand() {
            var command = new Command("get-by-ids");
            command.Description = "Provides operations to call the getByIds method.";
            var builder = new GetByIdsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// List properties and relationships of the user objects.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/intune-mam-user-list?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildListCommand() {
            var command = new Command("list");
            command.Description = "List properties and relationships of the user objects.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/intune-mam-user-list?view=graph-rest-1.0";
            var consistencyLevelOption = new Option<string[]>("--consistency-level", description: "Indicates the requested consistency level. Documentation URL: https://docs.microsoft.com/graph/aad-advanced-queries") {
                Arity = ArgumentArity.ZeroOrMore
            };
            consistencyLevelOption.IsRequired = false;
            command.AddOption(consistencyLevelOption);
            var topOption = new Option<int?>("--top", description: "Show only the first n items") {
            };
            topOption.IsRequired = false;
            command.AddOption(topOption);
            var searchOption = new Option<string>("--search", description: "Search items by search phrases") {
            };
            searchOption.IsRequired = false;
            command.AddOption(searchOption);
            var filterOption = new Option<string>("--filter", description: "Filter items by property values") {
            };
            filterOption.IsRequired = false;
            command.AddOption(filterOption);
            var countOption = new Option<bool?>("--count", description: "Include count of items") {
            };
            countOption.IsRequired = false;
            command.AddOption(countOption);
            var orderbyOption = new Option<string[]>("--orderby", description: "Order items by property values") {
                Arity = ArgumentArity.ZeroOrMore
            };
            orderbyOption.IsRequired = false;
            command.AddOption(orderbyOption);
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
            var allOption = new Option<bool>("--all");
            command.AddOption(allOption);
            command.SetHandler(async (invocationContext) => {
                var consistencyLevel = invocationContext.ParseResult.GetValueForOption(consistencyLevelOption);
                var top = invocationContext.ParseResult.GetValueForOption(topOption);
                var search = invocationContext.ParseResult.GetValueForOption(searchOption);
                var filter = invocationContext.ParseResult.GetValueForOption(filterOption);
                var count = invocationContext.ParseResult.GetValueForOption(countOption);
                var orderby = invocationContext.ParseResult.GetValueForOption(orderbyOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                var all = invocationContext.ParseResult.GetValueForOption(allOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                IPagingService pagingService = invocationContext.BindingContext.GetService(typeof(IPagingService)) as IPagingService ?? throw new ArgumentNullException("pagingService");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Top = top;
                    if (!string.IsNullOrEmpty(search)) q.QueryParameters.Search = search;
                    if (!string.IsNullOrEmpty(filter)) q.QueryParameters.Filter = filter;
                    q.QueryParameters.Count = count;
                    q.QueryParameters.Orderby = orderby;
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                if (consistencyLevel is not null) requestInfo.Headers.Add("ConsistencyLevel", consistencyLevel);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var pagingData = new PageLinkData(requestInfo, null, itemName: "value", nextLinkName: "@odata.nextLink");
                var pageResponse = await pagingService.GetPagedDataAsync((info, token) => reqAdapter.SendNoContentAsync(info, cancellationToken: token), pagingData, all, cancellationToken);
                var response = pageResponse?.Response;
                IOutputFormatterOptions? formatterOptions = null;
                IOutputFormatter? formatter = null;
                if (pageResponse?.StatusCode >= 200 && pageResponse?.StatusCode < 300) {
                    formatter = outputFormatterFactory.GetFormatter(output);
                    response = (response != Stream.Null) ? await outputFilter.FilterOutputAsync(response, query, cancellationToken) : response;
                    formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                } else {
                    formatter = outputFormatterFactory.GetFormatter(FormatterType.TEXT);
                }
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Provides operations to call the validateProperties method.
        /// </summary>
        public Command BuildValidatePropertiesNavCommand() {
            var command = new Command("validate-properties");
            command.Description = "Provides operations to call the validateProperties method.";
            var builder = new ValidatePropertiesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new UsersRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public UsersRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users{?%24top,%24search,%24filter,%24count,%24orderby,%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// List properties and relationships of the user objects.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<UsersRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<UsersRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<UsersRequestBuilderGetQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Create a new user object.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ApiSdk.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ApiSdk.Models.User body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
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
        /// List properties and relationships of the user objects.
        /// </summary>
        public class UsersRequestBuilderGetQueryParameters {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
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
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
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
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
    }
}
