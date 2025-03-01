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
namespace ApiSdk.IdentityGovernance.EntitlementManagement.AssignmentRequests.Item.Reprocess {
    /// <summary>
    /// Provides operations to call the reprocess method.
    /// </summary>
    public class ReprocessRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// In Azure AD entitlement management, callers can automatically retry a user&apos;s request for access to an access package. It is performed on an accessPackageAssignmentRequest object whose **requestState** is in a `DeliveryFailed` or `PartiallyDelivered` state.  You can only reprocess a request within 14 days from the time the original request was completed. For requests completed more than 14 days, you will need to ask the users to cancel the request(s) and make a new request in the MyAccess portal.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/accesspackageassignmentrequest-reprocess?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "In Azure AD entitlement management, callers can automatically retry a user's request for access to an access package. It is performed on an accessPackageAssignmentRequest object whose **requestState** is in a `DeliveryFailed` or `PartiallyDelivered` state.  You can only reprocess a request within 14 days from the time the original request was completed. For requests completed more than 14 days, you will need to ask the users to cancel the request(s) and make a new request in the MyAccess portal.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/accesspackageassignmentrequest-reprocess?view=graph-rest-1.0";
            var accessPackageAssignmentRequestIdOption = new Option<string>("--access-package-assignment-request-id", description: "The unique identifier of accessPackageAssignmentRequest") {
            };
            accessPackageAssignmentRequestIdOption.IsRequired = true;
            command.AddOption(accessPackageAssignmentRequestIdOption);
            command.SetHandler(async (invocationContext) => {
                var accessPackageAssignmentRequestId = invocationContext.ParseResult.GetValueForOption(accessPackageAssignmentRequestIdOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToPostRequestInformation(q => {
                });
                if (accessPackageAssignmentRequestId is not null) requestInfo.PathParameters.Add("accessPackageAssignmentRequest%2Did", accessPackageAssignmentRequestId);
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
        /// Instantiates a new ReprocessRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public ReprocessRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/identityGovernance/entitlementManagement/assignmentRequests/{accessPackageAssignmentRequest%2Did}/reprocess", pathParameters) {
        }
        /// <summary>
        /// In Azure AD entitlement management, callers can automatically retry a user&apos;s request for access to an access package. It is performed on an accessPackageAssignmentRequest object whose **requestState** is in a `DeliveryFailed` or `PartiallyDelivered` state.  You can only reprocess a request within 14 days from the time the original request was completed. For requests completed more than 14 days, you will need to ask the users to cancel the request(s) and make a new request in the MyAccess portal.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
#endif
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
