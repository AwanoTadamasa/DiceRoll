using Newtonsoft.Json.Linq;
using System.Text;

namespace DiceRoll02.helper;

internal static class NewtonsoftJsonExtensions
{
    // DONE: コメント。Formatting.Indented を使わない理由を説明するとよい。
    /// <summary>
    /// JsonTokenを文字列に変換する。最初のJArrayだけ改行し、その他は改行しない
    /// </summary>
    /// <param name="jsonToken"><see cref="JToken.FromObject"/>でシリアル化されたオブジェクト</param>
    /// <returns></returns>
    public static string ToStringIndented(this JToken jsonToken)
    {
        return jsonToken.TostringIndented(0);
    }

    // DONE: こっちはprivateでよさそう。
    // DONE: Indent をつけながら変換するというニュアンスがほしい。
    // ToStringIndented() あたりか？
    // ToIndentString() の方が自然だが、既存の ToString() と並ぶ方がわかりやすそう。
    /// <summary>
    /// JsonTokenを文字列に変換する。最初のJArrayだけ改行し、その他は改行しない
    /// </summary>
    /// <param name="jsonToken"><see cref="JToken.FromObject"/>でシリアル化されたオブジェクト</param>
    /// <param name="indentLevel">インデントの数</param>
    /// <returns></returns>
    private static string TostringIndented(this JToken jsonToken, int indentLevel)
    {
        // DONE: String.Empty と  "" の違いを調べてみましょう。
        var indent = (indentLevel == 0)
            ? string.Empty
            : Enumerable
                .Repeat("\t", indentLevel)
                .Aggregate((x, y) => x + y);
        // TODO: 複雑な文字列を組み立てるときは StringBuilder の出番。メソッドに ref で渡すと良い。
        var result = new StringBuilder();
        // DONE: if文の方がよさそう。
        // DONE: OSの改行文字列を取得するのは Environment.NewLine というのがある。

        if (jsonToken is JArray)
        {
            result.AppendFormat("{0}[", indent);
            result.AppendLine();
            var tokens = jsonToken
                .Select((x, i) => new { Index = i, Value = x });
            foreach (var item in tokens)
            {
                result.Append(item.Value.TostringIndented(indentLevel + 1));
                if (item.Index == jsonToken.Count() - 1)
                {
                    result.AppendLine();
                }
                else
                {
                    result.AppendLine(",");
                }
            }
            result.AppendFormat("{0}]",indent);
            result.AppendLine();
        }
        else
        {
            result.AppendFormat("{0}{1}", indent, jsonToken.ToString(Newtonsoft.Json.Formatting.None));
        }
        //switch (jsonToken)
        //{
        //    case JArray:
        //        result += $"{indent}[\r\n";
        //        var tokens = jsonToken
        //            .Select((x, i) => new { Index = i, Value = x });
        //        foreach (var token in tokens)
        //        {
        //            result += $"{token.Value.MorphingJsonToken(indentLevel + 1)}";
        //            var len = jsonToken.Count() - 1;
        //            result += (token.Index == len) ? "" : ",\r\n";
        //        }
        //        result += $"\r\n{indent}]\r\n";
        //        break;
        //    default:
        //        result += $"{indent}{jsonToken.ToString(Newtonsoft.Json.Formatting.None)}";
        //        break;
        //}

        return result.ToString();
    }
}
