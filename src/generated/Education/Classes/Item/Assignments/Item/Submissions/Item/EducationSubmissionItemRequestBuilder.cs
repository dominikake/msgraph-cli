using ApiSdk.Education.Classes.Item.Assignments.Item.Submissions.Item.Outcomes;
using ApiSdk.Education.Classes.Item.Assignments.Item.Submissions.Item.Reassign;
using ApiSdk.Education.Classes.Item.Assignments.Item.Submissions.Item.Resources;
using ApiSdk.Education.Classes.Item.Assignments.Item.Submissions.Item.Return;
using ApiSdk.Education.Classes.Item.Assignments.Item.Submissions.Item.SetUpResourcesFolder;
using ApiSdk.Education.Classes.Item.Assignments.Item.Submissions.Item.Submit;
using ApiSdk.Education.Classes.Item.Assignments.Item.Submissions.Item.SubmittedResources;
using ApiSdk.Education.Classes.Item.Assignments.Item.Submissions.Item.Unsubmit;
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
namespace ApiSdk.Education.Classes.Item.Assignments.Item.Submissions.Item {
    /// <summary>
    /// Provides operations to manage the submissions property of the microsoft.graph.educationAssignment entity.
    /// </summary>
    public class EducationSubmissionItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Delete navigation property submissions for education
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property submissions for education";
            var educationClassIdOption = new Option<string>("--education-class-id", description: "The unique identifier of educationClass") {
            };
            educationClassIdOption.IsRequired = true;
            command.AddOption(educationClassIdOption);
            var educationAssignmentIdOption = new Option<string>("--education-assignment-id", description: "The unique identifier of educationAssignment") {
            };
            educationAssignmentIdOption.IsRequired = true;
            command.AddOption(educationAssignmentIdOption);
            var educationSubmissionIdOption = new Option<string>("--education-submission-id", description: "The unique identifier of educationSubmission") {
            };
            educationSubmissionIdOption.IsRequired = true;
            command.AddOption(educationSubmissionIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var educationClassId = invocationContext.ParseResult.GetValueForOption(educationClassIdOption);
                var educationAssignmentId = invocationContext.ParseResult.GetValueForOption(educationAssignmentIdOption);
                var educationSubmissionId = invocationContext.ParseResult.GetValueForOption(educationSubmissionIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (educationClassId is not null) requestInfo.PathParameters.Add("educationClass%2Did", educationClassId);
                if (educationAssignmentId is not null) requestInfo.PathParameters.Add("educationAssignment%2Did", educationAssignmentId);
                if (educationSubmissionId is not null) requestInfo.PathParameters.Add("educationSubmission%2Did", educationSubmissionId);
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
        /// Retrieve a particular submission. Only teachers, students, and applications with application permissions can perform this operation. A **submission** object represents a student&apos;s work for an assignment. Resources associated with the **submission** represent this work. Only the **assignedTo** student can see and modify the **submission**. A teacher or application with application permissions has full access to all **submissions**. The grade and feedback from a teacher are part of the educationOutcome associated with this object. Only teachers or applications with application permissions can add or change grades and feedback. Students will not see the grade or feedback until the **assignment** has been released.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/educationsubmission-get?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Retrieve a particular submission. Only teachers, students, and applications with application permissions can perform this operation. A **submission** object represents a student's work for an assignment. Resources associated with the **submission** represent this work. Only the **assignedTo** student can see and modify the **submission**. A teacher or application with application permissions has full access to all **submissions**. The grade and feedback from a teacher are part of the educationOutcome associated with this object. Only teachers or applications with application permissions can add or change grades and feedback. Students will not see the grade or feedback until the **assignment** has been released.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/educationsubmission-get?view=graph-rest-1.0";
            var educationClassIdOption = new Option<string>("--education-class-id", description: "The unique identifier of educationClass") {
            };
            educationClassIdOption.IsRequired = true;
            command.AddOption(educationClassIdOption);
            var educationAssignmentIdOption = new Option<string>("--education-assignment-id", description: "The unique identifier of educationAssignment") {
            };
            educationAssignmentIdOption.IsRequired = true;
            command.AddOption(educationAssignmentIdOption);
            var educationSubmissionIdOption = new Option<string>("--education-submission-id", description: "The unique identifier of educationSubmission") {
            };
            educationSubmissionIdOption.IsRequired = true;
            command.AddOption(educationSubmissionIdOption);
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
                var educationClassId = invocationContext.ParseResult.GetValueForOption(educationClassIdOption);
                var educationAssignmentId = invocationContext.ParseResult.GetValueForOption(educationAssignmentIdOption);
                var educationSubmissionId = invocationContext.ParseResult.GetValueForOption(educationSubmissionIdOption);
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
                if (educationClassId is not null) requestInfo.PathParameters.Add("educationClass%2Did", educationClassId);
                if (educationAssignmentId is not null) requestInfo.PathParameters.Add("educationAssignment%2Did", educationAssignmentId);
                if (educationSubmissionId is not null) requestInfo.PathParameters.Add("educationSubmission%2Did", educationSubmissionId);
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
        /// Provides operations to manage the outcomes property of the microsoft.graph.educationSubmission entity.
        /// </summary>
        public Command BuildOutcomesNavCommand() {
            var command = new Command("outcomes");
            command.Description = "Provides operations to manage the outcomes property of the microsoft.graph.educationSubmission entity.";
            var builder = new OutcomesRequestBuilder(PathParameters);
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
        /// Update the navigation property submissions in education
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property submissions in education";
            var educationClassIdOption = new Option<string>("--education-class-id", description: "The unique identifier of educationClass") {
            };
            educationClassIdOption.IsRequired = true;
            command.AddOption(educationClassIdOption);
            var educationAssignmentIdOption = new Option<string>("--education-assignment-id", description: "The unique identifier of educationAssignment") {
            };
            educationAssignmentIdOption.IsRequired = true;
            command.AddOption(educationAssignmentIdOption);
            var educationSubmissionIdOption = new Option<string>("--education-submission-id", description: "The unique identifier of educationSubmission") {
            };
            educationSubmissionIdOption.IsRequired = true;
            command.AddOption(educationSubmissionIdOption);
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
                var educationClassId = invocationContext.ParseResult.GetValueForOption(educationClassIdOption);
                var educationAssignmentId = invocationContext.ParseResult.GetValueForOption(educationAssignmentIdOption);
                var educationSubmissionId = invocationContext.ParseResult.GetValueForOption(educationSubmissionIdOption);
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
                var model = parseNode.GetObjectValue<EducationSubmission>(EducationSubmission.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (educationClassId is not null) requestInfo.PathParameters.Add("educationClass%2Did", educationClassId);
                if (educationAssignmentId is not null) requestInfo.PathParameters.Add("educationAssignment%2Did", educationAssignmentId);
                if (educationSubmissionId is not null) requestInfo.PathParameters.Add("educationSubmission%2Did", educationSubmissionId);
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
        /// Provides operations to call the reassign method.
        /// </summary>
        public Command BuildReassignNavCommand() {
            var command = new Command("reassign");
            command.Description = "Provides operations to call the reassign method.";
            var builder = new ReassignRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the resources property of the microsoft.graph.educationSubmission entity.
        /// </summary>
        public Command BuildResourcesNavCommand() {
            var command = new Command("resources");
            command.Description = "Provides operations to manage the resources property of the microsoft.graph.educationSubmission entity.";
            var builder = new ResourcesRequestBuilder(PathParameters);
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
        /// Provides operations to call the return method.
        /// </summary>
        public Command BuildReturnNavCommand() {
            var command = new Command("return");
            command.Description = "Provides operations to call the return method.";
            var builder = new ReturnRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the setUpResourcesFolder method.
        /// </summary>
        public Command BuildSetUpResourcesFolderNavCommand() {
            var command = new Command("set-up-resources-folder");
            command.Description = "Provides operations to call the setUpResourcesFolder method.";
            var builder = new SetUpResourcesFolderRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the submit method.
        /// </summary>
        public Command BuildSubmitNavCommand() {
            var command = new Command("submit");
            command.Description = "Provides operations to call the submit method.";
            var builder = new SubmitRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the submittedResources property of the microsoft.graph.educationSubmission entity.
        /// </summary>
        public Command BuildSubmittedResourcesNavCommand() {
            var command = new Command("submitted-resources");
            command.Description = "Provides operations to manage the submittedResources property of the microsoft.graph.educationSubmission entity.";
            var builder = new SubmittedResourcesRequestBuilder(PathParameters);
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
        /// Provides operations to call the unsubmit method.
        /// </summary>
        public Command BuildUnsubmitNavCommand() {
            var command = new Command("unsubmit");
            command.Description = "Provides operations to call the unsubmit method.";
            var builder = new UnsubmitRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new EducationSubmissionItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public EducationSubmissionItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/education/classes/{educationClass%2Did}/assignments/{educationAssignment%2Did}/submissions/{educationSubmission%2Did}{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Delete navigation property submissions for education
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
        /// Retrieve a particular submission. Only teachers, students, and applications with application permissions can perform this operation. A **submission** object represents a student&apos;s work for an assignment. Resources associated with the **submission** represent this work. Only the **assignedTo** student can see and modify the **submission**. A teacher or application with application permissions has full access to all **submissions**. The grade and feedback from a teacher are part of the educationOutcome associated with this object. Only teachers or applications with application permissions can add or change grades and feedback. Students will not see the grade or feedback until the **assignment** has been released.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EducationSubmissionItemRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<EducationSubmissionItemRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<EducationSubmissionItemRequestBuilderGetQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property submissions in education
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(EducationSubmission body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(EducationSubmission body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        /// Retrieve a particular submission. Only teachers, students, and applications with application permissions can perform this operation. A **submission** object represents a student&apos;s work for an assignment. Resources associated with the **submission** represent this work. Only the **assignedTo** student can see and modify the **submission**. A teacher or application with application permissions has full access to all **submissions**. The grade and feedback from a teacher are part of the educationOutcome associated with this object. Only teachers or applications with application permissions can add or change grades and feedback. Students will not see the grade or feedback until the **assignment** has been released.
        /// </summary>
        public class EducationSubmissionItemRequestBuilderGetQueryParameters {
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
