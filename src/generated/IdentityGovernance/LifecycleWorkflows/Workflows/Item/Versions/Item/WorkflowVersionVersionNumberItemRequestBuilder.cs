using ApiSdk.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Versions.Item.CreatedBy;
using ApiSdk.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Versions.Item.LastModifiedBy;
using ApiSdk.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Versions.Item.Tasks;
using ApiSdk.Models.IdentityGovernance;
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
namespace ApiSdk.IdentityGovernance.LifecycleWorkflows.Workflows.Item.Versions.Item {
    /// <summary>
    /// Provides operations to manage the versions property of the microsoft.graph.identityGovernance.workflow entity.
    /// </summary>
    public class WorkflowVersionVersionNumberItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the createdBy property of the microsoft.graph.identityGovernance.workflowBase entity.
        /// </summary>
        public Command BuildCreatedByNavCommand() {
            var command = new Command("created-by");
            command.Description = "Provides operations to manage the createdBy property of the microsoft.graph.identityGovernance.workflowBase entity.";
            var builder = new CreatedByRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildMailboxSettingsNavCommand());
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
        /// Read the properties and relationships of a workflowVersion object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/identitygovernance-workflowversion-get?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Read the properties and relationships of a workflowVersion object.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/identitygovernance-workflowversion-get?view=graph-rest-1.0";
            var workflowIdOption = new Option<string>("--workflow-id", description: "The unique identifier of workflow") {
            };
            workflowIdOption.IsRequired = true;
            command.AddOption(workflowIdOption);
            var workflowVersionVersionNumberOption = new Option<int?>("--workflow-version-version-number", description: "The unique identifier of workflowVersion") {
            };
            workflowVersionVersionNumberOption.IsRequired = true;
            command.AddOption(workflowVersionVersionNumberOption);
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
                var workflowVersionVersionNumber = invocationContext.ParseResult.GetValueForOption(workflowVersionVersionNumberOption);
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
                if (workflowVersionVersionNumber is not null) requestInfo.PathParameters.Add("workflowVersion%2DversionNumber", workflowVersionVersionNumber);
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
        /// Provides operations to manage the lastModifiedBy property of the microsoft.graph.identityGovernance.workflowBase entity.
        /// </summary>
        public Command BuildLastModifiedByNavCommand() {
            var command = new Command("last-modified-by");
            command.Description = "Provides operations to manage the lastModifiedBy property of the microsoft.graph.identityGovernance.workflowBase entity.";
            var builder = new LastModifiedByRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildMailboxSettingsNavCommand());
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
        /// Provides operations to manage the tasks property of the microsoft.graph.identityGovernance.workflowBase entity.
        /// </summary>
        public Command BuildTasksNavCommand() {
            var command = new Command("tasks");
            command.Description = "Provides operations to manage the tasks property of the microsoft.graph.identityGovernance.workflowBase entity.";
            var builder = new TasksRequestBuilder(PathParameters);
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
        /// Instantiates a new WorkflowVersionVersionNumberItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public WorkflowVersionVersionNumberItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/lifecycleWorkflows/workflows/{workflow%2Did}/versions/{workflowVersion%2DversionNumber}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Read the properties and relationships of a workflowVersion object.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WorkflowVersionVersionNumberItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WorkflowVersionVersionNumberItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<WorkflowVersionVersionNumberItemRequestBuilderGetQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Read the properties and relationships of a workflowVersion object.
        /// </summary>
        public class WorkflowVersionVersionNumberItemRequestBuilderGetQueryParameters {
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
