// Copyright 2023 by Wolf Software e.K.
// 
// Alle Rechte vorbehalten. Die Weitergabe oder Vervielfältigung im Ganzen oder in Teilen,
// in welcher Form oder mit welchen Mitteln auch immer, elektronisch, mechanisch oder
// auf andere Weise, ist ohne die vorherige, schriftliche Zustimmung des Copyright-Inhabers verboten.
// 
// Solution           : Brewfather2Brautomat
// Projekt            : Brewfather2Brautomat
// Dateiname          : Raste.cs
// 
// Erstellt am        : 2023-05-10
// 
// =======================================================================================================================================================================
// 

using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrautomatModel;

public class Rast
{
    /// <summary>
    /// Die Dauer der Rast in Minuten
    /// </summary>
    [JsonPropertyName("Dauer")]
    public int Dauer { get; set; }

    /// <summary>
    /// Mengenfaktor (für Dekoktion)
    /// </summary>
    [JsonPropertyName("Mengenfaktor")]
    public double Mengenfaktor { get; set; }

    /// <summary>
    /// Name der Rast
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Temperatur der Rast
    /// </summary>
    [JsonPropertyName("Temp")]
    public int Temp { get; set; }

    /// <summary>
    /// Temperatur Kochen für Dekoktion
    /// </summary>
    [JsonPropertyName("Param1")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int TemperaturKochen { get; set; }

    /// <summary>
    /// Dauer Kochen für Dekoktion
    /// </summary>
    [JsonPropertyName("Param2")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int DauerKochen { get; set; }

    /// <summary>
    /// Temperatur zusaetzliche Rast für Dekoktion
    /// </summary>
    [JsonPropertyName("Param3")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int TemperaturZusatzRast { get; set; }

    /// <summary>
    /// Dauer zusaetzliche Rast für Dekoktion
    /// </summary>
    [JsonPropertyName("Param4")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public int DauerZusatzRast { get; set; }

    /// <summary>
    /// Typ der Rast
    /// </summary>
    [JsonPropertyName("Typ")]
    public RastTyp Typ { get; set; }
    
}
