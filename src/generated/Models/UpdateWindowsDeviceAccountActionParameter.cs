using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class UpdateWindowsDeviceAccountActionParameter : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Not yet documented</summary>
        public bool? CalendarSyncEnabled { get; set; }
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsDeviceAccount? DeviceAccount { get; set; }
#nullable restore
#else
        public WindowsDeviceAccount DeviceAccount { get; set; }
#endif
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceAccountEmail { get; set; }
#nullable restore
#else
        public string DeviceAccountEmail { get; set; }
#endif
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExchangeServer { get; set; }
#nullable restore
#else
        public string ExchangeServer { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Not yet documented</summary>
        public bool? PasswordRotationEnabled { get; set; }
        /// <summary>Not yet documented</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SessionInitiationProtocalAddress { get; set; }
#nullable restore
#else
        public string SessionInitiationProtocalAddress { get; set; }
#endif
        /// <summary>
        /// Instantiates a new updateWindowsDeviceAccountActionParameter and sets the default values.
        /// </summary>
        public UpdateWindowsDeviceAccountActionParameter() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UpdateWindowsDeviceAccountActionParameter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateWindowsDeviceAccountActionParameter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"calendarSyncEnabled", n => { CalendarSyncEnabled = n.GetBoolValue(); } },
                {"deviceAccount", n => { DeviceAccount = n.GetObjectValue<WindowsDeviceAccount>(WindowsDeviceAccount.CreateFromDiscriminatorValue); } },
                {"deviceAccountEmail", n => { DeviceAccountEmail = n.GetStringValue(); } },
                {"exchangeServer", n => { ExchangeServer = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"passwordRotationEnabled", n => { PasswordRotationEnabled = n.GetBoolValue(); } },
                {"sessionInitiationProtocalAddress", n => { SessionInitiationProtocalAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("calendarSyncEnabled", CalendarSyncEnabled);
            writer.WriteObjectValue<WindowsDeviceAccount>("deviceAccount", DeviceAccount);
            writer.WriteStringValue("deviceAccountEmail", DeviceAccountEmail);
            writer.WriteStringValue("exchangeServer", ExchangeServer);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("passwordRotationEnabled", PasswordRotationEnabled);
            writer.WriteStringValue("sessionInitiationProtocalAddress", SessionInitiationProtocalAddress);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
