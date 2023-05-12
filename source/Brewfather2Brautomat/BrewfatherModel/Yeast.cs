using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrewfatherModel;

public class Yeast
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("amount")]
    public object Amount { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("_id")]
    public string Id { get; set; }
}