using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.Library.BrewfatherModel;

public class Water
{
    [JsonPropertyName("settings")]
    public Settings Settings { get; set; }

    [JsonPropertyName("mash")]
    public Mash Mash { get; set; }

    [JsonPropertyName("enableSpargeAdjustments")]
    public bool? EnableSpargeAdjustments { get; set; }

    [JsonPropertyName("totalAdjustments")]
    public Adjustments TotalAdjustments { get; set; }

    [JsonPropertyName("sparge")]
    public WaterProfile Sparge { get; set; }

    [JsonPropertyName("spargeAdjustments")]
    public Adjustments SpargeAdjustments { get; set; }

    [JsonPropertyName("source")]
    public WaterProfile Source { get; set; }

    [JsonPropertyName("style")]
    public string Style { get; set; }

    [JsonPropertyName("sourceTargetDiff")]
    public TargetDiff SourceTargetDiff { get; set; }

    [JsonPropertyName("target")]
    public WaterProfile Target { get; set; }

    [JsonPropertyName("enableSpargeAcidAdjustments")]
    public bool? EnableSpargeAcidAdjustments { get; set; }

    [JsonPropertyName("totalTargetDiff")]
    public TargetDiff TotalTargetDiff { get; set; }

    [JsonPropertyName("spargeTargetDiff")]
    public TargetDiff SpargeTargetDiff { get; set; }

    [JsonPropertyName("mashTargetDiff")]
    public TargetDiff MashTargetDiff { get; set; }

    [JsonPropertyName("enableAcidAdjustments")]
    public bool? EnableAcidAdjustments { get; set; }

    [JsonPropertyName("mashAdjustments")]
    public Adjustments MashAdjustments { get; set; }

    [JsonPropertyName("spargeWaterAmount")]
    public object SpargeWaterAmount { get; set; }

    [JsonPropertyName("acidPhAdjustment")]
    public double? AcidPhAdjustment { get; set; }

    [JsonPropertyName("mashPh")]
    public double? MashPh { get; set; }

    [JsonPropertyName("total")]
    public Total Total { get; set; }

    [JsonPropertyName("spargeWaterPh")]
    public double? SpargeWaterPh { get; set; }

    [JsonPropertyName("diluted")]
    public object Diluted { get; set; }

    [JsonPropertyName("mashPhDistilled")]
    public double? MashPhDistilled { get; set; }

    [JsonPropertyName("spargeWaterTargetPh")]
    public double? SpargeWaterTargetPh { get; set; }

    [JsonPropertyName("meta")]
    public Meta Meta { get; set; }

    [JsonPropertyName("mashWaterAmount")]
    public object MashWaterAmount { get; set; }

    [JsonPropertyName("spargeAcidPhAdjustment")]
    public double? SpargeAcidPhAdjustment { get; set; }

    [JsonPropertyName("dilutionPercentage")]
    public object DilutionPercentage { get; set; }
}