using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrewfatherModel;

public class Misc
{
    [JsonPropertyName("userNotes")]
    public string UserNotes { get; set; }

    [JsonPropertyName("_created")]
    public Created Created { get; set; }

    [JsonPropertyName("amountPerL")]
    public object AmountPerL { get; set; }

    [JsonPropertyName("bestBeforeDate")]
    public object BestBeforeDate { get; set; }

    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("waterAdjustment")]
    public bool? WaterAdjustment { get; set; }

    [JsonPropertyName("useFor")]
    public string UseFor { get; set; }

    [JsonPropertyName("notes")]
    public string Notes { get; set; }

    [JsonPropertyName("inventory")]
    public double? Inventory { get; set; }

    [JsonPropertyName("hidden")]
    public bool? Hidden { get; set; }

    [JsonPropertyName("_timestamp")]
    public Timestamp Timestamp { get; set; }

    [JsonPropertyName("concentration")]
    public double? Concentration { get; set; }

    [JsonPropertyName("time")]
    public object Time { get; set; }

    [JsonPropertyName("unit")]
    public string Unit { get; set; }

    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("substitutes")]
    public string Substitutes { get; set; }

    [JsonPropertyName("timeIsDays")]
    public bool? TimeIsDays { get; set; }

    [JsonPropertyName("_timestamp_ms")]
    public object TimestampMs { get; set; }

    [JsonPropertyName("use")]
    public string Use { get; set; }

    [JsonPropertyName("manufacturingDate")]
    public object ManufacturingDate { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("_version")]
    public string Version { get; set; }
}