using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.Library.BrewfatherModel;

public class Acid
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("concentration")]
    public int? Concentration { get; set; }

    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    [JsonPropertyName("alkalinityMeqL")]
    public double? AlkalinityMeqL { get; set; }
}