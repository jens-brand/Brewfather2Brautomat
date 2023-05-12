// Copyright 2023 by Wolf Software e.K.
// 
// Alle Rechte vorbehalten. Die Weitergabe oder Vervielfältigung im Ganzen oder in Teilen,
// in welcher Form oder mit welchen Mitteln auch immer, elektronisch, mechanisch oder
// auf andere Weise, ist ohne die vorherige, schriftliche Zustimmung des Copyright-Inhabers verboten.
// 
// Solution           : Brewfather2Brautomat
// Projekt            : Brewfather2Brautomat
// Dateiname          : RastTyp.cs
// 
// Erstellt am        : 2023-05-10
// 
// =======================================================================================================================================================================
// 

namespace JensBrand.Brewfather2Brautomat.BrautomatModel;

public enum RastTyp
{
    /// <summary>
    /// 0 := Einmaischen
    /// </summary>
    Einmaischen = 0,
    
    /// <summary>
    /// 1 := Aufheizen
    /// </summary>
    Aufheizen = 1,
    
    /// <summary>
    /// 2 := Zubrühen
    /// </summary>
    Zubruehen = 2,
    
    /// <summary>
    /// 3 := Dekoktion
    /// </summary>
    Dekoktion = 3
}
