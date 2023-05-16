// See https://aka.ms/new-console-template for more information

using System.Reflection;

namespace JensBrand.Brewfather2Brautomat.ConsoleApp;

public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        var folder = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "..", "..", "..", "..", "Library", "TestFiles"));

        foreach (var file in Directory.GetFiles(folder, "*.json"))
        {
            if (file.Contains("brautomat"))
            {
                continue;
            }
            
            var brautomatFile = Path.ChangeExtension(file, ".brautomat.json");
            
            using var brewfatherStream = File.OpenRead(file);
            using var brautomatStream = File.OpenWrite(brautomatFile);
            brautomatStream.SetLength(0);
            await Library.Converter.Converter.Convert(brewfatherStream, brautomatStream);
            
            brautomatStream.Flush();
        }

        return 0; 
    }
}
