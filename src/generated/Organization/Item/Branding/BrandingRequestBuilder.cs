using ApiSdk.Models.ODataErrors;
using ApiSdk.Models;
using ApiSdk.Organization.Item.Branding.BackgroundImage;
using ApiSdk.Organization.Item.Branding.BannerLogo;
using ApiSdk.Organization.Item.Branding.CustomCSS;
using ApiSdk.Organization.Item.Branding.Favicon;
using ApiSdk.Organization.Item.Branding.HeaderLogo;
using ApiSdk.Organization.Item.Branding.Localizations;
using ApiSdk.Organization.Item.Branding.SquareLogo;
using ApiSdk.Organization.Item.Branding.SquareLogoDark;
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
namespace ApiSdk.Organization.Item.Branding {
    /// <summary>
    /// Provides operations to manage the branding property of the microsoft.graph.organization entity.
    /// </summary>
    public class BrandingRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the media for the organization entity.
        /// </summary>
        public Command BuildBackgroundImageNavCommand() {
            var command = new Command("background-image");
            command.Description = "Provides operations to manage the media for the organization entity.";
            var builder = new BackgroundImageRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the media for the organization entity.
        /// </summary>
        public Command BuildBannerLogoNavCommand() {
            var command = new Command("banner-logo");
            command.Description = "Provides operations to manage the media for the organization entity.";
            var builder = new BannerLogoRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the media for the organization entity.
        /// </summary>
        public Command BuildCustomCSSNavCommand() {
            var command = new Command("custom-c-s-s");
            command.Description = "Provides operations to manage the media for the organization entity.";
            var builder = new CustomCSSRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete the default organizational branding object. To delete the organizationalBranding object, all images (Stream types) must first be removed from the object.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/organizationalbranding-delete?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete the default organizational branding object. To delete the organizationalBranding object, all images (Stream types) must first be removed from the object.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/organizationalbranding-delete?view=graph-rest-1.0";
            var organizationIdOption = new Option<string>("--organization-id", description: "The unique identifier of organization") {
            };
            organizationIdOption.IsRequired = true;
            command.AddOption(organizationIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var organizationId = invocationContext.ParseResult.GetValueForOption(organizationIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (organizationId is not null) requestInfo.PathParameters.Add("organization%2Did", organizationId);
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
        /// Provides operations to manage the media for the organization entity.
        /// </summary>
        public Command BuildFaviconNavCommand() {
            var command = new Command("favicon");
            command.Description = "Provides operations to manage the media for the organization entity.";
            var builder = new FaviconRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Retrieve the default organizational branding object, if the **Accept-Language** header is set to `0` or `default`. If no default organizational branding object exists, this method returns a `404 Not Found` error. If the **Accept-Language** header is set to an existing locale identified by the value of its **id**, this method retrieves the branding for the specified locale. This method retrieves only non-Stream properties, for example, **usernameHintText** and **signInPageText**. To retrieve Stream types of the default branding, for example, **bannerLogo** and **backgroundImage**, use the GET organizationalBrandingLocalization method.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/organizationalbranding-get?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "Retrieve the default organizational branding object, if the **Accept-Language** header is set to `0` or `default`. If no default organizational branding object exists, this method returns a `404 Not Found` error. If the **Accept-Language** header is set to an existing locale identified by the value of its **id**, this method retrieves the branding for the specified locale. This method retrieves only non-Stream properties, for example, **usernameHintText** and **signInPageText**. To retrieve Stream types of the default branding, for example, **bannerLogo** and **backgroundImage**, use the GET organizationalBrandingLocalization method.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/organizationalbranding-get?view=graph-rest-1.0";
            var organizationIdOption = new Option<string>("--organization-id", description: "The unique identifier of organization") {
            };
            organizationIdOption.IsRequired = true;
            command.AddOption(organizationIdOption);
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
                var organizationId = invocationContext.ParseResult.GetValueForOption(organizationIdOption);
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
                if (organizationId is not null) requestInfo.PathParameters.Add("organization%2Did", organizationId);
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
        /// Provides operations to manage the media for the organization entity.
        /// </summary>
        public Command BuildHeaderLogoNavCommand() {
            var command = new Command("header-logo");
            command.Description = "Provides operations to manage the media for the organization entity.";
            var builder = new HeaderLogoRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the localizations property of the microsoft.graph.organizationalBranding entity.
        /// </summary>
        public Command BuildLocalizationsNavCommand() {
            var command = new Command("localizations");
            command.Description = "Provides operations to manage the localizations property of the microsoft.graph.organizationalBranding entity.";
            var builder = new LocalizationsRequestBuilder(PathParameters);
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
        /// Update the properties of the default branding object specified by the organizationalBranding resource.
        /// Find more info here <see href="https://docs.microsoft.com/graph/api/organizationalbranding-update?view=graph-rest-1.0" />
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the properties of the default branding object specified by the organizationalBranding resource.\n\nFind more info here:\n  https://docs.microsoft.com/graph/api/organizationalbranding-update?view=graph-rest-1.0";
            var organizationIdOption = new Option<string>("--organization-id", description: "The unique identifier of organization") {
            };
            organizationIdOption.IsRequired = true;
            command.AddOption(organizationIdOption);
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
                var organizationId = invocationContext.ParseResult.GetValueForOption(organizationIdOption);
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
                var model = parseNode.GetObjectValue<OrganizationalBranding>(OrganizationalBranding.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (organizationId is not null) requestInfo.PathParameters.Add("organization%2Did", organizationId);
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
        /// Provides operations to manage the media for the organization entity.
        /// </summary>
        public Command BuildSquareLogoDarkNavCommand() {
            var command = new Command("square-logo-dark");
            command.Description = "Provides operations to manage the media for the organization entity.";
            var builder = new SquareLogoDarkRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the media for the organization entity.
        /// </summary>
        public Command BuildSquareLogoNavCommand() {
            var command = new Command("square-logo");
            command.Description = "Provides operations to manage the media for the organization entity.";
            var builder = new SquareLogoRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPutCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new BrandingRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public BrandingRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/organization/{organization%2Did}/branding{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Delete the default organizational branding object. To delete the organizationalBranding object, all images (Stream types) must first be removed from the object.
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
        /// Retrieve the default organizational branding object, if the **Accept-Language** header is set to `0` or `default`. If no default organizational branding object exists, this method returns a `404 Not Found` error. If the **Accept-Language** header is set to an existing locale identified by the value of its **id**, this method retrieves the branding for the specified locale. This method retrieves only non-Stream properties, for example, **usernameHintText** and **signInPageText**. To retrieve Stream types of the default branding, for example, **bannerLogo** and **backgroundImage**, use the GET organizationalBrandingLocalization method.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<BrandingRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<BrandingRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<BrandingRequestBuilderGetQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the properties of the default branding object specified by the organizationalBranding resource.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(OrganizationalBranding body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(OrganizationalBranding body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        /// Retrieve the default organizational branding object, if the **Accept-Language** header is set to `0` or `default`. If no default organizational branding object exists, this method returns a `404 Not Found` error. If the **Accept-Language** header is set to an existing locale identified by the value of its **id**, this method retrieves the branding for the specified locale. This method retrieves only non-Stream properties, for example, **usernameHintText** and **signInPageText**. To retrieve Stream types of the default branding, for example, **bannerLogo** and **backgroundImage**, use the GET organizationalBrandingLocalization method.
        /// </summary>
        public class BrandingRequestBuilderGetQueryParameters {
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
