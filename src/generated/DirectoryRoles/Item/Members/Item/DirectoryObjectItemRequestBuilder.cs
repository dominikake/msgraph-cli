using ApiSdk.DirectoryRoles.Item.Members.Item.GraphApplication;
using ApiSdk.DirectoryRoles.Item.Members.Item.GraphDevice;
using ApiSdk.DirectoryRoles.Item.Members.Item.GraphGroup;
using ApiSdk.DirectoryRoles.Item.Members.Item.GraphOrgContact;
using ApiSdk.DirectoryRoles.Item.Members.Item.GraphServicePrincipal;
using ApiSdk.DirectoryRoles.Item.Members.Item.GraphUser;
using ApiSdk.DirectoryRoles.Item.Members.Item.Ref;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Cli.Commons.IO;
using Microsoft.Kiota.Cli.Commons;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
namespace ApiSdk.DirectoryRoles.Item.Members.Item {
    /// <summary>
    /// Builds and executes requests for operations under \directoryRoles\{directoryRole-id}\members\{directoryObject-id}
    /// </summary>
    public class DirectoryObjectItemRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Casts the previous resource to application.
        /// </summary>
        public Command BuildGraphApplicationByIdNavCommand() {
            var command = new Command("graph-application-by-id");
            command.Description = "Casts the previous resource to application.";
            var builder = new GraphApplicationRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Casts the previous resource to device.
        /// </summary>
        public Command BuildGraphDeviceByIdNavCommand() {
            var command = new Command("graph-device-by-id");
            command.Description = "Casts the previous resource to device.";
            var builder = new GraphDeviceRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Casts the previous resource to group.
        /// </summary>
        public Command BuildGraphGroupByIdNavCommand() {
            var command = new Command("graph-group-by-id");
            command.Description = "Casts the previous resource to group.";
            var builder = new GraphGroupRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Casts the previous resource to orgContact.
        /// </summary>
        public Command BuildGraphOrgContactByIdNavCommand() {
            var command = new Command("graph-org-contact-by-id");
            command.Description = "Casts the previous resource to orgContact.";
            var builder = new GraphOrgContactRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Casts the previous resource to servicePrincipal.
        /// </summary>
        public Command BuildGraphServicePrincipalByIdNavCommand() {
            var command = new Command("graph-service-principal-by-id");
            command.Description = "Casts the previous resource to servicePrincipal.";
            var builder = new GraphServicePrincipalRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Casts the previous resource to user.
        /// </summary>
        public Command BuildGraphUserByIdNavCommand() {
            var command = new Command("graph-user-by-id");
            command.Description = "Casts the previous resource to user.";
            var builder = new GraphUserRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the collection of directoryRole entities.
        /// </summary>
        public Command BuildRefNavCommand() {
            var command = new Command("ref");
            command.Description = "Provides operations to manage the collection of directoryRole entities.";
            var builder = new RefRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildDeleteCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Instantiates a new DirectoryObjectItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/directoryRoles/{directoryRole%2Did}/members/{directoryObject%2Did}", pathParameters) {
        }
    }
}
