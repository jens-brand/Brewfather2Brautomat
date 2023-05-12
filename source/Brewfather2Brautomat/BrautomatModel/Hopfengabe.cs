// Copyright 2023 by Wolf Software e.K.
// 
// Alle Rechte vorbehalten. Die Weitergabe oder Vervielfältigung im Ganzen oder in Teilen,
// in welcher Form oder mit welchen Mitteln auch immer, elektronisch, mechanisch oder
// auf andere Weise, ist ohne die vorherige, schriftliche Zustimmung des Copyright-Inhabers verboten.
// 
// Solution           : Brewfather2Brautomat
// Projekt            : Brewfather2Brautomat
// Dateiname          : Hopfengabe.cs
// 
// Erstellt am        : 2023-05-10
// 
// =======================================================================================================================================================================
// 

using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrautomatModel;

public class Hopfengabe
{
    /// <summary>
    /// Name der Hopfengabe
    /// </summary>
    [JsonPropertyName("Name")]
    public string Name { get; set; }

    /// <summary>
    /// Typ der Hopfengabe
    /// </summary>
    [JsonPropertyName("Vorderwuerze")]
    public HopfengabenTyp Typ { get; set; }

    /// <summary>
    /// Die Kochdauer
    /// </summary>
    [JsonPropertyName("Zeit")]
    public int Kochdauer { get; set; }
}
