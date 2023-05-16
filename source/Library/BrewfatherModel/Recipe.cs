using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.Library.BrewfatherModel;

public class Recipe
{
    [JsonPropertyName("styleFg")]
    public bool? StyleFg { get; set; }

    [JsonPropertyName("water")]
    public Water Water { get; set; }

    [JsonPropertyName("searchTags")]
    public List<string> SearchTags { get; set; }

    [JsonPropertyName("batchSize")]
    public double? BatchSize { get; set; }

    [JsonPropertyName("style")]
    public Style Style { get; set; }

    [JsonPropertyName("abv")]
    public double? Abv { get; set; }

    [JsonPropertyName("firstWortGravity")]
    public object FirstWortGravity { get; set; }

    [JsonPropertyName("yeastToleranceExceededBy")]
    public object YeastToleranceExceededBy { get; set; }

    [JsonPropertyName("styleColor")]
    public bool? StyleColor { get; set; }

    [JsonPropertyName("styleBuGu")]
    public bool? StyleBuGu { get; set; }

    [JsonPropertyName("_ev")]
    public double? Ev { get; set; }

    [JsonPropertyName("_timestamp")]
    public DateTime? Timestamp { get; set; }

    [JsonPropertyName("mash")]
    public Mash Mash { get; set; }

    [JsonPropertyName("preBoilGravity")]
    public double? PreBoilGravity { get; set; }

    [JsonPropertyName("styleOg")]
    public bool? StyleOg { get; set; }

    [JsonPropertyName("mashEfficiency")]
    public double? MashEfficiency { get; set; }

    [JsonPropertyName("ibu")]
    public double? Ibu { get; set; }

    [JsonPropertyName("color")]
    public double? Color { get; set; }

    [JsonPropertyName("yeasts")]
    public List<Yeast> Yeasts { get; set; }

    [JsonPropertyName("boilTime")]
    public double? BoilTime { get; set; }

    [JsonPropertyName("hopsTotalAmount")]
    public double? HopsTotalAmount { get; set; }

    [JsonPropertyName("_init")]
    public bool? Init { get; set; }

    [JsonPropertyName("boilSize")]
    public double? BoilSize { get; set; }

    [JsonPropertyName("og")]
    public double? Og { get; set; }

    [JsonPropertyName("primaryTemp")]
    public double? PrimaryTemp { get; set; }

    [JsonPropertyName("fermentablesTotalAmount")]
    public double? FermentablesTotalAmount { get; set; }

    [JsonPropertyName("sumDryHopPerLiter")]
    public double? SumDryHopPerLiter { get; set; }

    [JsonPropertyName("postBoilGravity")]
    public double? PostBoilGravity { get; set; }

    [JsonPropertyName("avgWeightedHopstandTemp")]
    public double? AvgWeightedHopstandTemp { get; set; }

    [JsonPropertyName("styleAbv")]
    public bool? StyleAbv { get; set; }

    [JsonPropertyName("fg")]
    public double? Fg { get; set; }

    [JsonPropertyName("_timestamp_ms")]
    public long? TimestampMs { get; set; }

    [JsonPropertyName("styleRbr")]
    public bool? StyleRbr { get; set; }

    [JsonPropertyName("_created")]
    public Created Created { get; set; }

    [JsonPropertyName("nutrition")]
    public Nutrition Nutrition { get; set; }

    [JsonPropertyName("styleIbu")]
    public bool? StyleIbu { get; set; }

    [JsonPropertyName("ogPlato")]
    public double? OgPlato { get; set; }

    [JsonPropertyName("hops")]
    public List<Hop> Hops { get; set; }

    [JsonPropertyName("_share")]
    public object Share { get; set; }

    [JsonPropertyName("styleConformity")]
    public bool? StyleConformity { get; set; }

    [JsonPropertyName("extraGravity")]
    public double? ExtraGravity { get; set; }

    [JsonPropertyName("tags")]
    public object Tags { get; set; }

    [JsonPropertyName("_type")]
    public string Type2 { get; set; }

    [JsonPropertyName("carbonation")]
    public double? Carbonation { get; set; }

    [JsonPropertyName("attenuation")]
    public double? Attenuation { get; set; }

    [JsonPropertyName("fgFormula")]
    public string FgFormula { get; set; }

    [JsonPropertyName("author")]
    public string Author { get; set; }

    [JsonPropertyName("hopStandMinutes")]
    public double? HopStandMinutes { get; set; }

    [JsonPropertyName("diastaticPower")]
    public double? DiastaticPower { get; set; }

    [JsonPropertyName("hidden")]
    public bool? Hidden { get; set; }

    [JsonPropertyName("fermentation")]
    public Fermentation Fermentation { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("efficiency")]
    public double? Efficiency { get; set; }

    [JsonPropertyName("sumAromaHopPerLiter")]
    public double? SumAromaHopPerLiter { get; set; }

    [JsonPropertyName("defaults")]
    public Defaults Defaults { get; set; }

    [JsonPropertyName("notes")]
    public string Notes { get; set; }

    [JsonPropertyName("carbonationStyle")]
    public CarbonationStyle CarbonationStyle { get; set; }

    [JsonPropertyName("fermentableIbu")]
    public double? FermentableIbu { get; set; }

    [JsonPropertyName("buGuRatio")]
    public double? BuGuRatio { get; set; }

    [JsonPropertyName("fermentables")]
    public List<Fermentable> Fermentables { get; set; }

    [JsonPropertyName("ibuFormula")]
    public string IbuFormula { get; set; }

    [JsonPropertyName("fgEstimated")]
    public double? FgEstimated { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("path")]
    public string Path { get; set; }

    [JsonPropertyName("_version")]
    public string Version { get; set; }

    [JsonPropertyName("styleCarb")]
    public bool? StyleCarb { get; set; }

    [JsonPropertyName("equipment")]
    public Equipment Equipment { get; set; }

    [JsonPropertyName("totalGravity")]
    public double? TotalGravity { get; set; }

    [JsonPropertyName("rbRatio")]
    public double? RbRatio { get; set; }

    [JsonPropertyName("data")]
    public Data Data { get; set; }

    [JsonPropertyName("_id")]
    public string Id { get; set; }

    [JsonPropertyName("miscs")]
    public List<Misc> Miscs { get; set; }
}