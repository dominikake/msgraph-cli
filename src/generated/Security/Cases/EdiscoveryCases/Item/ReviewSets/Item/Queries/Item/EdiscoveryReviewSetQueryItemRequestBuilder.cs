using ApiSdk.Models.ODataErrors;
using ApiSdk.Models.Security;
using ApiSdk.Security.Cases.EdiscoveryCases.Item.ReviewSets.Item.Queries.Item.ApplyTags;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Security.Cases.EdiscoveryCases.Item.ReviewSets.Item.Queries.Item {
    /// <summary>Provides operations to manage the queries property of the microsoft.graph.security.ediscoveryReviewSet entity.</summary>
    public class EdiscoveryReviewSetQueryItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        public Command BuildApplyTagsCommand() {
            var command = new Command("apply-tags");
            var builder = new ApplyTagsRequestBuilder(PathParameters, RequestAdapter);
            command.AddCommand(builder.BuildPostCommand());
            return command;
        }
        /// <summary>
        /// Delete navigation property queries for security
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property queries for security";
            // Create options for all the parameters
            var ediscoveryCaseIdOption = new Option<string>("--ediscovery-case-id", description: "key: id of ediscoveryCase") {
            };
            ediscoveryCaseIdOption.IsRequired = true;
            command.AddOption(ediscoveryCaseIdOption);
            var ediscoveryReviewSetIdOption = new Option<string>("--ediscovery-review-set-id", description: "key: id of ediscoveryReviewSet") {
            };
            ediscoveryReviewSetIdOption.IsRequired = true;
            command.AddOption(ediscoveryReviewSetIdOption);
            var ediscoveryReviewSetQueryIdOption = new Option<string>("--ediscovery-review-set-query-id", description: "key: id of ediscoveryReviewSetQuery") {
            };
            ediscoveryReviewSetQueryIdOption.IsRequired = true;
            command.AddOption(ediscoveryReviewSetQueryIdOption);
            var ifMatchOption = new Option<string>("--if-match", description: "ETag") {
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var ediscoveryCaseId = invocationContext.ParseResult.GetValueForOption(ediscoveryCaseIdOption);
                var ediscoveryReviewSetId = invocationContext.ParseResult.GetValueForOption(ediscoveryReviewSetIdOption);
                var ediscoveryReviewSetQueryId = invocationContext.ParseResult.GetValueForOption(ediscoveryReviewSetQueryIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                requestInfo.PathParameters.Add("ediscoveryCase%2Did", ediscoveryCaseId);
                requestInfo.PathParameters.Add("ediscoveryReviewSet%2Did", ediscoveryReviewSetId);
                requestInfo.PathParameters.Add("ediscoveryReviewSetQuery%2Did", ediscoveryReviewSetQueryId);
                requestInfo.Headers["If-Match"] = ifMatch;
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Represents queries within the review set.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Represents queries within the review set.";
            // Create options for all the parameters
            var ediscoveryCaseIdOption = new Option<string>("--ediscovery-case-id", description: "key: id of ediscoveryCase") {
            };
            ediscoveryCaseIdOption.IsRequired = true;
            command.AddOption(ediscoveryCaseIdOption);
            var ediscoveryReviewSetIdOption = new Option<string>("--ediscovery-review-set-id", description: "key: id of ediscoveryReviewSet") {
            };
            ediscoveryReviewSetIdOption.IsRequired = true;
            command.AddOption(ediscoveryReviewSetIdOption);
            var ediscoveryReviewSetQueryIdOption = new Option<string>("--ediscovery-review-set-query-id", description: "key: id of ediscoveryReviewSetQuery") {
            };
            ediscoveryReviewSetQueryIdOption.IsRequired = true;
            command.AddOption(ediscoveryReviewSetQueryIdOption);
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
                var ediscoveryCaseId = invocationContext.ParseResult.GetValueForOption(ediscoveryCaseIdOption);
                var ediscoveryReviewSetId = invocationContext.ParseResult.GetValueForOption(ediscoveryReviewSetIdOption);
                var ediscoveryReviewSetQueryId = invocationContext.ParseResult.GetValueForOption(ediscoveryReviewSetQueryIdOption);
                var select = invocationContext.ParseResult.GetValueForOption(selectOption);
                var expand = invocationContext.ParseResult.GetValueForOption(expandOption);
                var output = invocationContext.ParseResult.GetValueForOption(outputOption);
                var query = invocationContext.ParseResult.GetValueForOption(queryOption);
                var jsonNoIndent = invocationContext.ParseResult.GetValueForOption(jsonNoIndentOption);
                var outputFilter = invocationContext.BindingContext.GetRequiredService<IOutputFilter>();
                var outputFormatterFactory = invocationContext.BindingContext.GetRequiredService<IOutputFormatterFactory>();
                var cancellationToken = invocationContext.GetCancellationToken();
                var requestInfo = CreateGetRequestInformation(q => {
                    q.QueryParameters.Select = select;
                    q.QueryParameters.Expand = expand;
                });
                requestInfo.PathParameters.Add("ediscoveryCase%2Did", ediscoveryCaseId);
                requestInfo.PathParameters.Add("ediscoveryReviewSet%2Did", ediscoveryReviewSetId);
                requestInfo.PathParameters.Add("ediscoveryReviewSetQuery%2Did", ediscoveryReviewSetQueryId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            });
            return command;
        }
        /// <summary>
        /// Update the navigation property queries in security
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property queries in security";
            // Create options for all the parameters
            var ediscoveryCaseIdOption = new Option<string>("--ediscovery-case-id", description: "key: id of ediscoveryCase") {
            };
            ediscoveryCaseIdOption.IsRequired = true;
            command.AddOption(ediscoveryCaseIdOption);
            var ediscoveryReviewSetIdOption = new Option<string>("--ediscovery-review-set-id", description: "key: id of ediscoveryReviewSet") {
            };
            ediscoveryReviewSetIdOption.IsRequired = true;
            command.AddOption(ediscoveryReviewSetIdOption);
            var ediscoveryReviewSetQueryIdOption = new Option<string>("--ediscovery-review-set-query-id", description: "key: id of ediscoveryReviewSetQuery") {
            };
            ediscoveryReviewSetQueryIdOption.IsRequired = true;
            command.AddOption(ediscoveryReviewSetQueryIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var ediscoveryCaseId = invocationContext.ParseResult.GetValueForOption(ediscoveryCaseIdOption);
                var ediscoveryReviewSetId = invocationContext.ParseResult.GetValueForOption(ediscoveryReviewSetIdOption);
                var ediscoveryReviewSetQueryId = invocationContext.ParseResult.GetValueForOption(ediscoveryReviewSetQueryIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<EdiscoveryReviewSetQuery>(EdiscoveryReviewSetQuery.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                requestInfo.PathParameters.Add("ediscoveryCase%2Did", ediscoveryCaseId);
                requestInfo.PathParameters.Add("ediscoveryReviewSet%2Did", ediscoveryReviewSetId);
                requestInfo.PathParameters.Add("ediscoveryReviewSetQuery%2Did", ediscoveryReviewSetQueryId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new EdiscoveryReviewSetQueryItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public EdiscoveryReviewSetQueryItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/security/cases/ediscoveryCases/{ediscoveryCase%2Did}/reviewSets/{ediscoveryReviewSet%2Did}/queries/{ediscoveryReviewSetQuery%2Did}{?%24select,%24expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property queries for security
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<EdiscoveryReviewSetQueryItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new EdiscoveryReviewSetQueryItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Represents queries within the review set.
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<EdiscoveryReviewSetQueryItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new EdiscoveryReviewSetQueryItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property queries in security
        /// <param name="body"></param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(EdiscoveryReviewSetQuery body, Action<EdiscoveryReviewSetQueryItemRequestBuilderPatchRequestConfiguration> requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new EdiscoveryReviewSetQueryItemRequestBuilderPatchRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class EdiscoveryReviewSetQueryItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new EdiscoveryReviewSetQueryItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public EdiscoveryReviewSetQueryItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Represents queries within the review set.</summary>
        public class EdiscoveryReviewSetQueryItemRequestBuilderGetQueryParameters {
            /// <summary>Expand related entities</summary>
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class EdiscoveryReviewSetQueryItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public EdiscoveryReviewSetQueryItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new EdiscoveryReviewSetQueryItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new EdiscoveryReviewSetQueryItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public EdiscoveryReviewSetQueryItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class EdiscoveryReviewSetQueryItemRequestBuilderPatchRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new EdiscoveryReviewSetQueryItemRequestBuilderPatchRequestConfiguration and sets the default values.
            /// </summary>
            public EdiscoveryReviewSetQueryItemRequestBuilderPatchRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
