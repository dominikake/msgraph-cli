using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class ScheduleInformation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents a merged view of availability of all the items in scheduleItems. The view consists of time slots. Availability during each time slot is indicated with: 0= free, 1= tentative, 2= busy, 3= out of office, 4= working elsewhere.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AvailabilityView { get; set; }
#nullable restore
#else
        public string AvailabilityView { get; set; }
#endif
        /// <summary>Error information from attempting to get the availability of the user, distribution list, or resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FreeBusyError? Error { get; set; }
#nullable restore
#else
        public FreeBusyError Error { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>An SMTP address of the user, distribution list, or resource, identifying an instance of scheduleInformation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScheduleId { get; set; }
#nullable restore
#else
        public string ScheduleId { get; set; }
#endif
        /// <summary>Contains the items that describe the availability of the user or resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ScheduleItem>? ScheduleItems { get; set; }
#nullable restore
#else
        public List<ScheduleItem> ScheduleItems { get; set; }
#endif
        /// <summary>The days of the week and hours in a specific time zone that the user works. These are set as part of the user&apos;s mailboxSettings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApiSdk.Models.WorkingHours? WorkingHours { get; set; }
#nullable restore
#else
        public ApiSdk.Models.WorkingHours WorkingHours { get; set; }
#endif
        /// <summary>
        /// Instantiates a new scheduleInformation and sets the default values.
        /// </summary>
        public ScheduleInformation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ScheduleInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScheduleInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"availabilityView", n => { AvailabilityView = n.GetStringValue(); } },
                {"error", n => { Error = n.GetObjectValue<FreeBusyError>(FreeBusyError.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"scheduleId", n => { ScheduleId = n.GetStringValue(); } },
                {"scheduleItems", n => { ScheduleItems = n.GetCollectionOfObjectValues<ScheduleItem>(ScheduleItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"workingHours", n => { WorkingHours = n.GetObjectValue<ApiSdk.Models.WorkingHours>(ApiSdk.Models.WorkingHours.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("availabilityView", AvailabilityView);
            writer.WriteObjectValue<FreeBusyError>("error", Error);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("scheduleId", ScheduleId);
            writer.WriteCollectionOfObjectValues<ScheduleItem>("scheduleItems", ScheduleItems);
            writer.WriteObjectValue<ApiSdk.Models.WorkingHours>("workingHours", WorkingHours);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
