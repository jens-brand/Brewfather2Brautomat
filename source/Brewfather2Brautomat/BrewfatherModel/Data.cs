using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrewfatherModel;

public class Data
{
    [JsonPropertyName("mashFermentablesAmount")]
    public double? MashFermentablesAmount { get; set; }

    [JsonPropertyName("allDiastaticPower")]
    public bool? AllDiastaticPower { get; set; }

    [JsonPropertyName("totalDiastaticPower")]
    public double? TotalDiastaticPower { get; set; }

    [JsonPropertyName("mashFermentables")]
    public List<Fermentable> MashFermentables { get; set; }

    [JsonPropertyName("otherFermentablesAmount")]
    public double? OtherFermentablesAmount { get; set; }

    [JsonPropertyName("otherFermentables")]
    public List<object> OtherFermentables { get; set; }

    [JsonPropertyName("mashWaterAmount")]
    public double? MashWaterAmount { get; set; }

    [JsonPropertyName("spargeWaterAmount")]
    public double? SpargeWaterAmount { get; set; }

    [JsonPropertyName("mashVolumeSurplus")]
    public double? MashVolumeSurplus { get; set; }

    [JsonPropertyName("topUpWater")]
    public double? TopUpWater { get; set; }

    [JsonPropertyName("batchSpargeWaterAmount1")]
    public object BatchSpargeWaterAmount1 { get; set; }

    [JsonPropertyName("batchSpargeWaterAmount2")]
    public object BatchSpargeWaterAmount2 { get; set; }

    [JsonPropertyName("batchSpargeWaterAmount3")]
    public object BatchSpargeWaterAmount3 { get; set; }

    [JsonPropertyName("batchSpargeWaterAmount4")]
    public object BatchSpargeWaterAmount4 { get; set; }

    [JsonPropertyName("hltWaterAmount")]
    public double? HltWaterAmount { get; set; }

    [JsonPropertyName("totalWaterAmount")]
    public double? TotalWaterAmount { get; set; }

    [JsonPropertyName("hopsAmount")]
    public double? HopsAmount { get; set; }

    [JsonPropertyName("strikeTemp")]
    public object StrikeTemp { get; set; }

    [JsonPropertyName("mashVolume")]
    public double? MashVolume { get; set; }
}