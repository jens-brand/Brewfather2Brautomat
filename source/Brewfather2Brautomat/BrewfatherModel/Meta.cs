using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrewfatherModel;

public class Meta
{
    [JsonPropertyName("equalSourceTotal")]
    public bool? EqualSourceTotal { get; set; }
}