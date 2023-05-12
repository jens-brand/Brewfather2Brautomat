// Copyright 2023 by Wolf Software e.K.
// 
// Alle Rechte vorbehalten. Die Weitergabe oder Vervielfältigung im Ganzen oder in Teilen,
// in welcher Form oder mit welchen Mitteln auch immer, elektronisch, mechanisch oder
// auf andere Weise, ist ohne die vorherige, schriftliche Zustimmung des Copyright-Inhabers verboten.
// 
// Solution           : Brewfather2Brautomat
// Projekt            : Brewfather2Brautomat
// Dateiname          : Rezept.cs
// 
// Erstellt am        : 2023-05-12
// 
// =======================================================================================================================================================================
// 

using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.BrautomatModel;

/// <summary>
/// Definiert ein Rezept im Brautomat-Format
/// Ist im Prinzip die oberste Klasse, die die Einzelteile des Rezeptes zusammenfasst
/// <see href="https://hobbybrauer.de/forum/viewtopic.php?t=31397&start=100#p495912"/>
/// </summary>
public class Rezept
{
    
    /// <summary>
    /// Allgemeine Infos zum Sud
    /// </summary>
    [JsonPropertyName("Sud")]
    public Sud Sud { get; set; }
    
    /// <summary>
    /// Die Rasten des Sudes
    /// </summary>
    [JsonPropertyName("Rasten")]
    public IEnumerable<Rast> Rasten { get; set; }
    
    /// <summary>
    /// Die Hopfengaben des Sudes
    /// </summary>
    [JsonPropertyName("Hopfengaben")]
    public IEnumerable<Hopfengabe> Hopfengaben { get; set; }
    
}
