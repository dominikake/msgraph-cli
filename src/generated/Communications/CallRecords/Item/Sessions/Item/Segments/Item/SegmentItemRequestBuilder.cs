using ApiSdk.Models.Microsoft.Graph.CallRecords;
using ApiSdk.Models.Microsoft.Graph.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Cli.Commons.Binding;
using Microsoft.Kiota.Cli.Commons.IO;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace ApiSdk.Communications.CallRecords.Item.Sessions.Item.Segments.Item {
    /// <summary>Provides operations to manage the segments property of the microsoft.graph.callRecords.session entity.</summary>
    public class SegmentItemRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Delete navigation property segments for communications
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property segments for communications";
            // Create options for all the parameters
            var callRecordIdOption = new Option<string>("--call-record-id", description: "key: id of callRecord") {
            };
            callRecordIdOption.IsRequired = true;
            command.AddOption(callRecordIdOption);
            var sessionIdOption = new Option<string>("--session-id", description: "key: id of session") {
            };
            sessionIdOption.IsRequired = true;
            command.AddOption(sessionIdOption);
            var segmentIdOption = new Option<string>("--segment-id", description: "key: id of segment") {
            };
            segmentIdOption.IsRequired = true;
            command.AddOption(segmentIdOption);
            command.SetHandler(async (object[] parameters) => {
                var callRecordId = (string) parameters[0];
                var sessionId = (string) parameters[1];
                var segmentId = (string) parameters[2];
                var cancellationToken = (CancellationToken) parameters[3];
                PathParameters.Clear();
                PathParameters.Add("callRecord_id", callRecordId);
                PathParameters.Add("session_id", sessionId);
                PathParameters.Add("segment_id", segmentId);
                var requestInfo = CreateDeleteRequestInformation(q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(callRecordIdOption, sessionIdOption, segmentIdOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// The list of segments involved in the session. Read-only. Nullable.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The list of segments involved in the session. Read-only. Nullable.";
            // Create options for all the parameters
            var callRecordIdOption = new Option<string>("--call-record-id", description: "key: id of callRecord") {
            };
            callRecordIdOption.IsRequired = true;
            command.AddOption(callRecordIdOption);
            var sessionIdOption = new Option<string>("--session-id", description: "key: id of session") {
            };
            sessionIdOption.IsRequired = true;
            command.AddOption(sessionIdOption);
            var segmentIdOption = new Option<string>("--segment-id", description: "key: id of segment") {
            };
            segmentIdOption.IsRequired = true;
            command.AddOption(segmentIdOption);
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
            command.SetHandler(async (object[] parameters) => {
                var callRecordId = (string) parameters[0];
                var sessionId = (string) parameters[1];
                var segmentId = (string) parameters[2];
                var select = (string[]) parameters[3];
                var expand = (string[]) parameters[4];
                var output = (FormatterType) parameters[5];
                var query = (string) parameters[6];
                var jsonNoIndent = (bool) parameters[7];
                var outputFilter = (IOutputFilter) parameters[8];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[9];
                var cancellationToken = (CancellationToken) parameters[10];
                PathParameters.Clear();
                PathParameters.Add("callRecord_id", callRecordId);
                PathParameters.Add("session_id", sessionId);
                PathParameters.Add("segment_id", segmentId);
                var requestInfo = CreateGetRequestInformation(q => {
                    q.Select = select;
                    q.Expand = expand;
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                response = await outputFilter?.FilterOutputAsync(response, query, cancellationToken) ?? response;
                var formatterOptions = output.GetOutputFormatterOptions(new FormatterOptionsModel(!jsonNoIndent));
                var formatter = outputFormatterFactory.GetFormatter(output);
                await formatter.WriteOutputAsync(response, formatterOptions, cancellationToken);
            }, new CollectionBinding(callRecordIdOption, sessionIdOption, segmentIdOption, selectOption, expandOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Update the navigation property segments in communications
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property segments in communications";
            // Create options for all the parameters
            var callRecordIdOption = new Option<string>("--call-record-id", description: "key: id of callRecord") {
            };
            callRecordIdOption.IsRequired = true;
            command.AddOption(callRecordIdOption);
            var sessionIdOption = new Option<string>("--session-id", description: "key: id of session") {
            };
            sessionIdOption.IsRequired = true;
            command.AddOption(sessionIdOption);
            var segmentIdOption = new Option<string>("--segment-id", description: "key: id of segment") {
            };
            segmentIdOption.IsRequired = true;
            command.AddOption(segmentIdOption);
            var bodyOption = new Option<string>("--body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (object[] parameters) => {
                var callRecordId = (string) parameters[0];
                var sessionId = (string) parameters[1];
                var segmentId = (string) parameters[2];
                var body = (string) parameters[3];
                var cancellationToken = (CancellationToken) parameters[4];
                PathParameters.Clear();
                PathParameters.Add("callRecord_id", callRecordId);
                PathParameters.Add("session_id", sessionId);
                PathParameters.Add("segment_id", segmentId);
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<Segment>(Segment.CreateFromDiscriminatorValue);
                var requestInfo = CreatePatchRequestInformation(model, q => {
                });
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                await RequestAdapter.SendNoContentAsync(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken);
                Console.WriteLine("Success");
            }, new CollectionBinding(callRecordIdOption, sessionIdOption, segmentIdOption, bodyOption, new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new SegmentItemRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public SegmentItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/communications/callRecords/{callRecord_id}/sessions/{session_id}/segments/{segment_id}{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Delete navigation property segments for communications
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreateDeleteRequestInformation(Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// The list of segments involved in the session. Read-only. Nullable.
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// <param name="queryParameters">Request query parameters</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetQueryParameters> queryParameters = default, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (queryParameters != null) {
                var qParams = new GetQueryParameters();
                queryParameters.Invoke(qParams);
                qParams.AddQueryParameters(requestInfo.QueryParameters);
            }
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property segments in communications
        /// <param name="body"></param>
        /// <param name="headers">Request headers</param>
        /// <param name="options">Request options</param>
        /// </summary>
        public RequestInformation CreatePatchRequestInformation(Segment body, Action<IDictionary<string, string>> headers = default, IEnumerable<IRequestOption> options = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PATCH,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            headers?.Invoke(requestInfo.Headers);
            requestInfo.AddRequestOptions(options?.ToArray());
            return requestInfo;
        }
        /// <summary>The list of segments involved in the session. Read-only. Nullable.</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
