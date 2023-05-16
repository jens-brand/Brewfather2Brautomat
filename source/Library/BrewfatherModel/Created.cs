using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.Library.BrewfatherModel;

public class Created
{
    [JsonPropertyName("seconds")]
    public int? Seconds { get; set; }

    [JsonPropertyName("nanoseconds")]
    public int? Nanoseconds { get; set; }
}