namespace DiceRoll02;

internal class ErrorDice : IDice
{
    public string GetRollCommand()
    {
        return "ERROR";
    }

    public RollResult Roll()
    {
        return new RollResult("ERROR", new List<int>());
    }

    public string? GetErrorMessage() => "不明な振り方です。";

    public bool HasError() => true;
}
