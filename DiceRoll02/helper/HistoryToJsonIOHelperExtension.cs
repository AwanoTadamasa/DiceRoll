using Newtonsoft.Json.Linq;

namespace DiceRoll02.helper;

internal static class HistoryToJsonIOHelperExtension
{
    public static string MorphingJsonToken(this JToken jsonToken)
    {
        return jsonToken.MorphingJsonToken(0);
    }

    static string MorphingJsonToken(this JToken jsonToken, int tabs)
    {
        string result = string.Empty;
        string tabSpase = tabs == 0 ? string.Empty : Enumerable.Repeat("\t", tabs).Aggregate((x, y) => x + y);

        switch (jsonToken)
        {
            case JArray:
                result += $"{tabSpase}[\r\n";
                foreach (var item in jsonToken.Select((x, i) => new { Index = i, Value = x }))
                {
                    result += $"{item.Value.MorphingJsonToken(tabs + 1)}";
                    result += item.Index == jsonToken.Count() - 1 ? "" : ",\r\n";
                }
                result += $"\r\n{tabSpase}]\r\n";
                break;
            default:
                result += $"{tabSpase}{jsonToken.ToString(Newtonsoft.Json.Formatting.None)}";
                break;
        }

        return result;
    }
}
