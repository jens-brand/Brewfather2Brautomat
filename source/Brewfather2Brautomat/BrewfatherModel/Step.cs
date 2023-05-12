using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrewfatherModel;

public class Step
{
    [JsonPropertyName("displayStepTemp")]
    public int? DisplayStepTemp { get; set; }

    [JsonPropertyName("stepTemp")]
    public int? StepTemp { get; set; }

    [JsonPropertyName("stepTime")]
    public int? StepTime { get; set; }

    [JsonPropertyName("rampTime")]
    public int? RampTime { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("ramp")]
    public int? Ramp { get; set; }

    [JsonPropertyName("pressure")]
    public object Pressure { get; set; }

    [JsonPropertyName("displayPressure")]
    public object DisplayPressure { get; set; }
}