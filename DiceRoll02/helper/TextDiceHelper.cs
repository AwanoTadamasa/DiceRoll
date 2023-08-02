using DiceRoll02.enums;

namespace DiceRoll02.helper;

internal class TextDicesHelper
{
    internal static TextDices GetValueFromString(string key)
    {
        var table = new Lazy<Dictionary<string, TextDices>>(GetKeyValuePairs());
        if (table.Value.ContainsKey(key))
        {
            return table.Value[key];
        }
        else
        {
            return TextDices.OtherDice;
        }
    }

    private static Dictionary<string, TextDices> GetKeyValuePairs()
    {
        var temp = Enum
            .GetValues<TextDices>()
            .ToDictionary(
                x => x.ToString(),
                x => x
            );
        return temp;
    }
}
