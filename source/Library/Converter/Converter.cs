// Copyright 2023 by Wolf Software e.K.
// 
// Alle Rechte vorbehalten. Die Weitergabe oder Vervielfältigung im Ganzen oder in Teilen,
// in welcher Form oder mit welchen Mitteln auch immer, elektronisch, mechanisch oder
// auf andere Weise, ist ohne die vorherige, schriftliche Zustimmung des Copyright-Inhabers verboten.
// 
// Solution           : Library
// Projekt            : Library
// Dateiname          : Brewfather3Brautomat.cs
// 
// Erstellt am        : 2023-05-10
// 
// =======================================================================================================================================================================
// 

using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Web;
using JensBrand.Brewfather2Brautomat.Library.BrautomatModel;
using JensBrand.Brewfather2Brautomat.Library.BrewfatherModel;

namespace JensBrand.Brewfather2Brautomat.Library.Converter;

public class Converter
{
    /// <summary>
    /// Konvertiert einen Brewfather-JSON-Stream in einen Brautomat-JSON-Stream
    /// </summary>
    /// <param name="brewfatherStream"></param>
    /// <param name="brautomatStream"></param>
    /// <exception cref="ArgumentException"></exception>
    public static async Task Convert(Stream brewfatherStream, Stream brautomatStream)
    {
        Recipe? brewfatherRecipe = await JsonSerializer.DeserializeAsync<Recipe>(brewfatherStream);

        if (brewfatherRecipe == null)
        {
            throw new ArgumentException("Brewfather-Datei kann nicht deserialisiert werden!");
        }

        CheckBrewFatherRecipe(brewfatherRecipe);
        
        var rezept = new Rezept();
        rezept.Sud = GetSudInfos(brewfatherRecipe);
        rezept.Hopfengaben = GetHopfenGaben(brewfatherRecipe, rezept.Sud.Kochdauer);
        rezept.Rasten = GetRasten(brewfatherRecipe);

        var options = new JsonSerializerOptions();
        options.WriteIndented = true;
        options.Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Latin1Supplement);
        await JsonSerializer.SerializeAsync(brautomatStream, rezept, options);
    }

    /// <summary>
    /// Prüft, ob das Brewfather-Rezept alle notwendigen Dinge enthält
    /// </summary>
    /// <param name="brewfatherRecipe"></param>
    private static void CheckBrewFatherRecipe(Recipe brewfatherRecipe)
    {
        if (brewfatherRecipe.Equipment == null)
        {
            throw new ArgumentException("Brewfather-Recipe: Equipment missing");
        }
        if (brewfatherRecipe.Hops == null)
        {
            throw new ArgumentException("Brewfather-Recipe: Hops missing");
        }
        if (brewfatherRecipe.Mash == null)
        {
            throw new ArgumentException("Brewfather-Recipe: Mash missing");
        }
        if (brewfatherRecipe.Mash.Steps == null)
        {
            throw new ArgumentException("Brewfather-Recipe: MashSteps missing");
        }
        if (brewfatherRecipe.Equipment == null)
        {
            throw new ArgumentException("Brewfather-Recipe: Equipment is missing");
        }
        if (brewfatherRecipe.Equipment == null)
        {
            throw new ArgumentException("Brewfather-Recipe: Equipment is missing");
        }
    }

    /// <summary>
    /// Ermittelt die Rasten aus dem Rezept
    /// </summary>
    /// <param name="brewfatherRecipe"></param>
    /// <returns></returns>
    private static List<Rast> GetRasten(Recipe brewfatherRecipe)
    {
        var rasten = new List<Rast>();
        if (!brewfatherRecipe.Mash.Steps.Any())
        {
            return rasten;
        }
        
        // zuerst eine Einmaische-Rast suchen und wenn nicht gefunden hinzufügen
        var firstStep = brewfatherRecipe.Mash.Steps[0];
        var einmaischeStepGefunden = false;
        if (firstStep.Name.Equals("Einmaischen", StringComparison.InvariantCultureIgnoreCase))
        {
            einmaischeStepGefunden = true;
        }
        else
        {
            if ( brewfatherRecipe.Mash.Steps.Count > 1)
            {
                var secondStep = brewfatherRecipe.Mash.Steps[1];
                if (secondStep.StepTemp < firstStep.StepTemp)
                {
                    einmaischeStepGefunden = true;
                }
            }
        }

        if (!einmaischeStepGefunden)
        {
            var rast = new Rast();
            rast.Name = "Einmaischen";
            rast.Temp = (firstStep.StepTemp ?? 0) + 2;
            rast.Dauer = 1;
            rast.Mengenfaktor = 1;
            rast.Typ = RastTyp.Aufheizen;
            rasten.Add(rast);
        }
        

        foreach (var mashStep in brewfatherRecipe.Mash.Steps)
        {
            var rast = new Rast();
            rast.Name = HttpUtility.UrlDecode(mashStep.Name);
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
                    rast.Mengenfaktor = 0.5;
                    rast.DauerKochen = mashStep.RampTime ?? 0;
                    rast.TemperaturZusatzRast = 72;
                    rast.DauerZusatzRast = 10;
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
        sud.Name = HttpUtility.UrlDecode(brewfatherRecipe.Name);
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
            hopfengabe.Name = HttpUtility.UrlDecode(hop.Name);
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
                    continue;
            }

            hopfengaben.Add(hopfengabe);
        }

        return hopfengaben;
    }
}


