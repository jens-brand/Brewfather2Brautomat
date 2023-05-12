using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrewfatherModel;

public class Adjustments
{
    [JsonPropertyName("volume")]
    public double? Volume { get; set; }

    [JsonPropertyName("calciumCarbonate")]
    public double? CalciumCarbonate { get; set; }

    [JsonPropertyName("sodiumBicarbonate")]
    public double? SodiumBicarbonate { get; set; }

    [JsonPropertyName("calciumHydroxide")]
    public double? CalciumHydroxide { get; set; }

    [JsonPropertyName("calciumSulfate")]
    public double? CalciumSulfate { get; set; }

    [JsonPropertyName("magnesiumSulfate")]
    public double? MagnesiumSulfate { get; set; }

    [JsonPropertyName("calciumChloride")]
    public double? CalciumChloride { get; set; }

    [JsonPropertyName("magnesiumChloride")]
    public double? MagnesiumChloride { get; set; }

    [JsonPropertyName("sodiumChloride")]
    public double? SodiumChloride { get; set; }

    [JsonPropertyName("sodiumMetabisulfite")]
    public double? SodiumMetabisulfite { get; set; }

    [JsonPropertyName("ltDWB")]
    public double? LtDWB { get; set; }

    [JsonPropertyName("ltAMS")]
    public double? LtAMS { get; set; }

    [JsonPropertyName("acids")]
    public List<Acid> Acids { get; set; }

    [JsonPropertyName("sodiumMetabisulfitePPM")]
    public double? SodiumMetabisulfitePPM { get; set; }

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
}