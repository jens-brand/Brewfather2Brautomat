using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrewfatherModel;

public class Carbs
{
    [JsonPropertyName("total")]
    public double? Total { get; set; }
}