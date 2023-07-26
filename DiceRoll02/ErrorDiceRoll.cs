namespace DiceRoll02;

internal class ErrorDiceRoll : IDice
{
    public string? GetDiceCommand()
    {
        return null;
    }

    public string? GetRollResult()
    {
        return null;
    }

    public string CheckDiceCommandError()
    {
        return "HaveUnknownType";
    }
}
