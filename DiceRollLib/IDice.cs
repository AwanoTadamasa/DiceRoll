using DiceRollLib.type;

namespace DiceRollLib;

public interface IDice
{
    /// <summary>
    /// Roll dices number
    /// </summary>
    public int? DiceNum { get; init; }

    /// <summary>
    /// Roll dices side
    /// </summary>
    public int? DiceSide { get; init; }

    /// <summary>
    /// Roll Dices and create command
    /// </summary>
    /// <returns>command and roll results</returns>
    public RollResult Roll();

    /// <summary>
    /// Return ErrorMessage when Dice can't roll OR null when Roll succes
    /// </summary>
    /// <returns>ErrorMessage/null</returns>
    public string? GetErrorMessage();
}
