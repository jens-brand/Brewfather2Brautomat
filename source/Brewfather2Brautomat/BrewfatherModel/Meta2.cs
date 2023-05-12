using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrewfatherModel;

public class Meta2
{
    [JsonPropertyName("efficiencyIsCalculated")]
    public bool? EfficiencyIsCalculated { get; set; }

    [JsonPropertyName("mashEfficiencyIsCalculated")]
    public bool? MashEfficiencyIsCalculated { get; set; }
}