// Copyright 2023 by Wolf Software e.K.
// 
// Alle Rechte vorbehalten. Die Weitergabe oder Vervielfältigung im Ganzen oder in Teilen,
// in welcher Form oder mit welchen Mitteln auch immer, elektronisch, mechanisch oder
// auf andere Weise, ist ohne die vorherige, schriftliche Zustimmung des Copyright-Inhabers verboten.
// 
// Solution           : Brewfather2Brautomat
// Projekt            : Brewfather2Brautomat
// Dateiname          : HopfengabenTyp.cs
// 
// Erstellt am        : 2023-05-10
// 
// =======================================================================================================================================================================
// 

namespace JensBrand.Brewfather2Brautomat.BrautomatModel;

public enum HopfengabenTyp
{
    /// <summary>
    /// identisch mit Typ 3 ->  Hopfenkochdauer kleiner Gesamtkochdauert & grösser 0
    /// </summary>
    Unbekannt = 0,
    /// <summary>
    /// 1 =: Vorderwürze -> Hopfenkochdauer = Gesamtkochdauer
    /// </summary>
    Vorderwuerze = 1,
    /// <summary>
    /// 2 =: Kochbeginn -> Hopfenkochdauer = Gesamtkochdauer
    /// </summary>
    Kochbeginn = 2,
    /// <summary>
    /// 3 =: Kochen -> identisch mit Typ 0 ->  Hopfenkochdauer kleiner Gesamtkochdauert und grösser 0
    /// </summary>
    Kochen = 3,
    /// <summary>
    /// 4 =: Kochende -> Hopfenkochdauer = 0
    /// </summary>
    Kochende = 4,
    /// <summary>
    /// 5 =: Ausschlagen -> Hopfenkochdauer kleiner 0 und grösser negative Nachisomerisierungszeit
    /// </summary>
    Ausschlagen = 5
}
