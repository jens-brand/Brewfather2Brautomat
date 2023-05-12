using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrewfatherModel;

public class Fermentation
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("steps")]
    public List<Step> Steps { get; set; }

    [JsonPropertyName("_id")]
    public string Id { get; set; }
}