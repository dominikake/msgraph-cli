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
namespace ApiSdk.Identity.ApiConnectors.Item.MicrosoftGraphUploadClientCertificate {
    /// <summary>
    /// Provides operations to call the uploadClientCertificate method.
    /// </summary>
    public class MicrosoftGraphUploadClientCertificateRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Upload a PKCS 12 format key (.pfx) to an API connector&apos;s authentication configuration. The input is a base-64 encoded value of the PKCS 12 certificate contents. This method returns an apiConnector.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/identityapiconnector-uploadclientcertificate?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Upload a PKCS 12 format key (.pfx) to an API connector's authentication configuration. The input is a base-64 encoded value of the PKCS 12 certificate contents. This method returns an apiConnector.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/identityapiconnector-uploadclientcertificate?view=graph-rest-1.0";
            // Create options for all the parameters
            var identityApiConnectorIdOption = new Option<string>("--identity-api-connector-id", description: "key: id of identityApiConnector") {
            };
            identityApiConnectorIdOption.IsRequired = true;
            command.AddOption(identityApiConnectorIdOption);
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
                var identityApiConnectorId = invocationContext.ParseResult.GetValueForOption(identityApiConnectorIdOption);
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
                var model = parseNode.GetObjectValue<UploadClientCertificatePostRequestBody>(UploadClientCertificatePostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (identityApiConnectorId is not null) requestInfo.PathParameters.Add("identityApiConnector%2Did", identityApiConnectorId);
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
        /// Instantiates a new MicrosoftGraphUploadClientCertificateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphUploadClientCertificateRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/identity/apiConnectors/{identityApiConnector%2Did}/microsoft.graph.uploadClientCertificate";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// Upload a PKCS 12 format key (.pfx) to an API connector&apos;s authentication configuration. The input is a base-64 encoded value of the PKCS 12 certificate contents. This method returns an apiConnector.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(UploadClientCertificatePostRequestBody body, Action<MicrosoftGraphUploadClientCertificateRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(UploadClientCertificatePostRequestBody body, Action<MicrosoftGraphUploadClientCertificateRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new MicrosoftGraphUploadClientCertificateRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MicrosoftGraphUploadClientCertificateRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new microsoftGraphUploadClientCertificateRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public MicrosoftGraphUploadClientCertificateRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
