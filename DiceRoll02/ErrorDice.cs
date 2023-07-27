namespace DiceRoll02;

internal class ErrorDice : IDice
{
    public string GetRollCommand()
    {
        return "ERROR";
    }

    public string GetRollResult()
    {
        return "ERROR";
    }

    public string CommandError => "HaveUnknownType";
}
