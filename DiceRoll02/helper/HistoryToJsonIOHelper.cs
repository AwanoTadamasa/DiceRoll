using DiceRoll02.type;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DiceRoll02.helper;

internal static class HistoryToJsonIoHelper
{
    //シリアライズの設定があれば追記する
    public static readonly JsonSerializerSettings SerializerSettings = new()
    {
        Formatting = Formatting.None,
    };

    public static void ExportJson(List<DiceRollHistory> histories, string filePath)
    {
        // TODO: try-catch
        var serializer = JsonSerializer.Create(SerializerSettings);
        var token = JToken.FromObject(histories, serializer);

        using var writer = new StreamWriter(filePath, false);
        writer.Write(token.MorphingJsonToken());
    }

    public static List<DiceRollHistory>? ImportJson(string filePath)
    {
        // TODO: try-catch
        if (!File.Exists(filePath))
        {
            return null;
        }

        using var reader = new StreamReader(filePath);
        var str = reader.ReadToEnd();

        var histories = JsonConvert.DeserializeObject<List<DiceRollHistory>>(str);
        return histories;
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
