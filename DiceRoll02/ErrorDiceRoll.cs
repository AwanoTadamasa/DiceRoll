namespace DiceRoll02;

internal class ErrorDiceRoll : IDice
{
    public string? GetDiceCommand()
    {
        // TODO: null より "ERROR" というダイス名を返すほうが実装としてよいと思います。
        // null だと本当に null なのか、問題があって null なのかわからない可能性があります。
        return null;
    }

    public string? GetRollResult()
    {
        return null;
    }

    public string HasError()
    {
        return "HaveUnknownType";
    }
}
