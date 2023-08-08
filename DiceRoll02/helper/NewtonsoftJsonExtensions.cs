using Newtonsoft.Json.Linq;
using System.Text;

namespace DiceRoll02.helper;

internal static class NewtonsoftJsonExtensions
{
    /// <summary>
    /// JsonTokenを文字列に変換する。最初のJArrayだけ改行し、その他は改行しない
    /// </summary>
    /// <param name="jsonToken"><see cref="JToken.FromObject"/>でシリアル化されたオブジェクト</param>
    /// <returns></returns>
    public static string ToStringIndented(this JToken jsonToken)
    {
        return jsonToken.ToStringIndented(0);
    }

    /// <summary>
    /// JsonTokenを文字列に変換する。最初のJArrayだけ改行し、その他は改行しない
    /// </summary>
    /// <param name="jsonToken"><see cref="JToken.FromObject"/>でシリアル化されたオブジェクト</param>
    /// <param name="indentLevel">インデントの数</param>
    /// <returns></returns>
    private static string ToStringIndented(this JToken jsonToken, int indentLevel)
    {
        var indent = (indentLevel == 0)
            ? string.Empty
            : Enumerable
                .Repeat("\t", indentLevel)
                .Aggregate((x, y) => x + y);
        // TODO: 複雑な文字列を組み立てるときは StringBuilder の出番。メソッドに ref で渡すと良い。
        var result = new StringBuilder();

        if (jsonToken is JArray)
        {
            result.AppendFormat("{0}[", indent);
            result.AppendLine();
            var tokens = jsonToken
                .Select((x, i) => new { Index = i, Value = x });
            foreach (var item in tokens)
            {
                result.Append(item.Value.ToStringIndented(indentLevel + 1));
                if (item.Index == jsonToken.Count() - 1)
                {
                    result.AppendLine();
                }
                else
                {
                    result.AppendLine(",");
                }
            }
            result.AppendFormat("{0}]", indent);
            result.AppendLine();
        }
        else
        {
            result.AppendFormat("{0}{1}", indent, jsonToken.ToString(Newtonsoft.Json.Formatting.None));
        }
        return result.ToString();
    }
}
