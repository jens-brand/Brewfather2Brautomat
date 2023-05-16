using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.Library.BrewfatherModel;

public class Fermentable
{
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("lovibond")]
    public double? Lovibond { get; set; }

    [JsonPropertyName("_timestamp_ms")]
    public object TimestampMs { get; set; }

    [JsonPropertyName("color")]
    public double? Color { get; set; }

    [JsonPropertyName("lotNumber")]
    public string LotNumber { get; set; }

    [JsonPropertyName("usedIn")]
    public string UsedIn { get; set; }

    [JsonPropertyName("_version")]
    public string Version { get; set; }

    [JsonPropertyName("grainCategory")]
    public string GrainCategory { get; set; }

    [JsonPropertyName("fgdb")]
    public object Fgdb { get; set; }

    [JsonPropertyName("substitutes")]
    public string Substitutes { get; set; }

    [JsonPropertyName("bestBeforeDate")]
    public long? BestBeforeDate { get; set; }

    [JsonPropertyName("_timestamp")]
    public Timestamp Timestamp { get; set; }

    [JsonPropertyName("hidden")]
    public bool? Hidden { get; set; }

    [JsonPropertyName("notFermentable")]
    public bool? NotFermentable { get; set; }

    [JsonPropertyName("userNotes")]
    public string UserNotes { get; set; }

    [JsonPropertyName("attenuation")]
    public double? Attenuation { get; set; }

    [JsonPropertyName("origin")]
    public string Origin { get; set; }

    [JsonPropertyName("potential")]
    public double? Potential { get; set; }

    [JsonPropertyName("maxInBatch")]
    public double? MaxInBatch { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("friability")]
    public object Friability { get; set; }

    [JsonPropertyName("amount")]
    public double? Amount { get; set; }

    [JsonPropertyName("cgdb")]
    public object Cgdb { get; set; }

    [JsonPropertyName("inventory")]
    public double? Inventory { get; set; }

    [JsonPropertyName("coarseFineDiff")]
    public double? CoarseFineDiff { get; set; }

    [JsonPropertyName("notes")]
    public string Notes { get; set; }

    [JsonPropertyName("fan")]
    public object Fan { get; set; }

    [JsonPropertyName("moisture")]
    public double? Moisture { get; set; }

    [JsonPropertyName("costPerAmount")]
    public object CostPerAmount { get; set; }

    [JsonPropertyName("supplier")]
    public string Supplier { get; set; }

    [JsonPropertyName("ibuPerAmount")]
    public double? IbuPerAmount { get; set; }

    [JsonPropertyName("acid")]
    public double? Acid { get; set; }

    [JsonPropertyName("protein")]
    public double? Protein { get; set; }

    [JsonPropertyName("diastaticPower")]
    public double? DiastaticPower { get; set; }

    [JsonPropertyName("_created")]
    public Created Created { get; set; }

    [JsonPropertyName("potentialPercentage")]
    public double? PotentialPercentage { get; set; }

    [JsonPropertyName("manufacturingDate")]
    public object ManufacturingDate { get; set; }

    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("_parent")]
    public string Parent { get; set; }
}