using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrewfatherModel;

public class TargetDiff
{
    [JsonPropertyName("calcium")]
    public double? Calcium { get; set; }

    [JsonPropertyName("magnesium")]
    public double? Magnesium { get; set; }

    [JsonPropertyName("sodium")]
    public double? Sodium { get; set; }

    [JsonPropertyName("chloride")]
    public double? Chloride { get; set; }

    [JsonPropertyName("sulfate")]
    public double? Sulfate { get; set; }

    [JsonPropertyName("bicarbonate")]
    public double? Bicarbonate { get; set; }

    [JsonPropertyName("bicarbonateMeqL")]
    public double? BicarbonateMeqL { get; set; }

    [JsonPropertyName("cations")]
    public double? Cations { get; set; }

    [JsonPropertyName("anions")]
    public double? Anions { get; set; }

    [JsonPropertyName("ionBalance")]
    public double? IonBalance { get; set; }

    [JsonPropertyName("ionBalanceOff")]
    public bool? IonBalanceOff { get; set; }

    [JsonPropertyName("soClRatio")]
    public double? SoClRatio { get; set; }

    [JsonPropertyName("hardness")]
    public double? Hardness { get; set; }

    [JsonPropertyName("alkalinity")]
    public double? Alkalinity { get; set; }

    [JsonPropertyName("residualAlkalinity")]
    public double? ResidualAlkalinity { get; set; }

    [JsonPropertyName("residualAlkalinityMeqLCalc")]
    public double? ResidualAlkalinityMeqLCalc { get; set; }
}