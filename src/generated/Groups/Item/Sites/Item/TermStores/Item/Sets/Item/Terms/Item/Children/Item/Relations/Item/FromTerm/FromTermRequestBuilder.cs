using ApiSdk.Models.Microsoft.Graph.ODataErrors;
using ApiSdk.Models.Microsoft.Graph.TermStore;
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
namespace ApiSdk.Groups.Item.Sites.Item.TermStores.Item.Sets.Item.Terms.Item.Children.Item.Relations.Item.FromTerm {
    /// <summary>Provides operations to manage the fromTerm property of the microsoft.graph.termStore.relation entity.</summary>
    public class FromTermRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// The from [term] of the relation. The term from which the relationship is defined. A null value would indicate the relation is directly with the [set].
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "The from [term] of the relation. The term from which the relationship is defined. A null value would indicate the relation is directly with the [set].";
            // Create options for all the parameters
            var groupIdOption = new Option<string>("--group-id", description: "key: id of group") {
            };
            groupIdOption.IsRequired = true;
            command.AddOption(groupIdOption);
            var siteIdOption = new Option<string>("--site-id", description: "key: id of site") {
            };
            siteIdOption.IsRequired = true;
            command.AddOption(siteIdOption);
            var storeIdOption = new Option<string>("--store-id", description: "key: id of store") {
            };
            storeIdOption.IsRequired = true;
            command.AddOption(storeIdOption);
            var setIdOption = new Option<string>("--set-id", description: "key: id of set") {
            };
            setIdOption.IsRequired = true;
            command.AddOption(setIdOption);
            var termIdOption = new Option<string>("--term-id", description: "key: id of term") {
            };
            termIdOption.IsRequired = true;
            command.AddOption(termIdOption);
            var termId1Option = new Option<string>("--term-id1", description: "key: id of term") {
            };
            termId1Option.IsRequired = true;
            command.AddOption(termId1Option);
            var relationIdOption = new Option<string>("--relation-id", description: "key: id of relation") {
            };
            relationIdOption.IsRequired = true;
            command.AddOption(relationIdOption);
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
                var groupId = (string) parameters[0];
                var siteId = (string) parameters[1];
                var storeId = (string) parameters[2];
                var setId = (string) parameters[3];
                var termId = (string) parameters[4];
                var termId1 = (string) parameters[5];
                var relationId = (string) parameters[6];
                var select = (string[]) parameters[7];
                var expand = (string[]) parameters[8];
                var output = (FormatterType) parameters[9];
                var query = (string) parameters[10];
                var jsonNoIndent = (bool) parameters[11];
                var outputFilter = (IOutputFilter) parameters[12];
                var outputFormatterFactory = (IOutputFormatterFactory) parameters[13];
                var cancellationToken = (CancellationToken) parameters[14];
                PathParameters.Clear();
                PathParameters.Add("group_id", groupId);
                PathParameters.Add("site_id", siteId);
                PathParameters.Add("store_id", storeId);
                PathParameters.Add("set_id", setId);
                PathParameters.Add("term_id", termId);
                PathParameters.Add("term_id1", termId1);
                PathParameters.Add("relation_id", relationId);
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
            }, new CollectionBinding(groupIdOption, siteIdOption, storeIdOption, setIdOption, termIdOption, termId1Option, relationIdOption, selectOption, expandOption, outputOption, queryOption, jsonNoIndentOption, new TypeBinding(typeof(IOutputFilter)), new TypeBinding(typeof(IOutputFormatterFactory)), new TypeBinding(typeof(CancellationToken))));
            return command;
        }
        /// <summary>
        /// Instantiates a new FromTermRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public FromTermRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/groups/{group_id}/sites/{site_id}/termStores/{store_id}/sets/{set_id}/terms/{term_id}/children/{term_id1}/relations/{relation_id}/fromTerm{?select,expand}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// The from [term] of the relation. The term from which the relationship is defined. A null value would indicate the relation is directly with the [set].
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
        /// <summary>The from [term] of the relation. The term from which the relationship is defined. A null value would indicate the relation is directly with the [set].</summary>
        public class GetQueryParameters : QueryParametersBase {
            /// <summary>Expand related entities</summary>
            public string[] Expand { get; set; }
            /// <summary>Select properties to be returned</summary>
            public string[] Select { get; set; }
        }
    }
}
