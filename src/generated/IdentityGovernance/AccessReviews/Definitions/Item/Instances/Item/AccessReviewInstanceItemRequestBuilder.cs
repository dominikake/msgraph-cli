using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.AcceptRecommendations;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.ApplyDecisions;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.BatchRecordDecisions;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.ContactedReviewers;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Decisions;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.ResetDecisions;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.SendReminder;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stages;
using ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item.Stop;
using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
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
namespace ApiSdk.IdentityGovernance.AccessReviews.Definitions.Item.Instances.Item {
    /// <summary>
    /// Provides operations to manage the instances property of the microsoft.graph.accessReviewScheduleDefinition entity.
    /// </summary>
    public class AccessReviewInstanceItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to call the acceptRecommendations method.
        /// </summary>
        public Command BuildAcceptRecommendationsNavCommand() {
            var command = new Command("accept-recommendations");
            command.Description = "Provides operations to call the acceptRecommendations method.";
            var builder = new AcceptRecommendationsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the applyDecisions method.
        /// </summary>
        public Command BuildApplyDecisionsNavCommand() {
            var command = new Command("apply-decisions");
            command.Description = "Provides operations to call the applyDecisions method.";
            var builder = new ApplyDecisionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the batchRecordDecisions method.
        /// </summary>
        public Command BuildBatchRecordDecisionsNavCommand() {
            var command = new Command("batch-record-decisions");
            command.Description = "Provides operations to call the batchRecordDecisions method.";
            var builder = new BatchRecordDecisionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the contactedReviewers property of the microsoft.graph.accessReviewInstance entity.
        /// </summary>
        public Command BuildContactedReviewersNavCommand() {
            var command = new Command("contacted-reviewers");
            command.Description = "Provides operations to manage the contactedReviewers property of the microsoft.graph.accessReviewInstance entity.";
            var builder = new ContactedReviewersRequestBuilder(PathParameters);
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
        /// Provides operations to manage the decisions property of the microsoft.graph.accessReviewInstance entity.
        /// </summary>
        public Command BuildDecisionsNavCommand() {
            var command = new Command("decisions");
            command.Description = "Provides operations to manage the decisions property of the microsoft.graph.accessReviewInstance entity.";
            var builder = new DecisionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildFilterByCurrentUserWithOnRbCommand());
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
        /// Delete navigation property instances for identityGovernance
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property instances for identityGovernance";
            var accessReviewScheduleDefinitionIdOption = new Option<string>("--access-review-schedule-definition-id", description: "The unique identifier of accessReviewScheduleDefinition") {
            };
            accessReviewScheduleDefinitionIdOption.IsRequired = true;
            command.AddOption(accessReviewScheduleDefinitionIdOption);
            var accessReviewInstanceIdOption = new Option<string>("--access-review-instance-id", description: "The unique identifier of accessReviewInstance") {
            };
            accessReviewInstanceIdOption.IsRequired = true;
            command.AddOption(accessReviewInstanceIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var accessReviewScheduleDefinitionId = invocationContext.ParseResult.GetValueForOption(accessReviewScheduleDefinitionIdOption);
                var accessReviewInstanceId = invocationContext.ParseResult.GetValueForOption(accessReviewInstanceIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (accessReviewScheduleDefinitionId is not null) requestInfo.PathParameters.Add("accessReviewScheduleDefinition%2Did", accessReviewScheduleDefinitionId);
                if (accessReviewInstanceId is not null) requestInfo.PathParameters.Add("accessReviewInstance%2Did", accessReviewInstanceId);
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
        /// Read the properties and relationships of an accessReviewInstance object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/accessreviewinstance-get?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Read the properties and relationships of an accessReviewInstance object.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/accessreviewinstance-get?view=graph-rest-1.0";
            var accessReviewScheduleDefinitionIdOption = new Option<string>("--access-review-schedule-definition-id", description: "The unique identifier of accessReviewScheduleDefinition") {
            };
            accessReviewScheduleDefinitionIdOption.IsRequired = true;
            command.AddOption(accessReviewScheduleDefinitionIdOption);
            var accessReviewInstanceIdOption = new Option<string>("--access-review-instance-id", description: "The unique identifier of accessReviewInstance") {
            };
            accessReviewInstanceIdOption.IsRequired = true;
            command.AddOption(accessReviewInstanceIdOption);
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
                var accessReviewScheduleDefinitionId = invocationContext.ParseResult.GetValueForOption(accessReviewScheduleDefinitionIdOption);
                var accessReviewInstanceId = invocationContext.ParseResult.GetValueForOption(accessReviewInstanceIdOption);
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
                if (accessReviewScheduleDefinitionId is not null) requestInfo.PathParameters.Add("accessReviewScheduleDefinition%2Did", accessReviewScheduleDefinitionId);
                if (accessReviewInstanceId is not null) requestInfo.PathParameters.Add("accessReviewInstance%2Did", accessReviewInstanceId);
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
        /// Update the properties of an accessReviewInstance object. Only the **reviewers** and **fallbackReviewers** properties can be updated but the **scope** property is also required in the request body. You can only add reviewers to the **fallbackReviewers** property but can&apos;t remove existing **fallbackReviewers**. To update an **accessReviewInstance**, it&apos;s **status** must be `InProgress`.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/accessreviewinstance-update?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the properties of an accessReviewInstance object. Only the **reviewers** and **fallbackReviewers** properties can be updated but the **scope** property is also required in the request body. You can only add reviewers to the **fallbackReviewers** property but can't remove existing **fallbackReviewers**. To update an **accessReviewInstance**, it's **status** must be `InProgress`.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/accessreviewinstance-update?view=graph-rest-1.0";
            var accessReviewScheduleDefinitionIdOption = new Option<string>("--access-review-schedule-definition-id", description: "The unique identifier of accessReviewScheduleDefinition") {
            };
            accessReviewScheduleDefinitionIdOption.IsRequired = true;
            command.AddOption(accessReviewScheduleDefinitionIdOption);
            var accessReviewInstanceIdOption = new Option<string>("--access-review-instance-id", description: "The unique identifier of accessReviewInstance") {
            };
            accessReviewInstanceIdOption.IsRequired = true;
            command.AddOption(accessReviewInstanceIdOption);
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
                var accessReviewScheduleDefinitionId = invocationContext.ParseResult.GetValueForOption(accessReviewScheduleDefinitionIdOption);
                var accessReviewInstanceId = invocationContext.ParseResult.GetValueForOption(accessReviewInstanceIdOption);
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
                var model = parseNode.GetObjectValue<AccessReviewInstance>(AccessReviewInstance.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (accessReviewScheduleDefinitionId is not null) requestInfo.PathParameters.Add("accessReviewScheduleDefinition%2Did", accessReviewScheduleDefinitionId);
                if (accessReviewInstanceId is not null) requestInfo.PathParameters.Add("accessReviewInstance%2Did", accessReviewInstanceId);
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
        /// Provides operations to call the resetDecisions method.
        /// </summary>
        public Command BuildResetDecisionsNavCommand() {
            var command = new Command("reset-decisions");
            command.Description = "Provides operations to call the resetDecisions method.";
            var builder = new ResetDecisionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the sendReminder method.
        /// </summary>
        public Command BuildSendReminderNavCommand() {
            var command = new Command("send-reminder");
            command.Description = "Provides operations to call the sendReminder method.";
            var builder = new SendReminderRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the stages property of the microsoft.graph.accessReviewInstance entity.
        /// </summary>
        public Command BuildStagesNavCommand() {
            var command = new Command("stages");
            command.Description = "Provides operations to manage the stages property of the microsoft.graph.accessReviewInstance entity.";
            var builder = new StagesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildFilterByCurrentUserWithOnRbCommand());
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
        /// Provides operations to call the stop method.
        /// </summary>
        public Command BuildStopNavCommand() {
            var command = new Command("stop");
            command.Description = "Provides operations to call the stop method.";
            var builder = new StopRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new AccessReviewInstanceItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public AccessReviewInstanceItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/accessReviews/definitions/{accessReviewScheduleDefinition%2Did}/instances/{accessReviewInstance%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Delete navigation property instances for identityGovernance
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
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
        /// Read the properties and relationships of an accessReviewInstance object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AccessReviewInstanceItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<AccessReviewInstanceItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<AccessReviewInstanceItemRequestBuilderGetQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of an accessReviewInstance object. Only the **reviewers** and **fallbackReviewers** properties can be updated but the **scope** property is also required in the request body. You can only add reviewers to the **fallbackReviewers** property but can&apos;t remove existing **fallbackReviewers**. To update an **accessReviewInstance**, it&apos;s **status** must be `InProgress`.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(AccessReviewInstance body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(AccessReviewInstance body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        /// Read the properties and relationships of an accessReviewInstance object.
        /// </summary>
        public class AccessReviewInstanceItemRequestBuilderGetQueryParameters {
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
