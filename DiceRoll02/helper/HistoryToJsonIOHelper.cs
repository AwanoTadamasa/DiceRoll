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

    public static void ExportJson<T>(T histories, string filePath)
        where T : class
    {
        // DONE: try-catch
        try
        {
            var serializer = JsonSerializer.Create(SerializerSettings);
            var token = JToken.FromObject(histories, serializer);

            using var writer = new StreamWriter(filePath, false);
            writer.Write(token.ToStringIndented());
        }
        catch (Exception ex)
        {
            MessageBox.Show($"エラーが発生しました\r\n出力することができませんでした\r\n{ex}");
        }
    }

    public static T? ImportJson<T>(string filePath)
        where T : class
    {
        try
        {
            // DONE: try-catch
            if (!File.Exists(filePath))
            {
                return null;
            }

            using var reader = new StreamReader(filePath);
            var str = reader.ReadToEnd();

            var histories = JsonConvert.DeserializeObject<T>(str);
            return histories;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"エラーが発生しました\r\n読み込むことができませんでした\r\n{ex}");
            return null;
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
