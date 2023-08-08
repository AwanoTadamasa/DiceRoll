using DiceRollLib.Types;

namespace DiceRollLib;


/// <summary>
/// Return Error when don't match all other classes
/// </summary>
internal class ErrorDice : IDice
{
    // TODO: 自動実装プロパティでよさそう？
    private int? _diceNum;
    private int? _diceSide;

    /// <inheritdoc/>
    public int? DiceNum
    {
        get => this._diceNum;
        init => this._diceNum = value;
    }

    /// <inheritdoc/>
    public int? DiceSide
    {
        get => this._diceSide;
        init => this._diceSide = value;
    }

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
