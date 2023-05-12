// Copyright 2023 by Wolf Software e.K.
// 
// Alle Rechte vorbehalten. Die Weitergabe oder Vervielfältigung im Ganzen oder in Teilen,
// in welcher Form oder mit welchen Mitteln auch immer, elektronisch, mechanisch oder
// auf andere Weise, ist ohne die vorherige, schriftliche Zustimmung des Copyright-Inhabers verboten.
// 
// Solution           : Brewfather2Brautomat
// Projekt            : Brewfather2Brautomat
// Dateiname          : Brewfather3Brautomat.cs
// 
// Erstellt am        : 2023-05-10
// 
// =======================================================================================================================================================================
// 

using System.Security.Cryptography;
using System.Text.Json;
using System.Text.Json.Serialization;
using JensBrand.Brewfather2Brautomat.BrautomatModel;
using JensBrand.Brewfather2Brautomat.BrewfatherModel;

namespace JensBrand.Brewfather2Brautomat.Converter;

public class Brewfather2Brautomat
{
    /// <summary>
    /// Konvertiert einen Brewfather-JSON-Stream in einen Brautomat-JSON-Stream
    /// </summary>
    /// <param name="brewfatherStream"></param>
    /// <param name="brautomatStream"></param>
    /// <exception cref="ArgumentException"></exception>
    public static void Convert(Stream brewfatherStream, Stream brautomatStream)
    {
        Recipe? brewfatherRecipe = JsonSerializer.Deserialize<Recipe>(brewfatherStream);

        if (brewfatherRecipe == null)
        {
            throw new ArgumentException("Brewfather-Datei kann nicht deserialisiert werden!");
        }

        var rezept = new Rezept();
        rezept.Sud = GetSudInfos(brewfatherRecipe);
        rezept.Hopfengaben = GetHopfenGaben(brewfatherRecipe, rezept.Sud.Kochdauer);
        rezept.Rasten = GetRasten(brewfatherRecipe);

        JsonSerializer.Serialize(brautomatStream, rezept);
    }

    /// <summary>
    /// Ermittelt die Rasten aus dem Rezept
    /// </summary>
    /// <param name="brewfatherRecipe"></param>
    /// <returns></returns>
    private static List<Rast> GetRasten(Recipe brewfatherRecipe)
    {
        var rasten = new List<Rast>();
        foreach (var mashStep in brewfatherRecipe.Mash.Steps)
        {
            var rast = new Rast();
            rast.Name = mashStep.Name;
            rast.Temp = mashStep.StepTemp ?? 0;
            rast.Dauer = mashStep.StepTime ?? 0;
            rast.Mengenfaktor = 1;
            switch (mashStep.Type.ToUpper())
            {
                case "TEMPERATURE":
                    rast.Typ = RastTyp.Aufheizen;
                    break;
                case "INFUSION":
                    rast.Typ = RastTyp.Zubruehen;
                    break;
                case "DECOCTION":
                    rast.Typ = RastTyp.Dekoktion;
                    rast.TemperaturKochen = (int)(brewfatherRecipe.Equipment?.BoilTemp ?? 0);
                    rast.DauerKochen = rast.DauerKochen;
                    rast.TemperaturZusatzRast = 0;
                    rast.DauerZusatzRast = 0;
                    break;
                default:
                    rast.Typ = RastTyp.Aufheizen;
                    break;
            }

            rasten.Add(rast);
        }

        return rasten;
    }

    /// <summary>
    /// Ermittelt die allgemeinen Eigenschaften des Sudes aus dem Rezept
    /// </summary>
    /// <param name="brewfatherRecipe"></param>
    /// <returns></returns>
    private static Sud GetSudInfos(Recipe brewfatherRecipe)
    {
        var sud = new Sud();
        sud.Name = brewfatherRecipe.Name;
        sud.Kochdauer = (int)(brewfatherRecipe.BoilTime ?? 0d);
        sud.Nachisomerisierungszeit = brewfatherRecipe.Equipment.WirlpoolTime ?? 0;
        return sud;
    }

    /// <summary>
    /// Ermittelt die Hopfengaben aus dem Rezept
    /// </summary>
    /// <param name="brewfatherRecipe"></param>
    /// <param name="gesamtKochdauer"></param>
    /// <returns></returns>
    private static List<Hopfengabe> GetHopfenGaben(Recipe brewfatherRecipe, int gesamtKochdauer)
    {
        var hopfengaben = new List<Hopfengabe>();
        foreach (var hop in brewfatherRecipe.Hops)
        {
            var hopfengabe = new Hopfengabe();
            hopfengabe.Name = hop.Name;
            hopfengabe.Kochdauer = hop.Time ?? 0;

            switch (hop.Use.ToUpper())
            {
                case "FIRST WORT":
                    hopfengabe.Typ = HopfengabenTyp.Vorderwuerze;
                    hopfengabe.Kochdauer = gesamtKochdauer;
                    break;
                case "BOIL":
                    if (hopfengabe.Kochdauer == gesamtKochdauer)
                    {
                        hopfengabe.Typ = HopfengabenTyp.Kochbeginn;
                    }
                    else
                    {
                        hopfengabe.Typ = HopfengabenTyp.Kochen;
                    }
                    break;
                case "AROMA":
                    if (hopfengabe.Kochdauer == 0)
                    {
                        hopfengabe.Typ = HopfengabenTyp.Kochende;
                    }
                    else
                    {
                        hopfengabe.Typ = HopfengabenTyp.Ausschlagen;
                        hopfengabe.Kochdauer = -1 * Math.Abs(hopfengabe.Kochdauer);
                    }

                    break;
                default:
                    hopfengabe.Typ = HopfengabenTyp.Kochen;
                    break;
            }

            hopfengaben.Add(hopfengabe);
        }

        return hopfengaben;
    }
}


