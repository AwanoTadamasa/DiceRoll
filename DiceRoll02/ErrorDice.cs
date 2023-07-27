namespace DiceRoll02;

internal class ErrorDice : IDice
{
    public string GetRollCommand()
    {
        // DONE: null より "ERROR" というダイス名を返すほうが実装としてよいと思います。
        // null だと本当に null なのか、問題があって null なのかわからない可能性があります。
        return "ERROR";
    }

    public string GetRollResult()
    {
        return "ERROR";
    }

    public string CommandError => "HaveUnknownType";
}
