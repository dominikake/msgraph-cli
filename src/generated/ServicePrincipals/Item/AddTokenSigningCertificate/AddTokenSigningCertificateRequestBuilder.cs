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
namespace ApiSdk.ServicePrincipals.Item.AddTokenSigningCertificate {
    /// <summary>
    /// Provides operations to call the addTokenSigningCertificate method.
    /// </summary>
    public class AddTokenSigningCertificateRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Create a self-signed signing certificate and return a selfSignedCertificate object, which is the public part of the generated certificate.  The self-signed signing certificate is composed of the following objects, which are added to the servicePrincipal: + The keyCredentials object with the following objects:    + A private key object with **usage** set to `Sign`.    + A public key object with **usage** set to `Verify`.+ The passwordCredentials object.  All the objects have the same value of **customKeyIdentifier**. The **passwordCredential** is used to open the PFX file (private key). It and the associated private key object have the same value of **keyId**. When set during creation through the **displayName** property, the subject of the certificate cannot be updated. The **startDateTime** is set to the same time the certificate is created using the action. The **endDateTime** can be up to three years after the certificate is created.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/serviceprincipal-addtokensigningcertificate?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Create a self-signed signing certificate and return a selfSignedCertificate object, which is the public part of the generated certificate.  The self-signed signing certificate is composed of the following objects, which are added to the servicePrincipal: + The keyCredentials object with the following objects:    + A private key object with **usage** set to `Sign`.    + A public key object with **usage** set to `Verify`.+ The passwordCredentials object.  All the objects have the same value of **customKeyIdentifier**. The **passwordCredential** is used to open the PFX file (private key). It and the associated private key object have the same value of **keyId**. When set during creation through the **displayName** property, the subject of the certificate cannot be updated. The **startDateTime** is set to the same time the certificate is created using the action. The **endDateTime** can be up to three years after the certificate is created.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/serviceprincipal-addtokensigningcertificate?view=graph-rest-1.0";
            var servicePrincipalIdOption = new Option<string>("--service-principal-id", description: "The unique identifier of servicePrincipal") {
            };
            servicePrincipalIdOption.IsRequired = true;
            command.AddOption(servicePrincipalIdOption);
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
                var servicePrincipalId = invocationContext.ParseResult.GetValueForOption(servicePrincipalIdOption);
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
                var model = parseNode.GetObjectValue<AddTokenSigningCertificatePostRequestBody>(AddTokenSigningCertificatePostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (servicePrincipalId is not null) requestInfo.PathParameters.Add("servicePrincipal%2Did", servicePrincipalId);
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
        /// Instantiates a new AddTokenSigningCertificateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public AddTokenSigningCertificateRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/servicePrincipals/{servicePrincipal%2Did}/addTokenSigningCertificate", pathParameters) {
        }
        /// <summary>
        /// Create a self-signed signing certificate and return a selfSignedCertificate object, which is the public part of the generated certificate.  The self-signed signing certificate is composed of the following objects, which are added to the servicePrincipal: + The keyCredentials object with the following objects:    + A private key object with **usage** set to `Sign`.    + A public key object with **usage** set to `Verify`.+ The passwordCredentials object.  All the objects have the same value of **customKeyIdentifier**. The **passwordCredential** is used to open the PFX file (private key). It and the associated private key object have the same value of **keyId**. When set during creation through the **displayName** property, the subject of the certificate cannot be updated. The **startDateTime** is set to the same time the certificate is created using the action. The **endDateTime** can be up to three years after the certificate is created.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(AddTokenSigningCertificatePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(AddTokenSigningCertificatePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
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
    }
}
