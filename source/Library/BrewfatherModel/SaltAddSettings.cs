using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.Library.BrewfatherModel;

public class SaltAddSettings
{
    [JsonPropertyName("sparge")]
    public bool? Sparge { get; set; }

    [JsonPropertyName("form")]
    public string Form { get; set; }

    [JsonPropertyName("auto")]
    public bool? Auto { get; set; }

    [JsonPropertyName("mash")]
    public bool? Mash { get; set; }
}