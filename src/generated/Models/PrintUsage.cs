using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace ApiSdk.Models {
    public class PrintUsage : Entity, IParsable {
        /// <summary>The blackAndWhitePageCount property</summary>
        public long? BlackAndWhitePageCount { get; set; }
        /// <summary>The colorPageCount property</summary>
        public long? ColorPageCount { get; set; }
        /// <summary>The completedBlackAndWhiteJobCount property</summary>
        public long? CompletedBlackAndWhiteJobCount { get; set; }
        /// <summary>The completedColorJobCount property</summary>
        public long? CompletedColorJobCount { get; set; }
        /// <summary>The completedJobCount property</summary>
        public long? CompletedJobCount { get; set; }
        /// <summary>The doubleSidedSheetCount property</summary>
        public long? DoubleSidedSheetCount { get; set; }
        /// <summary>The incompleteJobCount property</summary>
        public long? IncompleteJobCount { get; set; }
        /// <summary>The mediaSheetCount property</summary>
        public long? MediaSheetCount { get; set; }
        /// <summary>The pageCount property</summary>
        public long? PageCount { get; set; }
        /// <summary>The singleSidedSheetCount property</summary>
        public long? SingleSidedSheetCount { get; set; }
        /// <summary>The usageDate property</summary>
        public Date? UsageDate { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrintUsage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.printUsageByPrinter" => new PrintUsageByPrinter(),
                "#microsoft.graph.printUsageByUser" => new PrintUsageByUser(),
                _ => new PrintUsage(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"blackAndWhitePageCount", n => { BlackAndWhitePageCount = n.GetLongValue(); } },
                {"colorPageCount", n => { ColorPageCount = n.GetLongValue(); } },
                {"completedBlackAndWhiteJobCount", n => { CompletedBlackAndWhiteJobCount = n.GetLongValue(); } },
                {"completedColorJobCount", n => { CompletedColorJobCount = n.GetLongValue(); } },
                {"completedJobCount", n => { CompletedJobCount = n.GetLongValue(); } },
                {"doubleSidedSheetCount", n => { DoubleSidedSheetCount = n.GetLongValue(); } },
                {"incompleteJobCount", n => { IncompleteJobCount = n.GetLongValue(); } },
                {"mediaSheetCount", n => { MediaSheetCount = n.GetLongValue(); } },
                {"pageCount", n => { PageCount = n.GetLongValue(); } },
                {"singleSidedSheetCount", n => { SingleSidedSheetCount = n.GetLongValue(); } },
                {"usageDate", n => { UsageDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("blackAndWhitePageCount", BlackAndWhitePageCount);
            writer.WriteLongValue("colorPageCount", ColorPageCount);
            writer.WriteLongValue("completedBlackAndWhiteJobCount", CompletedBlackAndWhiteJobCount);
            writer.WriteLongValue("completedColorJobCount", CompletedColorJobCount);
            writer.WriteLongValue("completedJobCount", CompletedJobCount);
            writer.WriteLongValue("doubleSidedSheetCount", DoubleSidedSheetCount);
            writer.WriteLongValue("incompleteJobCount", IncompleteJobCount);
            writer.WriteLongValue("mediaSheetCount", MediaSheetCount);
            writer.WriteLongValue("pageCount", PageCount);
            writer.WriteLongValue("singleSidedSheetCount", SingleSidedSheetCount);
            writer.WriteDateValue("usageDate", UsageDate);
        }
    }
}
