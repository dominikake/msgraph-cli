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
namespace ApiSdk.Admin.ServiceAnnouncement.HealthOverviews.Item.Issues.Item.IncidentReport {
    /// <summary>
    /// Provides operations to call the incidentReport method.
    /// </summary>
    public class IncidentReportRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Invoke function incidentReport
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Invoke function incidentReport";
            var serviceHealthIdOption = new Option<string>("--service-health-id", description: "The unique identifier of serviceHealth") {
            };
            serviceHealthIdOption.IsRequired = true;
            command.AddOption(serviceHealthIdOption);
            var serviceHealthIssueIdOption = new Option<string>("--service-health-issue-id", description: "The unique identifier of serviceHealthIssue") {
            };
            serviceHealthIssueIdOption.IsRequired = true;
            command.AddOption(serviceHealthIssueIdOption);
            var outputFileOption = new Option<FileInfo>("--output-file");
            command.AddOption(outputFileOption);
            command.SetHandler(async (invocationContext) => {
                var serviceHealthId = invocationContext.ParseResult.GetValueForOption(serviceHealthIdOption);
                var serviceHealthIssueId = invocationContext.ParseResult.GetValueForOption(serviceHealthIssueIdOption);
                var outputFile = invocationContext.ParseResult.GetValueForOption(outputFileOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToGetRequestInformation(q => {
                });
                if (serviceHealthId is not null) requestInfo.PathParameters.Add("serviceHealth%2Did", serviceHealthId);
                if (serviceHealthIssueId is not null) requestInfo.PathParameters.Add("serviceHealthIssue%2Did", serviceHealthIssueId);
                var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                    {"4XX", ODataError.CreateFromDiscriminatorValue},
                    {"5XX", ODataError.CreateFromDiscriminatorValue},
                };
                var response = await reqAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping: errorMapping, cancellationToken: cancellationToken) ?? Stream.Null;
                if (outputFile == null) {
                    using var reader = new StreamReader(response);
                    var strContent = reader.ReadToEnd();
                    Console.Write(strContent);
                }
                else {
                    using var writeStream = outputFile.OpenWrite();
                    await response.CopyToAsync(writeStream);
                    Console.WriteLine($"Content written to {outputFile.FullName}.");
                }
            });
            return command;
        }
        /// <summary>
        /// Instantiates a new IncidentReportRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public IncidentReportRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/admin/serviceAnnouncement/healthOverviews/{serviceHealth%2Did}/issues/{serviceHealthIssue%2Did}/incidentReport()", pathParameters) {
        }
        /// <summary>
        /// Invoke function incidentReport
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
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
