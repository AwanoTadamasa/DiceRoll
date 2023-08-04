using Newtonsoft.Json;

namespace DiceRoll02.helper;

internal static class HistoryToJsonIOHelper
{
    public static void ExpotJson(List<string[]> strings, string filePath)
    {
        var output = JsonConvert.SerializeObject(strings);
        System.Diagnostics.Debug.WriteLine(output);

        using var writer = new StreamWriter(filePath, false);
        writer.Write(output);
    }

    public static List<string[]>? ImpotJson(string filePath)
    {
        string? str = null;
        if (File.Exists(filePath))
        {
            using var reader = new StreamReader(filePath);
            str = reader.ReadToEnd();
        }

        if (str == null)
        {
            return null;
        }
        else
        {
            return JsonConvert.DeserializeObject<List<string[]>>(str);
        }
    }

    public static bool IsThere(string filePath)
    {
        return File.Exists(filePath);
    }

    public static void DeleteFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
    }
}
