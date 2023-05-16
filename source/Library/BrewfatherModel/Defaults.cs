using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.Library.BrewfatherModel;

public class Defaults
{
    [JsonPropertyName("preferred")]
    public string Preferred { get; set; }

    [JsonPropertyName("abv")]
    public string Abv { get; set; }

    [JsonPropertyName("attenuation")]
    public string Attenuation { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("grainColor")]
    public string GrainColor { get; set; }

    [JsonPropertyName("gravity")]
    public string Gravity { get; set; }

    [JsonPropertyName("ibu")]
    public string Ibu { get; set; }

    [JsonPropertyName("temp")]
    public string Temp { get; set; }

    [JsonPropertyName("volume")]
    public string Volume { get; set; }

    [JsonPropertyName("weight")]
    public string Weight { get; set; }

    [JsonPropertyName("hop")]
    public string Hop { get; set; }

    [JsonPropertyName("pressure")]
    public string Pressure { get; set; }

    [JsonPropertyName("carbonation")]
    public string Carbonation { get; set; }

    [JsonPropertyName("altitude")]
    public string Altitude { get; set; }
}