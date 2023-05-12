using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrewfatherModel;

public class WaterProfile
{
    [JsonPropertyName("sulfate")]
    public double? Sulfate { get; set; }

    [JsonPropertyName("chloride")]
    public double? Chloride { get; set; }

    [JsonPropertyName("bicarbonate")]
    public double? Bicarbonate { get; set; }

    [JsonPropertyName("_created")]
    public Created Created { get; set; }

    [JsonPropertyName("_timestamp_ms")]
    public long? TimestampMs { get; set; }

    [JsonPropertyName("sodium")]
    public double? Sodium { get; set; }

    [JsonPropertyName("residualAlkalinity")]
    public double? ResidualAlkalinity { get; set; }

    [JsonPropertyName("cations")]
    public double? Cations { get; set; }

    [JsonPropertyName("ionBalance")]
    public double? IonBalance { get; set; }

    [JsonPropertyName("residualAlkalinityMeqLCalc")]
    public double? ResidualAlkalinityMeqLCalc { get; set; }

    [JsonPropertyName("_timestamp")]
    public Timestamp Timestamp { get; set; }

    [JsonPropertyName("ph")]
    public double? Ph { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("ionBalanceOff")]
    public bool? IonBalanceOff { get; set; }

    [JsonPropertyName("anions")]
    public double? Anions { get; set; }

    [JsonPropertyName("hardness")]
    public double? Hardness { get; set; }

    [JsonPropertyName("calcium")]
    public double? Calcium { get; set; }

    [JsonPropertyName("soClRatio")]
    public double? SoClRatio { get; set; }

    [JsonPropertyName("hidden")]
    public bool? Hidden { get; set; }

    [JsonPropertyName("_version")]
    public string Version { get; set; }

    [JsonPropertyName("alkalinity")]
    public double? Alkalinity { get; set; }

    [JsonPropertyName("bicarbonateMeqL")]
    public double? BicarbonateMeqL { get; set; }

    [JsonPropertyName("magnesium")]
    public double? Magnesium { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("_id")]
    public string Id { get; set; }
}