// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Web;
using JensBrand.Brewfather2Brautomat.BrewfatherModel;

namespace JensBrand.Brewfather2Brautomat;

public static class Program
{
    public static int Main(string[] args)
    {
        var folder = @"D:\Github\Brewfather2Brautomat\source\Brewfather2Brautomat\TestFiles\";

        foreach (var file in Directory.GetFiles(folder, "*.json"))
        {
            if (file.Contains("brautomat"))
            {
                continue;
            }
            
            var brautomatFile = Path.ChangeExtension(file, ".brautomat.json");
            
            using var brewfatherStream = File.OpenRead(file);
            using var brautomatStream = File.OpenWrite(brautomatFile);
            Converter.Brewfather2Brautomat.Convert(brewfatherStream, brautomatStream);
            
            brautomatStream.Flush();
        }

        return 0; 
    }
}