using ApiSdk.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Runs.Item.UserProcessingResults.Item.TaskProcessingResults.Item.Subject.MailboxSettings;
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
namespace ApiSdk.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Runs.Item.UserProcessingResults.Item.TaskProcessingResults.Item.Subject {
    /// <summary>
    /// Provides operations to manage the subject property of the microsoft.graph.identityGovernance.taskProcessingResult entity.
    /// </summary>
    public class SubjectRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.";
            var workflowIdOption = new Option<string>("--workflow-id", description: "The unique identifier of workflow") {
            };
            workflowIdOption.IsRequired = true;
            command.AddOption(workflowIdOption);
            var runIdOption = new Option<string>("--run-id", description: "The unique identifier of run") {
            };
            runIdOption.IsRequired = true;
            command.AddOption(runIdOption);
            var userProcessingResultIdOption = new Option<string>("--user-processing-result-id", description: "The unique identifier of userProcessingResult") {
            };
            userProcessingResultIdOption.IsRequired = true;
            command.AddOption(userProcessingResultIdOption);
            var taskProcessingResultIdOption = new Option<string>("--task-processing-result-id", description: "The unique identifier of taskProcessingResult") {
            };
            taskProcessingResultIdOption.IsRequired = true;
            command.AddOption(taskProcessingResultIdOption);
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
                var workflowId = invocationContext.ParseResult.GetValueForOption(workflowIdOption);
                var runId = invocationContext.ParseResult.GetValueForOption(runIdOption);
                var userProcessingResultId = invocationContext.ParseResult.GetValueForOption(userProcessingResultIdOption);
                var taskProcessingResultId = invocationContext.ParseResult.GetValueForOption(taskProcessingResultIdOption);
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
                if (workflowId is not null) requestInfo.PathParameters.Add("workflow%2Did", workflowId);
                if (runId is not null) requestInfo.PathParameters.Add("run%2Did", runId);
                if (userProcessingResultId is not null) requestInfo.PathParameters.Add("userProcessingResult%2Did", userProcessingResultId);
                if (taskProcessingResultId is not null) requestInfo.PathParameters.Add("taskProcessingResult%2Did", taskProcessingResultId);
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
        /// The mailboxSettings property
        /// </summary>
        public Command BuildMailboxSettingsNavCommand() {
            var command = new Command("mailbox-settings");
            command.Description = "The mailboxSettings property";
            var builder = new MailboxSettingsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new SubjectRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public SubjectRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/lifecycleWorkflows/workflows/{workflow%2Did}/runs/{run%2Did}/userProcessingResults/{userProcessingResult%2Did}/taskProcessingResults/{taskProcessingResult%2Did}/subject{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SubjectRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<SubjectRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<SubjectRequestBuilderGetQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// The unique identifier of the Azure AD user targeted for the task execution.Supports $filter(eq, ne) and $expand.
        /// </summary>
        public class SubjectRequestBuilderGetQueryParameters {
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
