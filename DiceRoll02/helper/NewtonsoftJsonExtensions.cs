using Newtonsoft.Json.Linq;

namespace DiceRoll02.helper;

internal static class NewtonsoftJsonExtensions
{
    // TODO: コメント。Formatting.Indented を使わない理由を説明するとよい。
    public static string MorphingJsonToken(this JToken jsonToken)
    {
        return jsonToken.MorphingJsonToken(0);
    }

    // TODO: こっちはprivateでよさそう。
    // TODO: Indent をつけながら変換するというニュアンスがほしい。
    // ToStringIndented() あたりか？
    // ToIndentString() の方が自然だが、既存の ToString() と並ぶ方がわかりやすそう。
    static string MorphingJsonToken(this JToken jsonToken, int indentLevel)
    {
        // TODO: String.Empty と  "" の違いを調べてみましょう。
        var indent = (indentLevel == 0)
            ? string.Empty
            : Enumerable
                .Repeat("\t", indentLevel)
                .Aggregate((x, y) => x + y);

        // TODO: 複雑な文字列を組み立てるときは StringBuilder の出番。メソッドに ref で渡すと良い。
        var result = string.Empty;
        // TODO: if文の方がよさそう。
        // TODO: OSの改行文字列を取得するのは Environment.NewLine というのがある。
        switch (jsonToken)
        {
            case JArray:
                result += $"{indent}[\r\n";
                var tokens = jsonToken
                    .Select((x, i) => new { Index = i, Value = x });
                foreach (var token in tokens)
                {
                    result += $"{token.Value.MorphingJsonToken(indentLevel + 1)}";
                    var len = jsonToken.Count() - 1;
                    result += (token.Index == len) ? "" : ",\r\n";
                }
                result += $"\r\n{indent}]\r\n";
                break;
            default:
                result += $"{indent}{jsonToken.ToString(Newtonsoft.Json.Formatting.None)}";
                break;
        }

        return result;
    }
}
