using ApiSdk.Models.ODataErrors;
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
namespace ApiSdk.Users.Item.JoinedTeams.Item.Channels.Item.DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalName {
    /// <summary>
    /// Provides operations to call the doesUserHaveAccess method.
    /// </summary>
    public class DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalNameRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Invoke function doesUserHaveAccess
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function doesUserHaveAccess";
            var userIdOption = new Option<string>("--user-id", description: "The unique identifier of user") {
            };
            userIdOption.IsRequired = true;
            command.AddOption(userIdOption);
            var teamIdOption = new Option<string>("--team-id", description: "The unique identifier of team") {
            };
            teamIdOption.IsRequired = true;
            command.AddOption(teamIdOption);
            var channelIdOption = new Option<string>("--channel-id", description: "The unique identifier of channel") {
            };
            channelIdOption.IsRequired = true;
            command.AddOption(channelIdOption);
            var userIdQueryOption = new Option<string>("--user-id-query", description: "Usage: userId='@userId'") {
            };
            userIdQueryOption.IsRequired = false;
            command.AddOption(userIdQueryOption);
            var tenantIdOption = new Option<string>("--tenant-id", description: "Usage: tenantId='@tenantId'") {
            };
            tenantIdOption.IsRequired = false;
            command.AddOption(tenantIdOption);
            var userPrincipalNameOption = new Option<string>("--user-principal-name", description: "Usage: userPrincipalName='@userPrincipalName'") {
            };
            userPrincipalNameOption.IsRequired = false;
            command.AddOption(userPrincipalNameOption);
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
                var userId = invocationContext.ParseResult.GetValueForOption(userIdOption);
                var teamId = invocationContext.ParseResult.GetValueForOption(teamIdOption);
                var channelId = invocationContext.ParseResult.GetValueForOption(channelIdOption);
                var userIdQuery = invocationContext.ParseResult.GetValueForOption(userIdQueryOption);
                var tenantId = invocationContext.ParseResult.GetValueForOption(tenantIdOption);
                var userPrincipalName = invocationContext.ParseResult.GetValueForOption(userPrincipalNameOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetService(typeof(IOutputFilter)) as IOutputFilter ?? throw new ArgumentNullException("outputFilter");
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetService(typeof(IOutputFormatterFactory)) as IOutputFormatterFactory ?? throw new ArgumentNullException("outputFormatterFactory");
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    if (!string.IsNullOrEmpty(userIdQuery)) q.QueryParameters.UserId = userIdQuery;
                    if (!string.IsNullOrEmpty(tenantId)) q.QueryParameters.TenantId = tenantId;
                    if (!string.IsNullOrEmpty(userPrincipalName)) q.QueryParameters.UserPrincipalName = userPrincipalName;
                });
                if (userId is not null) requestInfo.PathParameters.Add("user%2Did", userId);
                if (teamId is not null) requestInfo.PathParameters.Add("team%2Did", teamId);
                if (channelId is not null) requestInfo.PathParameters.Add("channel%2Did", channelId);
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
        /// Instantiates a new DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalNameRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalNameRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/users/{user%2Did}/joinedTeams/{team%2Did}/channels/{channel%2Did}/doesUserHaveAccess(userId='@userId',tenantId='@tenantId',userPrincipalName='@userPrincipalName'){?userId*,tenantId*,userPrincipalName*}", pathParameters) {
        }
        /// <summary>
        /// Invoke function doesUserHaveAccess
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalNameRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalNameRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalNameRequestBuilderGetQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Invoke function doesUserHaveAccess
        /// </summary>
        public class DoesUserHaveAccessuserIdUserIdTenantIdTenantIdUserPrincipalNameUserPrincipalNameRequestBuilderGetQueryParameters {
            /// <summary>Usage: tenantId=&apos;@tenantId&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? TenantId { get; set; }
#nullable restore
#else
            public string TenantId { get; set; }
#endif
            /// <summary>Usage: userId=&apos;@userId&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? UserId { get; set; }
#nullable restore
#else
            public string UserId { get; set; }
#endif
            /// <summary>Usage: userPrincipalName=&apos;@userPrincipalName&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? UserPrincipalName { get; set; }
#nullable restore
#else
            public string UserPrincipalName { get; set; }
#endif
        }
    }
}
