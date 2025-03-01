using ApiSdk.Drives.Item.Items.Item.Workbook.Application;
using ApiSdk.Drives.Item.Items.Item.Workbook.CloseSession;
using ApiSdk.Drives.Item.Items.Item.Workbook.Comments;
using ApiSdk.Drives.Item.Items.Item.Workbook.CreateSession;
using ApiSdk.Drives.Item.Items.Item.Workbook.Functions;
using ApiSdk.Drives.Item.Items.Item.Workbook.Names;
using ApiSdk.Drives.Item.Items.Item.Workbook.Operations;
using ApiSdk.Drives.Item.Items.Item.Workbook.RefreshSession;
using ApiSdk.Drives.Item.Items.Item.Workbook.SessionInfoResourceWithKey;
using ApiSdk.Drives.Item.Items.Item.Workbook.TableRowOperationResultWithKey;
using ApiSdk.Drives.Item.Items.Item.Workbook.Tables;
using ApiSdk.Drives.Item.Items.Item.Workbook.Worksheets;
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
namespace ApiSdk.Drives.Item.Items.Item.Workbook {
    /// <summary>
    /// Provides operations to manage the workbook property of the microsoft.graph.driveItem entity.
    /// </summary>
    public class WorkbookRequestBuilder : BaseCliRequestBuilder {
        /// <summary>
        /// Provides operations to manage the application property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildApplicationNavCommand() {
            var command = new Command("application");
            command.Description = "Provides operations to manage the application property of the microsoft.graph.workbook entity.";
            var builder = new ApplicationRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildCalculateNavCommand());
            execCommands.Add(builder.BuildDeleteCommand());
            execCommands.Add(builder.BuildGetCommand());
            execCommands.Add(builder.BuildPatchCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the closeSession method.
        /// </summary>
        public Command BuildCloseSessionNavCommand() {
            var command = new Command("close-session");
            command.Description = "Provides operations to call the closeSession method.";
            var builder = new CloseSessionRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the comments property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildCommentsNavCommand() {
            var command = new Command("comments");
            command.Description = "Provides operations to manage the comments property of the microsoft.graph.workbook entity.";
            var builder = new CommentsRequestBuilder(PathParameters);
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
        /// Provides operations to call the createSession method.
        /// </summary>
        public Command BuildCreateSessionNavCommand() {
            var command = new Command("create-session");
            command.Description = "Provides operations to call the createSession method.";
            var builder = new CreateSessionRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Delete navigation property workbook for drives
        /// </summary>
        public Command BuildDeleteCommand() {
            var command = new Command("delete");
            command.Description = "Delete navigation property workbook for drives";
            var driveIdOption = new Option<string>("--drive-id", description: "The unique identifier of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "The unique identifier of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
            var ifMatchOption = new Option<string[]>("--if-match", description: "ETag") {
                Arity = ArgumentArity.ZeroOrMore
            };
            ifMatchOption.IsRequired = false;
            command.AddOption(ifMatchOption);
            command.SetHandler(async (invocationContext) => {
                var driveId = invocationContext.ParseResult.GetValueForOption(driveIdOption);
                var driveItemId = invocationContext.ParseResult.GetValueForOption(driveItemIdOption);
                var ifMatch = invocationContext.ParseResult.GetValueForOption(ifMatchOption);
                var cancellationToken = invocationContext.GetCancellationToken();
                var reqAdapter = invocationContext.GetRequestAdapter();
                var requestInfo = ToDeleteRequestInformation(q => {
                });
                if (driveId is not null) requestInfo.PathParameters.Add("drive%2Did", driveId);
                if (driveItemId is not null) requestInfo.PathParameters.Add("driveItem%2Did", driveItemId);
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
        /// Provides operations to manage the functions property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildFunctionsNavCommand() {
            var command = new Command("functions");
            command.Description = "Provides operations to manage the functions property of the microsoft.graph.workbook entity.";
            var builder = new FunctionsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAbsNavCommand());
            nonExecCommands.Add(builder.BuildAccrIntMNavCommand());
            nonExecCommands.Add(builder.BuildAccrIntNavCommand());
            nonExecCommands.Add(builder.BuildAcoshNavCommand());
            nonExecCommands.Add(builder.BuildAcosNavCommand());
            nonExecCommands.Add(builder.BuildAcothNavCommand());
            nonExecCommands.Add(builder.BuildAcotNavCommand());
            nonExecCommands.Add(builder.BuildAmorDegrcNavCommand());
            nonExecCommands.Add(builder.BuildAmorLincNavCommand());
            nonExecCommands.Add(builder.BuildAndNavCommand());
            nonExecCommands.Add(builder.BuildArabicNavCommand());
            nonExecCommands.Add(builder.BuildAreasNavCommand());
            nonExecCommands.Add(builder.BuildAscNavCommand());
            nonExecCommands.Add(builder.BuildAsinhNavCommand());
            nonExecCommands.Add(builder.BuildAsinNavCommand());
            nonExecCommands.Add(builder.BuildAtan2NavCommand());
            nonExecCommands.Add(builder.BuildAtanhNavCommand());
            nonExecCommands.Add(builder.BuildAtanNavCommand());
            nonExecCommands.Add(builder.BuildAveDevNavCommand());
            nonExecCommands.Add(builder.BuildAverageANavCommand());
            nonExecCommands.Add(builder.BuildAverageIfNavCommand());
            nonExecCommands.Add(builder.BuildAverageIfsNavCommand());
            nonExecCommands.Add(builder.BuildAverageNavCommand());
            nonExecCommands.Add(builder.BuildBahtTextNavCommand());
            nonExecCommands.Add(builder.BuildBaseNavCommand());
            nonExecCommands.Add(builder.BuildBesselINavCommand());
            nonExecCommands.Add(builder.BuildBesselJNavCommand());
            nonExecCommands.Add(builder.BuildBesselKNavCommand());
            nonExecCommands.Add(builder.BuildBesselYNavCommand());
            nonExecCommands.Add(builder.BuildBeta_DistNavCommand());
            nonExecCommands.Add(builder.BuildBeta_InvNavCommand());
            nonExecCommands.Add(builder.BuildBin2DecNavCommand());
            nonExecCommands.Add(builder.BuildBin2HexNavCommand());
            nonExecCommands.Add(builder.BuildBin2OctNavCommand());
            nonExecCommands.Add(builder.BuildBinom_Dist_RangeNavCommand());
            nonExecCommands.Add(builder.BuildBinom_DistNavCommand());
            nonExecCommands.Add(builder.BuildBinom_InvNavCommand());
            nonExecCommands.Add(builder.BuildBitandNavCommand());
            nonExecCommands.Add(builder.BuildBitlshiftNavCommand());
            nonExecCommands.Add(builder.BuildBitorNavCommand());
            nonExecCommands.Add(builder.BuildBitrshiftNavCommand());
            nonExecCommands.Add(builder.BuildBitxorNavCommand());
            nonExecCommands.Add(builder.BuildCeiling_MathNavCommand());
            nonExecCommands.Add(builder.BuildCeiling_PreciseNavCommand());
            nonExecCommands.Add(builder.BuildCharNavCommand());
            nonExecCommands.Add(builder.BuildChiSq_Dist_RTNavCommand());
            nonExecCommands.Add(builder.BuildChiSq_DistNavCommand());
            nonExecCommands.Add(builder.BuildChiSq_Inv_RTNavCommand());
            nonExecCommands.Add(builder.BuildChiSq_InvNavCommand());
            nonExecCommands.Add(builder.BuildChooseNavCommand());
            nonExecCommands.Add(builder.BuildCleanNavCommand());
            nonExecCommands.Add(builder.BuildCodeNavCommand());
            nonExecCommands.Add(builder.BuildColumnsNavCommand());
            nonExecCommands.Add(builder.BuildCombinaNavCommand());
            nonExecCommands.Add(builder.BuildCombinNavCommand());
            nonExecCommands.Add(builder.BuildComplexNavCommand());
            nonExecCommands.Add(builder.BuildConcatenateNavCommand());
            nonExecCommands.Add(builder.BuildConfidence_NormNavCommand());
            nonExecCommands.Add(builder.BuildConfidence_TNavCommand());
            nonExecCommands.Add(builder.BuildConvertNavCommand());
            nonExecCommands.Add(builder.BuildCoshNavCommand());
            nonExecCommands.Add(builder.BuildCosNavCommand());
            nonExecCommands.Add(builder.BuildCothNavCommand());
            nonExecCommands.Add(builder.BuildCotNavCommand());
            nonExecCommands.Add(builder.BuildCountANavCommand());
            nonExecCommands.Add(builder.BuildCountBlankNavCommand());
            nonExecCommands.Add(builder.BuildCountIfNavCommand());
            nonExecCommands.Add(builder.BuildCountIfsNavCommand());
            nonExecCommands.Add(builder.BuildCountNavCommand());
            nonExecCommands.Add(builder.BuildCoupDayBsNavCommand());
            nonExecCommands.Add(builder.BuildCoupDaysNavCommand());
            nonExecCommands.Add(builder.BuildCoupDaysNcNavCommand());
            nonExecCommands.Add(builder.BuildCoupNcdNavCommand());
            nonExecCommands.Add(builder.BuildCoupNumNavCommand());
            nonExecCommands.Add(builder.BuildCoupPcdNavCommand());
            nonExecCommands.Add(builder.BuildCschNavCommand());
            nonExecCommands.Add(builder.BuildCscNavCommand());
            nonExecCommands.Add(builder.BuildCumIPmtNavCommand());
            nonExecCommands.Add(builder.BuildCumPrincNavCommand());
            nonExecCommands.Add(builder.BuildDateNavCommand());
            nonExecCommands.Add(builder.BuildDatevalueNavCommand());
            nonExecCommands.Add(builder.BuildDaverageNavCommand());
            nonExecCommands.Add(builder.BuildDayNavCommand());
            nonExecCommands.Add(builder.BuildDays360NavCommand());
            nonExecCommands.Add(builder.BuildDaysNavCommand());
            nonExecCommands.Add(builder.BuildDbcsNavCommand());
            nonExecCommands.Add(builder.BuildDbNavCommand());
            nonExecCommands.Add(builder.BuildDcountANavCommand());
            nonExecCommands.Add(builder.BuildDcountNavCommand());
            nonExecCommands.Add(builder.BuildDdbNavCommand());
            nonExecCommands.Add(builder.BuildDec2BinNavCommand());
            nonExecCommands.Add(builder.BuildDec2HexNavCommand());
            nonExecCommands.Add(builder.BuildDec2OctNavCommand());
            nonExecCommands.Add(builder.BuildDecimalNavCommand());
            nonExecCommands.Add(builder.BuildDegreesNavCommand());
            execCommands.Add(builder.BuildDeleteCommand());
            nonExecCommands.Add(builder.BuildDeltaNavCommand());
            nonExecCommands.Add(builder.BuildDevSqNavCommand());
            nonExecCommands.Add(builder.BuildDgetNavCommand());
            nonExecCommands.Add(builder.BuildDiscNavCommand());
            nonExecCommands.Add(builder.BuildDmaxNavCommand());
            nonExecCommands.Add(builder.BuildDminNavCommand());
            nonExecCommands.Add(builder.BuildDollarDeNavCommand());
            nonExecCommands.Add(builder.BuildDollarFrNavCommand());
            nonExecCommands.Add(builder.BuildDollarNavCommand());
            nonExecCommands.Add(builder.BuildDproductNavCommand());
            nonExecCommands.Add(builder.BuildDstDevNavCommand());
            nonExecCommands.Add(builder.BuildDstDevPNavCommand());
            nonExecCommands.Add(builder.BuildDsumNavCommand());
            nonExecCommands.Add(builder.BuildDurationNavCommand());
            nonExecCommands.Add(builder.BuildDvarNavCommand());
            nonExecCommands.Add(builder.BuildDvarPNavCommand());
            nonExecCommands.Add(builder.BuildEcma_CeilingNavCommand());
            nonExecCommands.Add(builder.BuildEdateNavCommand());
            nonExecCommands.Add(builder.BuildEffectNavCommand());
            nonExecCommands.Add(builder.BuildEoMonthNavCommand());
            nonExecCommands.Add(builder.BuildErf_PreciseNavCommand());
            nonExecCommands.Add(builder.BuildErfC_PreciseNavCommand());
            nonExecCommands.Add(builder.BuildErfCNavCommand());
            nonExecCommands.Add(builder.BuildErfNavCommand());
            nonExecCommands.Add(builder.BuildError_TypeNavCommand());
            nonExecCommands.Add(builder.BuildEvenNavCommand());
            nonExecCommands.Add(builder.BuildExactNavCommand());
            nonExecCommands.Add(builder.BuildExpNavCommand());
            nonExecCommands.Add(builder.BuildExpon_DistNavCommand());
            nonExecCommands.Add(builder.BuildF_Dist_RTNavCommand());
            nonExecCommands.Add(builder.BuildF_DistNavCommand());
            nonExecCommands.Add(builder.BuildF_Inv_RTNavCommand());
            nonExecCommands.Add(builder.BuildF_InvNavCommand());
            nonExecCommands.Add(builder.BuildFactDoubleNavCommand());
            nonExecCommands.Add(builder.BuildFactNavCommand());
            nonExecCommands.Add(builder.BuildFalseNavCommand());
            nonExecCommands.Add(builder.BuildFindBNavCommand());
            nonExecCommands.Add(builder.BuildFindNavCommand());
            nonExecCommands.Add(builder.BuildFisherInvNavCommand());
            nonExecCommands.Add(builder.BuildFisherNavCommand());
            nonExecCommands.Add(builder.BuildFixedNavCommand());
            nonExecCommands.Add(builder.BuildFloor_MathNavCommand());
            nonExecCommands.Add(builder.BuildFloor_PreciseNavCommand());
            nonExecCommands.Add(builder.BuildFvNavCommand());
            nonExecCommands.Add(builder.BuildFvscheduleNavCommand());
            nonExecCommands.Add(builder.BuildGamma_DistNavCommand());
            nonExecCommands.Add(builder.BuildGamma_InvNavCommand());
            nonExecCommands.Add(builder.BuildGammaLn_PreciseNavCommand());
            nonExecCommands.Add(builder.BuildGammaLnNavCommand());
            nonExecCommands.Add(builder.BuildGammaNavCommand());
            nonExecCommands.Add(builder.BuildGaussNavCommand());
            nonExecCommands.Add(builder.BuildGcdNavCommand());
            nonExecCommands.Add(builder.BuildGeoMeanNavCommand());
            nonExecCommands.Add(builder.BuildGeStepNavCommand());
            execCommands.Add(builder.BuildGetCommand());
            nonExecCommands.Add(builder.BuildHarMeanNavCommand());
            nonExecCommands.Add(builder.BuildHex2BinNavCommand());
            nonExecCommands.Add(builder.BuildHex2DecNavCommand());
            nonExecCommands.Add(builder.BuildHex2OctNavCommand());
            nonExecCommands.Add(builder.BuildHlookupNavCommand());
            nonExecCommands.Add(builder.BuildHourNavCommand());
            nonExecCommands.Add(builder.BuildHyperlinkNavCommand());
            nonExecCommands.Add(builder.BuildHypGeom_DistNavCommand());
            nonExecCommands.Add(builder.BuildIfNavCommand());
            nonExecCommands.Add(builder.BuildImAbsNavCommand());
            nonExecCommands.Add(builder.BuildImaginaryNavCommand());
            nonExecCommands.Add(builder.BuildImArgumentNavCommand());
            nonExecCommands.Add(builder.BuildImConjugateNavCommand());
            nonExecCommands.Add(builder.BuildImCoshNavCommand());
            nonExecCommands.Add(builder.BuildImCosNavCommand());
            nonExecCommands.Add(builder.BuildImCotNavCommand());
            nonExecCommands.Add(builder.BuildImCschNavCommand());
            nonExecCommands.Add(builder.BuildImCscNavCommand());
            nonExecCommands.Add(builder.BuildImDivNavCommand());
            nonExecCommands.Add(builder.BuildImExpNavCommand());
            nonExecCommands.Add(builder.BuildImLnNavCommand());
            nonExecCommands.Add(builder.BuildImLog10NavCommand());
            nonExecCommands.Add(builder.BuildImLog2NavCommand());
            nonExecCommands.Add(builder.BuildImPowerNavCommand());
            nonExecCommands.Add(builder.BuildImProductNavCommand());
            nonExecCommands.Add(builder.BuildImRealNavCommand());
            nonExecCommands.Add(builder.BuildImSechNavCommand());
            nonExecCommands.Add(builder.BuildImSecNavCommand());
            nonExecCommands.Add(builder.BuildImSinhNavCommand());
            nonExecCommands.Add(builder.BuildImSinNavCommand());
            nonExecCommands.Add(builder.BuildImSqrtNavCommand());
            nonExecCommands.Add(builder.BuildImSubNavCommand());
            nonExecCommands.Add(builder.BuildImSumNavCommand());
            nonExecCommands.Add(builder.BuildImTanNavCommand());
            nonExecCommands.Add(builder.BuildIntNavCommand());
            nonExecCommands.Add(builder.BuildIntRateNavCommand());
            nonExecCommands.Add(builder.BuildIpmtNavCommand());
            nonExecCommands.Add(builder.BuildIrrNavCommand());
            nonExecCommands.Add(builder.BuildIsErrNavCommand());
            nonExecCommands.Add(builder.BuildIsErrorNavCommand());
            nonExecCommands.Add(builder.BuildIsEvenNavCommand());
            nonExecCommands.Add(builder.BuildIsFormulaNavCommand());
            nonExecCommands.Add(builder.BuildIsLogicalNavCommand());
            nonExecCommands.Add(builder.BuildIsNANavCommand());
            nonExecCommands.Add(builder.BuildIsNonTextNavCommand());
            nonExecCommands.Add(builder.BuildIsNumberNavCommand());
            nonExecCommands.Add(builder.BuildIso_CeilingNavCommand());
            nonExecCommands.Add(builder.BuildIsOddNavCommand());
            nonExecCommands.Add(builder.BuildIsoWeekNumNavCommand());
            nonExecCommands.Add(builder.BuildIspmtNavCommand());
            nonExecCommands.Add(builder.BuildIsrefNavCommand());
            nonExecCommands.Add(builder.BuildIsTextNavCommand());
            nonExecCommands.Add(builder.BuildKurtNavCommand());
            nonExecCommands.Add(builder.BuildLargeNavCommand());
            nonExecCommands.Add(builder.BuildLcmNavCommand());
            nonExecCommands.Add(builder.BuildLeftbNavCommand());
            nonExecCommands.Add(builder.BuildLeftNavCommand());
            nonExecCommands.Add(builder.BuildLenbNavCommand());
            nonExecCommands.Add(builder.BuildLenNavCommand());
            nonExecCommands.Add(builder.BuildLnNavCommand());
            nonExecCommands.Add(builder.BuildLog10NavCommand());
            nonExecCommands.Add(builder.BuildLogNavCommand());
            nonExecCommands.Add(builder.BuildLogNorm_DistNavCommand());
            nonExecCommands.Add(builder.BuildLogNorm_InvNavCommand());
            nonExecCommands.Add(builder.BuildLookupNavCommand());
            nonExecCommands.Add(builder.BuildLowerNavCommand());
            nonExecCommands.Add(builder.BuildMatchNavCommand());
            nonExecCommands.Add(builder.BuildMaxANavCommand());
            nonExecCommands.Add(builder.BuildMaxNavCommand());
            nonExecCommands.Add(builder.BuildMdurationNavCommand());
            nonExecCommands.Add(builder.BuildMedianNavCommand());
            nonExecCommands.Add(builder.BuildMidbNavCommand());
            nonExecCommands.Add(builder.BuildMidNavCommand());
            nonExecCommands.Add(builder.BuildMinANavCommand());
            nonExecCommands.Add(builder.BuildMinNavCommand());
            nonExecCommands.Add(builder.BuildMinuteNavCommand());
            nonExecCommands.Add(builder.BuildMirrNavCommand());
            nonExecCommands.Add(builder.BuildModNavCommand());
            nonExecCommands.Add(builder.BuildMonthNavCommand());
            nonExecCommands.Add(builder.BuildMroundNavCommand());
            nonExecCommands.Add(builder.BuildMultiNomialNavCommand());
            nonExecCommands.Add(builder.BuildNaNavCommand());
            nonExecCommands.Add(builder.BuildNegBinom_DistNavCommand());
            nonExecCommands.Add(builder.BuildNetworkDays_IntlNavCommand());
            nonExecCommands.Add(builder.BuildNetworkDaysNavCommand());
            nonExecCommands.Add(builder.BuildNNavCommand());
            nonExecCommands.Add(builder.BuildNominalNavCommand());
            nonExecCommands.Add(builder.BuildNorm_DistNavCommand());
            nonExecCommands.Add(builder.BuildNorm_InvNavCommand());
            nonExecCommands.Add(builder.BuildNorm_S_DistNavCommand());
            nonExecCommands.Add(builder.BuildNorm_S_InvNavCommand());
            nonExecCommands.Add(builder.BuildNotNavCommand());
            nonExecCommands.Add(builder.BuildNowNavCommand());
            nonExecCommands.Add(builder.BuildNperNavCommand());
            nonExecCommands.Add(builder.BuildNpvNavCommand());
            nonExecCommands.Add(builder.BuildNumberValueNavCommand());
            nonExecCommands.Add(builder.BuildOct2BinNavCommand());
            nonExecCommands.Add(builder.BuildOct2DecNavCommand());
            nonExecCommands.Add(builder.BuildOct2HexNavCommand());
            nonExecCommands.Add(builder.BuildOddFPriceNavCommand());
            nonExecCommands.Add(builder.BuildOddFYieldNavCommand());
            nonExecCommands.Add(builder.BuildOddLPriceNavCommand());
            nonExecCommands.Add(builder.BuildOddLYieldNavCommand());
            nonExecCommands.Add(builder.BuildOddNavCommand());
            nonExecCommands.Add(builder.BuildOrNavCommand());
            execCommands.Add(builder.BuildPatchCommand());
            nonExecCommands.Add(builder.BuildPdurationNavCommand());
            nonExecCommands.Add(builder.BuildPercentile_ExcNavCommand());
            nonExecCommands.Add(builder.BuildPercentile_IncNavCommand());
            nonExecCommands.Add(builder.BuildPercentRank_ExcNavCommand());
            nonExecCommands.Add(builder.BuildPercentRank_IncNavCommand());
            nonExecCommands.Add(builder.BuildPermutationaNavCommand());
            nonExecCommands.Add(builder.BuildPermutNavCommand());
            nonExecCommands.Add(builder.BuildPhiNavCommand());
            nonExecCommands.Add(builder.BuildPiNavCommand());
            nonExecCommands.Add(builder.BuildPmtNavCommand());
            nonExecCommands.Add(builder.BuildPoisson_DistNavCommand());
            nonExecCommands.Add(builder.BuildPowerNavCommand());
            nonExecCommands.Add(builder.BuildPpmtNavCommand());
            nonExecCommands.Add(builder.BuildPriceDiscNavCommand());
            nonExecCommands.Add(builder.BuildPriceMatNavCommand());
            nonExecCommands.Add(builder.BuildPriceNavCommand());
            nonExecCommands.Add(builder.BuildProductNavCommand());
            nonExecCommands.Add(builder.BuildProperNavCommand());
            nonExecCommands.Add(builder.BuildPvNavCommand());
            nonExecCommands.Add(builder.BuildQuartile_ExcNavCommand());
            nonExecCommands.Add(builder.BuildQuartile_IncNavCommand());
            nonExecCommands.Add(builder.BuildQuotientNavCommand());
            nonExecCommands.Add(builder.BuildRadiansNavCommand());
            nonExecCommands.Add(builder.BuildRandBetweenNavCommand());
            nonExecCommands.Add(builder.BuildRandNavCommand());
            nonExecCommands.Add(builder.BuildRank_AvgNavCommand());
            nonExecCommands.Add(builder.BuildRank_EqNavCommand());
            nonExecCommands.Add(builder.BuildRateNavCommand());
            nonExecCommands.Add(builder.BuildReceivedNavCommand());
            nonExecCommands.Add(builder.BuildReplaceBNavCommand());
            nonExecCommands.Add(builder.BuildReplaceNavCommand());
            nonExecCommands.Add(builder.BuildReptNavCommand());
            nonExecCommands.Add(builder.BuildRightbNavCommand());
            nonExecCommands.Add(builder.BuildRightNavCommand());
            nonExecCommands.Add(builder.BuildRomanNavCommand());
            nonExecCommands.Add(builder.BuildRoundDownNavCommand());
            nonExecCommands.Add(builder.BuildRoundNavCommand());
            nonExecCommands.Add(builder.BuildRoundUpNavCommand());
            nonExecCommands.Add(builder.BuildRowsNavCommand());
            nonExecCommands.Add(builder.BuildRriNavCommand());
            nonExecCommands.Add(builder.BuildSechNavCommand());
            nonExecCommands.Add(builder.BuildSecNavCommand());
            nonExecCommands.Add(builder.BuildSecondNavCommand());
            nonExecCommands.Add(builder.BuildSeriesSumNavCommand());
            nonExecCommands.Add(builder.BuildSheetNavCommand());
            nonExecCommands.Add(builder.BuildSheetsNavCommand());
            nonExecCommands.Add(builder.BuildSignNavCommand());
            nonExecCommands.Add(builder.BuildSinhNavCommand());
            nonExecCommands.Add(builder.BuildSinNavCommand());
            nonExecCommands.Add(builder.BuildSkew_pNavCommand());
            nonExecCommands.Add(builder.BuildSkewNavCommand());
            nonExecCommands.Add(builder.BuildSlnNavCommand());
            nonExecCommands.Add(builder.BuildSmallNavCommand());
            nonExecCommands.Add(builder.BuildSqrtNavCommand());
            nonExecCommands.Add(builder.BuildSqrtPiNavCommand());
            nonExecCommands.Add(builder.BuildStandardizeNavCommand());
            nonExecCommands.Add(builder.BuildStDev_PNavCommand());
            nonExecCommands.Add(builder.BuildStDev_SNavCommand());
            nonExecCommands.Add(builder.BuildStDevANavCommand());
            nonExecCommands.Add(builder.BuildStDevPANavCommand());
            nonExecCommands.Add(builder.BuildSubstituteNavCommand());
            nonExecCommands.Add(builder.BuildSubtotalNavCommand());
            nonExecCommands.Add(builder.BuildSumIfNavCommand());
            nonExecCommands.Add(builder.BuildSumIfsNavCommand());
            nonExecCommands.Add(builder.BuildSumNavCommand());
            nonExecCommands.Add(builder.BuildSumSqNavCommand());
            nonExecCommands.Add(builder.BuildSydNavCommand());
            nonExecCommands.Add(builder.BuildT_Dist_2TNavCommand());
            nonExecCommands.Add(builder.BuildT_Dist_RTNavCommand());
            nonExecCommands.Add(builder.BuildT_DistNavCommand());
            nonExecCommands.Add(builder.BuildT_Inv_2TNavCommand());
            nonExecCommands.Add(builder.BuildT_InvNavCommand());
            nonExecCommands.Add(builder.BuildTanhNavCommand());
            nonExecCommands.Add(builder.BuildTanNavCommand());
            nonExecCommands.Add(builder.BuildTbillEqNavCommand());
            nonExecCommands.Add(builder.BuildTbillPriceNavCommand());
            nonExecCommands.Add(builder.BuildTbillYieldNavCommand());
            nonExecCommands.Add(builder.BuildTextNavCommand());
            nonExecCommands.Add(builder.BuildTimeNavCommand());
            nonExecCommands.Add(builder.BuildTimevalueNavCommand());
            nonExecCommands.Add(builder.BuildTNavCommand());
            nonExecCommands.Add(builder.BuildTodayNavCommand());
            nonExecCommands.Add(builder.BuildTrimMeanNavCommand());
            nonExecCommands.Add(builder.BuildTrimNavCommand());
            nonExecCommands.Add(builder.BuildTrueNavCommand());
            nonExecCommands.Add(builder.BuildTruncNavCommand());
            nonExecCommands.Add(builder.BuildTypeNavCommand());
            nonExecCommands.Add(builder.BuildUnicharNavCommand());
            nonExecCommands.Add(builder.BuildUnicodeNavCommand());
            nonExecCommands.Add(builder.BuildUpperNavCommand());
            nonExecCommands.Add(builder.BuildUsdollarNavCommand());
            nonExecCommands.Add(builder.BuildValueNavCommand());
            nonExecCommands.Add(builder.BuildVar_PNavCommand());
            nonExecCommands.Add(builder.BuildVar_SNavCommand());
            nonExecCommands.Add(builder.BuildVarANavCommand());
            nonExecCommands.Add(builder.BuildVarPANavCommand());
            nonExecCommands.Add(builder.BuildVdbNavCommand());
            nonExecCommands.Add(builder.BuildVlookupNavCommand());
            nonExecCommands.Add(builder.BuildWeekdayNavCommand());
            nonExecCommands.Add(builder.BuildWeekNumNavCommand());
            nonExecCommands.Add(builder.BuildWeibull_DistNavCommand());
            nonExecCommands.Add(builder.BuildWorkDay_IntlNavCommand());
            nonExecCommands.Add(builder.BuildWorkDayNavCommand());
            nonExecCommands.Add(builder.BuildXirrNavCommand());
            nonExecCommands.Add(builder.BuildXnpvNavCommand());
            nonExecCommands.Add(builder.BuildXorNavCommand());
            nonExecCommands.Add(builder.BuildYearFracNavCommand());
            nonExecCommands.Add(builder.BuildYearNavCommand());
            nonExecCommands.Add(builder.BuildYieldDiscNavCommand());
            nonExecCommands.Add(builder.BuildYieldMatNavCommand());
            nonExecCommands.Add(builder.BuildYieldNavCommand());
            nonExecCommands.Add(builder.BuildZ_TestNavCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            foreach (var cmd in nonExecCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet&apos;s contents. Nullable.
        /// </summary>
        public Command BuildGetCommand() {
            var command = new Command("get");
            command.Description = "For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.";
            var driveIdOption = new Option<string>("--drive-id", description: "The unique identifier of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "The unique identifier of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
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
                var driveId = invocationContext.ParseResult.GetValueForOption(driveIdOption);
                var driveItemId = invocationContext.ParseResult.GetValueForOption(driveItemIdOption);
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
                if (driveId is not null) requestInfo.PathParameters.Add("drive%2Did", driveId);
                if (driveItemId is not null) requestInfo.PathParameters.Add("driveItem%2Did", driveItemId);
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
        /// Provides operations to manage the names property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildNamesNavCommand() {
            var command = new Command("names");
            command.Description = "Provides operations to manage the names property of the microsoft.graph.workbook entity.";
            var builder = new NamesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAddFormulaLocalNavCommand());
            nonExecCommands.Add(builder.BuildAddNavCommand());
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
        /// Provides operations to manage the operations property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildOperationsNavCommand() {
            var command = new Command("operations");
            command.Description = "Provides operations to manage the operations property of the microsoft.graph.workbook entity.";
            var builder = new OperationsRequestBuilder(PathParameters);
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
        /// Update the navigation property workbook in drives
        /// </summary>
        public Command BuildPatchCommand() {
            var command = new Command("patch");
            command.Description = "Update the navigation property workbook in drives";
            var driveIdOption = new Option<string>("--drive-id", description: "The unique identifier of drive") {
            };
            driveIdOption.IsRequired = true;
            command.AddOption(driveIdOption);
            var driveItemIdOption = new Option<string>("--drive-item-id", description: "The unique identifier of driveItem") {
            };
            driveItemIdOption.IsRequired = true;
            command.AddOption(driveItemIdOption);
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
                var driveId = invocationContext.ParseResult.GetValueForOption(driveIdOption);
                var driveItemId = invocationContext.ParseResult.GetValueForOption(driveItemIdOption);
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
                var model = parseNode.GetObjectValue<ApiSdk.Models.Workbook>(ApiSdk.Models.Workbook.CreateFromDiscriminatorValue);
                if (model is null) return; // Cannot create a POST request from a null model.
                var requestInfo = ToPatchRequestInformation(model, q => {
                });
                if (driveId is not null) requestInfo.PathParameters.Add("drive%2Did", driveId);
                if (driveItemId is not null) requestInfo.PathParameters.Add("driveItem%2Did", driveItemId);
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
        /// Provides operations to call the refreshSession method.
        /// </summary>
        public Command BuildRefreshSessionNavCommand() {
            var command = new Command("refresh-session");
            command.Description = "Provides operations to call the refreshSession method.";
            var builder = new RefreshSessionRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildPostCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the sessionInfoResource method.
        /// </summary>
        public Command BuildSessionInfoResourceWithKeyRbCommand() {
            var command = new Command("session-info-resource-with-key");
            command.Description = "Provides operations to call the sessionInfoResource method.";
            var builder = new SessionInfoResourceWithKeyRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to call the tableRowOperationResult method.
        /// </summary>
        public Command BuildTableRowOperationResultWithKeyRbCommand() {
            var command = new Command("table-row-operation-result-with-key");
            command.Description = "Provides operations to call the tableRowOperationResult method.";
            var builder = new TableRowOperationResultWithKeyRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            execCommands.Add(builder.BuildGetCommand());
            foreach (var cmd in execCommands)
            {
                command.AddCommand(cmd);
            }
            return command;
        }
        /// <summary>
        /// Provides operations to manage the tables property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildTablesNavCommand() {
            var command = new Command("tables");
            command.Description = "Provides operations to manage the tables property of the microsoft.graph.workbook entity.";
            var builder = new TablesRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAddNavCommand());
            nonExecCommands.Add(builder.BuildCountNavCommand());
            execCommands.Add(builder.BuildCreateCommand());
            nonExecCommands.Add(builder.BuildItemAtWithIndexRbCommand());
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
        /// Provides operations to manage the worksheets property of the microsoft.graph.workbook entity.
        /// </summary>
        public Command BuildWorksheetsNavCommand() {
            var command = new Command("worksheets");
            command.Description = "Provides operations to manage the worksheets property of the microsoft.graph.workbook entity.";
            var builder = new WorksheetsRequestBuilder(PathParameters);
            var execCommands = new List<Command>();
            var nonExecCommands = new List<Command>();
            nonExecCommands.Add(builder.BuildAddNavCommand());
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
        /// Instantiates a new WorkbookRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        public WorkbookRequestBuilder(Dictionary<string, object> pathParameters) : base("{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook{?%24select,%24expand}", pathParameters) {
        }
        /// <summary>
        /// Delete navigation property workbook for drives
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
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet&apos;s contents. Nullable.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WorkbookRequestBuilderGetQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<WorkbookRequestBuilderGetQueryParameters>> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RequestConfiguration<WorkbookRequestBuilderGetQueryParameters>();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the navigation property workbook in drives
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.Workbook body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPatchRequestInformation(ApiSdk.Models.Workbook body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default) {
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
        /// For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet&apos;s contents. Nullable.
        /// </summary>
        public class WorkbookRequestBuilderGetQueryParameters {
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
