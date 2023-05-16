using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.Library.BrewfatherModel;

public class Carbs
{
    [JsonPropertyName("total")]
    public double? Total { get; set; }
}