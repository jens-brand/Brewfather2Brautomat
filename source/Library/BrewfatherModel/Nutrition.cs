using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.Library.BrewfatherModel;

public class Nutrition
{
    [JsonPropertyName("calories")]
    public Calories Calories { get; set; }

    [JsonPropertyName("carbs")]
    public Carbs Carbs { get; set; }
}