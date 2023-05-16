using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.Library.BrewfatherModel;

public class Equipment
{
    [JsonPropertyName("calcAromaHopUtilization")]
    public bool? CalcAromaHopUtilization { get; set; }

    [JsonPropertyName("calcBoilVolume")]
    public bool? CalcBoilVolume { get; set; }

    [JsonPropertyName("hopUtilization")]
    public int? HopUtilization { get; set; }

    [JsonPropertyName("waterGrainRatio")]
    public int? WaterGrainRatio { get; set; }

    [JsonPropertyName("_meta")]
    public Meta Meta { get; set; }

    [JsonPropertyName("_created")]
    public Created Created { get; set; }

    [JsonPropertyName("evaporationRate")]
    public double? EvaporationRate { get; set; }

    [JsonPropertyName("fermenterVolumeBeforeTopUp")]
    public int? FermenterVolumeBeforeTopUp { get; set; }

    [JsonPropertyName("mashEfficiency")]
    public double? MashEfficiency { get; set; }

    [JsonPropertyName("boilSize")]
    public double? BoilSize { get; set; }

    [JsonPropertyName("spargeWaterOverflow")]
    public string SpargeWaterOverflow { get; set; }

    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("boilTime")]
    public int? BoilTime { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("mashWaterFormula")]
    public string MashWaterFormula { get; set; }

    [JsonPropertyName("fermenterLossEstimate")]
    public int? FermenterLossEstimate { get; set; }

    [JsonPropertyName("fermenterLoss")]
    public int? FermenterLoss { get; set; }

    [JsonPropertyName("grainAbsorptionRate")]
    public double? GrainAbsorptionRate { get; set; }

    [JsonPropertyName("efficiencyType")]
    public string EfficiencyType { get; set; }

    [JsonPropertyName("bottlingVolume")]
    public int? BottlingVolume { get; set; }

    [JsonPropertyName("calcStrikeWaterTemperature")]
    public bool? CalcStrikeWaterTemperature { get; set; }

    [JsonPropertyName("spargeWaterFormula")]
    public string SpargeWaterFormula { get; set; }

    [JsonPropertyName("altitudeAdjustment")]
    public bool? AltitudeAdjustment { get; set; }

    [JsonPropertyName("fermenterVolume")]
    public int? FermenterVolume { get; set; }

    [JsonPropertyName("aromaHopUtilization")]
    public double? AromaHopUtilization { get; set; }

    [JsonPropertyName("mashTunLoss")]
    public int? MashTunLoss { get; set; }

    [JsonPropertyName("boilTemp")]
    public double? BoilTemp { get; set; }

    [JsonPropertyName("boilOffPerHr")]
    public int? BoilOffPerHr { get; set; }

    [JsonPropertyName("hopstandTemperature")]
    public int? HopstandTemperature { get; set; }

    [JsonPropertyName("whirlpoolTime")]
    public int? WirlpoolTime { get; set; }

    [JsonPropertyName("_version")]
    public string Version { get; set; }

    [JsonPropertyName("calcMashEfficiency")]
    public bool? CalcMashEfficiency { get; set; }

    [JsonPropertyName("_timestamp")]
    public Timestamp Timestamp { get; set; }

    [JsonPropertyName("brewhouseEfficiency")]
    public double? BrewhouseEfficiency { get; set; }

    [JsonPropertyName("mashTunDeadSpace")]
    public int? MashTunDeadSpace { get; set; }

    [JsonPropertyName("hidden")]
    public bool? Hidden { get; set; }

    [JsonPropertyName("postBoilKettleVol")]
    public double? PostBoilKettleVol { get; set; }

    [JsonPropertyName("waterCalculation")]
    public string WaterCalculation { get; set; }

    [JsonPropertyName("trubChillerLoss")]
    public int? TrubChillerLoss { get; set; }

    [JsonPropertyName("efficiency")]
    public int? Efficiency { get; set; }

    [JsonPropertyName("_timestamp_ms")]
    public long? TimestampMs { get; set; }

    [JsonPropertyName("batchSize")]
    public int? BatchSize { get; set; }

    [JsonPropertyName("altitude")]
    public int? Altitude { get; set; }
}