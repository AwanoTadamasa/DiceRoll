using DiceRollLib.Types;

namespace DiceRollLib;


/// <summary>
/// Return Error when don't match all other classes
/// </summary>
internal class ErrorDice : IDice
{
    // DONE: 自動実装プロパティでよさそう？

    public int? DiceNum { get; init; }
    public int? DiceSide { get; init; }

    public ErrorDice()
    {
        this.DiceNum = null;
        this.DiceSide = null;
    }

    /// <inheritdoc/>
    public string? GetErrorMessage()
    {
        return "    不明なサイコロの振り方です。";
    }

    /// <inheritdoc/>
    public RollResult Roll()
    {
        return new RollResult("ERROR", "ERROR", new List<int>());
    }
}
