using ApiSdk.Me.Events.Item.Attachments;
using ApiSdk.Me.Events.Item.Calendar;
using ApiSdk.Me.Events.Item.Extensions;
using ApiSdk.Me.Events.Item.Instances;
using ApiSdk.Me.Events.Item.MicrosoftGraphAccept;
using ApiSdk.Me.Events.Item.MicrosoftGraphCancel;
using ApiSdk.Me.Events.Item.MicrosoftGraphDecline;
using ApiSdk.Me.Events.Item.MicrosoftGraphDismissReminder;
using ApiSdk.Me.Events.Item.MicrosoftGraphForward;
using ApiSdk.Me.Events.Item.MicrosoftGraphSnoozeReminder;
using ApiSdk.Me.Events.Item.MicrosoftGraphTentativelyAccept;
using ApiSdk.Me.Events.Item.MultiValueExtendedProperties;
using ApiSdk.Me.Events.Item.SingleValueExtendedProperties;
using ApiSdk.Models;
using ApiSdk.Models.ODataErrors;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Extensions;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Me.Events.Item {
    /// <summary>
    /// Provides operations to manage the events property of the microsoft.graph.user entity.
    /// </summary>
    public class EventItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Provides operations to manage the attachments property of the microsoft.graph.event entity.
        /// </summary>
        public Command BuildAttachmentsCommand() {
            var command = new Command("attachments");
            command.Description = "Provides operations to manage the attachments property of the microsoft.graph.event entity.";
            var builder = new AttachmentsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphCreateUploadSessionCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the calendar property of the microsoft.graph.event entity.
        /// </summary>
        public Command BuildCalendarCommand() {
            var command = new Command("calendar");
            command.Description = "Provides operations to manage the calendar property of the microsoft.graph.event entity.";
            var builder = new CalendarRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildGetCommand());
            return command;
        }
        /// <summary>
        /// Delete navigation property events for me
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property events for me";
            // Create options for all the parameters
            var eventIdOption = new Option<string>("--event-id", description: "key: id of event") {
            };
            eventIdOption.IsRequired = true;
            command.AddOption(eventIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var eventId = invocationContext.ParseResult.GetValueForOption(eventIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (eventId is not null) requestInfo.PathParameters.Add("event%2Did", eventId);
                if (ifMatch is not null) requestInfo.Headers.Add("If-Match", ifMatch);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await reqAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Provides operations to manage the extensions property of the microsoft.graph.event entity.
        /// </summary>
        public Command BuildExtensionsCommand() {
            var command = new Command("extensions");
            command.Description = "Provides operations to manage the extensions property of the microsoft.graph.event entity.";
            var builder = new ExtensionsRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// The user&apos;s events. Default is to show Events under the Default Calendar. Read-only. Nullable.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The user's events. Default is to show Events under the Default Calendar. Read-only. Nullable.";
            // Create options for all the parameters
            var eventIdOption = new Option<string>("--event-id", description: "key: id of event") {
            };
            eventIdOption.IsRequired = true;
            command.AddOption(eventIdOption);
            var selectOption = new Option<string[]>("--select", description: "Select properties to be returned") {
                Arity = ArgumentArity.ZeroOrMore
            };
            selectOption.IsRequired = false;
            command.AddOption(selectOption);
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
                var eventId = invocationContext.ParseResult.GetValueForOption(eventIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                });
                if (eventId is not null) requestInfo.PathParameters.Add("event%2Did", eventId);
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
        /// Provides operations to manage the instances property of the microsoft.graph.event entity.
        /// </summary>
        public Command BuildInstancesCommand() {
            var command = new Command("instances");
            command.Description = "Provides operations to manage the instances property of the microsoft.graph.event entity.";
            var builder = new InstancesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildListCommand());
            command.AddCommand(builder.BuildMicrosoftGraphDeltaCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the accept method.
        /// </summary>
        public Command BuildMicrosoftGraphAcceptCommand() {
            var command = new Command("microsoft-graph-accept");
            command.Description = "Provides operations to call the accept method.";
            var builder = new MicrosoftGraphAcceptRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the cancel method.
        /// </summary>
        public Command BuildMicrosoftGraphCancelCommand() {
            var command = new Command("microsoft-graph-cancel");
            command.Description = "Provides operations to call the cancel method.";
            var builder = new MicrosoftGraphCancelRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the decline method.
        /// </summary>
        public Command BuildMicrosoftGraphDeclineCommand() {
            var command = new Command("microsoft-graph-decline");
            command.Description = "Provides operations to call the decline method.";
            var builder = new MicrosoftGraphDeclineRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the dismissReminder method.
        /// </summary>
        public Command BuildMicrosoftGraphDismissReminderCommand() {
            var command = new Command("microsoft-graph-dismiss-reminder");
            command.Description = "Provides operations to call the dismissReminder method.";
            var builder = new MicrosoftGraphDismissReminderRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the forward method.
        /// </summary>
        public Command BuildMicrosoftGraphForwardCommand() {
            var command = new Command("microsoft-graph-forward");
            command.Description = "Provides operations to call the forward method.";
            var builder = new MicrosoftGraphForwardRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the snoozeReminder method.
        /// </summary>
        public Command BuildMicrosoftGraphSnoozeReminderCommand() {
            var command = new Command("microsoft-graph-snooze-reminder");
            command.Description = "Provides operations to call the snoozeReminder method.";
            var builder = new MicrosoftGraphSnoozeReminderRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to call the tentativelyAccept method.
        /// </summary>
        public Command BuildMicrosoftGraphTentativelyAcceptCommand() {
            var command = new Command("microsoft-graph-tentatively-accept");
            command.Description = "Provides operations to call the tentativelyAccept method.";
            var builder = new MicrosoftGraphTentativelyAcceptRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Provides operations to manage the multiValueExtendedProperties property of the microsoft.graph.event entity.
        /// </summary>
        public Command BuildMultiValueExtendedPropertiesCommand() {
            var command = new Command("multi-value-extended-properties");
            command.Description = "Provides operations to manage the multiValueExtendedProperties property of the microsoft.graph.event entity.";
            var builder = new MultiValueExtendedPropertiesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Update the navigation property events in me
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property events in me";
            // Create options for all the parameters
            var eventIdOption = new Option<string>("--event-id", description: "key: id of event") {
            };
            eventIdOption.IsRequired = true;
            command.AddOption(eventIdOption);
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
                var eventId = invocationContext.ParseResult.GetValueForOption(eventIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                IOutputFilter outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                IOutputFormatterFactory outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<Event>(Event.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (eventId is not null) requestInfo.PathParameters.Add("event%2Did", eventId);
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
        /// Provides operations to manage the singleValueExtendedProperties property of the microsoft.graph.event entity.
        /// </summary>
        public Command BuildSingleValueExtendedPropertiesCommand() {
            var command = new Command("single-value-extended-properties");
            command.Description = "Provides operations to manage the singleValueExtendedProperties property of the microsoft.graph.event entity.";
            var builder = new SingleValueExtendedPropertiesRequestBuilder(PathParameters);
            command.AddCommand(builder.BuildCommand());
            command.AddCommand(builder.BuildCountCommand());
            command.AddCommand(builder.BuildCreateCommand());
            command.AddCommand(builder.BuildListCommand());
            return command;
        }
        /// <summary>
        /// Instantiates a new EventItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public EventItemRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/me/events/{event%2Did}{?%24select}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Delete navigation property events for me
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<EventItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<EventItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new EventItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The user&apos;s events. Default is to show Events under the Default Calendar. Read-only. Nullable.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<EventItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<EventItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new EventItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property events in me
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(Event body, Action<EventItemRequestBuilderPatchRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(Event body, Action<EventItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new EventItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class EventItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new EventItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public EventItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// The user&apos;s events. Default is to show Events under the Default Calendar. Read-only. Nullable.
        /// </summary>
        public class EventItemRequestBuilderGetQueryParameters {
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
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class EventItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public EventItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new EventItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new EventItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public EventItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class EventItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new EventItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public EventItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
