// Copyright 2023 by Wolf Software e.K.
// 
// Alle Rechte vorbehalten. Die Weitergabe oder Vervielfältigung im Ganzen oder in Teilen,
// in welcher Form oder mit welchen Mitteln auch immer, elektronisch, mechanisch oder
// auf andere Weise, ist ohne die vorherige, schriftliche Zustimmung des Copyright-Inhabers verboten.
// 
// Solution           : Library
// Projekt            : Library
// Dateiname          : Sud.cs
// 
// Erstellt am        : 2023-05-10
// 
// =======================================================================================================================================================================
// 

using System.Text.Json.Serialization;

namespace JensBrand.Brewfather2Brautomat.Library.BrautomatModel;

public class Sud
{
    /// <summary>
    /// Name des Sudes
    /// </summary>
    [JsonPropertyName("Sudname")]
    public string Name { get; set; }

    /// <summary>
    /// Die Gesamtkochdauer des Sudes in Minuten
    /// </summary>
    [JsonPropertyName("Kochdauer")]
    public int Kochdauer { get; set; }

    /// <summary>
    /// Die Nachisomerisierungszeit des Sudes in Minuten
    /// </summary>
    [JsonPropertyName("Nachisomerisierungszeit")]
    public int Nachisomerisierungszeit { get; set; }

}
