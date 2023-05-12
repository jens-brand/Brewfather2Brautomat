using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrewfatherModel;

public class Settings
{
    [JsonPropertyName("magnesiumSulfate")]
    public SaltAddSettings MagnesiumSulfate { get; set; }

    [JsonPropertyName("calciumSulfate")]
    public SaltAddSettings CalciumSulfate { get; set; }

    [JsonPropertyName("sodiumBicarbonate")]
    public SaltAddSettings SodiumBicarbonate { get; set; }

    [JsonPropertyName("sodiumChloride")]
    public SaltAddSettings SodiumChloride { get; set; }

    [JsonPropertyName("adjustSparge")]
    public bool? AdjustSparge { get; set; }

    [JsonPropertyName("calciumHydroxide")]
    public SaltAddSettings CalciumHydroxide { get; set; }

    [JsonPropertyName("calciumChloride")]
    public SaltAddSettings CalciumChloride { get; set; }
}