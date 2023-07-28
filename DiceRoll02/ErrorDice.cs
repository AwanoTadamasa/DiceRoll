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

    public string? GetErrorMessage() => "不明な振り方です。";

    public bool HasError() => true;
}
