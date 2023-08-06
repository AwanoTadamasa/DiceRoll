using DiceRoll02.type;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DiceRoll02.helper;

internal static class HistoryToJsonIOHelper
{
    //シリアライズの設定があれば追記する
    public readonly static JsonSerializerSettings serializerSettings = new()
    {
        Formatting = Formatting.None,
    };

    public static void ExpotJson(List<DiceRollHistory> strings, string filePath)
    {
        var setting = JsonSerializer.Create(serializerSettings);
        var output = JToken.FromObject(strings, setting);

        using var writer = new StreamWriter(filePath, false);
        writer.Write(output.MorphingJsonToken());
    }

    public static List<DiceRollHistory>? ImpotJson(string filePath)
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
            return JsonConvert.DeserializeObject<List<DiceRollHistory>>(str);
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
