using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.Library.BrewfatherModel;

public class Hop
{
    [JsonPropertyName("farnesene")]
    public object Farnesene { get; set; }

    [JsonPropertyName("ibu")]
    public double? Ibu { get; set; }

    [JsonPropertyName("humulene")]
    public object Humulene { get; set; }

    [JsonPropertyName("usage")]
    public string Usage { get; set; }

    [JsonPropertyName("year")]
    public int? Year { get; set; }

    [JsonPropertyName("temp")]
    public object Temp { get; set; }

    [JsonPropertyName("usedIn")]
    public string UsedIn { get; set; }

    [JsonPropertyName("_version")]
    public string Version { get; set; }

    [JsonPropertyName("origin")]
    public string Origin { get; set; }

    [JsonPropertyName("inventory")]
    public double? Inventory { get; set; }

    [JsonPropertyName("cohumulone")]
    public object Cohumulone { get; set; }

    [JsonPropertyName("_timestamp")]
    public Timestamp Timestamp { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("notes")]
    public string Notes { get; set; }

    [JsonPropertyName("caryophyllene")]
    public object Caryophyllene { get; set; }

    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    [JsonPropertyName("substitutes")]
    public string Substitutes { get; set; }

    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("alpha")]
    public double? Alpha { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("userNotes")]
    public string UserNotes { get; set; }

    [JsonPropertyName("myrcene")]
    public object Myrcene { get; set; }

    [JsonPropertyName("beta")]
    public object Beta { get; set; }

    [JsonPropertyName("time")]
    public int? Time { get; set; }

    [JsonPropertyName("hidden")]
    public bool? Hidden { get; set; }

    [JsonPropertyName("manufacturingDate")]
    public object ManufacturingDate { get; set; }

    [JsonPropertyName("bestBeforeDate")]
    public object BestBeforeDate { get; set; }

    [JsonPropertyName("use")]
    public string Use { get; set; }

    [JsonPropertyName("hsi")]
    public object Hsi { get; set; }

    [JsonPropertyName("_timestamp_ms")]
    public object TimestampMs { get; set; }

    [JsonPropertyName("actualTime")]
    public object ActualTime { get; set; }

    [JsonPropertyName("oil")]
    public object Oil { get; set; }

    [JsonPropertyName("_created")]
    public Created Created { get; set; }
}