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
namespace ApiSdk.Me.Calendar.Events.Item.MicrosoftGraphForward {
    /// <summary>
    /// Provides operations to call the forward method.
    /// </summary>
    public class MicrosoftGraphForwardRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// This action allows the organizer or attendee of a meeting event to forward the meeting request to a new recipient.  If the meeting event is forwarded from an attendee&apos;s Microsoft 365 mailbox to another recipient, this action also sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer&apos;s copy of the meeting event. This convenience is not available when forwarding from an Outlook.com account.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/event-forward?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPostCommand() {
            var command = new Command("post");
            command.Description = "This action allows the organizer or attendee of a meeting event to forward the meeting request to a new recipient.  If the meeting event is forwarded from an attendee's Microsoft 365 mailbox to another recipient, this action also sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer's copy of the meeting event. This convenience is not available when forwarding from an Outlook.com account.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/event-forward?view=graph-rest-1.0";
            // Create options for all the parameters
            var eventIdOption = new Option<string>("--event-id", description: "key: id of event") {
            };
            eventIdOption.IsRequired = true;
            command.AddOption(eventIdOption);
            var bodyOption = new Option<string>("--body", description: "The request body") {
            };
            bodyOption.IsRequired = true;
            command.AddOption(bodyOption);
            command.SetHandler(async (invocationContext) => {
                var eventId = invocationContext.ParseResult.GetValueForOption(eventIdOption);
                var body = invocationContext.ParseResult.GetValueForOption(bodyOption) ?? string.Empty;
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                using var stream = new MemoryStream(Encoding.UTF8.GetBytes(body));
                var parseNode = ParseNodeFactoryRegistry.DefaultInstance.GetRootParseNode("application/json", stream);
                var model = parseNode.GetObjectValue<ForwardPostRequestBody>(ForwardPostRequestBody.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPostRequestInformation(model, q => {
                });
                if (eventId is not null) requestInfo.PathParameters.Add("event%2Did", eventId);
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
        /// Instantiates a new MicrosoftGraphForwardRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public MicrosoftGraphForwardRequestBuilder(Dictionary<string, object> pathParameters) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            UrlTemplate = "{+baseurl}/me/calendar/events/{event%2Did}/microsoft.graph.forward";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
        }
        /// <summary>
        /// This action allows the organizer or attendee of a meeting event to forward the meeting request to a new recipient.  If the meeting event is forwarded from an attendee&apos;s Microsoft 365 mailbox to another recipient, this action also sends a message to notify the organizer of the forwarding, and adds the recipient to the organizer&apos;s copy of the meeting event. This convenience is not available when forwarding from an Outlook.com account.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(ForwardPostRequestBody body, Action<MicrosoftGraphForwardRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(ForwardPostRequestBody body, Action<MicrosoftGraphForwardRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new MicrosoftGraphForwardRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MicrosoftGraphForwardRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new microsoftGraphForwardRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public MicrosoftGraphForwardRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
