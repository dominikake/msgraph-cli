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
namespace ApiSdk.Print.Shares.Item.Jobs.Item.Abort {
    /// <summary>
    /// Provides operations to call the abort method.
    /// </summary>
    public class AbortRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Abort a print job. Only applications using application permissions can abort a print job. Aborting a print job will only succeed if there is a printTask in a `processing` state on the associated print job, started by a trigger that the requesting app created. For details about how to register a task trigger, see Extending Universal Print to support pull printing.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/printjob-abort?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "Abort a print job. Only applications using application permissions can abort a print job. Aborting a print job will only succeed if there is a printTask in a `processing` state on the associated print job, started by a trigger that the requesting app created. For details about how to register a task trigger, see Extending Universal Print to support pull printing.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/printjob-abort?view=graph-rest-1.0";
            var printerShareIdOption = new Option<string>("--printer-share-id", description: "The unique identifier of printerShare") {
            };
            printerShareIdOption.IsRequired = true;
            command.AddOption(printerShareIdOption);
            var printJobIdOption = new Option<string>("--print-job-id", description: "The unique identifier of printJob") {
            };
            printJobIdOption.IsRequired = true;
            command.AddOption(printJobIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var printerShareId = invocationContext.ParseResult.GetValueForOption(printerShareIdOption);
                var printJobId = invocationContext.ParseResult.GetValueForOption(printJobIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<AbortPostRequestBody>(AbortPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (printerShareId is not null) requestInfo.PathParameters.Add("printerShare%2Did", printerShareId);
                if (printJobId is not null) requestInfo.PathParameters.Add("printJob%2Did", printJobId);
                requestInfo.SetContentFromParsable(reqAdapter, "application/json", model);
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
        /// Instantiates a new AbortRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public AbortRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/print/shares/{printerShare%2Did}/jobs/{printJob%2Did}/abort", pathParameters) {
        }
        /// <summary>
        /// Abort a print job. Only applications using application permissions can abort a print job. Aborting a print job will only succeed if there is a printTask in a `processing` state on the associated print job, started by a trigger that the requesting app created. For details about how to register a task trigger, see Extending Universal Print to support pull printing.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(AbortPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(AbortPostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
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
    }
}
