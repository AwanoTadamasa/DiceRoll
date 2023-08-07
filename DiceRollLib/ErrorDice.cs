using DiceRollLib.type;

namespace DiceRollLib;


/// <summary>
/// Return Error when don't match all other classes 
/// </summary>
internal class ErrorDice : IDice
{

    private int? _diceNum;
    private int? _diceSide;

    /// <inheritdoc/>
    public int? DiceNum
    {
        get => _diceNum;
        init => _diceNum = value;
    }

    /// <inheritdoc/>
    public int? DiceSide
    {
        get => _diceSide;
        init => _diceSide = value;
    }

    /// <inheritdoc/>
    public ErrorDice()
    {
        DiceNum = null;
        DiceSide = null;
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
