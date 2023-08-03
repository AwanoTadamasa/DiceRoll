using DiceRoll02.enums;

namespace DiceRoll02.helper;

internal class TextDicesHelper
{
    static readonly Lazy<Dictionary<string, TextDices>> table = new(GetKeyValuePairs);

    internal static TextDices GetValueFromString(string key)
    {
        //var table = new Lazy<Dictionary<string, TextDices>>(GetKeyValuePairs());
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
        //Enumerable.Range(0, 100)
        //    .Select(x => Random.Shared.Next(10))
        //    .Select(x => x % 2)
        //    .Where(x => x == 0)
        //    .Count();

        var temp = Enum
            .GetValues<TextDices>()
            .ToDictionary(
                x => x.ToString(),
                x => x
            );
        return temp;
    }
}
