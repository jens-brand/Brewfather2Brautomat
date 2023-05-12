using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrewfatherModel;

public class CarbonationStyle
{
    [JsonPropertyName("carbMin")]
    public double? CarbMin { get; set; }

    [JsonPropertyName("carbMax")]
    public int? CarbMax { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}